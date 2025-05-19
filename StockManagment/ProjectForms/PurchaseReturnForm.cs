using DevExpress.DataProcessing.InMemoryDataProcessor;
using DevExpress.Office.Utils;
using DevExpress.Pdf.Native.BouncyCastle.Utilities.Collections;
using DevExpress.PivotGrid.OLAP.Mdx;
using DevExpress.XtraBars;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using StockManagment.Models;
using StockManagment.ProjectReports;
using StockManagment.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StockManagment.ProjectForms
{
    public partial class PurchaseReturnForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public PurchaseReturnForm()
        {
            InitializeComponent();
        }
        public int _Id { get; set; } = 0;
        public enum RecordFlag
        {
            New,
            Edit
        }
        public RecordFlag record;
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        




        private void LoadDataTable()
        {
            //Suppliers
            //SupplierSearchLookUpEdit.Properties.DataSource = ValueListClass.GetFullList("VLSupplier");
            //SupplierSearchLookUpEdit.Properties.ValueMember = "Id";
            //SupplierSearchLookUpEdit.Properties.DisplayMember = "Name";

            //PurchaseRequestType
            currencyIDSpinEdit.Properties.DataSource = ValueListClass.GetFullList("VLCurrency");
            currencyIDSpinEdit.Properties.ValueMember = "Id";
            currencyIDSpinEdit.Properties.DisplayMember = "Name";

            //Users
            //RequestedbySearchLookUpEdit
            supplierIDSpinEdit.Properties.DataSource =ValueListClass.GetFullList("VLSupplier"); 
            supplierIDSpinEdit.Properties.ValueMember = "Id";
            supplierIDSpinEdit.Properties.DisplayMember = "Name";

            //RequestedbySearchLookUpEdit
            returnedByIDSpinEdit.Properties.DataSource = ValueListClass.GetUsers();
            returnedByIDSpinEdit.Properties.ValueMember = "Id";
            returnedByIDSpinEdit.Properties.DisplayMember = "Name";
            //RejectedBySearchLookUpEdit
            postedByIDSpinEdit.Properties.DataSource = ValueListClass.GetUsers();
            postedByIDSpinEdit.Properties.ValueMember = "Id";
            postedByIDSpinEdit.Properties.DisplayMember = "Name";
            //ClosedBySearchLookUpEdit
            approvedByIDSpinEdit.Properties.DataSource = ValueListClass.GetUsers();
            approvedByIDSpinEdit.Properties.ValueMember = "Id";
            approvedByIDSpinEdit.Properties.DisplayMember = "Name";

            //Confirmed By
            warehouseIDSpinEdit.Properties.DataSource = ValueListClass.GetFullList("VLWarehouse");
            warehouseIDSpinEdit.Properties.ValueMember = "Id";
            warehouseIDSpinEdit.Properties.DisplayMember = "Name";



            //Items
            if (ItemService.GetItemForCombo() != null)
            {
                ItemSearchLookUpEdit.Properties.DataSource = ItemService._ItemComboListDataTable;
                ItemSearchLookUpEdit.Properties.ValueMember = "Code";
                ItemSearchLookUpEdit.Properties.DisplayMember = "Description";

                repositoryItemLookUpEdit1.DataSource = ItemService._ItemComboListDataTable;
                repositoryItemLookUpEdit1.ValueMember = "Id";
                repositoryItemLookUpEdit1.DisplayMember = "Description";


            }

        }
            private void PurchaseOrderForm_Shown(object sender, EventArgs e)
        {
            LoadDataTable();
            if(record==RecordFlag.New)
            {
                returnedDateDateEdit.EditValue = DateTime.Now;
                currencyIDSpinEdit.EditValue = 1;
                warehouseIDSpinEdit.EditValue =1;
                //RejectedCheckEdit.CheckState = CheckState.Unchecked;
                //ConfirmedCheckEdit.CheckState = CheckState.Unchecked;
                //ClosedCheckEdit.CheckState = CheckState.Unchecked;
            }
            else
            {

                //Load head 
                Gethead();
                idSpinEdit1.EditValue= HeadDataTable.Rows[0]["Id"];
                CodeTextEdit.EditValue= HeadDataTable.Rows[0]["SerialNumber"];
                currencyIDSpinEdit.EditValue = HeadDataTable.Rows[0]["CurrencyID"];
                 supplierIDSpinEdit.EditValue = HeadDataTable.Rows[0]["SupplierID"];
                 warehouseIDSpinEdit.EditValue= HeadDataTable.Rows[0]["WarehouseID"];
                referenceNumberTextEdit1.EditValue= HeadDataTable.Rows[0]["ReferenceNumber"];
                returnedDateDateEdit.EditValue = HeadDataTable.Rows[0]["ReturnedDate"];
                 returnedByIDSpinEdit.EditValue= HeadDataTable.Rows[0]["ReturnedByID"];
                 reasonDiscriptionTextEdit.EditValue= HeadDataTable.Rows[0]["ReasonDiscription"];
                 totalAmountSpinEdit.EditValue= HeadDataTable.Rows[0]["TotalAmount"];
                hasVATCheckEdit1.EditValue= HeadDataTable.Rows[0]["HasVAT"];
              vATPercentageSpinEdit.EditValue= HeadDataTable.Rows[0]["VATPercentage"];
                 totalVATAmountSpinEdit.EditValue= HeadDataTable.Rows[0]["TotalVATAmount"];
                netAmountSpinEdit.EditValue= HeadDataTable.Rows[0]["NetAmount"];
                 localExRateSpinEdit.EditValue= HeadDataTable.Rows[0]["LocalExRate"];
                 localAmountSpinEdit.EditValue= HeadDataTable.Rows[0]["LocalAmount"];
               foreignExRateSpinEdit.EditValue= HeadDataTable.Rows[0]["ForeignExRate"];
                foreignAmountSpinEdit.EditValue= HeadDataTable.Rows[0]["ForeignAmount"];
                isApprovedCheckEdit.EditValue= HeadDataTable.Rows[0]["IsApproved"];
               
                 notesTextEdit.EditValue= HeadDataTable.Rows[0]["Notes"];
             
               
         
              



                //Load deatil

                GetItemList();
            }


        }


        PurshaseOrderService purshaseOrderService = new PurshaseOrderService();
        PurchaseOrderHead pohead;



        public int InsertHeadRecord()
        {

            using (SqlConnection connection = new SqlConnection(AAServerCon.GetServerConnection()))
                try
                {
                    string query = @"INSERT INTO[PurchaseReturnHead] ([CurrencyID], [SupplierID],
[WarehouseID], [SerialNumber], 
[ReferenceNumber], [ReturnedDate],
[ReturnedByID], [ReasonDiscription], 
[TotalAmount], [HasVAT], [VATPercentage],
[TotalVATAmount], [NetAmount], [LocalExRate], 
[LocalAmount], 
[ForeignExRate], [ForeignAmount], [IsApproved], [ApprovedByID], [ApprovedDate], [Notes], [IsPosted], [PostingTime], [PostedByID], [CreatedByID], [CreatedDate], [UpdatedByID], [UpdatedDate])
VALUES(@CurrencyID, @SupplierID, @WarehouseID, @SerialNumber, @ReferenceNumber, @ReturnedDate, @ReturnedByID, @ReasonDiscription, @TotalAmount, @HasVAT, @VATPercentage, @TotalVATAmount, @NetAmount, @LocalExRate, @LocalAmount, @ForeignExRate, @ForeignAmount, @IsApproved, @ApprovedByID, @ApprovedDate, @Notes, @IsPosted, @PostingTime, @PostedByID, @CreatedByID, @CreatedDate, @UpdatedByID, @UpdatedDate)";

                    SqlCommand cmd = new SqlCommand(query, connection);

                    // Add parameters
                    cmd.Parameters.AddWithValue("@CurrencyID", currencyIDSpinEdit.EditValue);
                    cmd.Parameters.AddWithValue("@SupplierID", supplierIDSpinEdit.EditValue);
                    cmd.Parameters.AddWithValue("@WarehouseID", warehouseIDSpinEdit.EditValue);
                    cmd.Parameters.AddWithValue("@SerialNumber", CodeTextEdit.Text);
                    cmd.Parameters.AddWithValue("@ReferenceNumber", referenceNumberTextEdit1.Text);
                    cmd.Parameters.AddWithValue("@ReturnedDate", returnedDateDateEdit.EditValue);
                    cmd.Parameters.AddWithValue("@ReturnedByID", returnedByIDSpinEdit.EditValue);
                    cmd.Parameters.AddWithValue("@ReasonDiscription", reasonDiscriptionTextEdit.Text);
                    cmd.Parameters.AddWithValue("@TotalAmount", totalAmountSpinEdit.EditValue);
                    cmd.Parameters.AddWithValue("@HasVAT", hasVATCheckEdit1.EditValue);
                    cmd.Parameters.AddWithValue("@VATPercentage", vATPercentageSpinEdit.EditValue);
                    cmd.Parameters.AddWithValue("@TotalVATAmount", totalVATAmountSpinEdit.EditValue);
                    cmd.Parameters.AddWithValue("@NetAmount", netAmountSpinEdit.EditValue);
                    cmd.Parameters.AddWithValue("@LocalExRate", localExRateSpinEdit.EditValue);
                    cmd.Parameters.AddWithValue("@LocalAmount", localAmountSpinEdit.EditValue);
                    cmd.Parameters.AddWithValue("@ForeignExRate", foreignExRateSpinEdit.EditValue);
                    cmd.Parameters.AddWithValue("@ForeignAmount", foreignAmountSpinEdit.EditValue);
                    cmd.Parameters.AddWithValue("@IsApproved", isApprovedCheckEdit.EditValue);
                    cmd.Parameters.AddWithValue("@ApprovedByID", approvedByIDSpinEdit.EditValue?? -1);
                    cmd.Parameters.AddWithValue("@ApprovedDate", approvedDateDateEdit.EditValue ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Notes", notesTextEdit.Text);
                    cmd.Parameters.AddWithValue("@IsPosted", isPostedCheckEdit.EditValue ?? false);
                    cmd.Parameters.AddWithValue("@PostingTime", postingTimeDateEdit.EditValue ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@PostedByID", postedByIDSpinEdit.EditValue);
                    cmd.Parameters.AddWithValue("@CreatedByID", returnedByIDSpinEdit.EditValue);
                    cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@UpdatedByID", -1);
                    cmd.Parameters.AddWithValue("@UpdatedDate", DBNull.Value);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    string query2 = "Select @@Identity";
                   
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = query2;

                    _Id = Convert.ToInt32(cmd.ExecuteScalar());

                    if (_Id > 0)
                    {

                        CodeTextEdit.Text = ValueListClass.GenerateIndexCode("RR");
                        string query3 = "update PurchaseReturnHead set SerialNumber=@code where id=@id";
                        cmd.Parameters.AddWithValue("@Code", CodeTextEdit.Text);
                        cmd.Parameters.AddWithValue("@id", _Id);
                        cmd.CommandText = query3;
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        return _Id;
                    }
                    else
                    {
                        return -1;
                    }
    }
            catch (Exception ex)
            {

                MessageBox.Show("Error :" + ex.Message);
                return -1;
            }

            finally
            {


                if (connection != null)
                {
                    connection.Close();
                }
            }

        }
        public bool UpdateHeadRecord()
        {

            using (SqlConnection connection = new SqlConnection(AAServerCon.GetServerConnection()))

                try
            {

            
            string query = @"UPDATE PurchaseReturnHead
                        SET 
                            [CurrencyID]=@CurrencyID,
[SupplierID]=@SupplierID,
[WarehouseID]=@WarehouseID,
 
[ReferenceNumber]=@ReferenceNumber,
[ReturnedDate]=@ReturnedDate,
[ReturnedByID]=@ReturnedByID,
[ReasonDiscription]=@ReasonDiscription, 
[TotalAmount]=@TotalAmount,
[HasVAT]=@HasVAT,
[VATPercentage]=@VATPercentage,
[TotalVATAmount]=@TotalVATAmount, 
[NetAmount]=@NetAmount,
[LocalExRate]=@LocalExRate, 
[LocalAmount]=@LocalAmount, 
[ForeignExRate]=@ForeignExRate,
[ForeignAmount]=@ForeignAmount,
[IsApproved]=@IsApproved,
[ApprovedByID]=@ApprovedByID,
[ApprovedDate]=@ApprovedDate,
[Notes]=@Notes

                        WHERE Id = @Id";

                    //RecievedQuantity
                    using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                        cmd.Parameters.AddWithValue("@Id", _Id);
                        cmd.Parameters.AddWithValue("@CurrencyID", currencyIDSpinEdit.EditValue);
                        cmd.Parameters.AddWithValue("@SupplierID", supplierIDSpinEdit.EditValue);
                        cmd.Parameters.AddWithValue("@WarehouseID", warehouseIDSpinEdit.EditValue);
                        
                        cmd.Parameters.AddWithValue("@ReferenceNumber", referenceNumberTextEdit1.Text);
                        cmd.Parameters.AddWithValue("@ReturnedDate", returnedDateDateEdit.EditValue);
                        cmd.Parameters.AddWithValue("@ReturnedByID", returnedByIDSpinEdit.EditValue);
                        cmd.Parameters.AddWithValue("@ReasonDiscription", reasonDiscriptionTextEdit.Text);
                        cmd.Parameters.AddWithValue("@TotalAmount", totalAmountSpinEdit.EditValue);
                        cmd.Parameters.AddWithValue("@HasVAT", hasVATCheckEdit1.EditValue);
                        cmd.Parameters.AddWithValue("@VATPercentage", vATPercentageSpinEdit.EditValue);
                        cmd.Parameters.AddWithValue("@TotalVATAmount", totalVATAmountSpinEdit.EditValue);
                        cmd.Parameters.AddWithValue("@NetAmount", netAmountSpinEdit.EditValue);
                        cmd.Parameters.AddWithValue("@LocalExRate", localExRateSpinEdit.EditValue);
                        cmd.Parameters.AddWithValue("@LocalAmount", localAmountSpinEdit.EditValue);
                        cmd.Parameters.AddWithValue("@ForeignExRate", foreignExRateSpinEdit.EditValue);
                        cmd.Parameters.AddWithValue("@ForeignAmount", foreignAmountSpinEdit.EditValue);
                        cmd.Parameters.AddWithValue("@IsApproved", isApprovedCheckEdit.EditValue);
                        cmd.Parameters.AddWithValue("@ApprovedByID", approvedByIDSpinEdit.EditValue ?? -1);
                        cmd.Parameters.AddWithValue("@ApprovedDate", approvedDateDateEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Notes", notesTextEdit.Text);
                       



                        connection.Open();
                        cmd.ExecuteNonQuery();
                        return true;
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                    return false;   
            }
        }
        private DataTable HeadDataTable = null;
        private DataTable Gethead()
        {
             SqlConnection con = new SqlConnection();

                try
                {
                    con.ConnectionString = AAServerCon.GetServerConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    string sql = @"select * from PurchaseReturnHead where id=@id";
                cmd.Parameters.AddWithValue("@id", _Id);

                    cmd.CommandText = sql;
                    SqlDataReader reader = cmd.ExecuteReader();
                    HeadDataTable = new DataTable();
                    HeadDataTable.Load(reader);

                return HeadDataTable;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                return null;
                }
            }
        private bool SaveHead()
        {
            try
            {
                if (returnedByIDSpinEdit.Text.Trim() == "")
                {

                    MessageBox.Show("User   Required");
                    returnedByIDSpinEdit.Select();
                    return false;


                }
                if (supplierIDSpinEdit.Text.Trim() == "")
                {

                    MessageBox.Show("Supplier  Required");
                    supplierIDSpinEdit.Select();
                    return false;


                }

                if (_Id==0)
                {
                   
                    //Generate Code 
                   

                    //Insert Head
                   if( InsertHeadRecord()>0)
                    {
                        return true;

                    }

                }



                else
                {
                    //Update Head
                    UpdateHeadRecord();

                }
                return true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }





        }
    
        private bool InsertItem()
        {
            using (SqlConnection connection = new SqlConnection(AAServerCon.GetServerConnection()))
                try
            {


                    string query = @"INSERT INTO PurchaseReturnDetail (ItemCode,ItemName,PurchaseReturnID, PurchaseReturnReasonID, ItemID, ReturnedQuantity, ReturnedGratisQty, UnitPrice, CurrencyID, QuantityOnHand, UnitID, TotalPrice, HasVAT, VATPercentage, TotalVATAmount, NetAmount, LocalExRate, LocalAmount, ForeignExRate, ForeignAmount, Notes, DeliveryDetailID, CreatedByID, CreatedDate)
                             VALUES (@ItemCode,@ItemName,@PurchaseReturnID, @PurchaseReturnReasonID, @ItemID, @ReturnedQuantity, @ReturnedGratisQty, @UnitPrice, @CurrencyID, @QuantityOnHand, @UnitID, @TotalPrice, @HasVAT, @VATPercentage, @TotalVATAmount, @NetAmount, @LocalExRate, @LocalAmount, @ForeignExRate, @ForeignAmount, @Notes, @DeliveryDetailID, @CreatedByID, @CreatedDate)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PurchaseReturnID", _Id);
                        command.Parameters.AddWithValue("@PurchaseReturnReasonID", -1);
                        command.Parameters.AddWithValue("@ItemID", gridView1.GetRowCellValue(gridView1.FocusedRowHandle, ("Id")));
                        command.Parameters.AddWithValue("@ReturnedQuantity", QuantityTextEdit.EditValue);
                        command.Parameters.AddWithValue("@ReturnedGratisQty", 0);
                        command.Parameters.AddWithValue("@UnitPrice", 0);
                        command.Parameters.AddWithValue("@CurrencyID", currencyIDSpinEdit.EditValue?? DBNull.Value);
                        command.Parameters.AddWithValue("@QuantityOnHand", 0);
                        command.Parameters.AddWithValue("@UnitID", 0);
                        command.Parameters.AddWithValue("@TotalPrice", 0);
                        command.Parameters.AddWithValue("@HasVAT", false);
                        command.Parameters.AddWithValue("@VATPercentage", 0);
                        command.Parameters.AddWithValue("@TotalVATAmount",0);
                        command.Parameters.AddWithValue("@NetAmount", 0);
                        command.Parameters.AddWithValue("@LocalExRate", 0);
                        command.Parameters.AddWithValue("@LocalAmount", 0);
                        command.Parameters.AddWithValue("@ForeignExRate", 0);
                        command.Parameters.AddWithValue("@ForeignAmount", 0);
                        command.Parameters.AddWithValue("@Notes", DetailNoteTextEdit.Text);
                        command.Parameters.AddWithValue("@DeliveryDetailID", -1);
                        command.Parameters.AddWithValue("@CreatedByID", returnedByIDSpinEdit.EditValue);
                        command.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                        command.Parameters.AddWithValue("@ItemCode", ItemSearchLookUpEdit.EditValue);
                        command.Parameters.AddWithValue("@ItemName", ItemSearchLookUpEdit.Text);



                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    return true;
            
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                    return false;
            }

        }

        DataTable DetailDatatable = null;
        private void GetItemList()
        {

            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = AAServerCon.GetServerConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                con.Open();
                string sql = @"select * from  PurchaseReturnDetail where PurchaseReturnID=@FK_Id ";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@FK_Id", _Id);
              if(DetailDatatable == null)
                {
                    DetailDatatable = new DataTable();

                }
                else
                {
                    DetailDatatable.Rows.Clear();


                }

              SqlDataReader reader=cmd.ExecuteReader();
                DetailDatatable.Load(reader);
                this.ListGridControl.DataSource = DetailDatatable;
               

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error :" + ex.Message);
              
            }
            finally
            {


                if (con != null)
                {
                    con.Close();
                }
            }


        }



        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //if(SupplierSearchLookUpEdit.Text.Trim()=="")
                //{

                //    MessageBox.Show("Supplier Required");
                //    SupplierSearchLookUpEdit.Select();
                //    return;


                //}
                if (ItemSearchLookUpEdit.Text.Trim() == "")
                {

                    MessageBox.Show("Item Required");
                    ItemSearchLookUpEdit.Select();
                    return;
                }

                if(   SaveHead()==true)
                {

                    InsertItem();
                    GetItemList();
                    QuantityTextEdit.EditValue = 1;
                    ItemSearchLookUpEdit.Text = "";
                    ItemSearchLookUpEdit.Select();
                }


                //Save Detail


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void UpdateItem(int _RowId, int Quantity)
        {

            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = AAServerCon.GetServerConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                con.Open();

                string query = @"UPDATE PurchaseReturnDetail
                        SET 
                            ReturnedQuantity = @ReturnedQuantity
                           
                        WHERE Id = @Id";
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@ReturnedQuantity", Quantity);
                cmd.Parameters.AddWithValue("@Id", _RowId);

                cmd.ExecuteNonQuery();
                con.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

        private void SaveBtn_ItemClick(object sender, ItemClickEventArgs e)
        {

            try
            {
 CodeTextEdit.Select();
            SaveHead();
          
            //Save item Details
            if (ListGridView.RowCount > 0)
            {
                for (int i = 0; i < ListGridView.RowCount; ++i)
                {
                    UpdateItem(Convert.ToInt32(ListGridView.GetRowCellValue(i, "Id")), Convert.ToInt32(ListGridView.GetRowCellValue(i, "ReturnedQuantity")));

                }

                    
                }

            GetItemList();
MessageBox.Show("Record Saved");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error Saving");
            }
           

        }

        DataTable printpodatata = null;
        public  void PrintPo()
        {

            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = AAServerCon.GetServerConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                con.Open();
                string sql = @"select PurchaseOrderHead.Code ,OrderDate,SupplierID,

PurchaseOrderDetail.ItemDetail,
PurchaseOrderDetail.Quantity,
PurchaseOrderDetail.ItemNote,
VLSupplier.NameEN,
VLSupplier.Phone1,
VLSupplier.Address1



from PurchaseOrderHead

inner join PurchaseOrderDetail on PurchaseOrderDetail.PurchaseRequestID=PurchaseOrderHead.Id
left join VLSupplier on PurchaseOrderHead.SupplierID=VLSupplier.Id


 where PurchaseOrderHead.Id=@Id ";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@Id", _Id);
                if (printpodatata == null)
                {
                    printpodatata = new DataTable();

                }
                else
                {
                    printpodatata.Rows.Clear();


                }

                SqlDataReader reader = cmd.ExecuteReader();
                printpodatata.Load(reader);
               


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error :" + ex.Message);

            }
            finally
            {


                if (con != null)
                {
                    con.Close();
                }
            }




        }
        private void PrintBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {






                if(_Id>0)
                {


                    PrintPo();


                PurchaseOrderReport report=new PurchaseOrderReport();
                report.DataSource = printpodatata;
                    ReportPrintTool printTool = new ReportPrintTool(report);
                    printTool.ShowPreview();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void GetCurrentStock(string _Code)
        {
            



        }


        private void ItemSearchLookUpEdit_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if(ItemSearchLookUpEdit.Text.Trim()!="")
                {
                    //Get Current Stock
                    GetCurrentStock(ItemSearchLookUpEdit.EditValue.ToString());

                    //Get Last Request

                    //get last Purshaced
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Delete 
            DialogResult result = XtraMessageBox.Show("Are you Sure Do You Want Delete This Record", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                int _Id = Convert.ToInt32(ListGridView.GetRowCellValue(ListGridView.FocusedRowHandle, "Id"));
                SqlConnection con = new SqlConnection();
                con.ConnectionString = AAServerCon.GetServerConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.CommandText = @"delete from  PurchaseReturnDetail  where Id=@Id";
                cmd.Parameters.AddWithValue("@Id", _Id);
                cmd.ExecuteNonQuery();
                con.Close();
                XtraMessageBox.Show("Record Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetItemList();
            }
            else
            {
                return;
            }
        }
    }
}