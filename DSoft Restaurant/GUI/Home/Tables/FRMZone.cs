using DevExpress.XtraEditors;
using DSoft_Restaurant.Code.Helper;
using DSoft_Restaurant.Core.Model;
using DSoft_Restaurant.Data.EF;
using DSoft_Restaurant.GUI.Home.Items;
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

namespace DSoft_Restaurant.GUI.Home.Tables
{
    public partial class FRMZone : DevExpress.XtraEditors.XtraForm
    {
        private readonly IDataHelper<TBZones> dataHelperzone;
        int _ID = 0;
        public FRMZone()
        {
            InitializeComponent();
            dataHelperzone = new ZonesEF();
        }

        private async void FRMZone_Load(object sender, EventArgs e)
        {
            await LoadData();
        }
        public async Task LoadData()
        {
            try
            {
                if (await Task.Run(() => dataHelperzone.IsCanConnect()))
                {
                    gridControl1.DataSource = await Task.Run(() => dataHelperzone.GetAll());
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

        private void ButNew_Click(object sender, EventArgs e)
        {
            ClearHelper.ClearInputs(this);
        }
        private bool IsValidate()
        {
            if (string.IsNullOrWhiteSpace(TxtName.Text))
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
                if (dataHelperzone.IsCanConnect())
                {
                    //save
                    if (_ID == 0)
                    {
                        //Add
                        isSuccess = Add();
                    }
                    else
                    {
                        //Update
                        isSuccess = Edit();
                    }
                    if (isSuccess)
                    {
                        await LoadData();
                        ClearHelper.ClearInputs(this);
                        _ID = 0;
                    }
                }
                else
                {
                    msgHelper.ShowServerError();
                }
            }
        }

        private bool Edit()
        {
            TBZones Category = new TBZones
            {
                ZoneName = TxtName.Text,
                IsActive = CkbState.Checked,
                ID = _ID
            };

            var Success = dataHelperzone.Update(Category);
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

        private bool Add()
        {
            TBZones Category = new TBZones
            {
                ZoneName = TxtName.Text,
                IsActive = CkbState.Checked,
                IsDelete = false
            };

            var Success = dataHelperzone.Add(Category);
            if (Success == "1")
            {
                msgHelper.ShowSuccessAdd();
                return true;
            }
            else
            {
                XtraMessageBox.Show(Success);
                return false;
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Clicks == 2 && e.Button == MouseButtons.Left)
            {
                _ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue(gridColumnID));
                SetDataForEdit();
            }
        }
        private void SetDataForEdit()
        {
            var _zone = dataHelperzone.Find(_ID);
            if (_zone.ID > 0)
            {
                TxtName.Text = _zone.ZoneName;
                CkbState.Checked = _zone.IsActive;
            }
        }

        private async void ButCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (_ID != 0)
                {
                    if (msgHelper.ShowDeleteDialog())
                    {
                        if (await Task.Run(() => dataHelperzone.IsCanConnect()))
                        {
                            var Success = await Task.Run(() => dataHelperzone.Delete(_ID));
                            if (Success == "1")
                            {
                                msgHelper.ShowSuccessDelete();
                                await LoadData();
                                ClearHelper.ClearInputs(this);
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
    }
}