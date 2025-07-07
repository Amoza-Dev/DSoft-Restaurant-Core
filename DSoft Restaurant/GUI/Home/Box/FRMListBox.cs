using DevExpress.XtraEditors;
using DevExpress.XtraWaitForm;
using DSoft_Restaurant.Code.Helper;
using DSoft_Restaurant.Core.Model;
using DSoft_Restaurant.Data.EF;
using DSoft_Restaurant.GUI.Home.Expenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSoft_Restaurant.GUI.Home.Box
{
    public partial class FRMListBox : DevExpress.XtraEditors.XtraForm
    {
        private readonly IDataHelper<TBBoxs> dataHelperBoxs;
        private readonly LoadDataHelper<TBBoxs> loadDataHelper;
        public int _ID = 0;
        public FRMListBox()
        {
            InitializeComponent();
            dataHelperBoxs = new BoxsEF();
            loadDataHelper = new LoadDataHelper<TBBoxs>(new BoxsEF());
        }
        private void ButNew_Click(object sender, EventArgs e)
        {
            FRMDetailsBox obj = new FRMDetailsBox(this);
            obj.ShowDialog();
        }

        private async void FRMListBox_Load(object sender, EventArgs e)
        {
            try
            {
                await loadDataHelper.LoadDataWithProjection(this.gridControl1, this, dataHelperBoxs =>
                dataHelperBoxs.Select(x => new
                {
                    x.ID,
                    x.BoxName,
                    x.Value,
                    x.StartDate,
                }));
                if (gridView1.RowCount > 0)
                {
                    await loadDataHelper.Suggestions(searchControl, x => x.BoxName);
                }
            }
            catch (Exception ex)
            {
                msgHelper.ShowException(ex);
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
                FRMDetailsBox obj = new FRMDetailsBox(this)
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
                        if (await Task.Run(() => dataHelperBoxs.IsCanConnect()))
                        {
                            var Success = await Task.Run(() => dataHelperBoxs.Delete(_ID));
                            if (Success == "1")
                            {
                                msgHelper.ShowSuccessDelete();
                                await loadDataHelper.LoadDataWithProjection(this.gridControl1, this, dataHelperBoxs =>
                                dataHelperBoxs.Select(x => new
                                {
                                    x.ID,
                                    x.BoxName,
                                    x.Value,
                                    x.StartDate,
                                }));
                                if (gridView1.RowCount > 0)
                                {
                                    await loadDataHelper.Suggestions(searchControl, x => x.BoxName);
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

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Clicks == 1 && e.Button == MouseButtons.Left)
            {
                _ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue(gridColumnID));
            }
            if (e.Clicks == 2 && e.Button == MouseButtons.Left)
            {
                _ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue(gridColumnID));
                FRMDetailsBox obj = new FRMDetailsBox(this)
                {
                    _ID = _ID,
                    IsUpdate = true,
                };
                obj.ShowDialog();
            }
        }
    }
}