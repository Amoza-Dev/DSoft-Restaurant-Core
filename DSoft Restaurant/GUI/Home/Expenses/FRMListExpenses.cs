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
using DSoft_Restaurant.GUI.Home.Expenses;

namespace DSoft_Restaurant.GUI.Home.Expenses
{
    public partial class FRMListExpenses : DevExpress.XtraEditors.XtraForm
    {
        public FRMListExpenses()
        {
            InitializeComponent();
        }

        private void ButNew_Click(object sender, EventArgs e)
        {
            FRMDetailsExpenses obj =new FRMDetailsExpenses();
            obj.ShowDialog();
        }

        private void ButGroupExpenses_Click(object sender, EventArgs e)
        {
            FRMGroupExpenses obj=new FRMGroupExpenses();
            obj.ShowDialog();
        }
    }
}