namespace StockManagment.ProjectForms
{
    partial class StockCountDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockCountDetailForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.SaveBtn = new DevExpress.XtraBars.BarButtonItem();
            this.CloseBtn = new DevExpress.XtraBars.BarButtonItem();
            this.PrintBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ListGridControl = new DevExpress.XtraGrid.GridControl();
            this.ListGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colPhysicalCountID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhysicalCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAvailableQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVariation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocalAmount1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colForeignAmount1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotes1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAvailableQuantityOnHand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedByID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedDate2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdatedByID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdatedDate2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.SaveBtn,
            this.CloseBtn,
            this.PrintBtn});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1130, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Caption = "Save";
            this.SaveBtn.Id = 1;
            this.SaveBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SaveBtn.ImageOptions.SvgImage")));
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SaveBtn_ItemClick);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Caption = "Close";
            this.CloseBtn.Id = 2;
            this.CloseBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("CloseBtn.ImageOptions.SvgImage")));
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CloseBtn_ItemClick);
            // 
            // PrintBtn
            // 
            this.PrintBtn.Caption = "Print";
            this.PrintBtn.Id = 3;
            this.PrintBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("PrintBtn.ImageOptions.SvgImage")));
            this.PrintBtn.Name = "PrintBtn";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Stock Count";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.SaveBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.PrintBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.CloseBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 1059);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1130, 32);
            // 
            // ListGridControl
            // 
            this.ListGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListGridControl.Location = new System.Drawing.Point(0, 144);
            this.ListGridControl.MainView = this.ListGridView;
            this.ListGridControl.Name = "ListGridControl";
            this.ListGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.ListGridControl.Size = new System.Drawing.Size(1130, 915);
            this.ListGridControl.TabIndex = 146;
            this.ListGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ListGridView});
            // 
            // ListGridView
            // 
            this.ListGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId2,
            this.colUnitID1,
            this.colItemID2,
            this.colPhysicalCountID,
            this.colPhysicalCount,
            this.colAvailableQty,
            this.colVariation,
            this.colPrice,
            this.colTotalAmount,
            this.colCurrencyID2,
            this.colLocalAmount1,
            this.colForeignAmount1,
            this.colNotes1,
            this.colAvailableQuantityOnHand,
            this.colCreatedByID2,
            this.colCreatedDate2,
            this.colUpdatedByID2,
            this.colUpdatedDate2});
            this.ListGridView.GridControl = this.ListGridControl;
            this.ListGridView.Name = "ListGridView";
            // 
            // colId2
            // 
            this.colId2.FieldName = "Id";
            this.colId2.Name = "colId2";
            this.colId2.OptionsColumn.AllowEdit = false;
            this.colId2.Width = 84;
            // 
            // colUnitID1
            // 
            this.colUnitID1.FieldName = "UnitID";
            this.colUnitID1.Name = "colUnitID1";
            this.colUnitID1.OptionsColumn.AllowEdit = false;
            this.colUnitID1.Width = 167;
            // 
            // colItemID2
            // 
            this.colItemID2.Caption = "Item";
            this.colItemID2.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colItemID2.FieldName = "ItemID";
            this.colItemID2.Name = "colItemID2";
            this.colItemID2.OptionsColumn.AllowEdit = false;
            this.colItemID2.Visible = true;
            this.colItemID2.VisibleIndex = 0;
            this.colItemID2.Width = 275;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // colPhysicalCountID
            // 
            this.colPhysicalCountID.FieldName = "PhysicalCountID";
            this.colPhysicalCountID.Name = "colPhysicalCountID";
            this.colPhysicalCountID.OptionsColumn.AllowEdit = false;
            this.colPhysicalCountID.Width = 160;
            // 
            // colPhysicalCount
            // 
            this.colPhysicalCount.FieldName = "PhysicalCount";
            this.colPhysicalCount.Name = "colPhysicalCount";
            this.colPhysicalCount.Visible = true;
            this.colPhysicalCount.VisibleIndex = 2;
            this.colPhysicalCount.Width = 195;
            // 
            // colAvailableQty
            // 
            this.colAvailableQty.Caption = "Quantity On Hand";
            this.colAvailableQty.FieldName = "AvailableQuantityOnHand";
            this.colAvailableQty.Name = "colAvailableQty";
            this.colAvailableQty.OptionsColumn.AllowEdit = false;
            this.colAvailableQty.Visible = true;
            this.colAvailableQty.VisibleIndex = 1;
            this.colAvailableQty.Width = 197;
            // 
            // colVariation
            // 
            this.colVariation.Caption = "Difference";
            this.colVariation.FieldName = "Variation";
            this.colVariation.Name = "colVariation";
            this.colVariation.OptionsColumn.AllowEdit = false;
            this.colVariation.Visible = true;
            this.colVariation.VisibleIndex = 4;
            this.colVariation.Width = 135;
            // 
            // colPrice
            // 
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsColumn.AllowEdit = false;
            this.colPrice.Width = 67;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.FieldName = "TotalAmount";
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.OptionsColumn.AllowEdit = false;
            this.colTotalAmount.Width = 67;
            // 
            // colCurrencyID2
            // 
            this.colCurrencyID2.FieldName = "CurrencyID";
            this.colCurrencyID2.Name = "colCurrencyID2";
            this.colCurrencyID2.OptionsColumn.AllowEdit = false;
            this.colCurrencyID2.Width = 67;
            // 
            // colLocalAmount1
            // 
            this.colLocalAmount1.FieldName = "LocalAmount";
            this.colLocalAmount1.Name = "colLocalAmount1";
            this.colLocalAmount1.OptionsColumn.AllowEdit = false;
            this.colLocalAmount1.Width = 67;
            // 
            // colForeignAmount1
            // 
            this.colForeignAmount1.FieldName = "ForeignAmount";
            this.colForeignAmount1.Name = "colForeignAmount1";
            this.colForeignAmount1.OptionsColumn.AllowEdit = false;
            this.colForeignAmount1.Width = 67;
            // 
            // colNotes1
            // 
            this.colNotes1.FieldName = "Notes";
            this.colNotes1.Name = "colNotes1";
            this.colNotes1.Visible = true;
            this.colNotes1.VisibleIndex = 3;
            this.colNotes1.Width = 310;
            // 
            // colAvailableQuantityOnHand
            // 
            this.colAvailableQuantityOnHand.FieldName = "AvailableQuantityOnHand";
            this.colAvailableQuantityOnHand.Name = "colAvailableQuantityOnHand";
            this.colAvailableQuantityOnHand.OptionsColumn.AllowEdit = false;
            this.colAvailableQuantityOnHand.Width = 306;
            // 
            // colCreatedByID2
            // 
            this.colCreatedByID2.FieldName = "CreatedByID";
            this.colCreatedByID2.Name = "colCreatedByID2";
            this.colCreatedByID2.OptionsColumn.AllowEdit = false;
            this.colCreatedByID2.Width = 72;
            // 
            // colCreatedDate2
            // 
            this.colCreatedDate2.FieldName = "CreatedDate";
            this.colCreatedDate2.Name = "colCreatedDate2";
            this.colCreatedDate2.OptionsColumn.AllowEdit = false;
            this.colCreatedDate2.Width = 72;
            // 
            // colUpdatedByID2
            // 
            this.colUpdatedByID2.FieldName = "UpdatedByID";
            this.colUpdatedByID2.Name = "colUpdatedByID2";
            this.colUpdatedByID2.OptionsColumn.AllowEdit = false;
            this.colUpdatedByID2.Width = 72;
            // 
            // colUpdatedDate2
            // 
            this.colUpdatedDate2.FieldName = "UpdatedDate";
            this.colUpdatedDate2.Name = "colUpdatedDate2";
            this.colUpdatedDate2.OptionsColumn.AllowEdit = false;
            this.colUpdatedDate2.Width = 169;
            // 
            // StockCountDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 1091);
            this.Controls.Add(this.ListGridControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "StockCountDetailForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "StockCountDetailForm";
            this.Shown += new System.EventHandler(this.StockCountDetailForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem SaveBtn;
        private DevExpress.XtraBars.BarButtonItem CloseBtn;
        private DevExpress.XtraBars.BarButtonItem PrintBtn;
        private DevExpress.XtraGrid.GridControl ListGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ListGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colId2;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitID1;
        private DevExpress.XtraGrid.Columns.GridColumn colItemID2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colPhysicalCountID;
        private DevExpress.XtraGrid.Columns.GridColumn colPhysicalCount;
        private DevExpress.XtraGrid.Columns.GridColumn colAvailableQty;
        private DevExpress.XtraGrid.Columns.GridColumn colVariation;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyID2;
        private DevExpress.XtraGrid.Columns.GridColumn colLocalAmount1;
        private DevExpress.XtraGrid.Columns.GridColumn colForeignAmount1;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes1;
        private DevExpress.XtraGrid.Columns.GridColumn colAvailableQuantityOnHand;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedByID2;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate2;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdatedByID2;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdatedDate2;
    }
}