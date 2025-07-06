using DevExpress.XtraTab;
using DSoft_Restaurant.GUI.Home.Box;
using DSoft_Restaurant.GUI.Home.DeliveryCompany;
using DSoft_Restaurant.GUI.Home.Employees;
using DSoft_Restaurant.GUI.Home.Expenses;
using DSoft_Restaurant.GUI.Home.Offers;
using DSoft_Restaurant.GUI.Home.Tables;
using System;
using System.Windows.Forms;

namespace DSoft_Restaurant
{
    public partial class FRMdashboard : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FRMdashboard()
        {
            InitializeComponent();
        }

        private void FRMdashboard_Load(object sender, EventArgs e)
        {

        }
        private void OpenFormInTab(Form frm, string tabTitle)
        {
            // Show close buttons on all tab pages
            xtraTabControl1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;

            // Check if tab already exists
            foreach (XtraTabPage page in xtraTabControl1.TabPages) // Corrected type to XtraTabPage
            {
                if (page.Text == tabTitle)
                {
                    xtraTabControl1.SelectedTabPage = page;
                    return;
                }
            }
            // Create a new tab
            XtraTabPage tabPage = new XtraTabPage // Corrected type to XtraTabPage
            {
                Text = tabTitle
            };

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tabPage.Controls.Add(frm);
            frm.Show();

            xtraTabControl1.TabPages.Add(tabPage);
            xtraTabControl1.SelectedTabPage = tabPage;
        }
        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs args = e as DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs;
            if (args != null)
            {
                XtraTabPage page = args.Page as XtraTabPage;
                if (page != null)
                {
                    // Dispose form inside tab before removing (optional but good practice)
                    if (page.Controls.Count > 0 && page.Controls[0] is Form form)
                    {
                        form.Dispose();
                    }

                    xtraTabControl1.TabPages.Remove(page);
                }
            }
        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButItems_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFormInTab(new FRMListItems(), ButItems.Caption);
        }

        private void ButCategories_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //OpenFormInTab(new FRMCategorey(), ButCategories.Caption);
            FRMCategorey obj = new FRMCategorey();
            obj.ShowDialog();
        }

        private void ButTables_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFormInTab(new FRMListTables(), ButTables.Caption);
        }

        private void ButEmployees_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFormInTab(new FRMListEmployees(), ButEmployees.Caption);
        }

        private void ButExpenses_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFormInTab(new FRMListExpenses(), ButExpenses.Caption);
        }

        private void ButOffers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFormInTab(new FRMListOffers(), ButOffers.Caption);
        }

        private void ButDeliveryEmployees_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFormInTab(new FRMListDeliveryEmployees(), ButDeliveryEmployees.Caption);
        }

        private void ButDeliveryCompany_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFormInTab(new FRMListDeliveryCompany(), ButDeliveryCompany.Caption);
        }

        private void ButBox_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFormInTab(new FRMListBox(), ButBox.Caption);
        }
    }
}
