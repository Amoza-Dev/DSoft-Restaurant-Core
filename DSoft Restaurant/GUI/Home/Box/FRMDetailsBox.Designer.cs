namespace DSoft_Restaurant.GUI.Home.Box
{
    partial class FRMDetailsBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMDetailsBox));
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            TxtBoxName = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ButSave = new DevExpress.XtraEditors.SimpleButton();
            ButNew = new DevExpress.XtraEditors.SimpleButton();
            CBUser = new DevExpress.XtraEditors.SearchLookUpEdit();
            searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            TxtBoxValue = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TxtBoxName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CBUser.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtBoxValue.Properties).BeginInit();
            SuspendLayout();
            // 
            // groupControl1
            // 
            groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            groupControl1.AppearanceCaption.Options.UseFont = true;
            groupControl1.Controls.Add(TxtBoxValue);
            groupControl1.Controls.Add(CBUser);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Controls.Add(TxtBoxName);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(labelControl5);
            groupControl1.Controls.Add(panelControl1);
            groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupControl1.Location = new System.Drawing.Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(498, 289);
            groupControl1.TabIndex = 1;
            groupControl1.Text = "زانیاری کۆمپانیا";
            groupControl1.Paint += groupControl1_Paint;
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(422, 148);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(64, 26);
            labelControl1.TabIndex = 39;
            labelControl1.Text = "بەکارهێنەر:";
            // 
            // TxtBoxName
            // 
            TxtBoxName.Location = new System.Drawing.Point(84, 47);
            TxtBoxName.Name = "TxtBoxName";
            TxtBoxName.Size = new System.Drawing.Size(304, 32);
            TxtBoxName.TabIndex = 37;
            // 
            // labelControl2
            // 
            labelControl2.Location = new System.Drawing.Point(414, 50);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(72, 26);
            labelControl2.TabIndex = 36;
            labelControl2.Text = "ناوی خەزێنە:";
            // 
            // labelControl5
            // 
            labelControl5.Location = new System.Drawing.Point(394, 99);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(92, 26);
            labelControl5.TabIndex = 38;
            labelControl5.Text = "حسابی سەرەتا:";
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(ButSave);
            panelControl1.Controls.Add(ButNew);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelControl1.Location = new System.Drawing.Point(2, 227);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(494, 60);
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
            // CBUser
            // 
            CBUser.Location = new System.Drawing.Point(178, 142);
            CBUser.Name = "CBUser";
            CBUser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            CBUser.Properties.NullText = "";
            CBUser.Properties.PopupView = searchLookUpEdit1View;
            CBUser.Size = new System.Drawing.Size(210, 32);
            CBUser.TabIndex = 40;
            // 
            // searchLookUpEdit1View
            // 
            searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // TxtBoxValue
            // 
            TxtBoxValue.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            TxtBoxValue.Location = new System.Drawing.Point(178, 96);
            TxtBoxValue.Name = "TxtBoxValue";
            TxtBoxValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            TxtBoxValue.Properties.Increment = new decimal(new int[] { 250, 0, 0, 0 });
            TxtBoxValue.Properties.MaskSettings.Set("mask", "d");
            TxtBoxValue.Properties.MaskSettings.Set("culture", "ckb");
            TxtBoxValue.Properties.MaskSettings.Set("hideInsignificantZeros", true);
            TxtBoxValue.Size = new System.Drawing.Size(210, 32);
            TxtBoxValue.TabIndex = 41;
            // 
            // FRMDetailsBox
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(498, 289);
            Controls.Add(groupControl1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            IconOptions.ShowIcon = false;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FRMDetailsBox";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TxtBoxName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CBUser.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtBoxValue.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton ButSave;
        private DevExpress.XtraEditors.SimpleButton ButNew;
        private DevExpress.XtraEditors.TextEdit TxtBoxName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit CBUser;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SpinEdit TxtBoxValue;
    }
}