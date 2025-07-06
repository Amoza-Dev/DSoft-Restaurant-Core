using DevExpress.XtraEditors;
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
    public partial class FRMDetailsOffers : DevExpress.XtraEditors.XtraForm
    {
        public FRMDetailsOffers()
        {
            InitializeComponent();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButCategory_Click(object sender, EventArgs e)
        {
            FRMCategorey obj= new FRMCategorey();
            obj.ShowDialog();
        }
    }
}