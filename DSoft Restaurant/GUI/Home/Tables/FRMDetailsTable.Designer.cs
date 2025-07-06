namespace DSoft_Restaurant.GUI.Home.Tables
{
    partial class FRMDetailsTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMDetailsTable));
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            CBZoneList = new DevExpress.XtraEditors.SearchLookUpEdit();
            searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ButSave = new DevExpress.XtraEditors.SimpleButton();
            ButNew = new DevExpress.XtraEditors.SimpleButton();
            TxtTableName = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CBZoneList.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TxtTableName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(CBZoneList);
            groupControl1.Controls.Add(panelControl1);
            groupControl1.Controls.Add(TxtTableName);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(labelControl5);
            groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupControl1.Location = new System.Drawing.Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(498, 248);
            groupControl1.TabIndex = 0;
            groupControl1.Text = "زانیاری مێز";
            // 
            // CBZoneList
            // 
            CBZoneList.Location = new System.Drawing.Point(228, 95);
            CBZoneList.Name = "CBZoneList";
            CBZoneList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            CBZoneList.Properties.DisplayMember = "ZoneName";
            CBZoneList.Properties.NullText = "شوێنی مێز دیاریبکە";
            CBZoneList.Properties.PopupView = searchLookUpEdit1View;
            CBZoneList.Properties.ValueMember = "ID";
            CBZoneList.Size = new System.Drawing.Size(210, 32);
            CBZoneList.TabIndex = 37;
            // 
            // searchLookUpEdit1View
            // 
            searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn5, gridColumn6 });
            searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn5
            // 
            gridColumn5.Caption = "شوێنەکان";
            gridColumn5.FieldName = "ZoneName";
            gridColumn5.Name = "gridColumn5";
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 0;
            // 
            // gridColumn6
            // 
            gridColumn6.Caption = "gridColumn2";
            gridColumn6.FieldName = "ID";
            gridColumn6.Name = "gridColumn6";
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(ButSave);
            panelControl1.Controls.Add(ButNew);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelControl1.Location = new System.Drawing.Point(2, 186);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(494, 60);
            panelControl1.TabIndex = 36;
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
            // TxtTableName
            // 
            TxtTableName.Location = new System.Drawing.Point(126, 50);
            TxtTableName.Name = "TxtTableName";
            TxtTableName.Size = new System.Drawing.Size(312, 32);
            TxtTableName.TabIndex = 33;
            // 
            // labelControl2
            // 
            labelControl2.Location = new System.Drawing.Point(461, 53);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(23, 26);
            labelControl2.TabIndex = 32;
            labelControl2.Text = "مێز:";
            // 
            // labelControl5
            // 
            labelControl5.Location = new System.Drawing.Point(444, 98);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(40, 26);
            labelControl5.TabIndex = 34;
            labelControl5.Text = "شوێن:";
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2 });
            gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridView1.Name = "gridView1";
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView1.OptionsView.ShowGroupPanel = false;
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
            // gridColumn3
            // 
            gridColumn3.Caption = "جۆری بابەت";
            gridColumn3.FieldName = "Name";
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            gridColumn4.Caption = "gridColumn2";
            gridColumn4.FieldName = "ID";
            gridColumn4.Name = "gridColumn4";
            // 
            // FRMDetailsTable
            // 
            Appearance.Options.UseFont = true;
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(498, 248);
            Controls.Add(groupControl1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            IconOptions.ShowIcon = false;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FRMDetailsTable";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += FRMDetailsTable_Load;
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CBZoneList.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TxtTableName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit TxtTableName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SearchLookUpEdit CBTableZone;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton ButSave;
        private DevExpress.XtraEditors.SimpleButton ButNew;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SearchLookUpEdit CBZoneList;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}