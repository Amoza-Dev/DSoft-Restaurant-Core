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

namespace DSoft_Restaurant.GUI.Home.Expenses
{
    public partial class FRMGroupExpenses : DevExpress.XtraEditors.XtraForm
    {
        private readonly AppDBContext appDBContext;
        private readonly IDataHelper<TBGroupExpenses> dataHelperGroupExpenses;
        private readonly LoadDataHelper<TBGroupExpenses> loadDataHelper;
        int _ID = 0;
        bool IsUpdate = false;
        public FRMGroupExpenses()
        {
            InitializeComponent();

            appDBContext = new AppDBContext();
            dataHelperGroupExpenses = new GroupExpensesEF();
            loadDataHelper = new LoadDataHelper<TBGroupExpenses>(new GroupExpensesEF());
        }

        private async void FRMEmployeeCategory_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            try
            {
                SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
                ButNew.Enabled = false;
                ButSave.Enabled = false;
                ButDelete.Enabled = false;
                TxtGroupExpenses.Enabled = false;
                if (await Task.Run(() => dataHelperGroupExpenses.IsCanConnect()))
                {
                    gridControl1.DataSource = await Task.Run(() => dataHelperGroupExpenses.GetAll());
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
                ButNew.Enabled = true;
                ButSave.Enabled = true;
                ButDelete.Enabled = true;
                TxtGroupExpenses.Enabled = true;
            }
        }

        private void ButNew_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            ClearHelper.ClearInputs(this);
            _ID = 0;
            IsUpdate = false;
        }
        private bool IsValidate()
        {
            if (string.IsNullOrWhiteSpace(TxtGroupExpenses.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool Add(TBGroupExpenses table)
        {
            bool Exists = appDBContext.Tables.Any(x => x.Name == table.Name);
            if (!Exists)
            {
                var Success = dataHelperGroupExpenses.Add(table);
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
            else
            {
                msgHelper.ShowDuplicatedItems();
                return false;
            }
        }
        private bool Edit(TBGroupExpenses table)
        {
            bool Exists = appDBContext.Tables.Any(x => x.Name == table.Name);
            if (!Exists)
            {
                var Success = dataHelperGroupExpenses.Update(table);
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
            else
            {
                msgHelper.ShowDuplicatedItems();
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
                    if (dataHelperGroupExpenses.IsCanConnect())
                    {
                        bool IsSuccess = false;
                        TBGroupExpenses tables = new TBGroupExpenses
                        {
                            Name = TxtGroupExpenses.Text,
                            IsDelete = false,
                        };
                        if (IsUpdate == true)
                        {
                            //Edit
                            tables.ID = _ID;
                            IsSuccess = Edit(tables);
                        }
                        else
                        {
                            //Save
                            IsSuccess = Add(tables);
                        }
                        if (IsSuccess)
                        {
                            await LoadData();
                            Clear();
                        }
                    }
                    else
                    {
                        msgHelper.ShowServerError();
                    }
                }
            }
            catch (Exception ex)
            {
                msgHelper.ShowException(ex);
            }
        }
        private void SetDataForEdit(int ID)
        {
            var _groupExpenses = dataHelperGroupExpenses.Find(ID);
            if (_groupExpenses.ID > 0)
            {
                TxtGroupExpenses.Text = _groupExpenses.Name;
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
                        if (await Task.Run(() => dataHelperGroupExpenses.IsCanConnect()))
                        {
                            var Success = await Task.Run(() => dataHelperGroupExpenses.Delete(_ID));
                            if (Success == "1")
                            {
                                msgHelper.ShowSuccessDelete();
                                await LoadData();
                                Clear();
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
            if (e.Clicks == 2 && e.Button == MouseButtons.Left)
            {
                _ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue(gridColumnID));
                if (_ID > 0)
                {
                    SetDataForEdit(_ID);
                    IsUpdate = true;
                }
            }
        }
    }
}