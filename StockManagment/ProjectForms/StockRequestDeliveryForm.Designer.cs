namespace StockManagment.ProjectForms
{
    partial class StockRequestDeliveryForm
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label serialNumberLabel;
            System.Windows.Forms.Label requisitionIDLabel;
            System.Windows.Forms.Label requisitionCodeLabel;
            System.Windows.Forms.Label fromWarehouseIDLabel;
            System.Windows.Forms.Label departmentIDLabel;
            System.Windows.Forms.Label deliveryDateLabel;
            System.Windows.Forms.Label approvedByIDLabel;
            System.Windows.Forms.Label approvedDateLabel;
            System.Windows.Forms.Label unitIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockRequestDeliveryForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.SaveBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ExitBtn = new DevExpress.XtraBars.BarButtonItem();
            this.PrintBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.approvedByIDSpinEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.createdByIDSpinEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.departmentIDSpinEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fromWarehouseIDSpinEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.CodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.requisitionIDSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.requisitionCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.deliveryDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.isApprovedCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.approvedDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.ListGridControl = new DevExpress.XtraGrid.GridControl();
            this.ListGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFK_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFK_SerialNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequestedItemID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeliveryItemID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colUnitID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeliveryQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPreparedQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStkCostCenterID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCancelled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCancelledDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCancelledByID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsAcceptedReturned = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAcceptedReturnedByID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAcceptedReturnedQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAcceptedReturnedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ItemSearchLookUpEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AddItemBtn = new DevExpress.XtraEditors.SimpleButton();
            this.unitIDSpinEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.deliveryQuantityTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            idLabel = new System.Windows.Forms.Label();
            serialNumberLabel = new System.Windows.Forms.Label();
            requisitionIDLabel = new System.Windows.Forms.Label();
            requisitionCodeLabel = new System.Windows.Forms.Label();
            fromWarehouseIDLabel = new System.Windows.Forms.Label();
            departmentIDLabel = new System.Windows.Forms.Label();
            deliveryDateLabel = new System.Windows.Forms.Label();
            approvedByIDLabel = new System.Windows.Forms.Label();
            approvedDateLabel = new System.Windows.Forms.Label();
            unitIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.approvedByIDSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createdByIDSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentIDSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromWarehouseIDSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisitionIDSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisitionCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isApprovedCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.approvedDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.approvedDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemSearchLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitIDSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryQuantityTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 27);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 13);
            idLabel.TabIndex = 35;
            idLabel.Text = "Id:";
            // 
            // serialNumberLabel
            // 
            serialNumberLabel.AutoSize = true;
            serialNumberLabel.Location = new System.Drawing.Point(12, 53);
            serialNumberLabel.Name = "serialNumberLabel";
            serialNumberLabel.Size = new System.Drawing.Size(77, 13);
            serialNumberLabel.TabIndex = 37;
            serialNumberLabel.Text = "Serial Number:";
            // 
            // requisitionIDLabel
            // 
            requisitionIDLabel.AutoSize = true;
            requisitionIDLabel.Location = new System.Drawing.Point(12, 159);
            requisitionIDLabel.Name = "requisitionIDLabel";
            requisitionIDLabel.Size = new System.Drawing.Size(72, 13);
            requisitionIDLabel.TabIndex = 39;
            requisitionIDLabel.Text = "Requisition Id";
            // 
            // requisitionCodeLabel
            // 
            requisitionCodeLabel.AutoSize = true;
            requisitionCodeLabel.Location = new System.Drawing.Point(12, 185);
            requisitionCodeLabel.Name = "requisitionCodeLabel";
            requisitionCodeLabel.Size = new System.Drawing.Size(87, 13);
            requisitionCodeLabel.TabIndex = 41;
            requisitionCodeLabel.Text = "Requisition Code";
            // 
            // fromWarehouseIDLabel
            // 
            fromWarehouseIDLabel.AutoSize = true;
            fromWarehouseIDLabel.Location = new System.Drawing.Point(12, 79);
            fromWarehouseIDLabel.Name = "fromWarehouseIDLabel";
            fromWarehouseIDLabel.Size = new System.Drawing.Size(89, 13);
            fromWarehouseIDLabel.TabIndex = 43;
            fromWarehouseIDLabel.Text = "From Warehouse";
            // 
            // departmentIDLabel
            // 
            departmentIDLabel.AutoSize = true;
            departmentIDLabel.Location = new System.Drawing.Point(12, 105);
            departmentIDLabel.Name = "departmentIDLabel";
            departmentIDLabel.Size = new System.Drawing.Size(79, 13);
            departmentIDLabel.TabIndex = 45;
            departmentIDLabel.Text = "To Department";
            // 
            // deliveryDateLabel
            // 
            deliveryDateLabel.AutoSize = true;
            deliveryDateLabel.Location = new System.Drawing.Point(12, 133);
            deliveryDateLabel.Name = "deliveryDateLabel";
            deliveryDateLabel.Size = new System.Drawing.Size(76, 13);
            deliveryDateLabel.TabIndex = 47;
            deliveryDateLabel.Text = "Delivery Date:";
            // 
            // approvedByIDLabel
            // 
            approvedByIDLabel.AutoSize = true;
            approvedByIDLabel.Location = new System.Drawing.Point(468, 107);
            approvedByIDLabel.Name = "approvedByIDLabel";
            approvedByIDLabel.Size = new System.Drawing.Size(69, 13);
            approvedByIDLabel.TabIndex = 59;
            approvedByIDLabel.Text = "Approved By";
            // 
            // approvedDateLabel
            // 
            approvedDateLabel.AutoSize = true;
            approvedDateLabel.Location = new System.Drawing.Point(468, 133);
            approvedDateLabel.Name = "approvedDateLabel";
            approvedDateLabel.Size = new System.Drawing.Size(80, 13);
            approvedDateLabel.TabIndex = 61;
            approvedDateLabel.Text = "Approved Date";
            // 
            // unitIDLabel
            // 
            unitIDLabel.AutoSize = true;
            unitIDLabel.Location = new System.Drawing.Point(683, 10);
            unitIDLabel.Name = "unitIDLabel";
            unitIDLabel.Size = new System.Drawing.Size(26, 13);
            unitIDLabel.TabIndex = 1694;
            unitIDLabel.Text = "Unit";
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(20, 21, 20, 21);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.SaveBtn,
            this.ExitBtn,
            this.PrintBtn,
            this.barButtonItem3,
            this.barButtonItem4});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(2);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 220;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1004, 147);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Caption = "Save";
            this.SaveBtn.Id = 1;
            this.SaveBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SaveBtn.ImageOptions.SvgImage")));
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SaveBtn_ItemClick);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Caption = "Exit";
            this.ExitBtn.Id = 2;
            this.ExitBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ExitBtn.ImageOptions.SvgImage")));
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // PrintBtn
            // 
            this.PrintBtn.Caption = "Print Preview";
            this.PrintBtn.Id = 3;
            this.PrintBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("PrintBtn.ImageOptions.SvgImage")));
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PrintBtn_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Export As PDF";
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Send Mail";
            this.barButtonItem4.Id = 5;
            this.barButtonItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Stock Delivery";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.SaveBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.PrintBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Save | Print";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.ExitBtn);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Exit";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.approvedByIDSpinEdit);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.createdByIDSpinEdit);
            this.groupControl1.Controls.Add(this.departmentIDSpinEdit);
            this.groupControl1.Controls.Add(this.fromWarehouseIDSpinEdit);
            this.groupControl1.Controls.Add(idLabel);
            this.groupControl1.Controls.Add(this.idSpinEdit);
            this.groupControl1.Controls.Add(serialNumberLabel);
            this.groupControl1.Controls.Add(this.CodeTextEdit);
            this.groupControl1.Controls.Add(requisitionIDLabel);
            this.groupControl1.Controls.Add(this.requisitionIDSpinEdit);
            this.groupControl1.Controls.Add(requisitionCodeLabel);
            this.groupControl1.Controls.Add(this.requisitionCodeTextEdit);
            this.groupControl1.Controls.Add(fromWarehouseIDLabel);
            this.groupControl1.Controls.Add(departmentIDLabel);
            this.groupControl1.Controls.Add(deliveryDateLabel);
            this.groupControl1.Controls.Add(this.deliveryDateDateEdit);
            this.groupControl1.Controls.Add(this.isApprovedCheckEdit);
            this.groupControl1.Controls.Add(approvedByIDLabel);
            this.groupControl1.Controls.Add(approvedDateLabel);
            this.groupControl1.Controls.Add(this.approvedDateDateEdit);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 147);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1004, 206);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Stock Delivery";
            // 
            // approvedByIDSpinEdit
            // 
            this.approvedByIDSpinEdit.EditValue = "";
            this.approvedByIDSpinEdit.EnterMoveNextControl = true;
            this.approvedByIDSpinEdit.Location = new System.Drawing.Point(561, 104);
            this.approvedByIDSpinEdit.Name = "approvedByIDSpinEdit";
            this.approvedByIDSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.approvedByIDSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.approvedByIDSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.approvedByIDSpinEdit.Properties.NullText = "";
            this.approvedByIDSpinEdit.Properties.PopupView = this.gridView6;
            this.approvedByIDSpinEdit.Size = new System.Drawing.Size(284, 22);
            this.approvedByIDSpinEdit.TabIndex = 1718;
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn9,
            this.gridColumn10});
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Id";
            this.gridColumn9.FieldName = "Id";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 0;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Description";
            this.gridColumn10.FieldName = "Name";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(468, 30);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 13);
            this.labelControl2.TabIndex = 1717;
            this.labelControl2.Text = "Created by";
            // 
            // createdByIDSpinEdit
            // 
            this.createdByIDSpinEdit.EditValue = "";
            this.createdByIDSpinEdit.EnterMoveNextControl = true;
            this.createdByIDSpinEdit.Location = new System.Drawing.Point(561, 27);
            this.createdByIDSpinEdit.Name = "createdByIDSpinEdit";
            this.createdByIDSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.createdByIDSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.createdByIDSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.createdByIDSpinEdit.Properties.NullText = "";
            this.createdByIDSpinEdit.Properties.PopupView = this.gridView4;
            this.createdByIDSpinEdit.Size = new System.Drawing.Size(284, 22);
            this.createdByIDSpinEdit.TabIndex = 1716;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn8});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Id";
            this.gridColumn7.FieldName = "Id";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Description";
            this.gridColumn8.FieldName = "Name";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            // 
            // departmentIDSpinEdit
            // 
            this.departmentIDSpinEdit.EditValue = "";
            this.departmentIDSpinEdit.EnterMoveNextControl = true;
            this.departmentIDSpinEdit.Location = new System.Drawing.Point(134, 102);
            this.departmentIDSpinEdit.Name = "departmentIDSpinEdit";
            this.departmentIDSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.departmentIDSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.departmentIDSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.departmentIDSpinEdit.Properties.NullText = "";
            this.departmentIDSpinEdit.Properties.PopupView = this.gridView3;
            this.departmentIDSpinEdit.Size = new System.Drawing.Size(211, 22);
            this.departmentIDSpinEdit.TabIndex = 1688;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Id";
            this.gridColumn5.FieldName = "Id";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Description";
            this.gridColumn6.FieldName = "Name";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            // 
            // fromWarehouseIDSpinEdit
            // 
            this.fromWarehouseIDSpinEdit.EditValue = "";
            this.fromWarehouseIDSpinEdit.EnterMoveNextControl = true;
            this.fromWarehouseIDSpinEdit.Location = new System.Drawing.Point(134, 74);
            this.fromWarehouseIDSpinEdit.Name = "fromWarehouseIDSpinEdit";
            this.fromWarehouseIDSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.fromWarehouseIDSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.fromWarehouseIDSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fromWarehouseIDSpinEdit.Properties.NullText = "";
            this.fromWarehouseIDSpinEdit.Properties.PopupView = this.gridView2;
            this.fromWarehouseIDSpinEdit.Size = new System.Drawing.Size(211, 22);
            this.fromWarehouseIDSpinEdit.TabIndex = 1687;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Id";
            this.gridColumn3.FieldName = "Id";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Description";
            this.gridColumn4.FieldName = "Name";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // idSpinEdit
            // 
            this.idSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.idSpinEdit.Location = new System.Drawing.Point(134, 24);
            this.idSpinEdit.Name = "idSpinEdit";
            this.idSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idSpinEdit.Properties.ReadOnly = true;
            this.idSpinEdit.Size = new System.Drawing.Size(211, 20);
            this.idSpinEdit.TabIndex = 36;
            // 
            // CodeTextEdit
            // 
            this.CodeTextEdit.Location = new System.Drawing.Point(134, 50);
            this.CodeTextEdit.Name = "CodeTextEdit";
            this.CodeTextEdit.Properties.ReadOnly = true;
            this.CodeTextEdit.Size = new System.Drawing.Size(211, 20);
            this.CodeTextEdit.TabIndex = 38;
            // 
            // requisitionIDSpinEdit
            // 
            this.requisitionIDSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.requisitionIDSpinEdit.Location = new System.Drawing.Point(134, 156);
            this.requisitionIDSpinEdit.Name = "requisitionIDSpinEdit";
            this.requisitionIDSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.requisitionIDSpinEdit.Properties.ReadOnly = true;
            this.requisitionIDSpinEdit.Size = new System.Drawing.Size(178, 20);
            this.requisitionIDSpinEdit.TabIndex = 40;
            // 
            // requisitionCodeTextEdit
            // 
            this.requisitionCodeTextEdit.Location = new System.Drawing.Point(134, 182);
            this.requisitionCodeTextEdit.Name = "requisitionCodeTextEdit";
            this.requisitionCodeTextEdit.Properties.ReadOnly = true;
            this.requisitionCodeTextEdit.Size = new System.Drawing.Size(211, 20);
            this.requisitionCodeTextEdit.TabIndex = 42;
            // 
            // deliveryDateDateEdit
            // 
            this.deliveryDateDateEdit.EditValue = null;
            this.deliveryDateDateEdit.Location = new System.Drawing.Point(134, 130);
            this.deliveryDateDateEdit.Name = "deliveryDateDateEdit";
            this.deliveryDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deliveryDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deliveryDateDateEdit.Size = new System.Drawing.Size(211, 20);
            this.deliveryDateDateEdit.TabIndex = 48;
            // 
            // isApprovedCheckEdit
            // 
            this.isApprovedCheckEdit.Location = new System.Drawing.Point(468, 75);
            this.isApprovedCheckEdit.Name = "isApprovedCheckEdit";
            this.isApprovedCheckEdit.Properties.Caption = "Is Approved";
            this.isApprovedCheckEdit.Size = new System.Drawing.Size(100, 19);
            this.isApprovedCheckEdit.TabIndex = 58;
            // 
            // approvedDateDateEdit
            // 
            this.approvedDateDateEdit.EditValue = null;
            this.approvedDateDateEdit.Location = new System.Drawing.Point(561, 130);
            this.approvedDateDateEdit.Name = "approvedDateDateEdit";
            this.approvedDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.approvedDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.approvedDateDateEdit.Size = new System.Drawing.Size(232, 20);
            this.approvedDateDateEdit.TabIndex = 62;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.ListGridControl);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 387);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1004, 445);
            this.groupControl2.TabIndex = 8;
            this.groupControl2.Text = "DeliveryDetail";
            // 
            // ListGridControl
            // 
            this.ListGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListGridControl.Location = new System.Drawing.Point(2, 22);
            this.ListGridControl.MainView = this.ListGridView;
            this.ListGridControl.Name = "ListGridControl";
            this.ListGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemButtonEdit1});
            this.ListGridControl.Size = new System.Drawing.Size(1000, 421);
            this.ListGridControl.TabIndex = 36;
            this.ListGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ListGridView});
            // 
            // ListGridView
            // 
            this.ListGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colFK_ID,
            this.colFK_SerialNumber,
            this.colRequestedItemID,
            this.colDeliveryItemID,
            this.colUnitID,
            this.colDeliveryQuantity,
            this.colPreparedQuantity,
            this.colStkCostCenterID,
            this.colIsCancelled,
            this.colCancelledDate,
            this.colCancelledByID,
            this.colIsAcceptedReturned,
            this.colAcceptedReturnedByID,
            this.colAcceptedReturnedQuantity,
            this.colAcceptedReturnedDate,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn16});
            this.ListGridView.GridControl = this.ListGridControl;
            this.ListGridView.Name = "ListGridView";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colFK_ID
            // 
            this.colFK_ID.FieldName = "FK_ID";
            this.colFK_ID.Name = "colFK_ID";
            // 
            // colFK_SerialNumber
            // 
            this.colFK_SerialNumber.FieldName = "FK_SerialNumber";
            this.colFK_SerialNumber.Name = "colFK_SerialNumber";
            // 
            // colRequestedItemID
            // 
            this.colRequestedItemID.FieldName = "RequestedItemID";
            this.colRequestedItemID.Name = "colRequestedItemID";
            this.colRequestedItemID.Visible = true;
            this.colRequestedItemID.VisibleIndex = 4;
            this.colRequestedItemID.Width = 126;
            // 
            // colDeliveryItemID
            // 
            this.colDeliveryItemID.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colDeliveryItemID.FieldName = "ItemId";
            this.colDeliveryItemID.Name = "colDeliveryItemID";
            this.colDeliveryItemID.Width = 170;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // colUnitID
            // 
            this.colUnitID.FieldName = "UnitID";
            this.colUnitID.Name = "colUnitID";
            this.colUnitID.Visible = true;
            this.colUnitID.VisibleIndex = 5;
            this.colUnitID.Width = 71;
            // 
            // colDeliveryQuantity
            // 
            this.colDeliveryQuantity.FieldName = "DeliveryQuantity";
            this.colDeliveryQuantity.Name = "colDeliveryQuantity";
            this.colDeliveryQuantity.Visible = true;
            this.colDeliveryQuantity.VisibleIndex = 3;
            this.colDeliveryQuantity.Width = 104;
            // 
            // colPreparedQuantity
            // 
            this.colPreparedQuantity.FieldName = "PreparedQuantity";
            this.colPreparedQuantity.Name = "colPreparedQuantity";
            this.colPreparedQuantity.Width = 126;
            // 
            // colStkCostCenterID
            // 
            this.colStkCostCenterID.FieldName = "StkCostCenterID";
            this.colStkCostCenterID.Name = "colStkCostCenterID";
            this.colStkCostCenterID.Visible = true;
            this.colStkCostCenterID.VisibleIndex = 6;
            this.colStkCostCenterID.Width = 68;
            // 
            // colIsCancelled
            // 
            this.colIsCancelled.FieldName = "IsCancelled";
            this.colIsCancelled.Name = "colIsCancelled";
            this.colIsCancelled.Visible = true;
            this.colIsCancelled.VisibleIndex = 7;
            this.colIsCancelled.Width = 55;
            // 
            // colCancelledDate
            // 
            this.colCancelledDate.FieldName = "CancelledDate";
            this.colCancelledDate.Name = "colCancelledDate";
            this.colCancelledDate.Visible = true;
            this.colCancelledDate.VisibleIndex = 8;
            this.colCancelledDate.Width = 31;
            // 
            // colCancelledByID
            // 
            this.colCancelledByID.FieldName = "CancelledByID";
            this.colCancelledByID.Name = "colCancelledByID";
            this.colCancelledByID.Visible = true;
            this.colCancelledByID.VisibleIndex = 9;
            this.colCancelledByID.Width = 31;
            // 
            // colIsAcceptedReturned
            // 
            this.colIsAcceptedReturned.FieldName = "IsAcceptedReturned";
            this.colIsAcceptedReturned.Name = "colIsAcceptedReturned";
            this.colIsAcceptedReturned.Visible = true;
            this.colIsAcceptedReturned.VisibleIndex = 10;
            this.colIsAcceptedReturned.Width = 31;
            // 
            // colAcceptedReturnedByID
            // 
            this.colAcceptedReturnedByID.FieldName = "AcceptedReturnedByID";
            this.colAcceptedReturnedByID.Name = "colAcceptedReturnedByID";
            this.colAcceptedReturnedByID.Visible = true;
            this.colAcceptedReturnedByID.VisibleIndex = 11;
            this.colAcceptedReturnedByID.Width = 31;
            // 
            // colAcceptedReturnedQuantity
            // 
            this.colAcceptedReturnedQuantity.FieldName = "AcceptedReturnedQuantity";
            this.colAcceptedReturnedQuantity.Name = "colAcceptedReturnedQuantity";
            this.colAcceptedReturnedQuantity.Visible = true;
            this.colAcceptedReturnedQuantity.VisibleIndex = 12;
            this.colAcceptedReturnedQuantity.Width = 31;
            // 
            // colAcceptedReturnedDate
            // 
            this.colAcceptedReturnedDate.FieldName = "AcceptedReturnedDate";
            this.colAcceptedReturnedDate.Name = "colAcceptedReturnedDate";
            this.colAcceptedReturnedDate.Visible = true;
            this.colAcceptedReturnedDate.VisibleIndex = 13;
            this.colAcceptedReturnedDate.Width = 87;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Description";
            this.gridColumn11.FieldName = "ItemName";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 2;
            this.gridColumn11.Width = 82;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Code";
            this.gridColumn12.FieldName = "ItemCode";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 1;
            this.gridColumn12.Width = 82;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Delete";
            this.gridColumn16.ColumnEdit = this.repositoryItemButtonEdit1;
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 14;
            this.gridColumn16.Width = 78;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonClick_1);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(unitIDLabel);
            this.panelControl1.Controls.Add(this.ItemSearchLookUpEdit);
            this.panelControl1.Controls.Add(this.AddItemBtn);
            this.panelControl1.Controls.Add(this.unitIDSpinEdit);
            this.panelControl1.Controls.Add(this.deliveryQuantityTextEdit);
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 353);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1004, 34);
            this.panelControl1.TabIndex = 11;
            // 
            // ItemSearchLookUpEdit
            // 
            this.ItemSearchLookUpEdit.EditValue = "";
            this.ItemSearchLookUpEdit.EnterMoveNextControl = true;
            this.ItemSearchLookUpEdit.Location = new System.Drawing.Point(134, 5);
            this.ItemSearchLookUpEdit.Name = "ItemSearchLookUpEdit";
            this.ItemSearchLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ItemSearchLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.ItemSearchLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemSearchLookUpEdit.Properties.NullText = "";
            this.ItemSearchLookUpEdit.Properties.NullValuePrompt = "Item";
            this.ItemSearchLookUpEdit.Properties.PopupView = this.gridView1;
            this.ItemSearchLookUpEdit.Size = new System.Drawing.Size(293, 22);
            this.ItemSearchLookUpEdit.TabIndex = 1681;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id";
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Description";
            this.gridColumn2.FieldName = "NameEnglish";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Code";
            this.gridColumn13.FieldName = "Code";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 2;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "QrCode";
            this.gridColumn14.FieldName = "ItemQrCode";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 3;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Barcode";
            this.gridColumn15.FieldName = "BarcodeNumber";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 4;
            // 
            // AddItemBtn
            // 
            this.AddItemBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("AddItemBtn.ImageOptions.SvgImage")));
            this.AddItemBtn.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.AddItemBtn.Location = new System.Drawing.Point(882, 5);
            this.AddItemBtn.Name = "AddItemBtn";
            this.AddItemBtn.Size = new System.Drawing.Size(78, 22);
            this.AddItemBtn.TabIndex = 4;
            this.AddItemBtn.Text = "Add";
            this.AddItemBtn.ToolTip = "Main Category Form";
            this.AddItemBtn.Click += new System.EventHandler(this.AddItemBtn_Click);
            // 
            // unitIDSpinEdit
            // 
            this.unitIDSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.unitIDSpinEdit.EnterMoveNextControl = true;
            this.unitIDSpinEdit.Location = new System.Drawing.Point(727, 7);
            this.unitIDSpinEdit.Name = "unitIDSpinEdit";
            this.unitIDSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.unitIDSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.unitIDSpinEdit.Properties.NullText = "";
            this.unitIDSpinEdit.Properties.PopupView = this.searchLookUpEdit1View;
            this.unitIDSpinEdit.Size = new System.Drawing.Size(149, 20);
            this.unitIDSpinEdit.TabIndex = 1693;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // deliveryQuantityTextEdit
            // 
            this.deliveryQuantityTextEdit.EditValue = "1";
            this.deliveryQuantityTextEdit.EnterMoveNextControl = true;
            this.deliveryQuantityTextEdit.Location = new System.Drawing.Point(503, 7);
            this.deliveryQuantityTextEdit.Name = "deliveryQuantityTextEdit";
            this.deliveryQuantityTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.deliveryQuantityTextEdit.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.deliveryQuantityTextEdit.Properties.MaskSettings.Set("mask", "f");
            this.deliveryQuantityTextEdit.Size = new System.Drawing.Size(143, 20);
            this.deliveryQuantityTextEdit.TabIndex = 2;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(442, 10);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(42, 13);
            this.labelControl8.TabIndex = 1680;
            this.labelControl8.Text = "Quantity";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(15, 5);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(22, 13);
            this.labelControl7.TabIndex = 1677;
            this.labelControl7.Text = "Item";
            // 
            // StockRequestDeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 832);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbon);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StockRequestDeliveryForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Request Delivery Form";
            this.Shown += new System.EventHandler(this.PurchaseOrderForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.approvedByIDSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createdByIDSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentIDSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromWarehouseIDSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisitionIDSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisitionCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isApprovedCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.approvedDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.approvedDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemSearchLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitIDSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryQuantityTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraBars.BarButtonItem SaveBtn;
        private DevExpress.XtraBars.BarButtonItem ExitBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem PrintBtn;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton AddItemBtn;
        private DevExpress.XtraEditors.TextEdit deliveryQuantityTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SpinEdit idSpinEdit;
        private DevExpress.XtraEditors.TextEdit CodeTextEdit;
        private DevExpress.XtraEditors.SpinEdit requisitionIDSpinEdit;
        private DevExpress.XtraEditors.TextEdit requisitionCodeTextEdit;
        private DevExpress.XtraEditors.DateEdit deliveryDateDateEdit;
        private DevExpress.XtraEditors.CheckEdit isApprovedCheckEdit;
        private DevExpress.XtraEditors.DateEdit approvedDateDateEdit;
        private DevExpress.XtraEditors.SearchLookUpEdit departmentIDSpinEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.SearchLookUpEdit fromWarehouseIDSpinEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SearchLookUpEdit createdByIDSpinEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.GridControl ListGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ListGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colFK_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colFK_SerialNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colRequestedItemID;
        private DevExpress.XtraGrid.Columns.GridColumn colDeliveryItemID;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitID;
        private DevExpress.XtraGrid.Columns.GridColumn colDeliveryQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colPreparedQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colStkCostCenterID;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCancelled;
        private DevExpress.XtraGrid.Columns.GridColumn colCancelledDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCancelledByID;
        private DevExpress.XtraGrid.Columns.GridColumn colIsAcceptedReturned;
        private DevExpress.XtraGrid.Columns.GridColumn colAcceptedReturnedByID;
        private DevExpress.XtraGrid.Columns.GridColumn colAcceptedReturnedQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colAcceptedReturnedDate;
        private DevExpress.XtraEditors.SearchLookUpEdit ItemSearchLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraEditors.SearchLookUpEdit approvedByIDSpinEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraEditors.SearchLookUpEdit unitIDSpinEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
    }
}