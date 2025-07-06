using DevExpress.XtraEditors;
using DevExpress.XtraWaitForm;
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

namespace DSoft_Restaurant.GUI.Home.Tables
{
    public partial class FRMListTables : DevExpress.XtraEditors.XtraForm
    {
        private readonly IDataHelper<TBTables> dataHelperTables;
        private readonly LoadDataHelper<TBTables> loadDataHelper;
        public int _ID = 0;

        public FRMListTables()
        {
            InitializeComponent();
            dataHelperTables = new TablesEF();
            loadDataHelper = new LoadDataHelper<TBTables>(new TablesEF());
        }

        private void ButZone_Click(object sender, EventArgs e)
        {
            FRMZone obj = new FRMZone();
            obj.ShowDialog();
        }

        private void ButNew_Click(object sender, EventArgs e)
        {
            FRMDetailsTable obj = new FRMDetailsTable(this);
            obj.ShowDialog();
        }

        private async void FRMListTables_Load(object sender, EventArgs e)
        {
            try
            {
                await loadDataHelper.LoadDataWithProjection(gridControl1, this, dataHelperTables =>
                dataHelperTables.Select(x => new
                {
                    x.ID,
                    x.Name,
                    x.IsDelete,
                    tablezone = x.TBZones.ZoneName
                })
                );
                if (gridView1.RowCount > 0)
                {
                    await loadDataHelper.Suggestions(searchControl1, x => x.Name);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Clicks == 1 && e.Button == MouseButtons.Left)
            {
                _ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue(gridColumnID));
            }
            if (e.Clicks == 2 && e.Button == MouseButtons.Left)
            {
                _ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue(gridColumnID));
                FRMDetailsTable obj = new FRMDetailsTable(this)
                {
                    _ID = _ID,
                    IsUpdate = true,
                };
                obj.ShowDialog();
            }
        }

        private void ButUpdate_Click(object sender, EventArgs e)
        {
            if (_ID == 0)
            {
                msgHelper.ShowUpdateSelectRow();
                return;
            }
            else
            {
                FRMDetailsTable obj = new FRMDetailsTable(this)
                {
                    _ID = _ID,
                    IsUpdate = true,
                };
                obj.ShowDialog();
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
                        if (await Task.Run(() => dataHelperTables.IsCanConnect()))
                        {
                            var Success = await Task.Run(() => dataHelperTables.Delete(_ID));
                            if (Success == "1")
                            {
                                msgHelper.ShowSuccessDelete();
                                await loadDataHelper.LoadDataWithProjection(gridControl1, this, dataHelperTables =>
                                dataHelperTables.Select(x => new
                                {
                                    x.ID,
                                    x.Name,
                                    x.IsDelete,
                                    tablezone = x.TBZones.ZoneName
                                })
                                );
                                if (gridView1.RowCount > 0)
                                {
                                    await loadDataHelper.Suggestions(searchControl1, x => x.Name);
                                }
                                _ID = 0;
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