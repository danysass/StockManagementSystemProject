using DevExpress.DataProcessing.InMemoryDataProcessor;
using DevExpress.Office.Utils;
using DevExpress.Pdf.Native.BouncyCastle.Utilities.Collections;
using DevExpress.PivotGrid.OLAP.Mdx;
using DevExpress.XtraBars;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
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

namespace StockManagment.ProjectForms
{
    public partial class StockCountForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public StockCountForm()
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
            WarehouseSearchLookUpEdit.Properties.DataSource = ValueListClass.GetFullList("VLWarehouse");
            WarehouseSearchLookUpEdit.Properties.ValueMember = "Id";
            WarehouseSearchLookUpEdit.Properties.DisplayMember = "Name";

            //Users
            //RequestedbySearchLookUpEdit
            CreatedBySearchLookUpEdit.Properties.DataSource = ValueListClass.GetUsers();
            CreatedBySearchLookUpEdit.Properties.ValueMember = "Id";
            CreatedBySearchLookUpEdit.Properties.DisplayMember = "Name";


           



            //RequestedbySearchLookUpEdit
            //ApprovedBySearchLookUpEdit.Properties.DataSource = ValueListClass.GetUsers();
            //ApprovedBySearchLookUpEdit.Properties.ValueMember = "Id";
            //ApprovedBySearchLookUpEdit.Properties.DisplayMember = "Name";;
            ////RejectedBySearchLookUpEdit
            //RejectedBySearchLookUpEdit.Properties.DataSource = ValueListClass.GetUsers();
            //RejectedBySearchLookUpEdit.Properties.ValueMember = "Id";
            //RejectedBySearchLookUpEdit.Properties.DisplayMember = "Name";
            //ClosedBySearchLookUpEdit
            ApprovedBySearchLookUpEdit.Properties.DataSource = ValueListClass.GetUsers();
            ApprovedBySearchLookUpEdit.Properties.ValueMember = "Id";
            ApprovedBySearchLookUpEdit.Properties.DisplayMember = "Name";

            //Confirmed By
            ConfirmedBySearchLookUpEdit.Properties.DataSource = ValueListClass.GetUsers();
            ConfirmedBySearchLookUpEdit.Properties.ValueMember = "Id";
            ConfirmedBySearchLookUpEdit.Properties.DisplayMember = "Name";



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
                CountDateEdit.EditValue=DateTime.Now;
               
                ConfirmedCheckEdit.CheckState = CheckState.Unchecked;
                ApprovedCheckEdit.CheckState = CheckState.Unchecked;
            }
            else
            {

                //Load head 
                Gethead();
                CodeTextEdit.EditValue= HeadDataTable.Rows[0]["SerialNumber"];
                WarehouseSearchLookUpEdit.EditValue = HeadDataTable.Rows[0]["WareHouseID"];
                CountDateEdit.EditValue= HeadDataTable.Rows[0]["CountDate"];
                CreatedBySearchLookUpEdit.EditValue=HeadDataTable.Rows[0]["CreatedByID"];
               
                NoteTextEdit.EditValue = HeadDataTable.Rows[0]["Notes"];
               
                ConfirmedCheckEdit.EditValue = HeadDataTable.Rows[0]["IsConfirmed"];
                ConfirmedDateEdit.EditValue = HeadDataTable.Rows[0]["ConfirmedDate"];
                ConfirmedBySearchLookUpEdit.EditValue = HeadDataTable.Rows[0]["ConfirmedByID"];

                ApprovedCheckEdit.EditValue = HeadDataTable.Rows[0]["IsApproved"];
                ApprovedDateEdit.EditValue = HeadDataTable.Rows[0]["ApprovedDate"];
                ApprovedBySearchLookUpEdit.EditValue = HeadDataTable.Rows[0]["ApprovedByID"];
               



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
                    string query = @"
                    INSERT INTO StockCountHead 
                    (SerialNumber, WareHouseID, CountDate, TotalCountQty, TotalAvailableQty, TotalAmount, CurrencyID,
                    ForeignAmount, LocalAmount, Notes, PreparedBy, CreatedByID, CreatedDate, UpdatedByID, UpdatedDate,
                    IsConfirmed, ConfirmedByID, ConfirmedDate, IsApproved, ApprovedByID, ApprovedDate)
                    VALUES 
                    (@SerialNumber, @WareHouseID, @CountDate, @TotalCountQty, @TotalAvailableQty, @TotalAmount, @CurrencyID,
                    @ForeignAmount, @LocalAmount, @Notes, @PreparedBy, @CreatedByID, @CreatedDate, @UpdatedByID, @UpdatedDate,
                    @IsConfirmed, @ConfirmedByID, @ConfirmedDate, @IsApproved, @ApprovedByID, @ApprovedDate);
                    SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@SerialNumber", CodeTextEdit.Text);
                       
                        cmd.Parameters.AddWithValue("@WareHouseID", WarehouseSearchLookUpEdit.EditValue ?? DBNull.Value);
                       
                        cmd.Parameters.AddWithValue("@CountDate", CountDateEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@TotalCountQty", 0);
                        cmd.Parameters.AddWithValue("@TotalAvailableQty",0);
                        cmd.Parameters.AddWithValue("@TotalAmount", 0);
                        cmd.Parameters.AddWithValue("@CurrencyID", 0);
                        cmd.Parameters.AddWithValue("@ForeignAmount",0);
                        cmd.Parameters.AddWithValue("@LocalAmount", 0);
                        cmd.Parameters.AddWithValue("@Notes", NoteTextEdit.Text);
                        cmd.Parameters.AddWithValue("@PreparedBy", CreatedBySearchLookUpEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@CreatedByID", CreatedBySearchLookUpEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now );
                        cmd.Parameters.AddWithValue("@UpdatedByID", CreatedBySearchLookUpEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@UpdatedDate", DateTime.Now );
                        cmd.Parameters.AddWithValue("@IsConfirmed", ConfirmedCheckEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ConfirmedByID", ConfirmedBySearchLookUpEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ConfirmedDate", ConfirmedDateEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@IsApproved", ApprovedCheckEdit.EditValue ?? false);
                        cmd.Parameters.AddWithValue("@ApprovedByID", ApprovedBySearchLookUpEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ApprovedDate", ApprovedDateEdit.EditValue ?? DBNull.Value);







                        string query2 = "Select @@Identity";
                    connection.Open();
                    cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    cmd.CommandText = query2;

                    _Id = Convert.ToInt32(cmd.ExecuteScalar());
                
                    if (_Id > 0)
                    {

                        CodeTextEdit.Text = ValueListClass.GenerateIndexCode("SC");
                        string query3 = "update StockCountHead set SerialNumber=@SerialNumber where id=@id";
                        cmd.Parameters.AddWithValue("@SerialNumber", CodeTextEdit.Text);
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

            
            string query = @"UPDATE StockCountHead 
                    SET SerialNumber = @SerialNumber, WareHouseID = @WareHouseID, CountDate = @CountDate, 
                    TotalCountQty = @TotalCountQty, TotalAvailableQty = @TotalAvailableQty, TotalAmount = @TotalAmount, 
                    CurrencyID = @CurrencyID, ForeignAmount = @ForeignAmount, LocalAmount = @LocalAmount, 
                    Notes = @Notes, PreparedBy = @PreparedBy, CreatedByID = @CreatedByID, CreatedDate = @CreatedDate, 
                    UpdatedByID = @UpdatedByID, UpdatedDate = @UpdatedDate, IsConfirmed = @IsConfirmed, 
                    ConfirmedByID = @ConfirmedByID, ConfirmedDate = @ConfirmedDate, IsApproved = @IsApproved, 
                    ApprovedByID = @ApprovedByID, ApprovedDate = @ApprovedDate
                    WHERE Id = @Id
                           ";

                    //RecievedQuantity
                    using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                        cmd.Parameters.AddWithValue("@SerialNumber", CodeTextEdit.Text);

                        cmd.Parameters.AddWithValue("@WareHouseID", WarehouseSearchLookUpEdit.EditValue ?? DBNull.Value);

                        cmd.Parameters.AddWithValue("@CountDate", CountDateEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@TotalCountQty", 0);
                        cmd.Parameters.AddWithValue("@TotalAvailableQty", 0);
                        cmd.Parameters.AddWithValue("@TotalAmount", 0);
                        cmd.Parameters.AddWithValue("@CurrencyID", 0);
                        cmd.Parameters.AddWithValue("@ForeignAmount", 0);
                        cmd.Parameters.AddWithValue("@LocalAmount", 0);
                        cmd.Parameters.AddWithValue("@Notes", NoteTextEdit.Text);
                        cmd.Parameters.AddWithValue("@PreparedBy", CreatedBySearchLookUpEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@CreatedByID", CreatedBySearchLookUpEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@UpdatedByID", CreatedBySearchLookUpEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@UpdatedDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@IsConfirmed", ConfirmedCheckEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ConfirmedByID", ConfirmedBySearchLookUpEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ConfirmedDate", ConfirmedDateEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@IsApproved", ApprovedCheckEdit.EditValue ?? false);
                        cmd.Parameters.AddWithValue("@ApprovedByID", ApprovedBySearchLookUpEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ApprovedDate", ApprovedDateEdit.EditValue ?? DBNull.Value);


                        cmd.Parameters.AddWithValue("@Id", _Id);

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
                    string sql = @"select * from StockCountHead where id=@id";
                cmd.Parameters.AddWithValue("@id", _Id);

                    cmd.CommandText = sql;
                    SqlDataReader reader = cmd.ExecuteReader();
                    HeadDataTable = new DataTable();
                    HeadDataTable.Load(reader);
                reader.Close();
                con.Close();

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
                if (WarehouseSearchLookUpEdit.Text.Trim() == "")
                {

                    MessageBox.Show("Type  Required");
                    WarehouseSearchLookUpEdit.Select();
                    return false;


                }
                if (CreatedBySearchLookUpEdit.Text.Trim() == "")
                {

                    MessageBox.Show("Request by   Required");
                    CreatedBySearchLookUpEdit.Select();
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



                //Check If Id Found And Serial not Found Then Update Head
                if(_Id>0)
                {

                    if(CodeTextEdit.Text.Trim()=="")
                    {


                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = AAServerCon.GetServerConnection();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.Text;

                        CodeTextEdit.Text = ValueListClass.GenerateIndexCode("IR");
                        string query3 = "update StockRequisitionHead set RequestNumber=@RequestNumber where id=@id";
                        cmd.Parameters.AddWithValue("@RequestNumber", CodeTextEdit.Text);
                        cmd.Parameters.AddWithValue("@id", _Id);
                        cmd.CommandText = query3;
                        cmd.ExecuteNonQuery();
                        con.Close();


                    }
                }
                return true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private bool SaveItem()
        {
            using (SqlConnection connection = new SqlConnection(AAServerCon.GetServerConnection()))
                try
                {


                    string query = @"
                    INSERT INTO StockWasteDetail 
                    (UnitID, ItemID, WasteID, Price, Quantity, TotalAmount, CurrencyID, LocalAmount, ForeignAmount, AvailableQuantityOnHand,
                    Notes, CreatedByID, CreatedDate, UpdatedByID, UpdatedDate, ItemCode, ItemDetail)
                    VALUES 
                    (@UnitID, @ItemID, @WasteID, @Price, @Quantity, @TotalAmount, @CurrencyID, @LocalAmount, @ForeignAmount, @AvailableQuantityOnHand,
                    @Notes, @CreatedByID, @CreatedDate, @UpdatedByID, @UpdatedDate, @ItemCode, @ItemDetail)";
                    

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UnitID",-1);
                        command.Parameters.AddWithValue("@ItemID", gridView1.GetRowCellValue(gridView1.FocusedRowHandle, ("Id")));
                        command.Parameters.AddWithValue("@WasteID",_Id);
                        command.Parameters.AddWithValue("@Price", 0);
                        command.Parameters.AddWithValue("@Quantity", QuantityTextEdit.Text );
                        command.Parameters.AddWithValue("@TotalAmount",0);
                        command.Parameters.AddWithValue("@CurrencyID", -1);
                        command.Parameters.AddWithValue("@LocalAmount", 0);
                        command.Parameters.AddWithValue("@ForeignAmount", 0);
                        command.Parameters.AddWithValue("@AvailableQuantityOnHand", 0);
                        command.Parameters.AddWithValue("@Notes", ItemNoteTextEdit.Text );
                        command.Parameters.AddWithValue("@CreatedByID", CreatedBySearchLookUpEdit.EditValue ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                        command.Parameters.AddWithValue("@UpdatedByID", -1);
                        command.Parameters.AddWithValue("@UpdatedDate", DateTime.Now);
                        command.Parameters.AddWithValue("@ItemCode", ItemSearchLookUpEdit.EditValue);
                        command.Parameters.AddWithValue("@ItemDetail", ItemSearchLookUpEdit.Text);
                       connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                        return true;
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                    return false;

            }

        }
        private bool DeleteItem(int RowId)
        {
            using (SqlConnection connection = new SqlConnection(AAServerCon.GetServerConnection()))
                try
                {


                    string query = @"delete from  StockWasteDetail where Id=@ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                       
                        command.Parameters.AddWithValue("@Id", RowId);
                        connection.Open();
                        command.ExecuteNonQuery();
                        return true;
                    }
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
                string sql = @"select * from  StockWasteDetail where WasteID=@FK_Id ";
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



                if (ApprovedCheckEdit.CheckState == CheckState.Checked)
                {
                    MessageBox.Show("Request Closed");
                    return;
                }


                if (ItemSearchLookUpEdit.Text.Trim() == "")
                {

                    MessageBox.Show("Item Required");
                    ItemSearchLookUpEdit.Select();
                    return;
                }

                if(   SaveHead()==true)
                {

                    SaveItem();
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

        private void SaveBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveHead();
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
                string sql = @"select StockRequisitionHead.Code ,OrderDate,SupplierID,

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
            

            //    SqlConnection con = new SqlConnection();

            //    try
            //    {
            //        con.ConnectionString = AAServerCon.GetServerConnection();
            //        SqlCommand cmd = new SqlCommand();
            //        cmd.Connection = con;
            //        cmd.CommandType = CommandType.Text;
            //        con.Open();
            //        string sql = @"select QuantityOnHand from Items where code=@Code";
            //        cmd.Parameters.AddWithValue("@Code", _Code);
            //        cmd.CommandText = sql;
            //    SqlDataReader rdr= cmd.ExecuteReader();
            //    if(rdr.HasRows)
            //    {
            //        while(rdr.Read())
            //        {
            //            CurrentQuantityTextEdit.EditValue =rdr.IsDBNull(0) ?0 : rdr.GetInt32(0);
            //        }
            //    }
            //    else
            //    {
            //        CurrentQuantityTextEdit.EditValue = 0;

            //    }

            //       rdr.Close();
               

            //    }
            //    catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);

            //}
            //finally { con.Close(); }


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

        //Remove item

        
        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (ApprovedCheckEdit.CheckState==CheckState.Checked)
                {
                    MessageBox.Show("Request Closed");
                    return;
                }
                else
                {
                    //Delete 

                    DeleteItem(Convert.ToInt32(ListGridView.GetRowCellValue(ListGridView.FocusedRowHandle, "Id")));

                    GetItemList();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void OpenCountBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {



                if (ApprovedCheckEdit.CheckState == CheckState.Checked)
                {
                    MessageBox.Show("Request Closed");
                    return;
                }


                if (SaveHead() == true)
                {

                    StockCountDetailForm stockcountdetail = new StockCountDetailForm();
                    stockcountdetail._Id=_Id;
                    stockcountdetail.ShowDialog();
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}