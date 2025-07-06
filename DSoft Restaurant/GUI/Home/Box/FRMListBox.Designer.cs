namespace DSoft_Restaurant.GUI.Home.Box
{
    partial class FRMListBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMListBox));
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            searchControl = new DevExpress.XtraEditors.SearchControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ButDelete = new DevExpress.XtraEditors.SimpleButton();
            ButUpdate = new DevExpress.XtraEditors.SimpleButton();
            ButNew = new DevExpress.XtraEditors.SimpleButton();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchControl.Properties).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            gridControl1.Location = new System.Drawing.Point(225, 104);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(843, 452);
            gridControl1.TabIndex = 12;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // searchControl
            // 
            searchControl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            searchControl.Client = gridControl1;
            searchControl.Location = new System.Drawing.Point(732, 55);
            searchControl.Name = "searchControl";
            searchControl.Properties.Appearance.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            searchControl.Properties.Appearance.Options.UseFont = true;
            searchControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Repository.ClearButton(), new DevExpress.XtraEditors.Repository.SearchButton() });
            searchControl.Properties.Client = gridControl1;
            searchControl.Size = new System.Drawing.Size(299, 32);
            searchControl.TabIndex = 11;
            // 
            // labelControl1
            // 
            labelControl1.AllowHtmlString = true;
            labelControl1.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            labelControl1.Appearance.BackColor = System.Drawing.SystemColors.HotTrack;
            labelControl1.Appearance.Font = new System.Drawing.Font("Rabar_021", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            labelControl1.Appearance.Options.UseBackColor = true;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Appearance.Options.UseTextOptions = true;
            labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            labelControl1.Location = new System.Drawing.Point(0, 0);
            labelControl1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(1080, 38);
            labelControl1.TabIndex = 10;
            labelControl1.Text = "خەزێنە";
            // 
            // ButDelete
            // 
            ButDelete.Appearance.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            ButDelete.Appearance.Options.UseFont = true;
            ButDelete.AppearanceDisabled.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButDelete.AppearanceDisabled.Options.UseFont = true;
            ButDelete.AppearanceHovered.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButDelete.AppearanceHovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Hyperlink;
            ButDelete.AppearanceHovered.Options.UseFont = true;
            ButDelete.AppearanceHovered.Options.UseForeColor = true;
            ButDelete.AppearancePressed.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButDelete.AppearancePressed.Options.UseFont = true;
            ButDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            ButDelete.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("ButDelete.ImageOptions.SvgImage");
            ButDelete.Location = new System.Drawing.Point(12, 212);
            ButDelete.Name = "ButDelete";
            ButDelete.Size = new System.Drawing.Size(207, 48);
            ButDelete.TabIndex = 16;
            ButDelete.Text = "سرینەوە";
            // 
            // ButUpdate
            // 
            ButUpdate.Appearance.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            ButUpdate.Appearance.Options.UseFont = true;
            ButUpdate.AppearanceDisabled.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButUpdate.AppearanceDisabled.Options.UseFont = true;
            ButUpdate.AppearanceHovered.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButUpdate.AppearanceHovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Hyperlink;
            ButUpdate.AppearanceHovered.Options.UseFont = true;
            ButUpdate.AppearanceHovered.Options.UseForeColor = true;
            ButUpdate.AppearancePressed.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButUpdate.AppearancePressed.Options.UseFont = true;
            ButUpdate.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            ButUpdate.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("ButUpdate.ImageOptions.SvgImage");
            ButUpdate.Location = new System.Drawing.Point(12, 158);
            ButUpdate.Name = "ButUpdate";
            ButUpdate.Size = new System.Drawing.Size(207, 48);
            ButUpdate.TabIndex = 15;
            ButUpdate.Text = "نوێکرنەوە";
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
            ButNew.Location = new System.Drawing.Point(12, 104);
            ButNew.Name = "ButNew";
            ButNew.Size = new System.Drawing.Size(207, 48);
            ButNew.TabIndex = 14;
            ButNew.Text = "نوێ";
            ButNew.Click += ButNew_Click;
            // 
            // labelControl2
            // 
            labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            labelControl2.Appearance.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new System.Drawing.Point(1037, 58);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(36, 26);
            labelControl2.TabIndex = 13;
            labelControl2.Text = "گەران:";
            // 
            // FRMListBox
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(1080, 568);
            Controls.Add(gridControl1);
            Controls.Add(searchControl);
            Controls.Add(labelControl1);
            Controls.Add(ButDelete);
            Controls.Add(ButUpdate);
            Controls.Add(ButNew);
            Controls.Add(labelControl2);
            IconOptions.ShowIcon = false;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FRMListBox";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchControl.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SearchControl searchControl;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton ButDelete;
        private DevExpress.XtraEditors.SimpleButton ButUpdate;
        private DevExpress.XtraEditors.SimpleButton ButNew;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}