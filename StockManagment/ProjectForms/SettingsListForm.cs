using DevExpress.XtraBars;
using DevExpress.XtraEditors;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagment
{
    public partial class SettingsListForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public SettingsListForm()
        {
            InitializeComponent();
        }
        public string _Id { get; set; }
        public string _Name { get; set; }
        
        int _RowHandle = 0;
        


        private void ExitBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
        //Shown
        #region Shown
        private void ShownForm()
        {
            try
            {
                this.Text = SettingService._TabName;
                SettingRibbonPage.Text = this.Text;

                //Load Data
                if (SettingService.GetFullList() !=null)
            {
                this.ListGridControl.DataSource = SettingService._FullListDataTable;
            }
            else
            {
                MessageBox.Show(AAServerCon._ErrorMessage);
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            //Form Control Status
        }
        private void Form_Shown(object sender, EventArgs e)
        {
            //Shown
            ShownForm();
        }



        #endregion


        //New Record
        #region NewRecord
        private void NewRecord()
        {
            try
            {
               

                SettingsDetailForm FormDetail = new SettingsDetailForm();
                FormDetail.record = SettingsDetailForm.RecordFlag.New;
               
                FormDetail.ShowDialog();
                ShownForm();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void NewBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                NewRecord();
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

        // Edit
        #region Edit
        private void EditRecord()
        {

            try
            {


                if (ListGridView.RowCount == 0)
                {

                    return;
                }
                _RowHandle = ListGridView.FocusedRowHandle;
                SettingsDetailForm FormDetail = new SettingsDetailForm();
                FormDetail.record = SettingsDetailForm.RecordFlag.Edit;
                FormDetail._Id = ListGridView.GetRowCellValue(_RowHandle, "Id").ToString();
                FormDetail.ShowDialog();
                ShownForm();
                this.ListGridView.FocusedRowHandle = _RowHandle;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void EditBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditRecord();
        }
        #endregion

        //Print
        #region PrintList
        private void PrintListBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {



                if (ListGridView.RowCount == 0)
                {

                    return;
                }
                this.ListGridView.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Print List :" + ex.Message);
            }
        }
        #endregion

        private void ListForm_Activated(object sender, EventArgs e)
        {
            ShownForm();
        }

        private void ListGridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                EditRecord();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Open Record :"+ex.Message);
            }
        }
    }
}