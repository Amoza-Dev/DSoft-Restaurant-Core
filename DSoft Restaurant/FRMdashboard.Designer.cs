namespace DSoft_Restaurant
{
    partial class FRMdashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMdashboard));
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            ButItems = new DevExpress.XtraBars.BarButtonItem();
            ButCategories = new DevExpress.XtraBars.BarButtonItem();
            ButTables = new DevExpress.XtraBars.BarButtonItem();
            ButDeliveryEmployees = new DevExpress.XtraBars.BarButtonItem();
            ButDeliveryCompany = new DevExpress.XtraBars.BarButtonItem();
            ButEmployees = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            ButBox = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            ButExpenses = new DevExpress.XtraBars.BarButtonItem();
            ButOffers = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroupItems = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroupEmployees = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroupOffer = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroupDeliver = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroupBox = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabControl1).BeginInit();
            xtraTabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // ribbonControl1
            // 
            ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(45, 60, 45, 60);
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, ButItems, ButCategories, ButTables, ButDeliveryEmployees, ButDeliveryCompany, ButEmployees, barButtonItem7, ButBox, barButtonItem9, ButExpenses, ButOffers, barButtonItem12, barButtonItem13 });
            ribbonControl1.Location = new System.Drawing.Point(0, 0);
            ribbonControl1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            ribbonControl1.MaxItemId = 16;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.OptionsMenuMinWidth = 495;
            ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbonControl1.Size = new System.Drawing.Size(1198, 215);
            ribbonControl1.StatusBar = ribbonStatusBar1;
            // 
            // ButItems
            // 
            ButItems.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            ButItems.Caption = "بابەتەکان";
            ButItems.Id = 1;
            ButItems.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("ButItems.ImageOptions.SvgImage");
            ButItems.ItemAppearance.Disabled.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButItems.ItemAppearance.Disabled.Options.UseFont = true;
            ButItems.ItemAppearance.Hovered.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButItems.ItemAppearance.Hovered.Options.UseFont = true;
            ButItems.ItemAppearance.Normal.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButItems.ItemAppearance.Normal.Options.UseFont = true;
            ButItems.ItemAppearance.Pressed.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButItems.ItemAppearance.Pressed.Options.UseFont = true;
            ButItems.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButItems.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            ButItems.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButItems.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            ButItems.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButItems.ItemInMenuAppearance.Normal.Options.UseFont = true;
            ButItems.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButItems.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            ButItems.LargeWidth = 70;
            ButItems.Name = "ButItems";
            ButItems.ItemClick += ButItems_ItemClick;
            // 
            // ButCategories
            // 
            ButCategories.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            ButCategories.Caption = "جۆری بابەت";
            ButCategories.Id = 2;
            ButCategories.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("ButCategories.ImageOptions.SvgImage");
            ButCategories.ItemAppearance.Disabled.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButCategories.ItemAppearance.Disabled.Options.UseFont = true;
            ButCategories.ItemAppearance.Hovered.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButCategories.ItemAppearance.Hovered.Options.UseFont = true;
            ButCategories.ItemAppearance.Normal.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButCategories.ItemAppearance.Normal.Options.UseFont = true;
            ButCategories.ItemAppearance.Pressed.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButCategories.ItemAppearance.Pressed.Options.UseFont = true;
            ButCategories.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButCategories.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            ButCategories.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButCategories.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            ButCategories.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButCategories.ItemInMenuAppearance.Normal.Options.UseFont = true;
            ButCategories.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButCategories.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            ButCategories.LargeWidth = 80;
            ButCategories.Name = "ButCategories";
            ButCategories.ItemClick += ButCategories_ItemClick;
            // 
            // ButTables
            // 
            ButTables.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            ButTables.Caption = "مێزەکان";
            ButTables.Id = 3;
            ButTables.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("ButTables.ImageOptions.SvgImage");
            ButTables.ItemAppearance.Disabled.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButTables.ItemAppearance.Disabled.Options.UseFont = true;
            ButTables.ItemAppearance.Hovered.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButTables.ItemAppearance.Hovered.Options.UseFont = true;
            ButTables.ItemAppearance.Normal.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButTables.ItemAppearance.Normal.Options.UseFont = true;
            ButTables.ItemAppearance.Pressed.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButTables.ItemAppearance.Pressed.Options.UseFont = true;
            ButTables.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButTables.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            ButTables.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButTables.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            ButTables.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButTables.ItemInMenuAppearance.Normal.Options.UseFont = true;
            ButTables.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButTables.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            ButTables.LargeWidth = 70;
            ButTables.Name = "ButTables";
            ButTables.ItemClick += ButTables_ItemClick;
            // 
            // ButDeliveryEmployees
            // 
            ButDeliveryEmployees.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            ButDeliveryEmployees.Caption = "کارمەندی گەیاندن";
            ButDeliveryEmployees.Id = 4;
            ButDeliveryEmployees.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("ButDeliveryEmployees.ImageOptions.SvgImage");
            ButDeliveryEmployees.ItemAppearance.Disabled.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButDeliveryEmployees.ItemAppearance.Disabled.Options.UseFont = true;
            ButDeliveryEmployees.ItemAppearance.Hovered.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButDeliveryEmployees.ItemAppearance.Hovered.Options.UseFont = true;
            ButDeliveryEmployees.ItemAppearance.Normal.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButDeliveryEmployees.ItemAppearance.Normal.Options.UseFont = true;
            ButDeliveryEmployees.ItemAppearance.Pressed.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButDeliveryEmployees.ItemAppearance.Pressed.Options.UseFont = true;
            ButDeliveryEmployees.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButDeliveryEmployees.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            ButDeliveryEmployees.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButDeliveryEmployees.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            ButDeliveryEmployees.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButDeliveryEmployees.ItemInMenuAppearance.Normal.Options.UseFont = true;
            ButDeliveryEmployees.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButDeliveryEmployees.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            ButDeliveryEmployees.Name = "ButDeliveryEmployees";
            ButDeliveryEmployees.ItemClick += ButDeliveryEmployees_ItemClick;
            // 
            // ButDeliveryCompany
            // 
            ButDeliveryCompany.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            ButDeliveryCompany.Caption = "کۆمپانیای گەیاندن";
            ButDeliveryCompany.Id = 6;
            ButDeliveryCompany.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("ButDeliveryCompany.ImageOptions.SvgImage");
            ButDeliveryCompany.ItemAppearance.Disabled.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButDeliveryCompany.ItemAppearance.Disabled.Options.UseFont = true;
            ButDeliveryCompany.ItemAppearance.Hovered.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButDeliveryCompany.ItemAppearance.Hovered.Options.UseFont = true;
            ButDeliveryCompany.ItemAppearance.Normal.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            ButDeliveryCompany.ItemAppearance.Normal.Options.UseFont = true;
            ButDeliveryCompany.ItemAppearance.Pressed.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButDeliveryCompany.ItemAppearance.Pressed.Options.UseFont = true;
            ButDeliveryCompany.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButDeliveryCompany.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            ButDeliveryCompany.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButDeliveryCompany.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            ButDeliveryCompany.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButDeliveryCompany.ItemInMenuAppearance.Normal.Options.UseFont = true;
            ButDeliveryCompany.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButDeliveryCompany.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            ButDeliveryCompany.Name = "ButDeliveryCompany";
            ButDeliveryCompany.ItemClick += ButDeliveryCompany_ItemClick;
            // 
            // ButEmployees
            // 
            ButEmployees.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            ButEmployees.Caption = "کارمەندەکان";
            ButEmployees.Id = 7;
            ButEmployees.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("ButEmployees.ImageOptions.SvgImage");
            ButEmployees.ItemAppearance.Disabled.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButEmployees.ItemAppearance.Disabled.Options.UseFont = true;
            ButEmployees.ItemAppearance.Hovered.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButEmployees.ItemAppearance.Hovered.Options.UseFont = true;
            ButEmployees.ItemAppearance.Normal.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            ButEmployees.ItemAppearance.Normal.Options.UseFont = true;
            ButEmployees.ItemAppearance.Pressed.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButEmployees.ItemAppearance.Pressed.Options.UseFont = true;
            ButEmployees.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButEmployees.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            ButEmployees.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButEmployees.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            ButEmployees.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButEmployees.ItemInMenuAppearance.Normal.Options.UseFont = true;
            ButEmployees.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButEmployees.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            ButEmployees.Name = "ButEmployees";
            ButEmployees.ItemClick += ButEmployees_ItemClick;
            // 
            // barButtonItem7
            // 
            barButtonItem7.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            barButtonItem7.Caption = "بەکار‌‌هێنەر";
            barButtonItem7.Id = 8;
            barButtonItem7.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem7.ImageOptions.SvgImage");
            barButtonItem7.ItemAppearance.Disabled.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            barButtonItem7.ItemAppearance.Disabled.Options.UseFont = true;
            barButtonItem7.ItemAppearance.Hovered.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            barButtonItem7.ItemAppearance.Hovered.Options.UseFont = true;
            barButtonItem7.ItemAppearance.Normal.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            barButtonItem7.ItemAppearance.Normal.Options.UseFont = true;
            barButtonItem7.ItemAppearance.Pressed.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            barButtonItem7.ItemAppearance.Pressed.Options.UseFont = true;
            barButtonItem7.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            barButtonItem7.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            barButtonItem7.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            barButtonItem7.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            barButtonItem7.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            barButtonItem7.ItemInMenuAppearance.Normal.Options.UseFont = true;
            barButtonItem7.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            barButtonItem7.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            barButtonItem7.Name = "barButtonItem7";
            // 
            // ButBox
            // 
            ButBox.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            ButBox.Caption = "خەزێنە";
            ButBox.Id = 9;
            ButBox.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("ButBox.ImageOptions.SvgImage");
            ButBox.ItemAppearance.Disabled.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButBox.ItemAppearance.Disabled.Options.UseFont = true;
            ButBox.ItemAppearance.Hovered.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButBox.ItemAppearance.Hovered.Options.UseFont = true;
            ButBox.ItemAppearance.Normal.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButBox.ItemAppearance.Normal.Options.UseFont = true;
            ButBox.ItemAppearance.Pressed.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButBox.ItemAppearance.Pressed.Options.UseFont = true;
            ButBox.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButBox.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            ButBox.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButBox.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            ButBox.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButBox.ItemInMenuAppearance.Normal.Options.UseFont = true;
            ButBox.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButBox.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            ButBox.LargeWidth = 70;
            ButBox.Name = "ButBox";
            ButBox.ItemClick += ButBox_ItemClick;
            // 
            // barButtonItem9
            // 
            barButtonItem9.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            barButtonItem9.Caption = "دەسەڵات";
            barButtonItem9.Id = 10;
            barButtonItem9.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem9.ImageOptions.SvgImage");
            barButtonItem9.ItemAppearance.Disabled.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            barButtonItem9.ItemAppearance.Disabled.Options.UseFont = true;
            barButtonItem9.ItemAppearance.Hovered.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            barButtonItem9.ItemAppearance.Hovered.Options.UseFont = true;
            barButtonItem9.ItemAppearance.Normal.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            barButtonItem9.ItemAppearance.Normal.Options.UseFont = true;
            barButtonItem9.ItemAppearance.Pressed.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            barButtonItem9.ItemAppearance.Pressed.Options.UseFont = true;
            barButtonItem9.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            barButtonItem9.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            barButtonItem9.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            barButtonItem9.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            barButtonItem9.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            barButtonItem9.ItemInMenuAppearance.Normal.Options.UseFont = true;
            barButtonItem9.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            barButtonItem9.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            barButtonItem9.Name = "barButtonItem9";
            // 
            // ButExpenses
            // 
            ButExpenses.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            ButExpenses.Caption = "خەرجیەکان";
            ButExpenses.Id = 12;
            ButExpenses.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("ButExpenses.ImageOptions.SvgImage");
            ButExpenses.ItemAppearance.Disabled.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButExpenses.ItemAppearance.Disabled.Options.UseFont = true;
            ButExpenses.ItemAppearance.Hovered.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButExpenses.ItemAppearance.Hovered.Options.UseFont = true;
            ButExpenses.ItemAppearance.Normal.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButExpenses.ItemAppearance.Normal.Options.UseFont = true;
            ButExpenses.ItemAppearance.Pressed.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButExpenses.ItemAppearance.Pressed.Options.UseFont = true;
            ButExpenses.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButExpenses.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            ButExpenses.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButExpenses.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            ButExpenses.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButExpenses.ItemInMenuAppearance.Normal.Options.UseFont = true;
            ButExpenses.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButExpenses.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            ButExpenses.Name = "ButExpenses";
            ButExpenses.ItemClick += ButExpenses_ItemClick;
            // 
            // ButOffers
            // 
            ButOffers.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            ButOffers.Caption = "ئۆفەرەکان";
            ButOffers.Id = 13;
            ButOffers.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("ButOffers.ImageOptions.SvgImage");
            ButOffers.ItemAppearance.Disabled.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButOffers.ItemAppearance.Disabled.Options.UseFont = true;
            ButOffers.ItemAppearance.Hovered.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButOffers.ItemAppearance.Hovered.Options.UseFont = true;
            ButOffers.ItemAppearance.Normal.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            ButOffers.ItemAppearance.Normal.Options.UseFont = true;
            ButOffers.ItemAppearance.Pressed.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButOffers.ItemAppearance.Pressed.Options.UseFont = true;
            ButOffers.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButOffers.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            ButOffers.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButOffers.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            ButOffers.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButOffers.ItemInMenuAppearance.Normal.Options.UseFont = true;
            ButOffers.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ButOffers.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            ButOffers.Name = "ButOffers";
            ButOffers.ItemClick += ButOffers_ItemClick;
            // 
            // barButtonItem12
            // 
            barButtonItem12.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            barButtonItem12.Caption = "خەزێنە و بەکارهێنەر";
            barButtonItem12.Id = 14;
            barButtonItem12.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem12.ImageOptions.SvgImage");
            barButtonItem12.ItemAppearance.Disabled.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            barButtonItem12.ItemAppearance.Disabled.Options.UseFont = true;
            barButtonItem12.ItemAppearance.Hovered.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            barButtonItem12.ItemAppearance.Hovered.Options.UseFont = true;
            barButtonItem12.ItemAppearance.Normal.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            barButtonItem12.ItemAppearance.Normal.Options.UseFont = true;
            barButtonItem12.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            barButtonItem12.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            barButtonItem12.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            barButtonItem12.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            barButtonItem12.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            barButtonItem12.ItemInMenuAppearance.Normal.Options.UseFont = true;
            barButtonItem12.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            barButtonItem12.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            barButtonItem12.Name = "barButtonItem12";
            // 
            // barButtonItem13
            // 
            barButtonItem13.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            barButtonItem13.Caption = "کریار";
            barButtonItem13.Id = 15;
            barButtonItem13.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem13.ImageOptions.SvgImage");
            barButtonItem13.ItemAppearance.Disabled.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            barButtonItem13.ItemAppearance.Disabled.Options.UseFont = true;
            barButtonItem13.ItemAppearance.Hovered.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            barButtonItem13.ItemAppearance.Hovered.Options.UseFont = true;
            barButtonItem13.ItemAppearance.Normal.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            barButtonItem13.ItemAppearance.Normal.Options.UseFont = true;
            barButtonItem13.ItemAppearance.Pressed.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            barButtonItem13.ItemAppearance.Pressed.Options.UseFont = true;
            barButtonItem13.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            barButtonItem13.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            barButtonItem13.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            barButtonItem13.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            barButtonItem13.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            barButtonItem13.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            barButtonItem13.LargeWidth = 50;
            barButtonItem13.Name = "barButtonItem13";
            // 
            // ribbonPage1
            // 
            ribbonPage1.Appearance.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            ribbonPage1.Appearance.Options.UseFont = true;
            ribbonPage1.AppearanceHovered.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ribbonPage1.AppearanceHovered.Options.UseFont = true;
            ribbonPage1.AppearanceSelected.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            ribbonPage1.AppearanceSelected.Options.UseFont = true;
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroupItems, ribbonPageGroupEmployees, ribbonPageGroupOffer, ribbonPageGroupDeliver, ribbonPageGroupBox, ribbonPageGroup1 });
            ribbonPage1.KeyTip = "ن";
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "ناساندن";
            // 
            // ribbonPageGroupItems
            // 
            ribbonPageGroupItems.ItemLinks.Add(ButItems, "با");
            ribbonPageGroupItems.ItemLinks.Add(ButTables, "م");
            ribbonPageGroupItems.KeyTip = "0";
            ribbonPageGroupItems.Name = "ribbonPageGroupItems";
            // 
            // ribbonPageGroupEmployees
            // 
            ribbonPageGroupEmployees.ItemLinks.Add(ButEmployees, "کا");
            ribbonPageGroupEmployees.ItemLinks.Add(barButtonItem7, "بە");
            ribbonPageGroupEmployees.KeyTip = "1";
            ribbonPageGroupEmployees.Name = "ribbonPageGroupEmployees";
            // 
            // ribbonPageGroupOffer
            // 
            ribbonPageGroupOffer.ItemLinks.Add(ButExpenses, "خە");
            ribbonPageGroupOffer.ItemLinks.Add(ButOffers, "ئ");
            ribbonPageGroupOffer.KeyTip = "2";
            ribbonPageGroupOffer.Name = "ribbonPageGroupOffer";
            // 
            // ribbonPageGroupDeliver
            // 
            ribbonPageGroupDeliver.ItemLinks.Add(ButDeliveryEmployees, "گ");
            ribbonPageGroupDeliver.ItemLinks.Add(ButDeliveryCompany, "کۆ");
            ribbonPageGroupDeliver.KeyTip = "3";
            ribbonPageGroupDeliver.Name = "ribbonPageGroupDeliver";
            // 
            // ribbonPageGroupBox
            // 
            ribbonPageGroupBox.ItemLinks.Add(ButBox, "خز");
            ribbonPageGroupBox.KeyTip = "4";
            ribbonPageGroupBox.Name = "ribbonPageGroupBox";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(barButtonItem13, true);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar1
            // 
            ribbonStatusBar1.Location = new System.Drawing.Point(1, 417);
            ribbonStatusBar1.Name = "ribbonStatusBar1";
            ribbonStatusBar1.Ribbon = ribbonControl1;
            ribbonStatusBar1.Size = new System.Drawing.Size(1113, 32);
            // 
            // xtraTabControl1
            // 
            xtraTabControl1.Appearance.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            xtraTabControl1.Appearance.Options.UseFont = true;
            xtraTabControl1.AppearancePage.Header.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            xtraTabControl1.AppearancePage.Header.Options.UseFont = true;
            xtraTabControl1.AppearancePage.HeaderActive.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            xtraTabControl1.AppearancePage.HeaderActive.Options.UseFont = true;
            xtraTabControl1.AppearancePage.HeaderDisabled.Font = new System.Drawing.Font("Rabar_021", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            xtraTabControl1.AppearancePage.HeaderDisabled.Options.UseFont = true;
            xtraTabControl1.AppearancePage.HeaderHotTracked.Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold);
            xtraTabControl1.AppearancePage.HeaderHotTracked.Options.UseFont = true;
            xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            xtraTabControl1.Location = new System.Drawing.Point(0, 215);
            xtraTabControl1.Name = "xtraTabControl1";
            xtraTabControl1.SelectedTabPage = xtraTabPage1;
            xtraTabControl1.Size = new System.Drawing.Size(1198, 393);
            xtraTabControl1.TabIndex = 3;
            xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage1 });
            xtraTabControl1.CloseButtonClick += xtraTabControl1_CloseButtonClick;
            // 
            // xtraTabPage1
            // 
            xtraTabPage1.Name = "xtraTabPage1";
            xtraTabPage1.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            xtraTabPage1.Size = new System.Drawing.Size(1196, 357);
            xtraTabPage1.TabPageWidth = 80;
            xtraTabPage1.Text = "سەرەکی";
            xtraTabPage1.Paint += xtraTabPage1_Paint;
            // 
            // FRMdashboard
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 26F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1198, 608);
            Controls.Add(xtraTabControl1);
            Controls.Add(ribbonControl1);
            Font = new System.Drawing.Font("Rabar_021", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            Name = "FRMdashboard";
            Ribbon = ribbonControl1;
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            StatusBar = ribbonStatusBar1;
            Text = "Dashboard";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += FRMdashboard_Load;
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabControl1).EndInit();
            xtraTabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarButtonItem ButItems;
        private DevExpress.XtraBars.BarButtonItem ButCategories;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraBars.BarButtonItem ButTables;
        private DevExpress.XtraBars.BarButtonItem ButDeliveryEmployees;
        private DevExpress.XtraBars.BarButtonItem ButDeliveryCompany;
        private DevExpress.XtraBars.BarButtonItem ButEmployees;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem ButBox;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem ButExpenses;
        private DevExpress.XtraBars.BarButtonItem ButOffers;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupItems;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupDeliver;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupEmployees;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupOffer;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupBox;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}

