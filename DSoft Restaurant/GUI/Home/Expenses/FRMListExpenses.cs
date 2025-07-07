using DevExpress.XtraEditors;
using DSoft_Restaurant.Code.Helper;
using DSoft_Restaurant.Core.Model;
using DSoft_Restaurant.Data.EF;
using DSoft_Restaurant.GUI.Home.Employees;
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

namespace DSoft_Restaurant.GUI.Home.Expenses
{
    public partial class FRMListExpenses : DevExpress.XtraEditors.XtraForm
    {
        private readonly IDataHelper<TBExpenses> dataHelperExpenses;
        private readonly LoadDataHelper<TBExpenses> loadDataHelper;
        public int _ID = 0;
        public FRMListExpenses()
        {
            InitializeComponent();
            dataHelperExpenses = new ExpensesEF();
            loadDataHelper = new LoadDataHelper<TBExpenses>(new ExpensesEF());
        }

        private void ButNew_Click(object sender, EventArgs e)
        {
            FRMDetailsExpenses obj = new FRMDetailsExpenses(this);
            obj.ShowDialog();
        }

        private void ButGroupExpenses_Click(object sender, EventArgs e)
        {
            FRMGroupExpenses obj = new FRMGroupExpenses();
            obj.ShowDialog();
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
                FRMDetailsExpenses obj = new FRMDetailsExpenses(this)
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
                        if (await Task.Run(() => dataHelperExpenses.IsCanConnect()))
                        {
                            var Success = await Task.Run(() => dataHelperExpenses.Delete(_ID));
                            if (Success == "1")
                            {
                                msgHelper.ShowSuccessDelete();
                                await loadDataHelper.LoadDataWithProjection(gridControl1, this, dataHelperExpenses =>
                                dataHelperExpenses.Select(x => new
                                {
                                    x.ID,
                                    x.Name,
                                    GroupExpenses = x.TBGroupExpenses.Name
                                }));
                                if (gridView1.RowCount > 0)
                                {
                                    await loadDataHelper.Suggestions(searchControl, x => x.Name);
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

        private async void FRMListExpenses_Load(object sender, EventArgs e)
        {
            try
            {
                await loadDataHelper.LoadDataWithProjection(gridControl1, this, dataHelperExpenses =>
                dataHelperExpenses.Select(x => new
                {
                    x.ID,
                    x.Name,
                    GroupExpenses = x.TBGroupExpenses.Name
                }));
                if (gridView1.RowCount > 0)
                {
                    await loadDataHelper.Suggestions(searchControl, x => x.Name);
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
                FRMDetailsExpenses obj = new FRMDetailsExpenses(this)
                {
                    _ID = _ID,
                    IsUpdate = true,
                };
                obj.ShowDialog();
            }
        }
    }
}