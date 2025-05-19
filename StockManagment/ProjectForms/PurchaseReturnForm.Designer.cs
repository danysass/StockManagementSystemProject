namespace StockManagment.ProjectForms
{
    partial class PurchaseReturnForm
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
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label currencyIDLabel;
            System.Windows.Forms.Label supplierIDLabel;
            System.Windows.Forms.Label warehouseIDLabel;
            System.Windows.Forms.Label serialNumberLabel;
            System.Windows.Forms.Label referenceNumberLabel1;
            System.Windows.Forms.Label returnedDateLabel;
            System.Windows.Forms.Label returnedByIDLabel;
            System.Windows.Forms.Label reasonDiscriptionLabel;
            System.Windows.Forms.Label totalAmountLabel;
            System.Windows.Forms.Label hasVATLabel1;
            System.Windows.Forms.Label vATPercentageLabel;
            System.Windows.Forms.Label totalVATAmountLabel;
            System.Windows.Forms.Label netAmountLabel;
            System.Windows.Forms.Label localExRateLabel;
            System.Windows.Forms.Label localAmountLabel;
            System.Windows.Forms.Label foreignExRateLabel;
            System.Windows.Forms.Label foreignAmountLabel;
            System.Windows.Forms.Label isApprovedLabel;
            System.Windows.Forms.Label approvedByIDLabel;
            System.Windows.Forms.Label approvedDateLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label isPostedLabel;
            System.Windows.Forms.Label postingTimeLabel;
            System.Windows.Forms.Label postedByIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseReturnForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.SaveBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ExitBtn = new DevExpress.XtraBars.BarButtonItem();
            this.PrintBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ListGridControl = new DevExpress.XtraGrid.GridControl();
            this.ListGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ColActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.DetailNoteTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AddItemBtn = new DevExpress.XtraEditors.SimpleButton();
            this.QuantityTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.ItemSearchLookUpEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.idSpinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.CodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.referenceNumberTextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.returnedDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.reasonDiscriptionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.currencyIDSpinEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.supplierIDSpinEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.warehouseIDSpinEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.returnedByIDSpinEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.totalAmountSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.hasVATCheckEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.vATPercentageSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.totalVATAmountSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.netAmountSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.localExRateSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.localAmountSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.foreignExRateSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.foreignAmountSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.isApprovedCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.approvedDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.notesTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.isPostedCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.postingTimeDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.postedByIDSpinEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.approvedByIDSpinEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            idLabel1 = new System.Windows.Forms.Label();
            currencyIDLabel = new System.Windows.Forms.Label();
            supplierIDLabel = new System.Windows.Forms.Label();
            warehouseIDLabel = new System.Windows.Forms.Label();
            serialNumberLabel = new System.Windows.Forms.Label();
            referenceNumberLabel1 = new System.Windows.Forms.Label();
            returnedDateLabel = new System.Windows.Forms.Label();
            returnedByIDLabel = new System.Windows.Forms.Label();
            reasonDiscriptionLabel = new System.Windows.Forms.Label();
            totalAmountLabel = new System.Windows.Forms.Label();
            hasVATLabel1 = new System.Windows.Forms.Label();
            vATPercentageLabel = new System.Windows.Forms.Label();
            totalVATAmountLabel = new System.Windows.Forms.Label();
            netAmountLabel = new System.Windows.Forms.Label();
            localExRateLabel = new System.Windows.Forms.Label();
            localAmountLabel = new System.Windows.Forms.Label();
            foreignExRateLabel = new System.Windows.Forms.Label();
            foreignAmountLabel = new System.Windows.Forms.Label();
            isApprovedLabel = new System.Windows.Forms.Label();
            approvedByIDLabel = new System.Windows.Forms.Label();
            approvedDateLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            isPostedLabel = new System.Windows.Forms.Label();
            postingTimeLabel = new System.Windows.Forms.Label();
            postedByIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailNoteTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemSearchLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idSpinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenceNumberTextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnedDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnedDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reasonDiscriptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyIDSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierIDSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseIDSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnedByIDSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalAmountSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hasVATCheckEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATPercentageSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalVATAmountSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.netAmountSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localExRateSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localAmountSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foreignExRateSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foreignAmountSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isApprovedCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.approvedDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.approvedDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isPostedCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postingTimeDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postingTimeDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postedByIDSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.approvedByIDSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(13, 27);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(21, 13);
            idLabel1.TabIndex = 173;
            idLabel1.Text = "Id:";
            // 
            // currencyIDLabel
            // 
            currencyIDLabel.AutoSize = true;
            currencyIDLabel.Location = new System.Drawing.Point(13, 106);
            currencyIDLabel.Name = "currencyIDLabel";
            currencyIDLabel.Size = new System.Drawing.Size(51, 13);
            currencyIDLabel.TabIndex = 175;
            currencyIDLabel.Text = "Currency";
            // 
            // supplierIDLabel
            // 
            supplierIDLabel.AutoSize = true;
            supplierIDLabel.Location = new System.Drawing.Point(13, 132);
            supplierIDLabel.Name = "supplierIDLabel";
            supplierIDLabel.Size = new System.Drawing.Size(45, 13);
            supplierIDLabel.TabIndex = 177;
            supplierIDLabel.Text = "Supplier";
            // 
            // warehouseIDLabel
            // 
            warehouseIDLabel.AutoSize = true;
            warehouseIDLabel.Location = new System.Drawing.Point(518, 46);
            warehouseIDLabel.Name = "warehouseIDLabel";
            warehouseIDLabel.Size = new System.Drawing.Size(62, 13);
            warehouseIDLabel.TabIndex = 179;
            warehouseIDLabel.Text = "Warehouse";
            // 
            // serialNumberLabel
            // 
            serialNumberLabel.AutoSize = true;
            serialNumberLabel.Location = new System.Drawing.Point(13, 50);
            serialNumberLabel.Name = "serialNumberLabel";
            serialNumberLabel.Size = new System.Drawing.Size(32, 13);
            serialNumberLabel.TabIndex = 181;
            serialNumberLabel.Text = "Code";
            // 
            // referenceNumberLabel1
            // 
            referenceNumberLabel1.AutoSize = true;
            referenceNumberLabel1.Location = new System.Drawing.Point(518, 72);
            referenceNumberLabel1.Name = "referenceNumberLabel1";
            referenceNumberLabel1.Size = new System.Drawing.Size(97, 13);
            referenceNumberLabel1.TabIndex = 183;
            referenceNumberLabel1.Text = "Reference Number";
            // 
            // returnedDateLabel
            // 
            returnedDateLabel.AutoSize = true;
            returnedDateLabel.Location = new System.Drawing.Point(13, 76);
            returnedDateLabel.Name = "returnedDateLabel";
            returnedDateLabel.Size = new System.Drawing.Size(82, 13);
            returnedDateLabel.TabIndex = 185;
            returnedDateLabel.Text = "Returned Date:";
            // 
            // returnedByIDLabel
            // 
            returnedByIDLabel.AutoSize = true;
            returnedByIDLabel.Location = new System.Drawing.Point(518, 98);
            returnedByIDLabel.Name = "returnedByIDLabel";
            returnedByIDLabel.Size = new System.Drawing.Size(67, 13);
            returnedByIDLabel.TabIndex = 187;
            returnedByIDLabel.Text = "Returned By";
            // 
            // reasonDiscriptionLabel
            // 
            reasonDiscriptionLabel.AutoSize = true;
            reasonDiscriptionLabel.Location = new System.Drawing.Point(518, 124);
            reasonDiscriptionLabel.Name = "reasonDiscriptionLabel";
            reasonDiscriptionLabel.Size = new System.Drawing.Size(43, 13);
            reasonDiscriptionLabel.TabIndex = 189;
            reasonDiscriptionLabel.Text = "Reason";
            // 
            // totalAmountLabel
            // 
            totalAmountLabel.AutoSize = true;
            totalAmountLabel.Enabled = false;
            totalAmountLabel.Location = new System.Drawing.Point(11, 108);
            totalAmountLabel.Name = "totalAmountLabel";
            totalAmountLabel.Size = new System.Drawing.Size(75, 13);
            totalAmountLabel.TabIndex = 223;
            totalAmountLabel.Text = "Total Amount:";
            // 
            // hasVATLabel1
            // 
            hasVATLabel1.AutoSize = true;
            hasVATLabel1.Enabled = false;
            hasVATLabel1.Location = new System.Drawing.Point(11, 135);
            hasVATLabel1.Name = "hasVATLabel1";
            hasVATLabel1.Size = new System.Drawing.Size(51, 13);
            hasVATLabel1.TabIndex = 225;
            hasVATLabel1.Text = "Has VAT:";
            // 
            // vATPercentageLabel
            // 
            vATPercentageLabel.AutoSize = true;
            vATPercentageLabel.Enabled = false;
            vATPercentageLabel.Location = new System.Drawing.Point(382, 26);
            vATPercentageLabel.Name = "vATPercentageLabel";
            vATPercentageLabel.Size = new System.Drawing.Size(85, 13);
            vATPercentageLabel.TabIndex = 227;
            vATPercentageLabel.Text = "VATPercentage:";
            // 
            // totalVATAmountLabel
            // 
            totalVATAmountLabel.AutoSize = true;
            totalVATAmountLabel.Enabled = false;
            totalVATAmountLabel.Location = new System.Drawing.Point(382, 52);
            totalVATAmountLabel.Name = "totalVATAmountLabel";
            totalVATAmountLabel.Size = new System.Drawing.Size(94, 13);
            totalVATAmountLabel.TabIndex = 229;
            totalVATAmountLabel.Text = "Total VATAmount:";
            // 
            // netAmountLabel
            // 
            netAmountLabel.AutoSize = true;
            netAmountLabel.Enabled = false;
            netAmountLabel.Location = new System.Drawing.Point(382, 78);
            netAmountLabel.Name = "netAmountLabel";
            netAmountLabel.Size = new System.Drawing.Size(68, 13);
            netAmountLabel.TabIndex = 231;
            netAmountLabel.Text = "Net Amount:";
            // 
            // localExRateLabel
            // 
            localExRateLabel.AutoSize = true;
            localExRateLabel.Enabled = false;
            localExRateLabel.Location = new System.Drawing.Point(382, 104);
            localExRateLabel.Name = "localExRateLabel";
            localExRateLabel.Size = new System.Drawing.Size(76, 13);
            localExRateLabel.TabIndex = 233;
            localExRateLabel.Text = "Local Ex Rate:";
            // 
            // localAmountLabel
            // 
            localAmountLabel.AutoSize = true;
            localAmountLabel.Enabled = false;
            localAmountLabel.Location = new System.Drawing.Point(382, 130);
            localAmountLabel.Name = "localAmountLabel";
            localAmountLabel.Size = new System.Drawing.Size(75, 13);
            localAmountLabel.TabIndex = 235;
            localAmountLabel.Text = "Local Amount:";
            // 
            // foreignExRateLabel
            // 
            foreignExRateLabel.AutoSize = true;
            foreignExRateLabel.Enabled = false;
            foreignExRateLabel.Location = new System.Drawing.Point(382, 156);
            foreignExRateLabel.Name = "foreignExRateLabel";
            foreignExRateLabel.Size = new System.Drawing.Size(88, 13);
            foreignExRateLabel.TabIndex = 237;
            foreignExRateLabel.Text = "Foreign Ex Rate:";
            // 
            // foreignAmountLabel
            // 
            foreignAmountLabel.AutoSize = true;
            foreignAmountLabel.Enabled = false;
            foreignAmountLabel.Location = new System.Drawing.Point(382, 182);
            foreignAmountLabel.Name = "foreignAmountLabel";
            foreignAmountLabel.Size = new System.Drawing.Size(87, 13);
            foreignAmountLabel.TabIndex = 239;
            foreignAmountLabel.Text = "Foreign Amount:";
            // 
            // isApprovedLabel
            // 
            isApprovedLabel.AutoSize = true;
            isApprovedLabel.Enabled = false;
            isApprovedLabel.Location = new System.Drawing.Point(32, 160);
            isApprovedLabel.Name = "isApprovedLabel";
            isApprovedLabel.Size = new System.Drawing.Size(70, 13);
            isApprovedLabel.TabIndex = 241;
            isApprovedLabel.Text = "Is Approved:";
            // 
            // approvedByIDLabel
            // 
            approvedByIDLabel.AutoSize = true;
            approvedByIDLabel.Enabled = false;
            approvedByIDLabel.Location = new System.Drawing.Point(382, 208);
            approvedByIDLabel.Name = "approvedByIDLabel";
            approvedByIDLabel.Size = new System.Drawing.Size(87, 13);
            approvedByIDLabel.TabIndex = 243;
            approvedByIDLabel.Text = "Approved By ID:";
            // 
            // approvedDateLabel
            // 
            approvedDateLabel.AutoSize = true;
            approvedDateLabel.Enabled = false;
            approvedDateLabel.Location = new System.Drawing.Point(382, 234);
            approvedDateLabel.Name = "approvedDateLabel";
            approvedDateLabel.Size = new System.Drawing.Size(84, 13);
            approvedDateLabel.TabIndex = 245;
            approvedDateLabel.Text = "Approved Date:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Enabled = false;
            notesLabel.Location = new System.Drawing.Point(48, 186);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(39, 13);
            notesLabel.TabIndex = 247;
            notesLabel.Text = "Notes:";
            // 
            // isPostedLabel
            // 
            isPostedLabel.AutoSize = true;
            isPostedLabel.Enabled = false;
            isPostedLabel.Location = new System.Drawing.Point(11, 30);
            isPostedLabel.Name = "isPostedLabel";
            isPostedLabel.Size = new System.Drawing.Size(56, 13);
            isPostedLabel.TabIndex = 249;
            isPostedLabel.Text = "Is Posted:";
            // 
            // postingTimeLabel
            // 
            postingTimeLabel.AutoSize = true;
            postingTimeLabel.Enabled = false;
            postingTimeLabel.Location = new System.Drawing.Point(11, 56);
            postingTimeLabel.Name = "postingTimeLabel";
            postingTimeLabel.Size = new System.Drawing.Size(71, 13);
            postingTimeLabel.TabIndex = 251;
            postingTimeLabel.Text = "Posting Time:";
            // 
            // postedByIDLabel
            // 
            postedByIDLabel.AutoSize = true;
            postedByIDLabel.Enabled = false;
            postedByIDLabel.Location = new System.Drawing.Point(11, 82);
            postedByIDLabel.Name = "postedByIDLabel";
            postedByIDLabel.Size = new System.Drawing.Size(55, 13);
            postedByIDLabel.TabIndex = 253;
            postedByIDLabel.Text = "Posted By";
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
            this.ribbon.Size = new System.Drawing.Size(993, 147);
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
            this.ribbonPage1.Text = "Purchase Return";
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
            // ListGridControl
            // 
            this.ListGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListGridControl.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.ListGridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.ListGridControl.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.ListGridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.ListGridControl.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.ListGridControl.EmbeddedNavigator.TextStringFormat = " {0} of {1}";
            this.ListGridControl.Location = new System.Drawing.Point(2, 22);
            this.ListGridControl.MainView = this.ListGridView;
            this.ListGridControl.Name = "ListGridControl";
            this.ListGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1,
            this.repositoryItemPictureEdit1,
            this.repositoryItemLookUpEdit1,
            this.repositoryItemButtonEdit1});
            this.ListGridControl.Size = new System.Drawing.Size(989, 437);
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
            this.ColDescription,
            this.ColActive,
            this.gridColumn10,
            this.gridColumn9,
            this.gridColumn21,
            this.gridColumn22,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.ListGridView.GridControl = this.ListGridControl;
            this.ListGridView.Name = "ListGridView";
            this.ListGridView.OptionsEditForm.PopupEditFormWidth = 400;
            this.ListGridView.OptionsFind.AlwaysVisible = true;
            this.ListGridView.OptionsFind.FindNullPrompt = "Find.....";
            this.ListGridView.OptionsFind.ShowCloseButton = false;
            this.ListGridView.OptionsFind.ShowFindButton = false;
            this.ListGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.ListGridView.OptionsView.ShowGroupPanel = false;
            this.ListGridView.OptionsView.ShowIndicator = false;
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
            this.ColName.Caption = "ItemID";
            this.ColName.FieldName = "ItemID";
            this.ColName.Name = "ColName";
            this.ColName.OptionsColumn.AllowEdit = false;
            this.ColName.Visible = true;
            this.ColName.VisibleIndex = 0;
            this.ColName.Width = 99;
            // 
            // ColDescription
            // 
            this.ColDescription.Caption = "Details";
            this.ColDescription.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.ColDescription.FieldName = "ItemCode";
            this.ColDescription.Name = "ColDescription";
            this.ColDescription.OptionsColumn.AllowEdit = false;
            this.ColDescription.Width = 537;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // ColActive
            // 
            this.ColActive.Caption = "Returned Quantity";
            this.ColActive.FieldName = "ReturnedQuantity";
            this.ColActive.Name = "ColActive";
            this.ColActive.Visible = true;
            this.ColActive.VisibleIndex = 3;
            this.ColActive.Width = 347;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Approved Quantity";
            this.gridColumn10.FieldName = "ApprovedQuantity";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Width = 122;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Ordered Quantity";
            this.gridColumn9.FieldName = "OrderQuantity";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Width = 100;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "Approved";
            this.gridColumn21.FieldName = "Excluded";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.OptionsColumn.AllowEdit = false;
            this.gridColumn21.Width = 97;
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "Ordred";
            this.gridColumn22.FieldName = "IsOrdred";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.OptionsColumn.AllowEdit = false;
            this.gridColumn22.Width = 79;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Unit Price";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Delete";
            this.gridColumn4.ColumnEdit = this.repositoryItemButtonEdit1;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 122;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonClick);
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
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.ListGridControl);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 361);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(993, 461);
            this.groupControl2.TabIndex = 8;
            this.groupControl2.Text = "Return Detail";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.DetailNoteTextEdit);
            this.panelControl1.Controls.Add(this.AddItemBtn);
            this.panelControl1.Controls.Add(this.QuantityTextEdit);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.ItemSearchLookUpEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 308);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(993, 53);
            this.panelControl1.TabIndex = 11;
            // 
            // DetailNoteTextEdit
            // 
            this.DetailNoteTextEdit.EnterMoveNextControl = true;
            this.DetailNoteTextEdit.Location = new System.Drawing.Point(494, 23);
            this.DetailNoteTextEdit.Name = "DetailNoteTextEdit";
            this.DetailNoteTextEdit.Size = new System.Drawing.Size(364, 20);
            this.DetailNoteTextEdit.TabIndex = 3;
            // 
            // AddItemBtn
            // 
            this.AddItemBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("AddItemBtn.ImageOptions.SvgImage")));
            this.AddItemBtn.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.AddItemBtn.Location = new System.Drawing.Point(880, 22);
            this.AddItemBtn.Name = "AddItemBtn";
            this.AddItemBtn.Size = new System.Drawing.Size(78, 22);
            this.AddItemBtn.TabIndex = 4;
            this.AddItemBtn.Text = "Add";
            this.AddItemBtn.ToolTip = "Main Category Form";
            this.AddItemBtn.Click += new System.EventHandler(this.AddItemBtn_Click);
            // 
            // QuantityTextEdit
            // 
            this.QuantityTextEdit.EditValue = "1";
            this.QuantityTextEdit.EnterMoveNextControl = true;
            this.QuantityTextEdit.Location = new System.Drawing.Point(345, 24);
            this.QuantityTextEdit.Name = "QuantityTextEdit";
            this.QuantityTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.QuantityTextEdit.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.QuantityTextEdit.Properties.MaskSettings.Set("mask", "f");
            this.QuantityTextEdit.Size = new System.Drawing.Size(143, 20);
            this.QuantityTextEdit.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(495, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 13);
            this.labelControl1.TabIndex = 1680;
            this.labelControl1.Text = "Notes";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(345, 5);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(42, 13);
            this.labelControl8.TabIndex = 1680;
            this.labelControl8.Text = "Quantity";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(13, 5);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(22, 13);
            this.labelControl7.TabIndex = 1677;
            this.labelControl7.Text = "Item";
            // 
            // ItemSearchLookUpEdit
            // 
            this.ItemSearchLookUpEdit.EditValue = "";
            this.ItemSearchLookUpEdit.EnterMoveNextControl = true;
            this.ItemSearchLookUpEdit.Location = new System.Drawing.Point(10, 23);
            this.ItemSearchLookUpEdit.Name = "ItemSearchLookUpEdit";
            this.ItemSearchLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ItemSearchLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.ItemSearchLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemSearchLookUpEdit.Properties.NullText = "";
            this.ItemSearchLookUpEdit.Properties.NullValuePrompt = "Item";
            this.ItemSearchLookUpEdit.Properties.PopupView = this.gridView1;
            this.ItemSearchLookUpEdit.Size = new System.Drawing.Size(325, 22);
            this.ItemSearchLookUpEdit.TabIndex = 1;
            this.ItemSearchLookUpEdit.Validating += new System.ComponentModel.CancelEventHandler(this.ItemSearchLookUpEdit_Validating);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn8});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Code";
            this.gridColumn1.FieldName = "Code";
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
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Id";
            this.gridColumn8.FieldName = "Id";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(idLabel1);
            this.groupControl1.Controls.Add(this.idSpinEdit1);
            this.groupControl1.Controls.Add(currencyIDLabel);
            this.groupControl1.Controls.Add(supplierIDLabel);
            this.groupControl1.Controls.Add(warehouseIDLabel);
            this.groupControl1.Controls.Add(serialNumberLabel);
            this.groupControl1.Controls.Add(this.CodeTextEdit);
            this.groupControl1.Controls.Add(referenceNumberLabel1);
            this.groupControl1.Controls.Add(this.referenceNumberTextEdit1);
            this.groupControl1.Controls.Add(returnedDateLabel);
            this.groupControl1.Controls.Add(this.returnedDateDateEdit);
            this.groupControl1.Controls.Add(returnedByIDLabel);
            this.groupControl1.Controls.Add(reasonDiscriptionLabel);
            this.groupControl1.Controls.Add(this.reasonDiscriptionTextEdit);
            this.groupControl1.Controls.Add(this.currencyIDSpinEdit);
            this.groupControl1.Controls.Add(this.supplierIDSpinEdit);
            this.groupControl1.Controls.Add(this.warehouseIDSpinEdit);
            this.groupControl1.Controls.Add(this.returnedByIDSpinEdit);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 147);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(993, 161);
            this.groupControl1.TabIndex = 18;
            this.groupControl1.Text = "Purchase Return";
            // 
            // idSpinEdit1
            // 
            this.idSpinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.idSpinEdit1.Location = new System.Drawing.Point(120, 24);
            this.idSpinEdit1.Name = "idSpinEdit1";
            this.idSpinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idSpinEdit1.Properties.ReadOnly = true;
            this.idSpinEdit1.Size = new System.Drawing.Size(100, 20);
            this.idSpinEdit1.TabIndex = 174;
            // 
            // CodeTextEdit
            // 
            this.CodeTextEdit.Location = new System.Drawing.Point(120, 47);
            this.CodeTextEdit.Name = "CodeTextEdit";
            this.CodeTextEdit.Properties.ReadOnly = true;
            this.CodeTextEdit.Size = new System.Drawing.Size(204, 20);
            this.CodeTextEdit.TabIndex = 182;
            // 
            // referenceNumberTextEdit1
            // 
            this.referenceNumberTextEdit1.Location = new System.Drawing.Point(625, 69);
            this.referenceNumberTextEdit1.Name = "referenceNumberTextEdit1";
            this.referenceNumberTextEdit1.Size = new System.Drawing.Size(204, 20);
            this.referenceNumberTextEdit1.TabIndex = 184;
            // 
            // returnedDateDateEdit
            // 
            this.returnedDateDateEdit.EditValue = null;
            this.returnedDateDateEdit.Location = new System.Drawing.Point(120, 73);
            this.returnedDateDateEdit.Name = "returnedDateDateEdit";
            this.returnedDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.returnedDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.returnedDateDateEdit.Size = new System.Drawing.Size(204, 20);
            this.returnedDateDateEdit.TabIndex = 186;
            // 
            // reasonDiscriptionTextEdit
            // 
            this.reasonDiscriptionTextEdit.Location = new System.Drawing.Point(625, 121);
            this.reasonDiscriptionTextEdit.Name = "reasonDiscriptionTextEdit";
            this.reasonDiscriptionTextEdit.Size = new System.Drawing.Size(204, 20);
            this.reasonDiscriptionTextEdit.TabIndex = 190;
            // 
            // currencyIDSpinEdit
            // 
            this.currencyIDSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.currencyIDSpinEdit.Location = new System.Drawing.Point(120, 103);
            this.currencyIDSpinEdit.Name = "currencyIDSpinEdit";
            this.currencyIDSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.currencyIDSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.currencyIDSpinEdit.Properties.NullText = "";
            this.currencyIDSpinEdit.Properties.PopupView = this.searchLookUpEdit1View;
            this.currencyIDSpinEdit.Size = new System.Drawing.Size(204, 20);
            this.currencyIDSpinEdit.TabIndex = 176;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // supplierIDSpinEdit
            // 
            this.supplierIDSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.supplierIDSpinEdit.Location = new System.Drawing.Point(120, 129);
            this.supplierIDSpinEdit.Name = "supplierIDSpinEdit";
            this.supplierIDSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.supplierIDSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.supplierIDSpinEdit.Properties.NullText = "";
            this.supplierIDSpinEdit.Properties.PopupView = this.gridView2;
            this.supplierIDSpinEdit.Size = new System.Drawing.Size(204, 20);
            this.supplierIDSpinEdit.TabIndex = 178;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // warehouseIDSpinEdit
            // 
            this.warehouseIDSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.warehouseIDSpinEdit.Location = new System.Drawing.Point(625, 43);
            this.warehouseIDSpinEdit.Name = "warehouseIDSpinEdit";
            this.warehouseIDSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.warehouseIDSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.warehouseIDSpinEdit.Properties.NullText = "";
            this.warehouseIDSpinEdit.Properties.PopupView = this.gridView3;
            this.warehouseIDSpinEdit.Size = new System.Drawing.Size(204, 20);
            this.warehouseIDSpinEdit.TabIndex = 180;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // returnedByIDSpinEdit
            // 
            this.returnedByIDSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.returnedByIDSpinEdit.Location = new System.Drawing.Point(625, 95);
            this.returnedByIDSpinEdit.Name = "returnedByIDSpinEdit";
            this.returnedByIDSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.returnedByIDSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.returnedByIDSpinEdit.Properties.NullText = "";
            this.returnedByIDSpinEdit.Properties.PopupView = this.gridView4;
            this.returnedByIDSpinEdit.Size = new System.Drawing.Size(204, 20);
            this.returnedByIDSpinEdit.TabIndex = 188;
            // 
            // gridView4
            // 
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // totalAmountSpinEdit
            // 
            this.totalAmountSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.totalAmountSpinEdit.Enabled = false;
            this.totalAmountSpinEdit.Location = new System.Drawing.Point(118, 105);
            this.totalAmountSpinEdit.Name = "totalAmountSpinEdit";
            this.totalAmountSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.totalAmountSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.totalAmountSpinEdit.TabIndex = 224;
            // 
            // hasVATCheckEdit1
            // 
            this.hasVATCheckEdit1.Enabled = false;
            this.hasVATCheckEdit1.Location = new System.Drawing.Point(118, 132);
            this.hasVATCheckEdit1.Name = "hasVATCheckEdit1";
            this.hasVATCheckEdit1.Properties.Caption = "checkEdit1";
            this.hasVATCheckEdit1.Size = new System.Drawing.Size(100, 19);
            this.hasVATCheckEdit1.TabIndex = 226;
            // 
            // vATPercentageSpinEdit
            // 
            this.vATPercentageSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.vATPercentageSpinEdit.Enabled = false;
            this.vATPercentageSpinEdit.Location = new System.Drawing.Point(489, 23);
            this.vATPercentageSpinEdit.Name = "vATPercentageSpinEdit";
            this.vATPercentageSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.vATPercentageSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.vATPercentageSpinEdit.TabIndex = 228;
            // 
            // totalVATAmountSpinEdit
            // 
            this.totalVATAmountSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.totalVATAmountSpinEdit.Enabled = false;
            this.totalVATAmountSpinEdit.Location = new System.Drawing.Point(489, 49);
            this.totalVATAmountSpinEdit.Name = "totalVATAmountSpinEdit";
            this.totalVATAmountSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.totalVATAmountSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.totalVATAmountSpinEdit.TabIndex = 230;
            // 
            // netAmountSpinEdit
            // 
            this.netAmountSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.netAmountSpinEdit.Enabled = false;
            this.netAmountSpinEdit.Location = new System.Drawing.Point(489, 75);
            this.netAmountSpinEdit.Name = "netAmountSpinEdit";
            this.netAmountSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.netAmountSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.netAmountSpinEdit.TabIndex = 232;
            // 
            // localExRateSpinEdit
            // 
            this.localExRateSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.localExRateSpinEdit.Enabled = false;
            this.localExRateSpinEdit.Location = new System.Drawing.Point(489, 101);
            this.localExRateSpinEdit.Name = "localExRateSpinEdit";
            this.localExRateSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.localExRateSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.localExRateSpinEdit.TabIndex = 234;
            // 
            // localAmountSpinEdit
            // 
            this.localAmountSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.localAmountSpinEdit.Enabled = false;
            this.localAmountSpinEdit.Location = new System.Drawing.Point(489, 127);
            this.localAmountSpinEdit.Name = "localAmountSpinEdit";
            this.localAmountSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.localAmountSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.localAmountSpinEdit.TabIndex = 236;
            // 
            // foreignExRateSpinEdit
            // 
            this.foreignExRateSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.foreignExRateSpinEdit.Enabled = false;
            this.foreignExRateSpinEdit.Location = new System.Drawing.Point(489, 153);
            this.foreignExRateSpinEdit.Name = "foreignExRateSpinEdit";
            this.foreignExRateSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.foreignExRateSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.foreignExRateSpinEdit.TabIndex = 238;
            // 
            // foreignAmountSpinEdit
            // 
            this.foreignAmountSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.foreignAmountSpinEdit.Enabled = false;
            this.foreignAmountSpinEdit.Location = new System.Drawing.Point(489, 179);
            this.foreignAmountSpinEdit.Name = "foreignAmountSpinEdit";
            this.foreignAmountSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.foreignAmountSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.foreignAmountSpinEdit.TabIndex = 240;
            // 
            // isApprovedCheckEdit
            // 
            this.isApprovedCheckEdit.Enabled = false;
            this.isApprovedCheckEdit.Location = new System.Drawing.Point(155, 158);
            this.isApprovedCheckEdit.Name = "isApprovedCheckEdit";
            this.isApprovedCheckEdit.Properties.Caption = "Is Approved";
            this.isApprovedCheckEdit.Size = new System.Drawing.Size(100, 19);
            this.isApprovedCheckEdit.TabIndex = 242;
            // 
            // approvedDateDateEdit
            // 
            this.approvedDateDateEdit.EditValue = null;
            this.approvedDateDateEdit.Enabled = false;
            this.approvedDateDateEdit.Location = new System.Drawing.Point(489, 231);
            this.approvedDateDateEdit.Name = "approvedDateDateEdit";
            this.approvedDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.approvedDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.approvedDateDateEdit.Size = new System.Drawing.Size(100, 20);
            this.approvedDateDateEdit.TabIndex = 246;
            // 
            // notesTextEdit
            // 
            this.notesTextEdit.Enabled = false;
            this.notesTextEdit.Location = new System.Drawing.Point(155, 183);
            this.notesTextEdit.Name = "notesTextEdit";
            this.notesTextEdit.Size = new System.Drawing.Size(100, 20);
            this.notesTextEdit.TabIndex = 248;
            // 
            // isPostedCheckEdit
            // 
            this.isPostedCheckEdit.Enabled = false;
            this.isPostedCheckEdit.Location = new System.Drawing.Point(118, 27);
            this.isPostedCheckEdit.Name = "isPostedCheckEdit";
            this.isPostedCheckEdit.Properties.Caption = "checkEdit1";
            this.isPostedCheckEdit.Size = new System.Drawing.Size(100, 19);
            this.isPostedCheckEdit.TabIndex = 250;
            // 
            // postingTimeDateEdit
            // 
            this.postingTimeDateEdit.EditValue = null;
            this.postingTimeDateEdit.Enabled = false;
            this.postingTimeDateEdit.Location = new System.Drawing.Point(118, 53);
            this.postingTimeDateEdit.Name = "postingTimeDateEdit";
            this.postingTimeDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.postingTimeDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.postingTimeDateEdit.Size = new System.Drawing.Size(100, 20);
            this.postingTimeDateEdit.TabIndex = 252;
            // 
            // postedByIDSpinEdit
            // 
            this.postedByIDSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.postedByIDSpinEdit.Enabled = false;
            this.postedByIDSpinEdit.Location = new System.Drawing.Point(118, 79);
            this.postedByIDSpinEdit.Name = "postedByIDSpinEdit";
            this.postedByIDSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.postedByIDSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.postedByIDSpinEdit.Properties.NullText = "";
            this.postedByIDSpinEdit.Properties.PopupView = this.gridView5;
            this.postedByIDSpinEdit.Size = new System.Drawing.Size(202, 20);
            this.postedByIDSpinEdit.TabIndex = 254;
            // 
            // gridView5
            // 
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // approvedByIDSpinEdit
            // 
            this.approvedByIDSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.approvedByIDSpinEdit.Enabled = false;
            this.approvedByIDSpinEdit.Location = new System.Drawing.Point(489, 205);
            this.approvedByIDSpinEdit.Name = "approvedByIDSpinEdit";
            this.approvedByIDSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.approvedByIDSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.approvedByIDSpinEdit.Properties.NullText = "";
            this.approvedByIDSpinEdit.Properties.PopupView = this.gridView6;
            this.approvedByIDSpinEdit.Size = new System.Drawing.Size(163, 20);
            this.approvedByIDSpinEdit.TabIndex = 244;
            // 
            // gridView6
            // 
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(isPostedLabel);
            this.groupControl3.Controls.Add(totalAmountLabel);
            this.groupControl3.Controls.Add(this.approvedByIDSpinEdit);
            this.groupControl3.Controls.Add(this.totalAmountSpinEdit);
            this.groupControl3.Controls.Add(this.postedByIDSpinEdit);
            this.groupControl3.Controls.Add(hasVATLabel1);
            this.groupControl3.Controls.Add(postedByIDLabel);
            this.groupControl3.Controls.Add(this.hasVATCheckEdit1);
            this.groupControl3.Controls.Add(this.postingTimeDateEdit);
            this.groupControl3.Controls.Add(vATPercentageLabel);
            this.groupControl3.Controls.Add(postingTimeLabel);
            this.groupControl3.Controls.Add(this.vATPercentageSpinEdit);
            this.groupControl3.Controls.Add(this.isPostedCheckEdit);
            this.groupControl3.Controls.Add(totalVATAmountLabel);
            this.groupControl3.Controls.Add(this.notesTextEdit);
            this.groupControl3.Controls.Add(this.totalVATAmountSpinEdit);
            this.groupControl3.Controls.Add(notesLabel);
            this.groupControl3.Controls.Add(netAmountLabel);
            this.groupControl3.Controls.Add(this.approvedDateDateEdit);
            this.groupControl3.Controls.Add(this.netAmountSpinEdit);
            this.groupControl3.Controls.Add(approvedDateLabel);
            this.groupControl3.Controls.Add(localExRateLabel);
            this.groupControl3.Controls.Add(approvedByIDLabel);
            this.groupControl3.Controls.Add(this.localExRateSpinEdit);
            this.groupControl3.Controls.Add(this.isApprovedCheckEdit);
            this.groupControl3.Controls.Add(localAmountLabel);
            this.groupControl3.Controls.Add(isApprovedLabel);
            this.groupControl3.Controls.Add(this.localAmountSpinEdit);
            this.groupControl3.Controls.Add(this.foreignAmountSpinEdit);
            this.groupControl3.Controls.Add(foreignExRateLabel);
            this.groupControl3.Controls.Add(foreignAmountLabel);
            this.groupControl3.Controls.Add(this.foreignExRateSpinEdit);
            this.groupControl3.Location = new System.Drawing.Point(435, 457);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(200, 85);
            this.groupControl3.TabIndex = 255;
            this.groupControl3.Text = "groupControl3";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Code";
            this.gridColumn5.FieldName = "ItemCode";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 100;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Description";
            this.gridColumn6.FieldName = "ItemName";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 319;
            // 
            // PurchaseReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 822);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.ribbon);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PurchaseReturnForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Return Form";
            this.Shown += new System.EventHandler(this.PurchaseOrderForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailNoteTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemSearchLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idSpinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenceNumberTextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnedDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnedDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reasonDiscriptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyIDSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierIDSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseIDSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnedByIDSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalAmountSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hasVATCheckEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATPercentageSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalVATAmountSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.netAmountSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localExRateSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localAmountSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foreignExRateSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foreignAmountSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isApprovedCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.approvedDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.approvedDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isPostedCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postingTimeDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postingTimeDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postedByIDSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.approvedByIDSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl ListGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ListGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn ColName;
        private DevExpress.XtraGrid.Columns.GridColumn ColDescription;
        private DevExpress.XtraGrid.Columns.GridColumn ColActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraBars.BarButtonItem SaveBtn;
        private DevExpress.XtraBars.BarButtonItem ExitBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem PrintBtn;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton AddItemBtn;
        private DevExpress.XtraEditors.TextEdit QuantityTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SearchLookUpEdit ItemSearchLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SpinEdit idSpinEdit1;
        private DevExpress.XtraEditors.TextEdit CodeTextEdit;
        private DevExpress.XtraEditors.TextEdit referenceNumberTextEdit1;
        private DevExpress.XtraEditors.DateEdit returnedDateDateEdit;
        private DevExpress.XtraEditors.TextEdit reasonDiscriptionTextEdit;
        private DevExpress.XtraEditors.SearchLookUpEdit currencyIDSpinEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SearchLookUpEdit supplierIDSpinEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SearchLookUpEdit warehouseIDSpinEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.SearchLookUpEdit returnedByIDSpinEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.TextEdit DetailNoteTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit totalAmountSpinEdit;
        private DevExpress.XtraEditors.CheckEdit hasVATCheckEdit1;
        private DevExpress.XtraEditors.SpinEdit vATPercentageSpinEdit;
        private DevExpress.XtraEditors.SpinEdit totalVATAmountSpinEdit;
        private DevExpress.XtraEditors.SpinEdit netAmountSpinEdit;
        private DevExpress.XtraEditors.SpinEdit localExRateSpinEdit;
        private DevExpress.XtraEditors.SpinEdit localAmountSpinEdit;
        private DevExpress.XtraEditors.SpinEdit foreignExRateSpinEdit;
        private DevExpress.XtraEditors.SpinEdit foreignAmountSpinEdit;
        private DevExpress.XtraEditors.CheckEdit isApprovedCheckEdit;
        private DevExpress.XtraEditors.DateEdit approvedDateDateEdit;
        private DevExpress.XtraEditors.TextEdit notesTextEdit;
        private DevExpress.XtraEditors.CheckEdit isPostedCheckEdit;
        private DevExpress.XtraEditors.DateEdit postingTimeDateEdit;
        private DevExpress.XtraEditors.SearchLookUpEdit postedByIDSpinEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraEditors.SearchLookUpEdit approvedByIDSpinEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}