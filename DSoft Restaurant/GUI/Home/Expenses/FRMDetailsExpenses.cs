using DevExpress.XtraEditors;
using DSoft_Restaurant.Code.Helper;
using DSoft_Restaurant.Core.Model;
using DSoft_Restaurant.Data.EF;
using DSoft_Restaurant.GUI.Home.Employees;
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
    public partial class FRMDetailsExpenses : DevExpress.XtraEditors.XtraForm
    {
        private readonly FRMListExpenses MainForm;
        private readonly IDataHelper<TBGroupExpenses> dataHelperGroupExpenses;
        private readonly IDataHelper<TBExpenses> dataHelperExpenses;
        private readonly AppDBContext appDBContext;
        private readonly LoadDataHelper<TBExpenses> loadDataHelper;
        public int _ID = 0;
        public bool IsUpdate = false;
        public FRMDetailsExpenses(FRMListExpenses MainForm)
        {
            InitializeComponent();
            this.MainForm = MainForm;

            appDBContext = new AppDBContext();
            dataHelperGroupExpenses = new GroupExpensesEF();
            dataHelperExpenses = new ExpensesEF();
            loadDataHelper = new LoadDataHelper<TBExpenses>(new ExpensesEF());
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButNew_Click(object sender, EventArgs e)
        {

        }
        private void Clear()
        {
            ClearHelper.ClearInputs(groupControl1);
            IsUpdate = false;
            _ID = 0;
            CBGroupExpenses.EditValue = null;
        }
        private bool IsValidate()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtExpenseName.Text))
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
        private bool Add(TBExpenses table)
        {
            try
            {
                bool Exists = appDBContext.Expenses.Any(x => x.Name == table.Name && x.GroupID == table.GroupID);
                if (!Exists)
                {
                    var Add = dataHelperExpenses.Add(table);
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
        private bool Edit(TBExpenses table)
        {
            try
            {
                bool Exists = appDBContext.Expenses.Any(x => x.Name == table.Name && x.GroupID == table.GroupID && x.ID != table.ID);
                if (!Exists)
                {
                    var Edit = dataHelperExpenses.Update(table);
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
                    if (dataHelperExpenses.IsCanConnect())
                    {
                        TBExpenses table = new TBExpenses
                        {
                            Name = TxtExpenseName.Text,
                            GroupID = (int)CBGroupExpenses.EditValue,
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
                            await loadDataHelper.LoadDataWithProjection(MainForm.gridControl1, this, dataHelperExpenses =>
                            dataHelperExpenses.Select(x => new
                            {
                                x.ID,
                                x.Name,
                                GroupExpenses = x.TBGroupExpenses.Name
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

        private async void FRMDetailsExpenses_Load(object sender, EventArgs e)
        {
            try
            {
                await FillComboBox();
                if (dataHelperExpenses.IsCanConnect())
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
                var _tables = dataHelperExpenses.Find(_ID);
                if (_tables.ID > 0)
                {
                    TxtExpenseName.Text = _tables.Name;
                    CBGroupExpenses.EditValue = _tables.GroupID;
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
                if (dataHelperGroupExpenses.IsCanConnect())
                {
                    var ListCategores = await Task.Run(() => dataHelperGroupExpenses.GetAll()
                    .Select(x => new { x.Name, x.ID }).ToList());
                    CBGroupExpenses.Properties.DataSource = ListCategores;
                    CBGroupExpenses.Properties.DisplayMember = "Name";
                    CBGroupExpenses.Properties.ValueMember = "ID";
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