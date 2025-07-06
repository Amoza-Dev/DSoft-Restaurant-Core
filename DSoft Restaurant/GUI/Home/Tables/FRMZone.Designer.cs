namespace DSoft_Restaurant.GUI.Home.Tables
{
    partial class FRMZone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMZone));
            TxtName = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            CkbState = new DevExpress.XtraEditors.CheckEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ButCategory = new DevExpress.XtraEditors.SimpleButton();
            ButSave = new DevExpress.XtraEditors.SimpleButton();
            ButNew = new DevExpress.XtraEditors.SimpleButton();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumnIsDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumnIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)TxtName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CkbState.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemTextEdit1).BeginInit();
            SuspendLayout();
            // 
            // TxtName
            // 
            TxtName.Location = new System.Drawing.Point(223, 53);
            TxtName.Name = "TxtName";
            TxtName.Size = new System.Drawing.Size(312, 32);
            TxtName.TabIndex = 0;
            // 
            // labelControl2
            // 
            labelControl2.Location = new System.Drawing.Point(549, 56);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(71, 26);
            labelControl2.TabIndex = 23;
            labelControl2.Text = "ناوی شوێن:";
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
            labelControl1.TabIndex = 21;
            labelControl1.Text = "شوێن";
            // 
            // CkbState
            // 
            CkbState.EditValue = true;
            CkbState.Location = new System.Drawing.Point(348, 91);
            CkbState.Name = "CkbState";
            CkbState.Properties.Caption = "بەردەستە";
            CkbState.Size = new System.Drawing.Size(187, 30);
            CkbState.TabIndex = 1;
            // 
            // labelControl5
            // 
            labelControl5.Location = new System.Drawing.Point(541, 93);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(79, 26);
            labelControl5.TabIndex = 30;
            labelControl5.Text = "دۆخی شوێن:";
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
            ButCategory.Location = new System.Drawing.Point(329, 127);
            ButCategory.Name = "ButCategory";
            ButCategory.Size = new System.Drawing.Size(100, 45);
            ButCategory.TabIndex = 29;
            ButCategory.Text = "سرینەوە";
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
            ButSave.Location = new System.Drawing.Point(223, 127);
            ButSave.Name = "ButSave";
            ButSave.Size = new System.Drawing.Size(100, 45);
            ButSave.TabIndex = 2;
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
            ButNew.Location = new System.Drawing.Point(435, 127);
            ButNew.Name = "ButNew";
            ButNew.Size = new System.Drawing.Size(100, 45);
            ButNew.TabIndex = 27;
            ButNew.Text = "نوێ";
            ButNew.Click += ButNew_Click;
            // 
            // gridControl1
            // 
            gridControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            gridControl1.Location = new System.Drawing.Point(11, 192);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemTextEdit1 });
            gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            gridControl1.Size = new System.Drawing.Size(624, 450);
            gridControl1.TabIndex = 32;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumnID, gridColumnName, gridColumnIsDelete, gridColumnIsActive });
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
            gridView1.CustomColumnDisplayText += gridView1_CustomColumnDisplayText;
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
            gridColumnName.Caption = "ناوی شوێن";
            gridColumnName.FieldName = "ZoneName";
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
            // gridColumnIsActive
            // 
            gridColumnIsActive.AppearanceCell.Options.UseTextOptions = true;
            gridColumnIsActive.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumnIsActive.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridColumnIsActive.AppearanceHeader.Font = new System.Drawing.Font("Rabar_021", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            gridColumnIsActive.AppearanceHeader.Options.UseFont = true;
            gridColumnIsActive.AppearanceHeader.Options.UseTextOptions = true;
            gridColumnIsActive.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumnIsActive.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridColumnIsActive.Caption = "دۆخی شوێن";
            gridColumnIsActive.ColumnEdit = repositoryItemTextEdit1;
            gridColumnIsActive.FieldName = "IsActive";
            gridColumnIsActive.Name = "gridColumnIsActive";
            gridColumnIsActive.Visible = true;
            gridColumnIsActive.VisibleIndex = 1;
            // 
            // repositoryItemTextEdit1
            // 
            repositoryItemTextEdit1.AutoHeight = false;
            repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // FRMZone
            // 
            Appearance.Options.UseFont = true;
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(648, 648);
            Controls.Add(gridControl1);
            Controls.Add(TxtName);
            Controls.Add(labelControl2);
            Controls.Add(labelControl1);
            Controls.Add(CkbState);
            Controls.Add(labelControl5);
            Controls.Add(ButCategory);
            Controls.Add(ButSave);
            Controls.Add(ButNew);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            IconOptions.ShowIcon = false;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FRMZone";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += FRMZone_Load;
            ((System.ComponentModel.ISupportInitialize)TxtName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)CkbState.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemTextEdit1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraEditors.TextEdit TxtName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit CkbState;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton ButCategory;
        private DevExpress.XtraEditors.SimpleButton ButSave;
        private DevExpress.XtraEditors.SimpleButton ButNew;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIsDelete;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIsActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}