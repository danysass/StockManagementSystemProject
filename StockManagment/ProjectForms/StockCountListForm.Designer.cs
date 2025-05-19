namespace StockManagment.ProjectForms
{
    partial class StockCountListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockCountListForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.TodayOrderBtn = new DevExpress.XtraBars.BarButtonItem();
            this.Last30DaysBtn = new DevExpress.XtraBars.BarButtonItem();
            this.Last3MonthBtn = new DevExpress.XtraBars.BarButtonItem();
            this.Last6MonthBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ThisYearBtn = new DevExpress.XtraBars.BarButtonItem();
            this.AllDaysBtn = new DevExpress.XtraBars.BarButtonItem();
            this.GroupBySupplierBtn = new DevExpress.XtraBars.BarButtonItem();
            this.GroupByDateBtn = new DevExpress.XtraBars.BarButtonItem();
            this.GroupByCompletedBtn = new DevExpress.XtraBars.BarButtonItem();
            this.PrintBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ExitBtn = new DevExpress.XtraBars.BarButtonItem();
            this.UngroupBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.ListGridControl = new DevExpress.XtraGrid.GridControl();
            this.ListGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.OrderDateColum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.TodayOrderBtn,
            this.Last30DaysBtn,
            this.Last3MonthBtn,
            this.Last6MonthBtn,
            this.ThisYearBtn,
            this.AllDaysBtn,
            this.GroupBySupplierBtn,
            this.GroupByDateBtn,
            this.GroupByCompletedBtn,
            this.PrintBtn,
            this.ExitBtn,
            this.UngroupBtn,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 17;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(975, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // TodayOrderBtn
            // 
            this.TodayOrderBtn.Caption = "Today";
            this.TodayOrderBtn.Id = 1;
            this.TodayOrderBtn.ImageOptions.SvgImage = global::StockManagment.Properties.Resources.Today;
            this.TodayOrderBtn.Name = "TodayOrderBtn";
            this.TodayOrderBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.TodayOrderBtn_ItemClick);
            // 
            // Last30DaysBtn
            // 
            this.Last30DaysBtn.Caption = "Last 30 days";
            this.Last30DaysBtn.Id = 2;
            this.Last30DaysBtn.ImageOptions.SvgImage = global::StockManagment.Properties.Resources.Tomorrow;
            this.Last30DaysBtn.Name = "Last30DaysBtn";
            this.Last30DaysBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.Last30DaysBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Last30DaysBtn_ItemClick);
            // 
            // Last3MonthBtn
            // 
            this.Last3MonthBtn.Caption = "Last 3 Month";
            this.Last3MonthBtn.Id = 3;
            this.Last3MonthBtn.ImageOptions.SvgImage = global::StockManagment.Properties.Resources.NextWeek;
            this.Last3MonthBtn.Name = "Last3MonthBtn";
            this.Last3MonthBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.Last3MonthBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Last3MonthBtn_ItemClick);
            // 
            // Last6MonthBtn
            // 
            this.Last6MonthBtn.Caption = "Last 6 Month";
            this.Last6MonthBtn.Id = 4;
            this.Last6MonthBtn.ImageOptions.SvgImage = global::StockManagment.Properties.Resources.ThisWeek;
            this.Last6MonthBtn.Name = "Last6MonthBtn";
            this.Last6MonthBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.Last6MonthBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Last6MonthBtn_ItemClick);
            // 
            // ThisYearBtn
            // 
            this.ThisYearBtn.Caption = "This Year";
            this.ThisYearBtn.Id = 5;
            this.ThisYearBtn.ImageOptions.SvgImage = global::StockManagment.Properties.Resources.CustomDate;
            this.ThisYearBtn.Name = "ThisYearBtn";
            this.ThisYearBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ThisYearBtn_ItemClick);
            // 
            // AllDaysBtn
            // 
            this.AllDaysBtn.Caption = "All Days";
            this.AllDaysBtn.Id = 6;
            this.AllDaysBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("AllDaysBtn.ImageOptions.SvgImage")));
            this.AllDaysBtn.Name = "AllDaysBtn";
            this.AllDaysBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AllDaysBtn_ItemClick);
            // 
            // GroupBySupplierBtn
            // 
            this.GroupBySupplierBtn.Caption = "Group by Department";
            this.GroupBySupplierBtn.Id = 7;
            this.GroupBySupplierBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("GroupBySupplierBtn.ImageOptions.SvgImage")));
            this.GroupBySupplierBtn.Name = "GroupBySupplierBtn";
            this.GroupBySupplierBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.GroupBySupplierBtn_ItemClick);
            // 
            // GroupByDateBtn
            // 
            this.GroupByDateBtn.Caption = "Group By Date";
            this.GroupByDateBtn.Id = 8;
            this.GroupByDateBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("GroupByDateBtn.ImageOptions.SvgImage")));
            this.GroupByDateBtn.Name = "GroupByDateBtn";
            this.GroupByDateBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.GroupByDateBtn_ItemClick);
            // 
            // GroupByCompletedBtn
            // 
            this.GroupByCompletedBtn.Caption = "Group by Completation";
            this.GroupByCompletedBtn.Id = 9;
            this.GroupByCompletedBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("GroupByCompletedBtn.ImageOptions.SvgImage")));
            this.GroupByCompletedBtn.Name = "GroupByCompletedBtn";
            this.GroupByCompletedBtn.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // PrintBtn
            // 
            this.PrintBtn.Caption = "Print";
            this.PrintBtn.Id = 10;
            this.PrintBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("PrintBtn.ImageOptions.SvgImage")));
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PrintBtn_ItemClick);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Caption = "Exit";
            this.ExitBtn.Id = 11;
            this.ExitBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ExitBtn.ImageOptions.SvgImage")));
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ExitBtn_ItemClick);
            // 
            // UngroupBtn
            // 
            this.UngroupBtn.Caption = "Ungroup";
            this.UngroupBtn.Id = 12;
            this.UngroupBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("UngroupBtn.ImageOptions.SvgImage")));
            this.UngroupBtn.Name = "UngroupBtn";
            this.UngroupBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.UngroupBtn_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Approved";
            this.barButtonItem1.Id = 13;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Closed";
            this.barButtonItem2.Id = 14;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Rejected";
            this.barButtonItem3.Id = 15;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Confirmed";
            this.barButtonItem4.Id = 16;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Count  List";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.TodayOrderBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.Last30DaysBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.Last3MonthBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.Last6MonthBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.ThisYearBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.AllDaysBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Filter";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.GroupBySupplierBtn);
            this.ribbonPageGroup2.ItemLinks.Add(this.GroupByDateBtn);
            this.ribbonPageGroup2.ItemLinks.Add(this.GroupByCompletedBtn);
            this.ribbonPageGroup2.ItemLinks.Add(this.UngroupBtn);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Grouping";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.PrintBtn);
            this.ribbonPageGroup3.ItemLinks.Add(this.ExitBtn);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Exit";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 775);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(975, 32);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.ListGridControl);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 144);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(975, 631);
            this.groupControl2.TabIndex = 9;
            this.groupControl2.Text = "Count  List";
            // 
            // ListGridControl
            // 
            this.ListGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListGridControl.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.ListGridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.ListGridControl.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.ListGridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.ListGridControl.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.ListGridControl.EmbeddedNavigator.TextStringFormat = " {0} of {1}";
            this.ListGridControl.Location = new System.Drawing.Point(2, 21);
            this.ListGridControl.MainView = this.ListGridView;
            this.ListGridControl.Name = "ListGridControl";
            this.ListGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1,
            this.repositoryItemPictureEdit1,
            this.repositoryItemLookUpEdit1});
            this.ListGridControl.Size = new System.Drawing.Size(971, 608);
            this.ListGridControl.TabIndex = 5;
            this.ListGridControl.UseEmbeddedNavigator = true;
            this.ListGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ListGridView});
            // 
            // ListGridView
            // 
            this.ListGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.ColName,
            this.ColSupplier,
            this.OrderDateColum,
            this.gridColumn3,
            this.gridColumn5});
            this.ListGridView.GridControl = this.ListGridControl;
            this.ListGridView.Name = "ListGridView";
            this.ListGridView.OptionsBehavior.Editable = false;
            this.ListGridView.OptionsEditForm.PopupEditFormWidth = 400;
            this.ListGridView.OptionsFind.AlwaysVisible = true;
            this.ListGridView.OptionsFind.FindNullPrompt = "Find.....";
            this.ListGridView.OptionsFind.ShowCloseButton = false;
            this.ListGridView.OptionsFind.ShowFindButton = false;
            this.ListGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.ListGridView.OptionsView.ShowGroupPanel = false;
            this.ListGridView.OptionsView.ShowIndicator = false;
            this.ListGridView.DoubleClick += new System.EventHandler(this.ListGridView_DoubleClick);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.Width = 45;
            // 
            // ColName
            // 
            this.ColName.Caption = "Code";
            this.ColName.FieldName = "SerialNumber";
            this.ColName.Name = "ColName";
            this.ColName.OptionsColumn.AllowEdit = false;
            this.ColName.Visible = true;
            this.ColName.VisibleIndex = 0;
            this.ColName.Width = 130;
            // 
            // ColSupplier
            // 
            this.ColSupplier.Caption = "Warehouse";
            this.ColSupplier.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.ColSupplier.FieldName = "WareHouseID";
            this.ColSupplier.Name = "ColSupplier";
            this.ColSupplier.OptionsColumn.AllowEdit = false;
            this.ColSupplier.Visible = true;
            this.ColSupplier.VisibleIndex = 1;
            this.ColSupplier.Width = 564;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // OrderDateColum
            // 
            this.OrderDateColum.Caption = "Date";
            this.OrderDateColum.FieldName = "CountDate";
            this.OrderDateColum.Name = "OrderDateColum";
            this.OrderDateColum.OptionsColumn.AllowEdit = false;
            this.OrderDateColum.Visible = true;
            this.OrderDateColum.VisibleIndex = 2;
            this.OrderDateColum.Width = 195;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Confirmed";
            this.gridColumn3.FieldName = "IsConfirmed";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Closed";
            this.gridColumn5.FieldName = "IsClosed";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            // 
            // StockCountListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 807);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "StockCountListForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Count  List";
            this.Shown += new System.EventHandler(this.PurchaseOrderListForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem TodayOrderBtn;
        private DevExpress.XtraBars.BarButtonItem Last30DaysBtn;
        private DevExpress.XtraBars.BarButtonItem Last3MonthBtn;
        private DevExpress.XtraBars.BarButtonItem Last6MonthBtn;
        private DevExpress.XtraBars.BarButtonItem ThisYearBtn;
        private DevExpress.XtraBars.BarButtonItem AllDaysBtn;
        private DevExpress.XtraBars.BarButtonItem GroupBySupplierBtn;
        private DevExpress.XtraBars.BarButtonItem GroupByDateBtn;
        private DevExpress.XtraBars.BarButtonItem GroupByCompletedBtn;
        private DevExpress.XtraBars.BarButtonItem PrintBtn;
        private DevExpress.XtraBars.BarButtonItem ExitBtn;
        private DevExpress.XtraBars.BarButtonItem UngroupBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl ListGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ListGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn ColName;
        private DevExpress.XtraGrid.Columns.GridColumn ColSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn OrderDateColum;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}