using DevExpress.Diagram.Core.Shapes;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using DSoft_Restaurant.Code.Helper;
using DSoft_Restaurant.Core.Model;
using DSoft_Restaurant.Data.EF;
using Microsoft.EntityFrameworkCore;
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

namespace DSoft_Restaurant.GUI.Home.Items
{
    public partial class FRMDetailsItem : DevExpress.XtraEditors.XtraForm
    {
        private readonly IDataHelper<TBCategory> dataHelperCategory;
        private readonly IDataHelper<TBItems> dataHelperItems;
        private readonly LoadDataHelper<TBItems> loadDataHelper;
        private readonly FRMListItems MainForm;
        public static FRMDetailsItem Instance;
        public int _ID;
        private AppDBContext appDBContext;
        public FRMDetailsItem(FRMListItems MainForm)
        {
            InitializeComponent();

            dataHelperCategory = new CategoryEF();
            dataHelperItems = new ItemsEF();
            appDBContext = new AppDBContext();
            this.MainForm = MainForm;
            loadDataHelper=new LoadDataHelper<TBItems>(new ItemsEF());
            Instance = this;
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButCategory_Click(object sender, EventArgs e)
        {
            FRMCategorey obj = new FRMCategorey();
            obj.ShowDialog();
        }

        private async void FRMDetailsItem_Load(object sender, EventArgs e)
        {
            await FillComboBox();
            if (dataHelperItems.IsCanConnect())
            {
                if (_ID != 0)
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
        private void SetDataForEdit()
        {
            var _item = dataHelperItems.Find(_ID);
            if (_item.ID > 0)
            {
                TxtNameItem.Text = _item.Name;
                TxtPriceItem.Value = (decimal)_item.Price;
                CkbState.Checked = _item.IsActive;
                CBWeight.SelectedIndex = _item.IsWeight == true ? 0 : 1;
                CBCategoryItem.EditValue = _item.CategoryId;
            }
        }
        public async Task FillComboBox()
        {
            try
            {
                var ListCategory = await Task.Run(() => dataHelperCategory.GetAll().Where(a => a.IsActive == true)
                .Select(x => new { x.Name, x.ID }).ToList());
                CBCategoryItem.Properties.DataSource = ListCategory;
                CBCategoryItem.Properties.DisplayMember = "Name";
                CBCategoryItem.Properties.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                msgHelper.ShowException(ex);
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
                if (dataHelperItems.IsCanConnect())
                {
                    //save
                    if (_ID == 0)
                    {
                        //Add
                        await Add();
                    }
                    else
                    {
                        //Update
                        await Edit();
                    }
                }
                else
                {
                    msgHelper.ShowServerError();
                }
            }
        }
        private bool IsValidate()
        {
            if (string.IsNullOrWhiteSpace(TxtNameItem.Text) || CBCategoryItem.Text == "جۆری بابەت دیاریبکە")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private async Task Add()
        {
            TBItems items = new TBItems
            {
                Name = TxtNameItem.Text,
                Price = TxtPriceItem.Value,
                CategoryId = (int)CBCategoryItem.EditValue,
                IsActive = CkbState.Checked,
                IsDelete = false,
                IsWeight = CBWeight.SelectedIndex == 0 ? true : false,
            };

            var Success = dataHelperItems.Add(items);
            if (Success == "1")
            {
                msgHelper.ShowSuccessAdd();
                await loadDataHelper.LoadDataWithProjection(MainForm.gridControl1, this, dataHelperItems =>
                dataHelperItems.Select(x => new
                {
                    x.ID,
                    x.Name,
                    x.Price,
                    x.IsWeight,
                    x.IsActive,
                    CategoryName = x.tBCategory.Name
                })
                );
                if (MainForm.gridView1.RowCount > 0)
                {
                    await loadDataHelper.Suggestions(MainForm.searchControl, x => x.Name);
                }
                ClearHelper.ClearInputs(groupControl1);
            }
            else
            {
                XtraMessageBox.Show(Success);
            }
        }
        private async Task Edit()
        {
            TBItems items = new TBItems
            {
                Name = TxtNameItem.Text,
                Price = TxtPriceItem.Value,
                CategoryId = (int)CBCategoryItem.EditValue,
                IsActive = CkbState.Checked,
                IsWeight = CBWeight.SelectedIndex == 0 ? true : false,  
                ID = _ID
            };

            var Success = dataHelperItems.Update(items);
            if (Success == "1")
            {
                msgHelper.ShowSuccessEdit();
                FRMListItems.Instance._ID = 0;
                await loadDataHelper.LoadDataWithProjection(MainForm.gridControl1, this, dataHelperItems =>
                dataHelperItems.Select(x => new
                {
                    x.ID,
                    x.Name,
                    x.Price,
                    x.IsWeight,
                    x.IsActive,
                    CategoryName = x.tBCategory.Name
                })
                );
                if (MainForm.gridView1.RowCount > 0)
                {
                    await loadDataHelper.Suggestions(MainForm.searchControl, x => x.Name);
                }
                this.Close();
            }
            else
            {
                XtraMessageBox.Show(Success);
            }
        }
        public async Task LoadData()
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            try
            {
                if (await Task.Run(() => dataHelperItems.IsCanConnect()))
                {
                   FRMListItems.Instance.gridControl1.DataSource = dataHelperItems.GetAll().Select(x => new
                    {
                        x.ID,
                        x.Name,
                        x.Price,
                        x.IsWeight,
                        x.IsActive,
                        CategoryName = x.tBCategory.Name
                    });
                    if (FRMListItems.Instance.gridView1.RowCount > 0)
                    {
                        await suggestions();
                    }
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
        public async Task suggestions()
        {
            var suggestions = await Task.Run(() => dataHelperItems.GetAll().Select(x => x.Name).ToList());

            FRMListItems.Instance.searchControl.Properties.Items.BeginUpdate();
            FRMListItems.Instance.searchControl.Properties.Items.Clear();
            FRMListItems.Instance.searchControl.Properties.Items.AddRange(suggestions);
            FRMListItems.Instance.searchControl.Properties.Items.EndUpdate();
        }
        private void ButNew_Click(object sender, EventArgs e)
        {
            ClearHelper.ClearInputs(groupControl1);
        }
    }
}