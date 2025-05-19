
namespace StockManagment
{
    partial class SettingsListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsListForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.NewBtn = new DevExpress.XtraBars.BarButtonItem();
            this.EditBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ExitBtn = new DevExpress.XtraBars.BarButtonItem();
            this.PrintListBtn = new DevExpress.XtraBars.BarButtonItem();
            this.SettingRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.NewRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.CloseRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ListGridControl = new DevExpress.XtraGrid.GridControl();
            this.ListGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.NewBtn,
            this.EditBtn,
            this.ExitBtn,
            this.PrintListBtn});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 10;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.SettingRibbonPage});
            this.ribbon.Size = new System.Drawing.Size(792, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // NewBtn
            // 
            this.NewBtn.Caption = "New";
            this.NewBtn.Id = 1;
            this.NewBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("NewBtn.ImageOptions.SvgImage")));
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NewBtn_ItemClick);
            // 
            // EditBtn
            // 
            this.EditBtn.Caption = "Edit";
            this.EditBtn.Id = 4;
            this.EditBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("EditBtn.ImageOptions.SvgImage")));
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.EditBtn_ItemClick);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Caption = "Close";
            this.ExitBtn.Id = 8;
            this.ExitBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ExitBtn.ImageOptions.SvgImage")));
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ExitBtn_ItemClick);
            // 
            // PrintListBtn
            // 
            this.PrintListBtn.Caption = "Print";
            this.PrintListBtn.Id = 9;
            this.PrintListBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("PrintListBtn.ImageOptions.SvgImage")));
            this.PrintListBtn.Name = "PrintListBtn";
            this.PrintListBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PrintListBtn_ItemClick);
            // 
            // SettingRibbonPage
            // 
            this.SettingRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.NewRibbonPageGroup,
            this.ribbonPageGroup1,
            this.CloseRibbonPageGroup});
            this.SettingRibbonPage.Name = "SettingRibbonPage";
            this.SettingRibbonPage.Text = "Setting List";
            // 
            // NewRibbonPageGroup
            // 
            this.NewRibbonPageGroup.ItemLinks.Add(this.NewBtn);
            this.NewRibbonPageGroup.ItemLinks.Add(this.EditBtn, true);
            this.NewRibbonPageGroup.Name = "NewRibbonPageGroup";
            this.NewRibbonPageGroup.Text = "New / Edit";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.PrintListBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Printing";
            // 
            // CloseRibbonPageGroup
            // 
            this.CloseRibbonPageGroup.ItemLinks.Add(this.ExitBtn);
            this.CloseRibbonPageGroup.Name = "CloseRibbonPageGroup";
            this.CloseRibbonPageGroup.Text = "Exit";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 687);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(792, 24);
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
            this.ListGridControl.Location = new System.Drawing.Point(0, 158);
            this.ListGridControl.MainView = this.ListGridView;
            this.ListGridControl.Name = "ListGridControl";
            this.ListGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1,
            this.repositoryItemPictureEdit1});
            this.ListGridControl.Size = new System.Drawing.Size(792, 529);
            this.ListGridControl.TabIndex = 4;
            this.ListGridControl.UseEmbeddedNavigator = true;
            this.ListGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ListGridView});
            // 
            // ListGridView
            // 
            this.ListGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.ColCode,
            this.ColName,
            this.ColDescription,
            this.ColActive});
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
            this.colId.Width = 45;
            // 
            // ColCode
            // 
            this.ColCode.Caption = "الرمز";
            this.ColCode.FieldName = "Id";
            this.ColCode.Name = "ColCode";
            // 
            // ColName
            // 
            this.ColName.Caption = "Name";
            this.ColName.FieldName = "Name";
            this.ColName.Name = "ColName";
            this.ColName.Visible = true;
            this.ColName.VisibleIndex = 0;
            this.ColName.Width = 271;
            // 
            // ColDescription
            // 
            this.ColDescription.Caption = "Details";
            this.ColDescription.FieldName = "Details";
            this.ColDescription.Name = "ColDescription";
            this.ColDescription.Visible = true;
            this.ColDescription.VisibleIndex = 1;
            this.ColDescription.Width = 455;
            // 
            // ColActive
            // 
            this.ColActive.Caption = "Active";
            this.ColActive.CustomizationCaption = "نشط";
            this.ColActive.FieldName = "IsActive";
            this.ColActive.Name = "ColActive";
            this.ColActive.Visible = true;
            this.ColActive.VisibleIndex = 2;
            this.ColActive.Width = 61;
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
            // SettingsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 711);
            this.Controls.Add(this.ListGridControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "SettingsListForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Settings";
            this.Activated += new System.EventHandler(this.ListForm_Activated);
            this.Shown += new System.EventHandler(this.Form_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage SettingRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup NewRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem NewBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup CloseRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem EditBtn;
        private DevExpress.XtraBars.BarButtonItem ExitBtn;
        private DevExpress.XtraGrid.GridControl ListGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ListGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn ColName;
        private DevExpress.XtraGrid.Columns.GridColumn ColDescription;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn ColActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn ColCode;
        private DevExpress.XtraBars.BarButtonItem PrintListBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}