using DevExpress.Drawing.Internal.Fonts.Interop;
using DevExpress.Utils.FormatStrings;
using DevExpress.XtraEditors;
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
using static DevExpress.DataAccess.Native.Sql.QueryBuilder.SelectionItemData;

namespace DSoft_Restaurant.GUI.Home.Items
{
    public partial class FRMChangePrice : DevExpress.XtraEditors.XtraForm
    {
        private readonly IDataHelper<TBItems> dataHelperItems;
        private readonly LoadDataHelper<TBItems> loadDataHelper;
        private readonly FRMListItems MainForm;
        public int _ID = 0;
        public int CategoryID = 0;  
        public FRMChangePrice(FRMListItems mainForm)
        {
            InitializeComponent();
            dataHelperItems = new ItemsEF();
            MainForm = mainForm;
            loadDataHelper = new LoadDataHelper<TBItems>(new ItemsEF());
        }

        private void FRMChangePrice_Load(object sender, EventArgs e)
        {
            SetDataForEdit();
        }
        private void SetDataForEdit()
        {
            var _item = dataHelperItems.Find(_ID);
            if (_item.ID > 0)
            {
                TxtNameItem.Text = _item.Name;
                TxtPriceItem.Value = (decimal)_item.Price;
                CategoryID = _item.CategoryId;
            }
        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            if (dataHelperItems.IsCanConnect())
            {
                //Save Price
                SavePrice();
            }
            else
            {
                msgHelper.ShowServerError();
            }
        }
        private async void SavePrice()
        {
            TBItems items = new TBItems
            {
                Name = TxtNameItem.Text,
                Price = TxtPriceItem.Value,
                CategoryId = CategoryID,
                ID = _ID
            };

            var Success = dataHelperItems.Update(items);
            if (Success == "1")
            {
                msgHelper.ShowSuccessEdit();
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
                this.Close();
            }
            else
            {
                XtraMessageBox.Show(Success);
            }
        }
    }
}