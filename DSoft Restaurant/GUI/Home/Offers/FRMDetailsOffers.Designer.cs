namespace DSoft_Restaurant.GUI.Home.Offers
{
    partial class FRMDetailsOffers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMDetailsOffers));
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            CkbState = new DevExpress.XtraEditors.CheckEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            TxtPriceOffer = new DevExpress.XtraEditors.SpinEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            TxtNameOffer = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ButSave = new DevExpress.XtraEditors.SimpleButton();
            ButNew = new DevExpress.XtraEditors.SimpleButton();
            DTStartOffer = new DevExpress.XtraEditors.DateEdit();
            DTEndOffer = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)xtraTabControl1).BeginInit();
            xtraTabControl1.SuspendLayout();
            xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CkbState.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtPriceOffer.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtNameOffer.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DTStartOffer.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DTStartOffer.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DTEndOffer.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DTEndOffer.Properties.CalendarTimeProperties).BeginInit();
            SuspendLayout();
            // 
            // groupControl1
            // 
            groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            groupControl1.AppearanceCaption.Options.UseFont = true;
            groupControl1.Controls.Add(DTEndOffer);
            groupControl1.Controls.Add(DTStartOffer);
            groupControl1.Controls.Add(xtraTabControl1);
            groupControl1.Controls.Add(CkbState);
            groupControl1.Controls.Add(labelControl5);
            groupControl1.Controls.Add(labelControl4);
            groupControl1.Controls.Add(TxtPriceOffer);
            groupControl1.Controls.Add(labelControl3);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(TxtNameOffer);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Controls.Add(panelControl1);
            groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupControl1.Location = new System.Drawing.Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(922, 695);
            groupControl1.TabIndex = 0;
            groupControl1.Text = "زانیاری ئۆفەر";
            groupControl1.Paint += groupControl1_Paint;
            // 
            // xtraTabControl1
            // 
            xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            xtraTabControl1.Location = new System.Drawing.Point(2, 194);
            xtraTabControl1.Name = "xtraTabControl1";
            xtraTabControl1.SelectedTabPage = xtraTabPage1;
            xtraTabControl1.Size = new System.Drawing.Size(918, 439);
            xtraTabControl1.TabIndex = 13;
            xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage1 });
            // 
            // xtraTabPage1
            // 
            xtraTabPage1.Controls.Add(gridControl1);
            xtraTabPage1.Name = "xtraTabPage1";
            xtraTabPage1.Size = new System.Drawing.Size(916, 403);
            xtraTabPage1.Text = "لیستی بابەتەکان";
            // 
            // gridControl1
            // 
            gridControl1.Location = new System.Drawing.Point(336, 21);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(571, 360);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Rabar_021", 14F);
            gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // CkbState
            // 
            CkbState.EditValue = true;
            CkbState.Location = new System.Drawing.Point(638, 147);
            CkbState.Name = "CkbState";
            CkbState.Properties.Caption = "بەردەستە";
            CkbState.Size = new System.Drawing.Size(187, 30);
            CkbState.TabIndex = 12;
            // 
            // labelControl5
            // 
            labelControl5.Location = new System.Drawing.Point(838, 149);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(76, 26);
            labelControl5.TabIndex = 10;
            labelControl5.Text = "دۆخی بابەت:";
            // 
            // labelControl4
            // 
            labelControl4.Location = new System.Drawing.Point(375, 98);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(93, 26);
            labelControl4.TabIndex = 7;
            labelControl4.Text = "بەرواری کۆتایی:";
            // 
            // TxtPriceOffer
            // 
            TxtPriceOffer.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            TxtPriceOffer.Location = new System.Drawing.Point(615, 95);
            TxtPriceOffer.Name = "TxtPriceOffer";
            TxtPriceOffer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            TxtPriceOffer.Properties.Increment = new decimal(new int[] { 250, 0, 0, 0 });
            TxtPriceOffer.Properties.MaskSettings.Set("mask", "d");
            TxtPriceOffer.Properties.MaskSettings.Set("culture", "ckb");
            TxtPriceOffer.Properties.MaskSettings.Set("hideInsignificantZeros", true);
            TxtPriceOffer.Size = new System.Drawing.Size(210, 32);
            TxtPriceOffer.TabIndex = 5;
            // 
            // labelControl3
            // 
            labelControl3.Location = new System.Drawing.Point(838, 98);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(72, 26);
            labelControl3.TabIndex = 4;
            labelControl3.Text = "نرخی ئۆفەر:";
            // 
            // labelControl2
            // 
            labelControl2.Location = new System.Drawing.Point(380, 49);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(95, 26);
            labelControl2.TabIndex = 3;
            labelControl2.Text = "بەروار دەستپێک:";
            // 
            // TxtNameOffer
            // 
            TxtNameOffer.Location = new System.Drawing.Point(499, 46);
            TxtNameOffer.Name = "TxtNameOffer";
            TxtNameOffer.Size = new System.Drawing.Size(326, 32);
            TxtNameOffer.TabIndex = 1;
            TxtNameOffer.EditValueChanged += textEdit1_EditValueChanged;
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(842, 49);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(68, 26);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "ناوی ئۆفەر:";
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(ButSave);
            panelControl1.Controls.Add(ButNew);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelControl1.Location = new System.Drawing.Point(2, 633);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(918, 60);
            panelControl1.TabIndex = 14;
            // 
            // ButSave
            // 
            ButSave.Appearance.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            ButSave.Appearance.Options.UseFont = true;
            ButSave.AppearanceDisabled.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButSave.AppearanceDisabled.Options.UseFont = true;
            ButSave.AppearanceHovered.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButSave.AppearanceHovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Hyperlink;
            ButSave.AppearanceHovered.Options.UseFont = true;
            ButSave.AppearanceHovered.Options.UseForeColor = true;
            ButSave.AppearancePressed.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButSave.AppearancePressed.Options.UseFont = true;
            ButSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            ButSave.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("ButSave.ImageOptions.SvgImage");
            ButSave.Location = new System.Drawing.Point(10, 8);
            ButSave.Name = "ButSave";
            ButSave.Size = new System.Drawing.Size(100, 45);
            ButSave.TabIndex = 7;
            ButSave.Text = "تۆمارکردن";
            // 
            // ButNew
            // 
            ButNew.Appearance.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            ButNew.Appearance.Options.UseFont = true;
            ButNew.AppearanceDisabled.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButNew.AppearanceDisabled.Options.UseFont = true;
            ButNew.AppearanceHovered.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButNew.AppearanceHovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Hyperlink;
            ButNew.AppearanceHovered.Options.UseFont = true;
            ButNew.AppearanceHovered.Options.UseForeColor = true;
            ButNew.AppearancePressed.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButNew.AppearancePressed.Options.UseFont = true;
            ButNew.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            ButNew.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("ButNew.ImageOptions.SvgImage");
            ButNew.Location = new System.Drawing.Point(124, 8);
            ButNew.Name = "ButNew";
            ButNew.Size = new System.Drawing.Size(100, 45);
            ButNew.TabIndex = 6;
            ButNew.Text = "نوێ";
            // 
            // DTStartOffer
            // 
            DTStartOffer.EditValue = null;
            DTStartOffer.Location = new System.Drawing.Point(159, 46);
            DTStartOffer.Name = "DTStartOffer";
            DTStartOffer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            DTStartOffer.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            DTStartOffer.Size = new System.Drawing.Size(210, 32);
            DTStartOffer.TabIndex = 15;
            // 
            // DTEndOffer
            // 
            DTEndOffer.EditValue = null;
            DTEndOffer.Location = new System.Drawing.Point(159, 95);
            DTEndOffer.Name = "DTEndOffer";
            DTEndOffer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            DTEndOffer.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            DTEndOffer.Size = new System.Drawing.Size(210, 32);
            DTEndOffer.TabIndex = 16;
            // 
            // FRMDetailsOffers
            // 
            Appearance.Options.UseFont = true;
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(922, 695);
            Controls.Add(groupControl1);
            Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            IconOptions.ShowIcon = false;
            Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FRMDetailsOffers";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)xtraTabControl1).EndInit();
            xtraTabControl1.ResumeLayout(false);
            xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CkbState.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtPriceOffer.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtNameOffer.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DTStartOffer.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DTStartOffer.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DTEndOffer.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DTEndOffer.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit TxtNameOffer;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SpinEdit TxtPriceOffer;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.CheckEdit CkbState;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton ButSave;
        private DevExpress.XtraEditors.SimpleButton ButNew;
        private DevExpress.XtraEditors.DateEdit DTStartOffer;
        private DevExpress.XtraEditors.DateEdit DTEndOffer;
    }
}