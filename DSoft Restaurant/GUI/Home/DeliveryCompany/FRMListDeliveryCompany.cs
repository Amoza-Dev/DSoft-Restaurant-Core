using DevExpress.Diagram.Core.Shapes;
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

namespace DSoft_Restaurant.GUI.Home.DeliveryCompany
{
    public partial class FRMListDeliveryCompany : DevExpress.XtraEditors.XtraForm
    {
        private readonly IDataHelper<TBDeliveryCompany> dataHelper;
        private readonly LoadDataHelper<TBDeliveryCompany> loadDataHelper;
        public static FRMListDeliveryCompany Instance { get; private set; }
        public int _ID = 0;
        public FRMListDeliveryCompany()
        {
            InitializeComponent();
            Instance = this;
            dataHelper = new DeliverCompanyEF();
            loadDataHelper = new LoadDataHelper<TBDeliveryCompany>(new DeliverCompanyEF());
        }
        private void ButNew_Click(object sender, EventArgs e)
        {
            FRMDetailsDeliverCompany obj = new FRMDetailsDeliverCompany(this)
            {
                IsUpdate = false
            };
            obj.ShowDialog();
        }

        private async void FRMListDeliveryCompany_Load(object sender, EventArgs e)
        {
            await loadDataHelper.LoadData(gridControl1, this);
            await loadDataHelper.Suggestions(searchControl, x => x.Name);
        }
        private void ButUpdate_Click(object sender, EventArgs e)
        {
            FRMDetailsDeliverCompany obj = new FRMDetailsDeliverCompany(this)
            {
                _ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue(gridColumnID)),
                IsUpdate = true
            };
            obj.ShowDialog();
        }

        private async void ButDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_ID != 0)
                {
                    if (msgHelper.ShowDeleteDialog())
                    {
                        if (await Task.Run(() => dataHelper.IsCanConnect()))
                        {
                            var Success = await Task.Run(() => dataHelper.Delete(_ID));
                            if (Success == "1")
                            {
                                msgHelper.ShowSuccessDelete();
                                await loadDataHelper.LoadData(gridControl1, this);
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
            if (e.Clicks == 2 && e.Button == MouseButtons.Left)
            {
                _ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue(gridColumnID));
            }
        }
    }
}