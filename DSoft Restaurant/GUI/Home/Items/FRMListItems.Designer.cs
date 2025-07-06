namespace DSoft_Restaurant
{
    partial class FRMListItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMListItems));
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            searchControl = new DevExpress.XtraEditors.SearchControl();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumnPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumnIsWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            gridColumnIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            gridColumnCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ButNew = new DevExpress.XtraEditors.SimpleButton();
            ButUpdate = new DevExpress.XtraEditors.SimpleButton();
            ButDelete = new DevExpress.XtraEditors.SimpleButton();
            ButChangePrice = new DevExpress.XtraEditors.SimpleButton();
            ButCategory = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)searchControl.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemTextEdit2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemTextEdit1).BeginInit();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.AllowHtmlString = true;
            resources.ApplyResources(labelControl1, "labelControl1");
            labelControl1.Appearance.BackColor = System.Drawing.SystemColors.HotTrack;
            labelControl1.Appearance.Font = (System.Drawing.Font)resources.GetObject("labelControl1.Appearance.Font");
            labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            labelControl1.Appearance.Options.UseBackColor = true;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Appearance.Options.UseTextOptions = true;
            labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            labelControl1.Name = "labelControl1";
            // 
            // searchControl
            // 
            resources.ApplyResources(searchControl, "searchControl");
            searchControl.Client = gridControl1;
            searchControl.Name = "searchControl";
            searchControl.Properties.Appearance.Font = (System.Drawing.Font)resources.GetObject("searchControl.Properties.Appearance.Font");
            searchControl.Properties.Appearance.Options.UseFont = true;
            searchControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Repository.ClearButton(), new DevExpress.XtraEditors.Repository.SearchButton(), new DevExpress.XtraEditors.Repository.MRUButton() });
            searchControl.Properties.Client = gridControl1;
            searchControl.Properties.ShowMRUButton = true;
            // 
            // gridControl1
            // 
            resources.ApplyResources(gridControl1, "gridControl1");
            gridControl1.EmbeddedNavigator.Margin = (System.Windows.Forms.Padding)resources.GetObject("gridControl1.EmbeddedNavigator.Margin");
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemTextEdit1, repositoryItemTextEdit2 });
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumnID, gridColumnName, gridColumnPrice, gridColumnIsWeight, gridColumnIsActive, gridColumnCategory });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            gridView1.OptionsBehavior.Editable = false;
            gridView1.RowCellClick += gridView1_RowCellClick;
            gridView1.PopupMenuShowing += gridView1_PopupMenuShowing;
            gridView1.CustomColumnDisplayText += gridView1_CustomColumnDisplayText;
            gridView1.MouseUp += gridView1_MouseUp;
            // 
            // gridColumnID
            // 
            resources.ApplyResources(gridColumnID, "gridColumnID");
            gridColumnID.FieldName = "ID";
            gridColumnID.Name = "gridColumnID";
            // 
            // gridColumnName
            // 
            gridColumnName.AppearanceCell.Options.UseTextOptions = true;
            gridColumnName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumnName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridColumnName.AppearanceHeader.Options.UseTextOptions = true;
            gridColumnName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumnName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(gridColumnName, "gridColumnName");
            gridColumnName.FieldName = "Name";
            gridColumnName.Name = "gridColumnName";
            // 
            // gridColumnPrice
            // 
            gridColumnPrice.AppearanceCell.Options.UseTextOptions = true;
            gridColumnPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumnPrice.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridColumnPrice.AppearanceHeader.Options.UseTextOptions = true;
            gridColumnPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumnPrice.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(gridColumnPrice, "gridColumnPrice");
            gridColumnPrice.FieldName = "Price";
            gridColumnPrice.Name = "gridColumnPrice";
            // 
            // gridColumnIsWeight
            // 
            gridColumnIsWeight.AppearanceCell.Options.UseTextOptions = true;
            gridColumnIsWeight.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumnIsWeight.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridColumnIsWeight.AppearanceHeader.Options.UseTextOptions = true;
            gridColumnIsWeight.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumnIsWeight.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(gridColumnIsWeight, "gridColumnIsWeight");
            gridColumnIsWeight.ColumnEdit = repositoryItemTextEdit2;
            gridColumnIsWeight.FieldName = "IsWeight";
            gridColumnIsWeight.Name = "gridColumnIsWeight";
            // 
            // repositoryItemTextEdit2
            // 
            resources.ApplyResources(repositoryItemTextEdit2, "repositoryItemTextEdit2");
            repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // gridColumnIsActive
            // 
            gridColumnIsActive.AppearanceCell.Options.UseTextOptions = true;
            gridColumnIsActive.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumnIsActive.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridColumnIsActive.AppearanceHeader.Options.UseTextOptions = true;
            gridColumnIsActive.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumnIsActive.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(gridColumnIsActive, "gridColumnIsActive");
            gridColumnIsActive.ColumnEdit = repositoryItemTextEdit1;
            gridColumnIsActive.FieldName = "IsActive";
            gridColumnIsActive.Name = "gridColumnIsActive";
            // 
            // repositoryItemTextEdit1
            // 
            resources.ApplyResources(repositoryItemTextEdit1, "repositoryItemTextEdit1");
            repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // gridColumnCategory
            // 
            gridColumnCategory.AppearanceCell.Options.UseTextOptions = true;
            gridColumnCategory.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumnCategory.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridColumnCategory.AppearanceHeader.Options.UseTextOptions = true;
            gridColumnCategory.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumnCategory.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(gridColumnCategory, "gridColumnCategory");
            gridColumnCategory.FieldName = "CategoryName";
            gridColumnCategory.Name = "gridColumnCategory";
            // 
            // labelControl2
            // 
            resources.ApplyResources(labelControl2, "labelControl2");
            labelControl2.Appearance.Font = (System.Drawing.Font)resources.GetObject("labelControl2.Appearance.Font");
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Name = "labelControl2";
            // 
            // ButNew
            // 
            ButNew.Appearance.Font = (System.Drawing.Font)resources.GetObject("ButNew.Appearance.Font");
            ButNew.Appearance.Options.UseFont = true;
            ButNew.AppearanceDisabled.Font = (System.Drawing.Font)resources.GetObject("ButNew.AppearanceDisabled.Font");
            ButNew.AppearanceDisabled.Options.UseFont = true;
            ButNew.AppearanceHovered.Font = (System.Drawing.Font)resources.GetObject("ButNew.AppearanceHovered.Font");
            ButNew.AppearanceHovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Hyperlink;
            ButNew.AppearanceHovered.Options.UseFont = true;
            ButNew.AppearanceHovered.Options.UseForeColor = true;
            ButNew.AppearancePressed.Font = (System.Drawing.Font)resources.GetObject("ButNew.AppearancePressed.Font");
            ButNew.AppearancePressed.Options.UseFont = true;
            ButNew.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            ButNew.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("ButNew.ImageOptions.SvgImage");
            resources.ApplyResources(ButNew, "ButNew");
            ButNew.Name = "ButNew";
            ButNew.Click += ButNew_Click;
            // 
            // ButUpdate
            // 
            ButUpdate.Appearance.Font = (System.Drawing.Font)resources.GetObject("ButUpdate.Appearance.Font");
            ButUpdate.Appearance.Options.UseFont = true;
            ButUpdate.AppearanceDisabled.Font = (System.Drawing.Font)resources.GetObject("ButUpdate.AppearanceDisabled.Font");
            ButUpdate.AppearanceDisabled.Options.UseFont = true;
            ButUpdate.AppearanceHovered.Font = (System.Drawing.Font)resources.GetObject("ButUpdate.AppearanceHovered.Font");
            ButUpdate.AppearanceHovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Hyperlink;
            ButUpdate.AppearanceHovered.Options.UseFont = true;
            ButUpdate.AppearanceHovered.Options.UseForeColor = true;
            ButUpdate.AppearancePressed.Font = (System.Drawing.Font)resources.GetObject("ButUpdate.AppearancePressed.Font");
            ButUpdate.AppearancePressed.Options.UseFont = true;
            ButUpdate.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            ButUpdate.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("ButUpdate.ImageOptions.SvgImage");
            resources.ApplyResources(ButUpdate, "ButUpdate");
            ButUpdate.Name = "ButUpdate";
            ButUpdate.Click += ButUpdate_Click;
            // 
            // ButDelete
            // 
            ButDelete.Appearance.Font = (System.Drawing.Font)resources.GetObject("ButDelete.Appearance.Font");
            ButDelete.Appearance.Options.UseFont = true;
            ButDelete.AppearanceDisabled.Font = (System.Drawing.Font)resources.GetObject("ButDelete.AppearanceDisabled.Font");
            ButDelete.AppearanceDisabled.Options.UseFont = true;
            ButDelete.AppearanceHovered.Font = (System.Drawing.Font)resources.GetObject("ButDelete.AppearanceHovered.Font");
            ButDelete.AppearanceHovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Hyperlink;
            ButDelete.AppearanceHovered.Options.UseFont = true;
            ButDelete.AppearanceHovered.Options.UseForeColor = true;
            ButDelete.AppearancePressed.Font = (System.Drawing.Font)resources.GetObject("ButDelete.AppearancePressed.Font");
            ButDelete.AppearancePressed.Options.UseFont = true;
            ButDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            ButDelete.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("ButDelete.ImageOptions.SvgImage");
            resources.ApplyResources(ButDelete, "ButDelete");
            ButDelete.Name = "ButDelete";
            ButDelete.Click += ButDelete_Click;
            // 
            // ButChangePrice
            // 
            ButChangePrice.Appearance.Font = (System.Drawing.Font)resources.GetObject("ButChangePrice.Appearance.Font");
            ButChangePrice.Appearance.Options.UseFont = true;
            ButChangePrice.AppearanceDisabled.Font = (System.Drawing.Font)resources.GetObject("ButChangePrice.AppearanceDisabled.Font");
            ButChangePrice.AppearanceDisabled.Options.UseFont = true;
            ButChangePrice.AppearanceHovered.Font = (System.Drawing.Font)resources.GetObject("ButChangePrice.AppearanceHovered.Font");
            ButChangePrice.AppearanceHovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Hyperlink;
            ButChangePrice.AppearanceHovered.Options.UseFont = true;
            ButChangePrice.AppearanceHovered.Options.UseForeColor = true;
            ButChangePrice.AppearancePressed.Font = (System.Drawing.Font)resources.GetObject("ButChangePrice.AppearancePressed.Font");
            ButChangePrice.AppearancePressed.Options.UseFont = true;
            ButChangePrice.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            ButChangePrice.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("ButChangePrice.ImageOptions.SvgImage");
            resources.ApplyResources(ButChangePrice, "ButChangePrice");
            ButChangePrice.Name = "ButChangePrice";
            ButChangePrice.Click += ButChangePrice_Click;
            // 
            // ButCategory
            // 
            ButCategory.Appearance.Font = (System.Drawing.Font)resources.GetObject("ButCategory.Appearance.Font");
            ButCategory.Appearance.Options.UseFont = true;
            ButCategory.AppearanceDisabled.Font = (System.Drawing.Font)resources.GetObject("ButCategory.AppearanceDisabled.Font");
            ButCategory.AppearanceDisabled.Options.UseFont = true;
            ButCategory.AppearanceHovered.Font = (System.Drawing.Font)resources.GetObject("ButCategory.AppearanceHovered.Font");
            ButCategory.AppearanceHovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Hyperlink;
            ButCategory.AppearanceHovered.Options.UseFont = true;
            ButCategory.AppearanceHovered.Options.UseForeColor = true;
            ButCategory.AppearancePressed.Font = (System.Drawing.Font)resources.GetObject("ButCategory.AppearancePressed.Font");
            ButCategory.AppearancePressed.Options.UseFont = true;
            ButCategory.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            ButCategory.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("ButCategory.ImageOptions.SvgImage");
            resources.ApplyResources(ButCategory, "ButCategory");
            ButCategory.Name = "ButCategory";
            ButCategory.Click += ButCategory_Click;
            // 
            // FRMListItems
            // 
            Appearance.Options.UseFont = true;
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            Controls.Add(ButCategory);
            Controls.Add(ButChangePrice);
            Controls.Add(ButDelete);
            Controls.Add(ButUpdate);
            Controls.Add(ButNew);
            Controls.Add(labelControl2);
            Controls.Add(gridControl1);
            Controls.Add(searchControl);
            Controls.Add(labelControl1);
            IconOptions.ShowIcon = false;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FRMListItems";
            ShowInTaskbar = false;
            Load += FRMListItems_Load;
            ((System.ComponentModel.ISupportInitialize)searchControl.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemTextEdit2).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemTextEdit1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton ButNew;
        private DevExpress.XtraEditors.SimpleButton ButUpdate;
        private DevExpress.XtraEditors.SimpleButton ButDelete;
        private DevExpress.XtraEditors.SimpleButton ButChangePrice;
        private DevExpress.XtraEditors.SimpleButton ButCategory;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIsWeight;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCategory;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        public DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.XtraEditors.SearchControl searchControl;
    }
}