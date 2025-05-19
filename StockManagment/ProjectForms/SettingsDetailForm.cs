using DevExpress.XtraBars;
using DevExpress.XtraEditors;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagment
{
    public partial class SettingsDetailForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public SettingsDetailForm()
        {
            InitializeComponent();
        }
        public string _Id { get; set; }
        public string _Name { get; set; }
        public string _Code { get; set; }
        public string _Details { get; set; }

        public bool _IsActive { get; set; }
       

        bool _Saved = false;
        public  enum RecordFlag
        {
            New,
            Edit
        }
        public RecordFlag record;
       

        private void ExitBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                //foreach (DevExpress.XtraBars.BarButtonItem bi in barManager1.Items )
                //{
                //    MessageBox.Show(bi.Name);
                //}

                //Check If Data Changed



                if(_Saved==false)
                {
                    if(_IsActive!=Convert.ToBoolean( ISActivetoggleSwitch.EditValue) || _Name!=NameTextEdit.Text || DescriptionMemoEdit.Text!=_Details)
                {
                        DialogResult result = XtraMessageBox.Show("Save Change", "Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                        if (result == DialogResult.Yes)
                        {

                            if (SaveRecord())
                            {
                                this.Close();
                            }

                        }
                        else
                        {
                            this.Close();


                        }


                    }


                    else
                    {
                        this.Close();
                    }
                }
               
                else
                {

                    this.Close();
                }

                      




               
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

            this.Text = SettingService._TabName;


            if (record == RecordFlag.New)
            {

                NameTextEdit.Select();
                ISActivetoggleSwitch.EditValue = true;
               
                this.FormRibbonPage.Text = SettingService._TabName;

            }

            else
            {

                SettingService.GetDetailById(Convert.ToInt32(_Id));


                _Name= SettingService._DetailDataTable.Rows[0][2].ToString();
                NameTextEdit.Text = _Name;

                _Code= SettingService._DetailDataTable.Rows[0][1].ToString();
                CodeTextEdit.Text = _Code;  
                _Details = SettingService._DetailDataTable.Rows[0][3].ToString();
                DescriptionMemoEdit.Text = _Details;
                _IsActive=Convert.ToBoolean(SettingService._DetailDataTable.Rows[0][4].ToString());
                ISActivetoggleSwitch.EditValue = _IsActive;
                this.FormRibbonPage.Text = _Name;
                if(CodeTextEdit.Text.Trim()!="")
                {
CodeTextEdit.ReadOnly = true;
                }
                
            }
        }
        private void Form_Shown(object sender, EventArgs e)
        {
            //Shown
            try
            {
                ShownForm();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }



        #endregion


        //New Record
        #region NewRecord
        private void NewRecord()
        {
            try
            {
                //this.jobTypeBindingSource.AddNew();
              
                NameTextEdit.Select();
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
        //Save
        #region Save Record

        private bool SaveRecord()
        {

            try
            {

                //Validate

                if (string.IsNullOrEmpty(NameTextEdit.Text))
                {

                    XtraMessageBox.Show("Name Required ", "Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NameTextEdit.Select();
                    return false;
                }

                if(SettingService._TableName== "VLDivision")
                {

               

                if (string.IsNullOrEmpty(CodeTextEdit.Text))
                {

                    XtraMessageBox.Show("Code Required ", "Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        CodeTextEdit.Select();
                    return false;
                }
                    if (CodeTextEdit.Text.Length<2)
                    {

                        XtraMessageBox.Show("Code lenght minimum 2 ", "Lenght", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        CodeTextEdit.Select();
                        return false;
                    }


                }

                //Is New Record
                if (record == RecordFlag.New)
                {

                    //Insert

                    _Id = SettingService.InsertRecord(CodeTextEdit.Text, NameTextEdit.Text, DescriptionMemoEdit.Text, Convert.ToBoolean(ISActivetoggleSwitch.EditValue)).ToString();
                    SettingService._FullListDataTable = null;
                    //Select 
                    record = RecordFlag.Edit;
                }
                //Is Old Record

                else if (record == RecordFlag.Edit)
                {
                    // Update
                    SettingService.UpdateRecord(CodeTextEdit.Text, NameTextEdit.Text, DescriptionMemoEdit.Text, Convert.ToBoolean(ISActivetoggleSwitch.EditValue),Convert.ToInt32(_Id));
                    SettingService._FullListDataTable = null;

                }


               
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private void SaveBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveRecord();
            _Saved=true;
        }
        private void SaveCloseBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (SaveRecord())
            {
                this.Close();
            }
        }
        #endregion
        // Edit
        #region Edit
        private void EditRecord()
        {

            try
            {
                
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
        //Cancel Record
        #region Cancel Record

        private void CancelRecord()
        {

            try
            {
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void CancelBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            CancelRecord();
            //Load Record



        }
        #endregion
        //Print
        #region PrintList
        private void PrintBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
               
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        //Delete
        #region Delete
        private void DeleteBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {

                //Chek if Record used in Tables

                DialogResult result = XtraMessageBox.Show("Are you Sure Do You Want Delete This Record", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                
                if (result == DialogResult.Yes)
                {
                   
                    if (SettingService.DeleteRecordById(Convert.ToInt32(_Id))==1)
                   {
                        XtraMessageBox.Show("Record Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SettingService._FullListDataTable = null;
                        this.Close();
                    }

                }
                else
                {
                    //XtraMessageBox.Show("Record cant be delete because its in use in another tables", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void CodeTextEdit_Validated(object sender, EventArgs e)
        {
            
          
            
        }

        private void CodeTextEdit_Validating(object sender, CancelEventArgs e)
        {   
            
           
            
        }
    }
}