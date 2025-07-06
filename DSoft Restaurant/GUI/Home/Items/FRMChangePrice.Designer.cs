namespace DSoft_Restaurant.GUI.Home.Items
{
    partial class FRMChangePrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMChangePrice));
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ButSave = new DevExpress.XtraEditors.SimpleButton();
            TxtPriceItem = new DevExpress.XtraEditors.SpinEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            TxtNameItem = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TxtPriceItem.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtNameItem.Properties).BeginInit();
            SuspendLayout();
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(panelControl1);
            groupControl1.Controls.Add(TxtPriceItem);
            groupControl1.Controls.Add(labelControl3);
            groupControl1.Controls.Add(TxtNameItem);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupControl1.Location = new System.Drawing.Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(628, 224);
            groupControl1.TabIndex = 0;
            groupControl1.Text = "گۆرینی نرخ";
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(ButSave);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelControl1.Location = new System.Drawing.Point(2, 162);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(624, 60);
            panelControl1.TabIndex = 15;
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
            ButSave.Click += ButSave_Click;
            // 
            // TxtPriceItem
            // 
            TxtPriceItem.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            TxtPriceItem.Location = new System.Drawing.Point(322, 94);
            TxtPriceItem.Name = "TxtPriceItem";
            TxtPriceItem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            TxtPriceItem.Properties.Increment = new decimal(new int[] { 250, 0, 0, 0 });
            TxtPriceItem.Properties.MaskSettings.Set("mask", "d");
            TxtPriceItem.Properties.MaskSettings.Set("culture", "ckb");
            TxtPriceItem.Properties.MaskSettings.Set("hideInsignificantZeros", true);
            TxtPriceItem.Size = new System.Drawing.Size(210, 32);
            TxtPriceItem.TabIndex = 9;
            // 
            // labelControl3
            // 
            labelControl3.Location = new System.Drawing.Point(545, 97);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(72, 26);
            labelControl3.TabIndex = 8;
            labelControl3.Text = "نرخی بابەت:";
            // 
            // TxtNameItem
            // 
            TxtNameItem.Location = new System.Drawing.Point(206, 45);
            TxtNameItem.Name = "TxtNameItem";
            TxtNameItem.Properties.ReadOnly = true;
            TxtNameItem.Size = new System.Drawing.Size(326, 32);
            TxtNameItem.TabIndex = 7;
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(549, 48);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(68, 26);
            labelControl1.TabIndex = 6;
            labelControl1.Text = "ناوی بابەت:";
            // 
            // FRMChangePrice
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(628, 224);
            Controls.Add(groupControl1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            IconOptions.ShowIcon = false;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FRMChangePrice";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += FRMChangePrice_Load;
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TxtPriceItem.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtNameItem.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SpinEdit TxtPriceItem;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtNameItem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton ButSave;
    }
}