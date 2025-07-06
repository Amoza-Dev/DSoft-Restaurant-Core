using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSoft_Restaurant.Code.Helper
{
    public class ClearHelper
    {
        public static void ClearInputs(Control parent) 
        {
            foreach (Control control in parent.Controls)
            {
                if(control is BaseEdit devbase)
                {
                    Clear(devbase);
                }
                if (control.HasChildren)
                {
                    ClearInputs(control);
                }
            }
        }
        public static void Clear(BaseEdit control) 
        {
            if (control is TextEdit textbox)
            {
                textbox.Text = string.Empty;
            }
            else if (control is ComboBoxEdit comboBox)
            {
                comboBox.SelectedIndex = 0;
            }
            else if (control is DateEdit dateedit)
            {
                dateedit.EditValue = null;
                dateedit.DateTime = DateTime.Now;
            }
            else if (control is SpinEdit spinedit)
            {
                spinedit.Value = 0;
            }
            else if (control is LookUpEdit lookupedit)
            {
                lookupedit.EditValue = null;
            }
            else if (control is CheckEdit checkedit) 
            {
                checkedit.Checked = true;
            }
        }
    }
}
