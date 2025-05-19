
namespace StockManagment
{
    partial class SettingsDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsDetailForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.SaveBtn = new DevExpress.XtraBars.BarButtonItem();
            this.SaveCloseBtn = new DevExpress.XtraBars.BarButtonItem();
            this.DeleteBtn = new DevExpress.XtraBars.BarButtonItem();
            this.PrintBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ExitBtn = new DevExpress.XtraBars.BarButtonItem();
            this.FormRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.SaveRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PrintRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.DeleteRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.CloseRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ISActivetoggleSwitch = new DevExpress.XtraEditors.ToggleSwitch();
            this.DetailLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.DescriptionMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NameLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.CodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ISActivetoggleSwitch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.SaveBtn,
            this.SaveCloseBtn,
            this.DeleteBtn,
            this.PrintBtn,
            this.ExitBtn});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 10;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsExpandCollapseMenu.ShowQuickAccessToolbarItem = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.FormRibbonPage});
            this.ribbon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ribbon.Size = new System.Drawing.Size(658, 170);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Caption = "Save";
            this.SaveBtn.Id = 2;
            this.SaveBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SaveBtn.ImageOptions.SvgImage")));
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SaveBtn_ItemClick);
            // 
            // SaveCloseBtn
            // 
            this.SaveCloseBtn.Caption = "Save And Close";
            this.SaveCloseBtn.Id = 3;
            this.SaveCloseBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SaveCloseBtn.ImageOptions.SvgImage")));
            this.SaveCloseBtn.Name = "SaveCloseBtn";
            this.SaveCloseBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SaveCloseBtn_ItemClick);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Caption = "Delete";
            this.DeleteBtn.Id = 6;
            this.DeleteBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("DeleteBtn.ImageOptions.SvgImage")));
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DeleteBtn_ItemClick);
            // 
            // PrintBtn
            // 
            this.PrintBtn.Caption = "Print";
            this.PrintBtn.Id = 7;
            this.PrintBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("PrintBtn.ImageOptions.SvgImage")));
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PrintBtn_ItemClick);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Caption = "Close";
            this.ExitBtn.Id = 8;
            this.ExitBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ExitBtn.ImageOptions.SvgImage")));
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ExitBtn_ItemClick);
            // 
            // FormRibbonPage
            // 
            this.FormRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.SaveRibbonPageGroup,
            this.PrintRibbonPageGroup,
            this.DeleteRibbonPageGroup,
            this.CloseRibbonPageGroup});
            this.FormRibbonPage.Name = "FormRibbonPage";
            this.FormRibbonPage.Text = "Detail";
            // 
            // SaveRibbonPageGroup
            // 
            this.SaveRibbonPageGroup.ItemLinks.Add(this.SaveBtn);
            this.SaveRibbonPageGroup.ItemLinks.Add(this.SaveCloseBtn);
            this.SaveRibbonPageGroup.Name = "SaveRibbonPageGroup";
            this.SaveRibbonPageGroup.Text = "Save And Close";
            // 
            // PrintRibbonPageGroup
            // 
            this.PrintRibbonPageGroup.ItemLinks.Add(this.PrintBtn);
            this.PrintRibbonPageGroup.Name = "PrintRibbonPageGroup";
            this.PrintRibbonPageGroup.Text = "Print";
            this.PrintRibbonPageGroup.Visible = false;
            // 
            // DeleteRibbonPageGroup
            // 
            this.DeleteRibbonPageGroup.ItemLinks.Add(this.DeleteBtn);
            this.DeleteRibbonPageGroup.Name = "DeleteRibbonPageGroup";
            this.DeleteRibbonPageGroup.Text = "Delete";
            // 
            // CloseRibbonPageGroup
            // 
            this.CloseRibbonPageGroup.ItemLinks.Add(this.ExitBtn);
            this.CloseRibbonPageGroup.Name = "CloseRibbonPageGroup";
            this.CloseRibbonPageGroup.Text = "Exit";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 362);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(658, 31);
            // 
            // ISActivetoggleSwitch
            // 
            this.ISActivetoggleSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ISActivetoggleSwitch.EditValue = true;
            this.ISActivetoggleSwitch.EnterMoveNextControl = true;
            this.ISActivetoggleSwitch.Location = new System.Drawing.Point(510, 183);
            this.ISActivetoggleSwitch.Name = "ISActivetoggleSwitch";
            this.ISActivetoggleSwitch.Properties.OffText = "Not Active";
            this.ISActivetoggleSwitch.Properties.OnText = "Active";
            this.ISActivetoggleSwitch.Size = new System.Drawing.Size(111, 24);
            this.ISActivetoggleSwitch.TabIndex = 3;
            // 
            // DetailLabelControl
            // 
            this.DetailLabelControl.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.DetailLabelControl.Location = new System.Drawing.Point(15, 220);
            this.DetailLabelControl.Name = "DetailLabelControl";
            this.DetailLabelControl.Size = new System.Drawing.Size(28, 13);
            this.DetailLabelControl.TabIndex = 1244;
            this.DetailLabelControl.Text = "Notes";
            // 
            // DescriptionMemoEdit
            // 
            this.DescriptionMemoEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionMemoEdit.Location = new System.Drawing.Point(61, 220);
            this.DescriptionMemoEdit.Name = "DescriptionMemoEdit";
            this.DescriptionMemoEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DescriptionMemoEdit.Size = new System.Drawing.Size(549, 129);
            this.DescriptionMemoEdit.TabIndex = 3;
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextEdit.EnterMoveNextControl = true;
            this.NameTextEdit.Location = new System.Drawing.Point(61, 184);
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Properties.ValidateOnEnterKey = true;
            this.NameTextEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameTextEdit.Size = new System.Drawing.Size(311, 22);
            this.NameTextEdit.TabIndex = 2;
            // 
            // NameLabelControl
            // 
            this.NameLabelControl.Location = new System.Drawing.Point(15, 189);
            this.NameLabelControl.Name = "NameLabelControl";
            this.NameLabelControl.Size = new System.Drawing.Size(27, 13);
            this.NameLabelControl.TabIndex = 1242;
            this.NameLabelControl.Text = "Name";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(399, 189);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(25, 13);
            this.labelControl1.TabIndex = 1248;
            this.labelControl1.Text = "Code";
            // 
            // CodeTextEdit
            // 
            this.CodeTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CodeTextEdit.EnterMoveNextControl = true;
            this.CodeTextEdit.Location = new System.Drawing.Point(430, 184);
            this.CodeTextEdit.Name = "CodeTextEdit";
            this.CodeTextEdit.Properties.MaxLength = 2;
            this.CodeTextEdit.Properties.ValidateOnEnterKey = true;
            this.CodeTextEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CodeTextEdit.Size = new System.Drawing.Size(63, 22);
            this.CodeTextEdit.TabIndex = 1247;
            // 
            // SettingsDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 393);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.CodeTextEdit);
            this.Controls.Add(this.ISActivetoggleSwitch);
            this.Controls.Add(this.DetailLabelControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.DescriptionMemoEdit);
            this.Controls.Add(this.NameLabelControl);
            this.Controls.Add(this.NameTextEdit);
            this.Controls.Add(this.ribbon);
            this.MaximumSize = new System.Drawing.Size(1190, 802);
            this.Name = "SettingsDetailForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "InfoForm";
            this.Shown += new System.EventHandler(this.Form_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ISActivetoggleSwitch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem SaveBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup DeleteRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PrintRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup CloseRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem SaveCloseBtn;
        private DevExpress.XtraBars.BarButtonItem DeleteBtn;
        private DevExpress.XtraBars.BarButtonItem PrintBtn;
        private DevExpress.XtraBars.BarButtonItem ExitBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup SaveRibbonPageGroup;
        private DevExpress.XtraEditors.LabelControl DetailLabelControl;
        private DevExpress.XtraEditors.MemoEdit DescriptionMemoEdit;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private DevExpress.XtraEditors.LabelControl NameLabelControl;
        private DevExpress.XtraEditors.ToggleSwitch ISActivetoggleSwitch;
        public DevExpress.XtraBars.Ribbon.RibbonPage FormRibbonPage;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit CodeTextEdit;
    }
}