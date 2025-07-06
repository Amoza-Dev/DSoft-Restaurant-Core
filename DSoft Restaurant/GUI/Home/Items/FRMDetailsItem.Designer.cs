namespace DSoft_Restaurant.GUI.Home.Items
{
    partial class FRMDetailsItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMDetailsItem));
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            CkbState = new DevExpress.XtraEditors.CheckEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            CBCategoryItem = new DevExpress.XtraEditors.SearchLookUpEdit();
            searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            CBWeight = new DevExpress.XtraEditors.ComboBoxEdit();
            TxtPriceItem = new DevExpress.XtraEditors.SpinEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            TxtNameItem = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ButCategory = new DevExpress.XtraEditors.SimpleButton();
            ButSave = new DevExpress.XtraEditors.SimpleButton();
            ButNew = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CkbState.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CBCategoryItem.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CBWeight.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtPriceItem.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtNameItem.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            SuspendLayout();
            // 
            // groupControl1
            // 
            groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            groupControl1.AppearanceCaption.Options.UseFont = true;
            groupControl1.Controls.Add(CkbState);
            groupControl1.Controls.Add(labelControl5);
            groupControl1.Controls.Add(CBCategoryItem);
            groupControl1.Controls.Add(labelControl4);
            groupControl1.Controls.Add(CBWeight);
            groupControl1.Controls.Add(TxtPriceItem);
            groupControl1.Controls.Add(labelControl3);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(TxtNameItem);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Controls.Add(panelControl1);
            groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupControl1.Location = new System.Drawing.Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(862, 297);
            groupControl1.TabIndex = 0;
            groupControl1.Text = "زانیاری بابەت";
            groupControl1.Paint += groupControl1_Paint;
            // 
            // CkbState
            // 
            CkbState.EditValue = true;
            CkbState.Location = new System.Drawing.Point(578, 147);
            CkbState.Name = "CkbState";
            CkbState.Properties.Caption = "بەردەستە";
            CkbState.Size = new System.Drawing.Size(187, 30);
            CkbState.TabIndex = 12;
            // 
            // labelControl5
            // 
            labelControl5.Location = new System.Drawing.Point(778, 149);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(76, 26);
            labelControl5.TabIndex = 10;
            labelControl5.Text = "دۆخی بابەت:";
            // 
            // CBCategoryItem
            // 
            CBCategoryItem.Location = new System.Drawing.Point(141, 46);
            CBCategoryItem.Name = "CBCategoryItem";
            CBCategoryItem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            CBCategoryItem.Properties.DisplayMember = "Name";
            CBCategoryItem.Properties.NullText = "جۆری بابەت دیاریبکە";
            CBCategoryItem.Properties.PopupView = searchLookUpEdit1View;
            CBCategoryItem.Properties.ValueMember = "ID";
            CBCategoryItem.Size = new System.Drawing.Size(210, 32);
            CBCategoryItem.TabIndex = 8;
            // 
            // searchLookUpEdit1View
            // 
            searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2 });
            searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "جۆری بابەت";
            gridColumn1.FieldName = "Name";
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "gridColumn2";
            gridColumn2.FieldName = "ID";
            gridColumn2.Name = "gridColumn2";
            // 
            // labelControl4
            // 
            labelControl4.Location = new System.Drawing.Point(357, 98);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(80, 26);
            labelControl4.TabIndex = 7;
            labelControl4.Text = "کێشی بابەت:";
            // 
            // CBWeight
            // 
            CBWeight.EditValue = "بەردەست نیە";
            CBWeight.Location = new System.Drawing.Point(141, 95);
            CBWeight.Name = "CBWeight";
            CBWeight.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            CBWeight.Properties.Items.AddRange(new object[] { "بەردەستە", "بەردەست نیە" });
            CBWeight.Size = new System.Drawing.Size(210, 32);
            CBWeight.TabIndex = 6;
            // 
            // TxtPriceItem
            // 
            TxtPriceItem.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            TxtPriceItem.Location = new System.Drawing.Point(555, 95);
            TxtPriceItem.Name = "TxtPriceItem";
            TxtPriceItem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            TxtPriceItem.Properties.Increment = new decimal(new int[] { 250, 0, 0, 0 });
            TxtPriceItem.Properties.MaskSettings.Set("mask", "d");
            TxtPriceItem.Properties.MaskSettings.Set("culture", "ckb");
            TxtPriceItem.Properties.MaskSettings.Set("hideInsignificantZeros", true);
            TxtPriceItem.Size = new System.Drawing.Size(210, 32);
            TxtPriceItem.TabIndex = 5;
            // 
            // labelControl3
            // 
            labelControl3.Location = new System.Drawing.Point(778, 98);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(72, 26);
            labelControl3.TabIndex = 4;
            labelControl3.Text = "نرخی بابەت:";
            // 
            // labelControl2
            // 
            labelControl2.Location = new System.Drawing.Point(362, 49);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(71, 26);
            labelControl2.TabIndex = 3;
            labelControl2.Text = "جۆری بابەت:";
            // 
            // TxtNameItem
            // 
            TxtNameItem.Location = new System.Drawing.Point(439, 46);
            TxtNameItem.Name = "TxtNameItem";
            TxtNameItem.Size = new System.Drawing.Size(326, 32);
            TxtNameItem.TabIndex = 1;
            TxtNameItem.EditValueChanged += textEdit1_EditValueChanged;
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(782, 49);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(68, 26);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "ناوی بابەت:";
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(ButCategory);
            panelControl1.Controls.Add(ButSave);
            panelControl1.Controls.Add(ButNew);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelControl1.Location = new System.Drawing.Point(2, 235);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(858, 60);
            panelControl1.TabIndex = 14;
            // 
            // ButCategory
            // 
            ButCategory.Appearance.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            ButCategory.Appearance.Options.UseFont = true;
            ButCategory.AppearanceDisabled.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButCategory.AppearanceDisabled.Options.UseFont = true;
            ButCategory.AppearanceHovered.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButCategory.AppearanceHovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Hyperlink;
            ButCategory.AppearanceHovered.Options.UseFont = true;
            ButCategory.AppearanceHovered.Options.UseForeColor = true;
            ButCategory.AppearancePressed.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButCategory.AppearancePressed.Options.UseFont = true;
            ButCategory.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            ButCategory.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("ButCategory.ImageOptions.SvgImage");
            ButCategory.Location = new System.Drawing.Point(238, 8);
            ButCategory.Name = "ButCategory";
            ButCategory.Size = new System.Drawing.Size(100, 45);
            ButCategory.TabIndex = 8;
            ButCategory.Text = "جۆر";
            ButCategory.Click += ButCategory_Click;
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
            ButNew.Click += ButNew_Click;
            // 
            // FRMDetailsItem
            // 
            Appearance.Options.UseFont = true;
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(862, 297);
            Controls.Add(groupControl1);
            Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            IconOptions.ShowIcon = false;
            Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FRMDetailsItem";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += FRMDetailsItem_Load;
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CkbState.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)CBCategoryItem.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)CBWeight.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtPriceItem.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtNameItem.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit TxtNameItem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SpinEdit TxtPriceItem;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit CBWeight;
        private DevExpress.XtraEditors.SearchLookUpEdit CBCategoryItem;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.CheckEdit CkbState;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton ButCategory;
        private DevExpress.XtraEditors.SimpleButton ButSave;
        private DevExpress.XtraEditors.SimpleButton ButNew;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}