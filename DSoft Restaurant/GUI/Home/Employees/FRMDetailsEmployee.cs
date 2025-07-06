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
    public partial class FRMDetailsEmployee : DevExpress.XtraEditors.XtraForm
    {
        private readonly FRMListEmployees MainForm;
        private readonly IDataHelper<TBEmployeeCategory> dataHelperEmployeeCategory;
        private readonly IDataHelper<TBEmployees> dataHelperEmloyees;
        private readonly AppDBContext appDBContext;
        private readonly LoadDataHelper<TBEmployees> loadDataHelper;
        public int _ID = 0;
        public bool IsUpdate = false;
        public FRMDetailsEmployee(FRMListEmployees MainForm)
        {
            InitializeComponent();
            this.MainForm = MainForm;

            appDBContext = new AppDBContext();  
            dataHelperEmployeeCategory =new EmployeeCategoryEF();
            dataHelperEmloyees = new EmployeesEF();
            loadDataHelper = new LoadDataHelper<TBEmployees>(new EmployeesEF());

            DTStartJob.EditValue = DateTime.Now;
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

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
            CBCategoryEmployee.EditValue = null;
        }

        private bool  IsValidate() 
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
        private bool Add(TBEmployees table)
        {
            try
            {
            bool Exists = appDBContext.Employees.Any(x => x.Name == table.Name && x.CategoryID == table.CategoryID);
                if (!Exists)
                {
                    var Add = dataHelperEmloyees.Add(table);
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
        private bool Edit(TBEmployees table)
        {
            try
            {
                bool Exists = appDBContext.Employees.Any(x => x.Name == table.Name && x.CategoryID == table.CategoryID && x.ID != table.ID);
                if (!Exists)
                {
                    var Edit=dataHelperEmloyees.Update(table);
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
                    if (dataHelperEmloyees.IsCanConnect())
                    {
                        TBEmployees table = new TBEmployees
                        {
                            Name = TxtNameEmployee.Text,
                            PhoneNumber = TxtPhoneNumber.Text,
                            Salaray = TxtSalary.Value,
                            CategoryID = (int)CBCategoryEmployee.EditValue,
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
                            IsSuccess=Add(table);
                        }
                        if(IsSuccess)
                        {
                            await loadDataHelper.LoadDataWithProjection(MainForm.gridControl1, this, dataHelperEmloyees =>
                            dataHelperEmloyees.Select(x => new
                            {
                                x.ID,
                                x.Name,
                                x.PhoneNumber,
                                x.Salaray,
                                x.Address,
                                x.StartDate,
                                CategoryEmployee = x.TBEmployeeCategory.Name
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

        private async void FRMDetailsEmployee_Load(object sender, EventArgs e)
        {
            try
            {
                await FillComboBox();
                if (dataHelperEmloyees.IsCanConnect())
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
                var _tables = dataHelperEmloyees.Find(_ID);
                if (_tables.ID > 0)
                {
                    TxtNameEmployee.Text = _tables.Name;
                    TxtPhoneNumber.Text = _tables.PhoneNumber;
                    TxtSalary.EditValue = _tables.Salaray;
                    TxtAddress.Text = _tables.Address;
                    CBCategoryEmployee.EditValue = _tables.CategoryID;
                    DTStartJob.EditValue = _tables.StartDate;
                }
            }
            catch (Exception ex)
            {
                msgHelper.ShowException(ex);
            }
        }

        private async Task FillComboBox()
        {
            try
            {
                if (dataHelperEmployeeCategory.IsCanConnect())
                {
                    var ListCategores = await Task.Run(() => dataHelperEmployeeCategory.GetAll()
                    .Select(x => new { x.Name, x.ID }).ToList());
                    CBCategoryEmployee.Properties.DataSource = ListCategores;
                    CBCategoryEmployee.Properties.DisplayMember = "Name";   
                    CBCategoryEmployee.Properties.ValueMember = "ID";
                }
                else
                {
                    msgHelper.ShowServerError();
                }
            }
            catch (Exception ex)
            {
                msgHelper.ShowException(ex);
            }
        }
    }
}