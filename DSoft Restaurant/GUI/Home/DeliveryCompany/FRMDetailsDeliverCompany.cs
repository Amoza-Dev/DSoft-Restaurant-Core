using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
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
using System.Xml.Linq;
using static DevExpress.DataAccess.Native.Sql.QueryBuilder.SelectionItemData;

namespace DSoft_Restaurant.GUI.Home.DeliveryCompany
{
    public partial class FRMDetailsDeliverCompany : DevExpress.XtraEditors.XtraForm
    {
        private readonly IDataHelper<TBDeliveryCompany> dataHelper;
        private readonly LoadDataHelper<TBDeliveryCompany> loadDataHelper;
        public bool IsUpdate = false;
        public int _ID;
        private readonly FRMListDeliveryCompany MainForm;
        public FRMDetailsDeliverCompany(FRMListDeliveryCompany MianForm)
        {
            InitializeComponent();
            dataHelper = new DeliverCompanyEF();
            DTStart.DateTime = DateTime.Now;
            MainForm = new FRMListDeliveryCompany();
            this.MainForm = MianForm;
            loadDataHelper = new LoadDataHelper<TBDeliveryCompany>(new DeliverCompanyEF());
        }
        private void ButNew_Click(object sender, EventArgs e)
        {
            ClearHelper.ClearInputs(groupControl1);
            _ID = 0;
        }
        private bool IsValidate()
        {
            if (string.IsNullOrWhiteSpace(TxtCompanyName.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void FRMDetailsDeliverCompany_Load(object sender, EventArgs e)
        {
            if (dataHelper.IsCanConnect())
            {
                if (IsUpdate)
                {
                    //Fill Controls
                    SetDataForEdit();
                }

            }
            else
            {
                msgHelper.ShowServerError();
            }
        }


        private async void Add()
        {
            try
            {
                TBDeliveryCompany deliveryCompany = new TBDeliveryCompany
                {
                    Name = TxtCompanyName.Text,
                    PhoneNumber = TxtCompanyNumber.Text,
                    StartDate = DTStart.DateOnly,
                    //StartDate = DateOnly.FromDateTime((DateTime)DTStart.EditValue),
                    IsDelete = false
                };

                var Success = dataHelper.Add(deliveryCompany);
                if (Success == "1")
                {
                    msgHelper.ShowSuccessAdd();
                    await loadDataHelper.LoadData(MainForm.gridControl1, this);
                    await loadDataHelper.Suggestions(MainForm.searchControl, x => x.Name);
                    ClearHelper.ClearInputs(groupControl1);
                    _ID = 0;
                }
                else
                {
                    XtraMessageBox.Show(Success);
                }
            }
            catch (Exception ex)
            {
                msgHelper.ShowException(ex);
            }
        }
        private async void Edit()
        {
            try
            {
                TBDeliveryCompany deliveryCompany = new TBDeliveryCompany
                {
                    Name = TxtCompanyName.Text,
                    PhoneNumber = TxtCompanyNumber.Text,
                    StartDate = DTStart.DateOnly,
                    IsDelete = false,
                    ID = _ID
                };

                var Success = dataHelper.Update(deliveryCompany);
                if (Success == "1")
                {
                    msgHelper.ShowSuccessEdit();
                    await loadDataHelper.LoadData(MainForm.gridControl1, this);
                    await loadDataHelper.Suggestions(MainForm.searchControl, x => x.Name);
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show(Success);
                }
            }
            catch (Exception ex)
            {
                msgHelper.ShowException(ex);
            }
        }
        private void SetDataForEdit()
        {
            var _deliveryCompany = dataHelper.Find(_ID);
            if (_deliveryCompany.ID > 0)
            {
                TxtCompanyName.Text = _deliveryCompany.Name;
                TxtCompanyNumber.Text = _deliveryCompany.PhoneNumber;
                DTStart.EditValue = _deliveryCompany.StartDate;
            }
        }
        private void ButSave_Click(object sender, EventArgs e)
        {
            if (!IsValidate())
            {
                msgHelper.ShowRequiredFields();
            }
            else
            {
                if (dataHelper.IsCanConnect())
                {
                    //save
                    if (IsUpdate)
                    {
                        //Update
                        Edit();
                    }
                    else
                    {
                        //Add
                        Add();
                    }
                }
                else
                {
                    msgHelper.ShowServerError();
                }
            }
        }
    }
}