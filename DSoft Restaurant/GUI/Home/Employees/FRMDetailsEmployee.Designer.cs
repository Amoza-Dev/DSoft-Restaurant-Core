namespace DSoft_Restaurant.GUI.Home.Employees
{
    partial class FRMDetailsEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMDetailsEmployee));
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            CBCategoryEmployee = new DevExpress.XtraEditors.SearchLookUpEdit();
            searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            TxtAddress = new DevExpress.XtraEditors.TextEdit();
            DTStartJob = new DevExpress.XtraEditors.DateEdit();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            TxtPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            TxtSalary = new DevExpress.XtraEditors.SpinEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            TxtNameEmployee = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ButSave = new DevExpress.XtraEditors.SimpleButton();
            ButNew = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CBCategoryEmployee.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtAddress.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DTStartJob.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DTStartJob.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtPhoneNumber.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtSalary.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtNameEmployee.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            SuspendLayout();
            // 
            // groupControl1
            // 
            groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            groupControl1.AppearanceCaption.Options.UseFont = true;
            groupControl1.Controls.Add(CBCategoryEmployee);
            groupControl1.Controls.Add(TxtAddress);
            groupControl1.Controls.Add(DTStartJob);
            groupControl1.Controls.Add(labelControl6);
            groupControl1.Controls.Add(TxtPhoneNumber);
            groupControl1.Controls.Add(labelControl5);
            groupControl1.Controls.Add(labelControl4);
            groupControl1.Controls.Add(TxtSalary);
            groupControl1.Controls.Add(labelControl3);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(TxtNameEmployee);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Controls.Add(panelControl1);
            groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupControl1.Location = new System.Drawing.Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(826, 276);
            groupControl1.TabIndex = 1;
            groupControl1.Text = "زانیاری کارمەند";
            groupControl1.Paint += groupControl1_Paint;
            // 
            // CBCategoryEmployee
            // 
            CBCategoryEmployee.Location = new System.Drawing.Point(61, 45);
            CBCategoryEmployee.Name = "CBCategoryEmployee";
            CBCategoryEmployee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            CBCategoryEmployee.Properties.DisplayMember = "Name";
            CBCategoryEmployee.Properties.NullText = "جۆری کارمەند دیاریبکە";
            CBCategoryEmployee.Properties.PopupView = searchLookUpEdit1View;
            CBCategoryEmployee.Properties.ValueMember = "ID";
            CBCategoryEmployee.Size = new System.Drawing.Size(210, 32);
            CBCategoryEmployee.TabIndex = 38;
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
            gridColumn5.Caption = "جۆری کارمەند";
            gridColumn5.FieldName = "Name";
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
            // TxtAddress
            // 
            TxtAddress.Location = new System.Drawing.Point(61, 94);
            TxtAddress.Name = "TxtAddress";
            TxtAddress.Size = new System.Drawing.Size(210, 32);
            TxtAddress.TabIndex = 19;
            // 
            // DTStartJob
            // 
            DTStartJob.EditValue = null;
            DTStartJob.Location = new System.Drawing.Point(61, 142);
            DTStartJob.Name = "DTStartJob";
            DTStartJob.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            DTStartJob.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            DTStartJob.Size = new System.Drawing.Size(210, 32);
            DTStartJob.TabIndex = 18;
            // 
            // labelControl6
            // 
            labelControl6.Location = new System.Drawing.Point(283, 145);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new System.Drawing.Size(94, 26);
            labelControl6.TabIndex = 17;
            labelControl6.Text = "دەستبەکاربوون:";
            // 
            // TxtPhoneNumber
            // 
            TxtPhoneNumber.Location = new System.Drawing.Point(506, 142);
            TxtPhoneNumber.Name = "TxtPhoneNumber";
            TxtPhoneNumber.Size = new System.Drawing.Size(210, 32);
            TxtPhoneNumber.TabIndex = 15;
            // 
            // labelControl5
            // 
            labelControl5.Location = new System.Drawing.Point(320, 97);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(57, 26);
            labelControl5.TabIndex = 10;
            labelControl5.Text = "ناونیشان:";
            // 
            // labelControl4
            // 
            labelControl4.Location = new System.Drawing.Point(740, 145);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(74, 26);
            labelControl4.TabIndex = 7;
            labelControl4.Text = "ژمارە مۆبایل:";
            // 
            // TxtSalary
            // 
            TxtSalary.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            TxtSalary.Location = new System.Drawing.Point(506, 94);
            TxtSalary.Name = "TxtSalary";
            TxtSalary.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            TxtSalary.Properties.Increment = new decimal(new int[] { 250, 0, 0, 0 });
            TxtSalary.Properties.MaskSettings.Set("mask", "d");
            TxtSalary.Properties.MaskSettings.Set("culture", "ckb");
            TxtSalary.Properties.MaskSettings.Set("hideInsignificantZeros", true);
            TxtSalary.Size = new System.Drawing.Size(210, 32);
            TxtSalary.TabIndex = 5;
            // 
            // labelControl3
            // 
            labelControl3.Location = new System.Drawing.Point(755, 97);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(59, 26);
            labelControl3.TabIndex = 4;
            labelControl3.Text = "بری موچە:";
            // 
            // labelControl2
            // 
            labelControl2.Location = new System.Drawing.Point(296, 48);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(81, 26);
            labelControl2.TabIndex = 3;
            labelControl2.Text = "جۆری کارمەند:";
            // 
            // TxtNameEmployee
            // 
            TxtNameEmployee.Location = new System.Drawing.Point(390, 45);
            TxtNameEmployee.Name = "TxtNameEmployee";
            TxtNameEmployee.Size = new System.Drawing.Size(326, 32);
            TxtNameEmployee.TabIndex = 1;
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(736, 48);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(78, 26);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "ناوی کارمەند:";
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(ButSave);
            panelControl1.Controls.Add(ButNew);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelControl1.Location = new System.Drawing.Point(2, 214);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(822, 60);
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
            // FRMDetailsEmployee
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(826, 276);
            Controls.Add(groupControl1);
            Font = new System.Drawing.Font("Rabar_021", 12F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            IconOptions.ShowIcon = false;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FRMDetailsEmployee";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += FRMDetailsEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CBCategoryEmployee.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtAddress.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DTStartJob.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DTStartJob.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtPhoneNumber.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtSalary.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtNameEmployee.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SpinEdit TxtSalary;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtNameEmployee;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton ButSave;
        private DevExpress.XtraEditors.SimpleButton ButNew;
        private DevExpress.XtraEditors.TextEdit TxtPhoneNumber;
        private DevExpress.XtraEditors.DateEdit DTStartJob;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit TxtAddress;
        private DevExpress.XtraEditors.SearchLookUpEdit CBCategoryEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}