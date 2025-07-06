using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using DSoft_Restaurant.Code.Helper;
using DSoft_Restaurant.Core.Model;
using DSoft_Restaurant.Data.EF;
using DSoft_Restaurant.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;
using System.Xml.Linq;
using System.Drawing.Printing;
using System.Windows.Documents;
using DSoft_Restaurant.GUI.Home.Items;

namespace DSoft_Restaurant
{
    public partial class FRMCategorey : XtraForm
    {
        private IDataHelper<TBCategory> dataHelper;
        int _ID = 0;
        public FRMCategorey()
        {
            InitializeComponent();
            dataHelper = new CategoryEF();
        }

        private async void XtraForm2_Load(object sender, EventArgs e)
        {
            List<string> PrinterList = new List<string>();
            foreach (string Printer in PrinterSettings.InstalledPrinters)
            {
                PrinterList.Add(Printer);
            }
            CBListPrinter.Properties.DataSource = PrinterList;
            CBListPrinter.Properties.NullText = "Select Printer";
            await LoadData();
        }
        public async Task LoadData()
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            try
            {
                if (await Task.Run(() => dataHelper.IsCanConnect()))
                {
                    gridControl1.DataSource = await Task.Run(() => dataHelper.GetAll());
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
            finally
            {
                SplashScreenManager.CloseForm();
            }
        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "IsActive")
            {
                if (e.Value != null && e.Value is bool)
                {
                    e.DisplayText = (bool)e.Value ? "بەردەستە" : "بەردەست نیە";
                }
            }
        }
        private bool IsValidate()
        {
            if (string.IsNullOrWhiteSpace(TxtName.Text) || CBListPrinter.Text == null || CBListPrinter.Text == "Select Printer")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private async void ButSave_Click(object sender, EventArgs e)
        {
            if (!IsValidate())
            {
                msgHelper.ShowRequiredFields();
            }
            else
            {
                bool isSuccess = false;
                if (dataHelper.IsCanConnect())
                {
                    //save
                    if (_ID == 0)
                    {
                        //Add
                        isSuccess = AddCategory();
                    }
                    else
                    {
                        //Update
                        isSuccess = EditCategory();
                    }
                    if (isSuccess)
                    {
                        for (int i = 0; i < Application.OpenForms.Count; i++)
                        {
                            XtraForm openform = Application.OpenForms[i] as XtraForm;
                            if (openform != null)
                            {
                                if (openform.Name == "FRMDetailsItem")
                                {
                                    await FRMDetailsItem.Instance.FillComboBox();
                                    this.Close();
                                }
                                else
                                {
                                    await LoadData();
                                    if (_ID != 0)
                                    {
                                        ClearControls();
                                    }
                                    else
                                    {
                                        this.Close();
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    msgHelper.ShowServerError();
                }
            }
        }

        private bool AddCategory()
        {
            TBCategory Category = new TBCategory
            {
                Name = TxtName.Text,
                PrintetName = CBListPrinter.Text,
                IsActive = true,
                IsDelete = false
            };

            var Success = dataHelper.Add(Category);
            if (Success == "1")
            {
                //XtraMessageBox.Show(Category.ID.ToString());
                msgHelper.ShowSuccessAdd();
                return true;
            }
            else
            {
                XtraMessageBox.Show(Success);
                return false;
            }
        }
        private bool EditCategory()
        {
            TBCategory Category = new TBCategory
            {
                Name = TxtName.Text,
                PrintetName = CBListPrinter.Text,
                IsActive = CkbState.Checked,
                ID = _ID
            };

            var Success = dataHelper.Update(Category);
            if (Success == "1")
            {
                msgHelper.ShowSuccessEdit();
                return true;
            }
            else
            {
                XtraMessageBox.Show(Success);
                return false;
            }
        }
        private void SetDataForEdit()
        {
            var _category = dataHelper.Find(_ID);
            if (_category.ID > 0)
            {
                TxtName.Text = _category.Name;
                CBListPrinter.Text = _category.PrintetName;
                CkbState.Checked = _category.IsActive;
            }
        }

        private async void ButDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_ID != 0)
                {
                    if (msgHelper.ShowDeleteDialog())
                    {
                        if (await Task.Run(() => dataHelper.IsCanConnect()))
                        {
                            var Success = await Task.Run(() => dataHelper.Delete(_ID));
                            if (Success == "1")
                            {
                                msgHelper.ShowSuccessDelete();
                                await LoadData();
                                ClearControls();
                            }
                            else
                            {
                                XtraMessageBox.Show(Success);
                            }
                        }
                        else
                        {
                            msgHelper.ShowServerError();
                        }
                    }
                }
                else
                {
                    msgHelper.ShowDeleteSelectRow();
                }
            }
            catch (Exception ex)
            {
                msgHelper.ShowException(ex);
            }
        }

        private void ButNew_Click(object sender, EventArgs e)
        {
            ClearHelper.ClearInputs(this);
            //ClearControls();
        }

        private void ClearControls()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextEdit)
                {
                    ((TextEdit)ctrl).Text = string.Empty;
                }
                if (ctrl is SearchLookUpEdit)
                {
                    ((SearchLookUpEdit)ctrl).EditValue = null;
                    CBListPrinter.Properties.NullText = "Select Printer";
                }
                if(ctrl is CheckEdit)
                {
                    ((CheckEdit)ctrl).Checked = true;
                }
            }
            _ID = 0;
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Clicks == 2 && e.Button == MouseButtons.Left)
            {
                _ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue(gridColumnID));
                SetDataForEdit();
            }
        }
    }
}