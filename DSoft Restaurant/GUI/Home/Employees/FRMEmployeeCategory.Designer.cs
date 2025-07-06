namespace DSoft_Restaurant.GUI.Home.Employees
{
    partial class FRMEmployeeCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMEmployeeCategory));
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            TxtEmployeeCategory = new DevExpress.XtraEditors.TextEdit();
            ButDelete = new DevExpress.XtraEditors.SimpleButton();
            ButSave = new DevExpress.XtraEditors.SimpleButton();
            ButNew = new DevExpress.XtraEditors.SimpleButton();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumnIsDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)TxtEmployeeCategory.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemTextEdit1).BeginInit();
            SuspendLayout();
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
            labelControl1.Size = new System.Drawing.Size(648, 38);
            labelControl1.TabIndex = 10;
            labelControl1.Text = "جۆری کامەند";
            // 
            // labelControl2
            // 
            labelControl2.Location = new System.Drawing.Point(554, 62);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(81, 26);
            labelControl2.TabIndex = 22;
            labelControl2.Text = "جۆری کارمەند:";
            // 
            // TxtEmployeeCategory
            // 
            TxtEmployeeCategory.Location = new System.Drawing.Point(228, 59);
            TxtEmployeeCategory.Name = "TxtEmployeeCategory";
            TxtEmployeeCategory.Size = new System.Drawing.Size(312, 32);
            TxtEmployeeCategory.TabIndex = 23;
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
            ButDelete.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("ButCategory.ImageOptions.SvgImage");
            ButDelete.Location = new System.Drawing.Point(334, 109);
            ButDelete.Name = "ButDelete";
            ButDelete.Size = new System.Drawing.Size(100, 45);
            ButDelete.TabIndex = 28;
            ButDelete.Text = "سرینەوە";
            ButDelete.Click += ButDelete_Click;
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
            ButSave.Location = new System.Drawing.Point(228, 109);
            ButSave.Name = "ButSave";
            ButSave.Size = new System.Drawing.Size(100, 45);
            ButSave.TabIndex = 27;
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
            ButNew.Location = new System.Drawing.Point(440, 109);
            ButNew.Name = "ButNew";
            ButNew.Size = new System.Drawing.Size(100, 45);
            ButNew.TabIndex = 26;
            ButNew.Text = "نوێ";
            ButNew.Click += ButNew_Click;
            // 
            // gridControl1
            // 
            gridControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            gridControl1.Location = new System.Drawing.Point(11, 167);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemTextEdit1 });
            gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            gridControl1.Size = new System.Drawing.Size(624, 468);
            gridControl1.TabIndex = 29;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumnID, gridColumnName, gridColumnIsDelete });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsLayout.Columns.AddNewColumns = false;
            gridView1.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.False;
            gridView1.OptionsView.ShowDetailButtons = false;
            gridView1.OptionsView.ShowGroupExpandCollapseButtons = false;
            gridView1.RowCellClick += gridView1_RowCellClick;
            // 
            // gridColumnID
            // 
            gridColumnID.Caption = "gridColumn1";
            gridColumnID.FieldName = "ID";
            gridColumnID.Name = "gridColumnID";
            // 
            // gridColumnName
            // 
            gridColumnName.AppearanceCell.Options.UseTextOptions = true;
            gridColumnName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumnName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridColumnName.AppearanceHeader.Font = new System.Drawing.Font("Rabar_021", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            gridColumnName.AppearanceHeader.Options.UseFont = true;
            gridColumnName.AppearanceHeader.Options.UseTextOptions = true;
            gridColumnName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumnName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridColumnName.Caption = "جۆری کارمەند";
            gridColumnName.FieldName = "Name";
            gridColumnName.Name = "gridColumnName";
            gridColumnName.Visible = true;
            gridColumnName.VisibleIndex = 0;
            // 
            // gridColumnIsDelete
            // 
            gridColumnIsDelete.Caption = "gridColumn4";
            gridColumnIsDelete.FieldName = "IsDelete";
            gridColumnIsDelete.Name = "gridColumnIsDelete";
            // 
            // repositoryItemTextEdit1
            // 
            repositoryItemTextEdit1.AutoHeight = false;
            repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // FRMEmployeeCategory
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(648, 648);
            Controls.Add(gridControl1);
            Controls.Add(labelControl2);
            Controls.Add(TxtEmployeeCategory);
            Controls.Add(ButDelete);
            Controls.Add(ButSave);
            Controls.Add(ButNew);
            Controls.Add(labelControl1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            IconOptions.ShowIcon = false;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FRMEmployeeCategory";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += FRMEmployeeCategory_Load;
            ((System.ComponentModel.ISupportInitialize)TxtEmployeeCategory.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemTextEdit1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtEmployeeCategory;
        private DevExpress.XtraEditors.SimpleButton ButDelete;
        private DevExpress.XtraEditors.SimpleButton ButSave;
        private DevExpress.XtraEditors.SimpleButton ButNew;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIsDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}