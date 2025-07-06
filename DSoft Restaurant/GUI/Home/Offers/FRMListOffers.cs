using DevExpress.XtraEditors;
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

namespace DSoft_Restaurant.GUI.Home.Offers
{
    public partial class FRMListOffers : DevExpress.XtraEditors.XtraForm
    {
        public FRMListOffers()
        {
            InitializeComponent();
        }

        private void FRMListItems_Load(object sender, EventArgs e)
        {

        }

        private void ButNew_Click(object sender, EventArgs e)
        {
            FRMDetailsOffers obj = new FRMDetailsOffers();
            obj.ShowDialog();
        }
    }
}