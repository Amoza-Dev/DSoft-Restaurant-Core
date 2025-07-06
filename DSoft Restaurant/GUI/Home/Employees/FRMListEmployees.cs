using DevExpress.XtraEditors;
using DevExpress.XtraWaitForm;
using DSoft_Restaurant.Code.Helper;
using DSoft_Restaurant.Core.Model;
using DSoft_Restaurant.Data.EF;
using DSoft_Restaurant.GUI.Home.Tables;
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
    public partial class FRMListEmployees : DevExpress.XtraEditors.XtraForm
    {
        private readonly IDataHelper<TBEmployees> dataHelperEmployees;
        private readonly LoadDataHelper<TBEmployees> loadDataHelper;
        public int _ID = 0;
        public FRMListEmployees()
        {
            InitializeComponent();
            dataHelperEmployees = new EmployeesEF();
            loadDataHelper = new LoadDataHelper<TBEmployees>(new EmployeesEF());
        }

        private void ButCategory_Click(object sender, EventArgs e)
        {
            FRMEmployeeCategory obj = new FRMEmployeeCategory();
            obj.ShowDialog();
        }

        private void ButNew_Click(object sender, EventArgs e)
        {
            FRMDetailsEmployee obj = new FRMDetailsEmployee(this);
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
                FRMDetailsEmployee obj = new FRMDetailsEmployee(this)
                {
                    _ID = _ID,
                    IsUpdate = true,
                };
                obj.ShowDialog();
            }
        }

        private async void FRMListEmployees_Load(object sender, EventArgs e)
        {
            try
            {
                await loadDataHelper.LoadDataWithProjection(gridControl1, this, dataHelperEmloyees =>
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
                FRMDetailsEmployee obj = new FRMDetailsEmployee(this)
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
                        if (await Task.Run(() => dataHelperEmployees.IsCanConnect()))
                        {
                            var Success = await Task.Run(() => dataHelperEmployees.Delete(_ID));
                            if (Success == "1")
                            {
                                msgHelper.ShowSuccessDelete();
                                await loadDataHelper.LoadDataWithProjection(gridControl1, this, dataHelperEmployees =>
                                dataHelperEmployees.Select(x => new
                                {
                                    x.ID,
                                    x.Name,
                                    x.PhoneNumber,
                                    x.Salaray,
                                    x.Address,
                                    x.StartDate,
                                    CategoryEmployee = x.TBEmployeeCategory.Name
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
    }
}