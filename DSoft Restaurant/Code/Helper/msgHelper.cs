using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSoft_Restaurant.Code.Helper
{
    public class msgHelper
    {
        public static void ShowSuccessAdd()
        {
            XtraMessageBox.Show("بەسەرکەوتووی تۆمارکرا!",
                  "تۆمارکرا",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowSuccessEdit()
        {
            XtraMessageBox.Show("بەسەرکەوتووی نوێکرایەوە!",
                  "نوێکرایەوە",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowSuccessDelete()
        {
            XtraMessageBox.Show("بەسەرکەوتووی سرایەوە!",
                  "سرایەوە",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowServerError()
        {
            XtraMessageBox.Show("کێشەیێک هەیە لە پەیوەندی کردن بە سێرڤەر. تکایە دووبارە هەوڵ بدە.",
                  "پەیوەندی سێرڤەر بەردەست نییە",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowRequiredFields()
        {
            XtraMessageBox.Show("هەموو خانەیەکان کە * تێدایە خانەیەکی پێویستن. تکایە پڕیان بکە و دووبارە هەوڵ بدە.",
                  "خانەی پێویست",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowDuplicatedItems()
        {
            XtraMessageBox.Show("سەرکەوتوونەو ئەم زانیارییە پێشتر زیادکراوە. تکایە دڵنیابە لە زانیاریەکان و دووبارە هەوڵ بدە.",
                  "زانیاری دووبارەکراو",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowEmptyDataGridView()
        {
            XtraMessageBox.Show("بۆ ئەم کارە پێویستە داتاکە دیاری بکەی.",
                  "داتا بەردەست نییە",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowDeleteSelectRow()
        {
            XtraMessageBox.Show("بۆ سڕینەوەی داتا، پێویستە ریزێک هەڵبژێریت.",
                  "سڕینەوە",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowUpdateSelectRow()
        {
            XtraMessageBox.Show("بۆ نوێکردنەوەی داتا، پێویستە ریزێک هەڵبژێریت.",
                  "نوێکردنەوە",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool ShowDeleteDialog()
        {
            var result = XtraMessageBox.Show("دڵنیایت لە سرینەوە؟ داتاکە دواتر بەردەست نابێت.",
                   "سڕینەوە",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        public static void ShowNumberValid()
        {
            XtraMessageBox.Show("تکایە تەنها ژمارە بنووسە!",
                  "هەڵە لە نووسین",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowException(Exception ex)
        {
            XtraMessageBox.Show($"هەڵە: {ex.Message}", "هەڵە هەیە لە ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
