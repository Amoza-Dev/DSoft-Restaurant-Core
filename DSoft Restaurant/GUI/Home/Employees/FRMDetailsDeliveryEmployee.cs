using DevExpress.XtraEditors;
using DSoft_Restaurant.Code.Helper;
using DSoft_Restaurant.Core.Model;
using DSoft_Restaurant.Data.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSoft_Restaurant.GUI.Home.Employees
{
    public partial class FRMDetailsDeliveryEmployee : DevExpress.XtraEditors.XtraForm
    {
        private readonly FRMListDeliveryEmployees MainForm;
        private readonly IDataHelper<TBDeliveryEmployee> dataHelperDeliverEmployee;
        private readonly AppDBContext appDBContext;
        private readonly LoadDataHelper<TBDeliveryEmployee> loadDataHelper;
        public int _ID = 0;
        public bool IsUpdate = false;
        public FRMDetailsDeliveryEmployee(FRMListDeliveryEmployees MainForm)
        {
            InitializeComponent();
            this.MainForm = MainForm;   

            appDBContext = new AppDBContext();
            dataHelperDeliverEmployee = new DeliveryEmployeesEF();
            loadDataHelper = new LoadDataHelper<TBDeliveryEmployee>(new DeliveryEmployeesEF());

            DTStartJob.EditValue = DateTime.Now;
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void FRMDetailsDeliveryEmployee_Load(object sender, EventArgs e)
        {
            try
            {
                if (dataHelperDeliverEmployee.IsCanConnect())
                {
                    if (IsUpdate)
                    {
                        SetDataForEdit();
                    }
                }
            }
            catch (Exception ex)
            {
                msgHelper.ShowException(ex);
            }
        }
        private void SetDataForEdit()
        {
            try
            {
                var _tables = dataHelperDeliverEmployee.Find(_ID);
                if (_tables.ID > 0)
                {
                    TxtNameEmployee.Text = _tables.Name;
                    TxtPhoneNumber.Text = _tables.PhoneNumber;
                    TxtSalary.EditValue = _tables.Salaray;
                    TxtAddress.Text = _tables.Address;
                    DTStartJob.EditValue = _tables.StartDate;
                }
            }
            catch (Exception ex)
            {
                msgHelper.ShowException(ex);
            }
        }
        private void ButNew_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            ClearHelper.ClearInputs(groupControl1);
            IsUpdate = false;
            _ID = 0;
            DTStartJob.DateTime = DateTime.Now;
        }
        private bool IsValidate()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtNameEmployee.Text))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                msgHelper.ShowException(ex);
                return false;
            }
        }
        private bool Add(TBDeliveryEmployee table)
        {
            try
            {
                bool Exists = appDBContext.DeliveryEmployees.Any(x => x.Name == table.Name);
                if (!Exists)
                {
                    var Add = dataHelperDeliverEmployee.Add(table);
                    if (Add == "1")
                    {
                        msgHelper.ShowSuccessAdd();
                        return true;
                    }
                    else
                    {
                        XtraMessageBox.Show(Add);
                        return false;
                    }
                }
                else
                {
                    msgHelper.ShowDuplicatedItems();
                    return false;
                }
            }
            catch (Exception ex)
            {
                msgHelper.ShowException(ex);
                return false;
            }
        }
        private bool Edit(TBDeliveryEmployee table)
        {
            try
            {
                bool Exists = appDBContext.DeliveryEmployees.Any(x => x.Name == table.Name && x.ID != table.ID);
                if (!Exists)
                {
                    var Edit = dataHelperDeliverEmployee.Update(table);
                    if (Edit == "1")
                    {
                        msgHelper.ShowSuccessAdd();
                        return true;
                    }
                    else
                    {
                        XtraMessageBox.Show(Edit);
                        return false;
                    }
                }
                else
                {
                    msgHelper.ShowDuplicatedItems();
                    return false;
                }

            }
            catch (Exception ex)
            {
                msgHelper.ShowException(ex);
                return false;
            }
        }
        private async void ButSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidate())
                {
                    msgHelper.ShowRequiredFields();
                }
                else
                {
                    if (dataHelperDeliverEmployee.IsCanConnect())
                    {
                        TBDeliveryEmployee table = new TBDeliveryEmployee
                        {
                            Name = TxtNameEmployee.Text,
                            PhoneNumber = TxtPhoneNumber.Text,
                            Salaray = TxtSalary.Value,
                            Address = TxtAddress.Text,
                            StartDate = DTStartJob.DateOnly,
                            IsDelete = false,
                        };
                        bool IsSuccess = false;
                        if (IsUpdate)
                        {
                            table.ID = _ID;
                            //Edit
                            IsSuccess = Edit(table);
                        }
                        else
                        {
                            //Save
                            IsSuccess = Add(table);
                        }
                        if (IsSuccess)
                        {
                            await loadDataHelper.LoadDataWithProjection(MainForm.gridControl1, this, dataHelperDeliverEmployee =>
                            dataHelperDeliverEmployee.Select(x => new
                            {
                                x.ID,
                                x.Name,
                                x.PhoneNumber,
                                x.Salaray,
                                x.Address,
                                x.StartDate,
                            }));
                            await loadDataHelper.Suggestions(MainForm.searchControl, x => x.Name);
                            if (IsUpdate)
                            {
                                this.Close();
                            }
                            Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                msgHelper.ShowException(ex);
            }
        }
    }
}