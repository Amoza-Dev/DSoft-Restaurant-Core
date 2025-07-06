using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraSplashScreen;
using DSoft_Restaurant.Code.Helper;
using DSoft_Restaurant.Core.Model;
using DSoft_Restaurant.Data.EF;
using DSoft_Restaurant.GUI;
using DSoft_Restaurant.GUI.Home.DeliveryCompany;
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

namespace DSoft_Restaurant
{
    public partial class FRMListItems : DevExpress.XtraEditors.XtraForm
    {
        private readonly IDataHelper<TBItems> dataHelperItems;
        private readonly LoadDataHelper<TBItems> loadDataHelper;
        public static FRMListItems Instance;
        public int _ID = 0;
        public FRMListItems()
        {
            InitializeComponent();
            Instance = this;
            dataHelperItems = new ItemsEF();
            loadDataHelper = new LoadDataHelper<TBItems>(new ItemsEF());
        }
        private async void FRMListItems_Load(object sender, EventArgs e)
        {
            await LoadData();
        }
        public async Task LoadData()
        {
            await loadDataHelper.LoadDataWithProjection(gridControl1, this, dataHelperItems =>
                dataHelperItems.Where(x => x.IsDelete == false).Select(x => new
                {
                    x.ID,
                    x.Name,
                    x.Price,
                    x.IsWeight,
                    x.IsActive,
                    CategoryName = x.tBCategory.Name
                })
                );
            if (gridView1.RowCount > 0)
            {
                await loadDataHelper.Suggestions(searchControl, x => x.Name);
            }
        }
        public async Task suggestions()
        {
            var suggestions = await Task.Run(() => dataHelperItems.GetAll().Select(x => x.Name).ToList());

            searchControl.Properties.Items.BeginUpdate();
            searchControl.Properties.Items.Clear();
            searchControl.Properties.Items.AddRange(suggestions);
            searchControl.Properties.Items.EndUpdate();
        }
        private void ButNew_Click(object sender, EventArgs e)
        {
            FRMDetailsItem obj = new FRMDetailsItem(this);
            obj.ShowDialog();
        }

        private void ButCategory_Click(object sender, EventArgs e)
        {
            FRMCategorey obj = new FRMCategorey();
            obj.ShowDialog();
        }

        private void ButChangePrice_Click(object sender, EventArgs e)
        {
            if (_ID == 0)
            {
                msgHelper.ShowUpdateSelectRow();
                return;
            }
            else
            {
                FRMChangePrice obj = new FRMChangePrice(this);
                obj._ID = _ID;
                obj.ShowDialog();
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
            if (e.Column.FieldName == "IsWeight")
            {
                if (e.Value != null && e.Value is bool)
                {
                    e.DisplayText = (bool)e.Value ? "بەردەستە" : "بەردەست نیە";
                }
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
                FRMDetailsItem obj = new FRMDetailsItem(this);
                obj._ID = _ID;
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
                FRMDetailsItem obj = new FRMDetailsItem(this);
                obj._ID = _ID;
                obj.ShowDialog();
            }
        }

        private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {

        }

        private void gridView1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private async void ButDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_ID != 0)
                {
                    if (msgHelper.ShowDeleteDialog())
                    {
                        if (await Task.Run(() => dataHelperItems.IsCanConnect()))
                        {
                            var Success = await Task.Run(() => dataHelperItems.Delete(_ID));
                            if (Success == "1")
                            {
                                msgHelper.ShowSuccessDelete();
                                await loadDataHelper.LoadDataWithProjection(gridControl1, this, dataHelperItems =>
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