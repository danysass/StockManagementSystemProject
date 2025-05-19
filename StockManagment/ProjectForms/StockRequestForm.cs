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

namespace StockManagment.ProjectForms
{
    public partial class StockRequestForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public StockRequestForm()
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
            WarehouseSearchLookUpEdit.Properties.DataSource = ValueListClass.GetFullList("VLRequestType");
            WarehouseSearchLookUpEdit.Properties.ValueMember = "Id";
            WarehouseSearchLookUpEdit.Properties.DisplayMember = "Name";

            //Users
            //RequestedbySearchLookUpEdit
            RequestedbySearchLookUpEdit.Properties.DataSource = ValueListClass.GetUsers();
            RequestedbySearchLookUpEdit.Properties.ValueMember = "Id";
            RequestedbySearchLookUpEdit.Properties.DisplayMember = "Name";




            //DivisionSearchLookUpEdit
            DepartmentSearchLookUpEdit.Properties.DataSource = ValueListClass.GetFullList("VLDepartment");
            DepartmentSearchLookUpEdit.Properties.ValueMember = "Id";
            DepartmentSearchLookUpEdit.Properties.DisplayMember = "Name";


            //RequestedbySearchLookUpEdit
            //ApprovedBySearchLookUpEdit.Properties.DataSource = ValueListClass.GetUsers();
            //ApprovedBySearchLookUpEdit.Properties.ValueMember = "Id";
            //ApprovedBySearchLookUpEdit.Properties.DisplayMember = "Name";;
            ////RejectedBySearchLookUpEdit
            //RejectedBySearchLookUpEdit.Properties.DataSource = ValueListClass.GetUsers();
            //RejectedBySearchLookUpEdit.Properties.ValueMember = "Id";
            //RejectedBySearchLookUpEdit.Properties.DisplayMember = "Name";
            //ClosedBySearchLookUpEdit
            ClosedBySearchLookUpEdit.Properties.DataSource = ValueListClass.GetUsers();
            ClosedBySearchLookUpEdit.Properties.ValueMember = "Id";
            ClosedBySearchLookUpEdit.Properties.DisplayMember = "Name";

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
                RequestDateEdit.EditValue=DateTime.Now;
               
                ConfirmedCheckEdit.CheckState = CheckState.Unchecked;
                ClosedCheckEdit.CheckState = CheckState.Unchecked;
            }
            else
            {

                //Load head 
                Gethead();
                CodeTextEdit.EditValue= HeadDataTable.Rows[0]["RequestNumber"];
                WarehouseSearchLookUpEdit.EditValue = HeadDataTable.Rows[0]["WareHouseID"];
                RequestDateEdit.EditValue= HeadDataTable.Rows[0]["RequisitionDate"];
                RequestedbySearchLookUpEdit.EditValue=HeadDataTable.Rows[0]["CreatedByID"];
                DueDateEdit.EditValue=HeadDataTable.Rows[0]["DueDate"];
                RequestNoteTextEdit.EditValue = HeadDataTable.Rows[0]["Description"];
                DepartmentSearchLookUpEdit.EditValue = HeadDataTable.Rows[0]["DepartmentId"];
                ConfirmedCheckEdit.EditValue = HeadDataTable.Rows[0]["IsConfirmed"];
                ConfirmedDateEdit.EditValue = HeadDataTable.Rows[0]["ConfirmedDate"];
                ConfirmedBySearchLookUpEdit.EditValue = HeadDataTable.Rows[0]["ConfirmedByID"];

                ClosedCheckEdit.EditValue = HeadDataTable.Rows[0]["IsClosed"];
                ClosedDateEdit.EditValue = HeadDataTable.Rows[0]["ClosedDate"];
                ClosedBySearchLookUpEdit.EditValue = HeadDataTable.Rows[0]["ClosedByID"];
               



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
                string query = @"INSERT INTO StockRequisitionHead 
(StkOrganizationUnitID,
WareHouseID, RequisitionDate, DueDate, IsConfirmed, ConfirmedDate, ConfirmedByID, IsClosed, ClosedDate, ClosedByID,
Description, CreatedByID, CreatedDate, UpdatedByID, UpdatedDate, IsDeleted, IsAsset,DepartmentId) 
                           VALUES (@StkOrganizationUnitID, @WareHouseID, @RequisitionDate, @DueDate, @IsConfirmed, @ConfirmedDate,
@ConfirmedByID, @IsClosed, @ClosedDate, @ClosedByID, @Description, @CreatedByID, @CreatedDate, @UpdatedByID, @UpdatedDate, @IsDeleted, @IsAsset,@DepartmentId)";

               
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {

                        cmd.Parameters.AddWithValue("@StkOrganizationUnitID", -1);
               cmd.Parameters.AddWithValue("@DepartmentId", DepartmentSearchLookUpEdit.EditValue??DBNull.Value);
                        cmd.Parameters.AddWithValue("@WareHouseID", WarehouseSearchLookUpEdit.EditValue);
                       
                        cmd.Parameters.AddWithValue("@RequisitionDate", RequestDateEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@DueDate", DueDateEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@IsConfirmed", ConfirmedCheckEdit.EditValue);
                        cmd.Parameters.AddWithValue("@ConfirmedDate", ConfirmedDateEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ConfirmedByID", ConfirmedBySearchLookUpEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@IsClosed", ClosedCheckEdit.EditValue);
                        cmd.Parameters.AddWithValue("@ClosedDate", ClosedDateEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ClosedByID", ClosedBySearchLookUpEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Description", RequestNoteTextEdit.Text);
                        cmd.Parameters.AddWithValue("@CreatedByID", RequestedbySearchLookUpEdit.EditValue);
                        cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@UpdatedByID", -1);
                        cmd.Parameters.AddWithValue("@UpdatedDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@IsDeleted", false);
                        cmd.Parameters.AddWithValue("@IsAsset", false);
                        
                        string query2 = "Select @@Identity";
                    connection.Open();
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = query2;

                    _Id = Convert.ToInt32(cmd.ExecuteScalar());

                    if (_Id > 0)
                    {

                        CodeTextEdit.Text = ValueListClass.GenerateIndexCode("IR");
                        string query3 = "update StockRequisitionHead set RequestNumber=@RequestNumber where id=@id";
                        cmd.Parameters.AddWithValue("@RequestNumber", CodeTextEdit.Text);
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

            
            string query = @"update  StockRequisitionHead SET StkOrganizationUnitID = @StkOrganizationUnitID, 
WareHouseID = @WareHouseID, RequestNumber = @RequestNumber, RequisitionDate = @RequisitionDate, DueDate = @DueDate, 
                               IsConfirmed = @IsConfirmed, ConfirmedDate = @ConfirmedDate, 
ConfirmedByID = @ConfirmedByID, IsClosed = @IsClosed, ClosedDate = @ClosedDate, ClosedByID = @ClosedByID, 
                               Description = @Description, CreatedByID = @CreatedByID, 
CreatedDate = @CreatedDate, UpdatedByID = @UpdatedByID, UpdatedDate = @UpdatedDate, 
                               IsDeleted = @IsDeleted, IsAsset = @IsAsset ,DepartmentId=@DepartmentId
                           WHERE Id = @Id";

                    //RecievedQuantity
                    using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                        cmd.Parameters.AddWithValue("@DepartmentId", DepartmentSearchLookUpEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@StkOrganizationUnitID", -1);
                        cmd.Parameters.AddWithValue("@WareHouseID", WarehouseSearchLookUpEdit.EditValue);
                        cmd.Parameters.AddWithValue("@RequestNumber", CodeTextEdit.Text);
                        cmd.Parameters.AddWithValue("@RequisitionDate", RequestDateEdit.EditValue ??DBNull.Value);
                        cmd.Parameters.AddWithValue("@DueDate", DueDateEdit.EditValue ?? DBNull.Value) ;
                        cmd.Parameters.AddWithValue("@IsConfirmed", ConfirmedCheckEdit.EditValue);
                        cmd.Parameters.AddWithValue("@ConfirmedDate", ConfirmedDateEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ConfirmedByID", ConfirmedBySearchLookUpEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@IsClosed", ClosedCheckEdit.EditValue);
                        cmd.Parameters.AddWithValue("@ClosedDate", ClosedDateEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ClosedByID", ClosedBySearchLookUpEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Description", RequestNoteTextEdit.Text);
                        cmd.Parameters.AddWithValue("@CreatedByID", RequestedbySearchLookUpEdit.EditValue);
                        cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@UpdatedByID", -1);
                        cmd.Parameters.AddWithValue("@UpdatedDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@IsDeleted", false);
                        cmd.Parameters.AddWithValue("@IsAsset", false);
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
                    string sql = @"select * from StockRequisitionHead where id=@id";
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
                if (RequestedbySearchLookUpEdit.Text.Trim() == "")
                {

                    MessageBox.Show("Request by   Required");
                    RequestedbySearchLookUpEdit.Select();
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

            
            string query = @"INSERT INTO StockRequisitionDetail (FK_RequestNumber, StkRequisitionID, ItemID, ItemName, UnitID, 
                                 QuantityRequest, QuantityDelivered, IsDelivered, DeliveredDate, DeliveredByID, QuantityExisted, 
                                 IsCancelled, CancelledDate, CancelledByID, IsReturned, QuantityReturned, ReturnedDate, 
                                 ReturnReasonID, ReturnedByID, AccpetedQuantity,ItemCode) 
                                 VALUES (@FK_RequestNumber, @StkRequisitionID, @ItemID, @ItemName, @UnitID, @QuantityRequest, 
                                 @QuantityDelivered, @IsDelivered, @DeliveredDate, @DeliveredByID, @QuantityExisted, 
                                 @IsCancelled, @CancelledDate, @CancelledByID, @IsReturned, @QuantityReturned, @ReturnedDate, 
                                 @ReturnReasonID, @ReturnedByID, @AccpetedQuantity,@ItemCode)";


            using (SqlCommand command = new SqlCommand(query, connection))
            {
                        command.Parameters.AddWithValue("@FK_RequestNumber", CodeTextEdit.Text);
                        command.Parameters.AddWithValue("@StkRequisitionID", _Id);
                        command.Parameters.AddWithValue("@ItemID", gridView1.GetRowCellValue(gridView1.FocusedRowHandle, ("Id")));
                        command.Parameters.AddWithValue("@ItemName", ItemSearchLookUpEdit.Text);
                        command.Parameters.AddWithValue("@UnitID", -1);
                        command.Parameters.AddWithValue("@QuantityRequest", QuantityTextEdit.Text);
                        command.Parameters.AddWithValue("@QuantityDelivered", 0);
                        command.Parameters.AddWithValue("@IsDelivered", false);
                        command.Parameters.AddWithValue("@DeliveredDate", DBNull.Value);
                        command.Parameters.AddWithValue("@DeliveredByID", -1);
                        command.Parameters.AddWithValue("@QuantityExisted", 0);
                        command.Parameters.AddWithValue("@IsCancelled", false);
                        command.Parameters.AddWithValue("@CancelledDate", DBNull.Value);
                        command.Parameters.AddWithValue("@CancelledByID", -1);
                        command.Parameters.AddWithValue("@IsReturned", false);
                        command.Parameters.AddWithValue("@QuantityReturned", 0);
                        command.Parameters.AddWithValue("@ReturnedDate", DBNull.Value);
                        command.Parameters.AddWithValue("@ReturnReasonID", -1);
                        command.Parameters.AddWithValue("@ReturnedByID", -1);
                        command.Parameters.AddWithValue("@AccpetedQuantity", 0);
                        command.Parameters.AddWithValue("@ItemCode", ItemSearchLookUpEdit.EditValue);
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
        private bool DeleteItem(int RowId)
        {
            using (SqlConnection connection = new SqlConnection(AAServerCon.GetServerConnection()))
                try
                {


                    string query = @"delete from  StockRequisitionDetail where Id=@ID";

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
                string sql = @"select * from  StockRequisitionDetail where StkRequisitionID=@FK_Id ";
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



                if (ClosedCheckEdit.CheckState == CheckState.Checked)
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
            CodeTextEdit.Select();
            if (WarehouseSearchLookUpEdit.Text.Trim() == "")
            {

                MessageBox.Show("Type  Required");
                WarehouseSearchLookUpEdit.Select();
                return ;


            }
        if (DepartmentSearchLookUpEdit.Text.Trim() == "")
            {

                MessageBox.Show("Department  Required");
                DepartmentSearchLookUpEdit.Select();
                return ;


            }

            if (RequestedbySearchLookUpEdit.Text.Trim() == "")
            {

                MessageBox.Show("Request by   Required");
                RequestedbySearchLookUpEdit.Select();
                return ;


            }
            SaveHead();

            if(ListGridView.RowCount>0)
            {
                //Update Detail
                for(int i = 0;i< ListGridView.RowCount;++i)
                {
                    int Qte = Convert.ToInt32(ListGridView.GetRowCellValue(i, "QuantityRequest"));
                    int rowid = Convert.ToInt32(ListGridView.GetRowCellValue(i, "ID"));
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = AAServerCon.GetServerConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    cmd.CommandText = @"update    StockRequisitionDetail set QuantityRequest=@QuantityRequest where Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", rowid);
                    cmd.Parameters.AddWithValue("@QuantityRequest", Qte);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    
                    


                }

            }
            GetItemList();
            MessageBox.Show("Record Saved");
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

                try
                {
                    //Delete 
                    DialogResult result = XtraMessageBox.Show("Are you Sure Do You Want Delete This Record", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        int _Id = Convert.ToInt32(ListGridView.GetRowCellValue(ListGridView.FocusedRowHandle, "ID"));
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = AAServerCon.GetServerConnection();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.Text;
                        con.Open();
                        cmd.CommandText = @"delete from  StockRequisitionDetail  where Id=@Id";
                        cmd.Parameters.AddWithValue("@Id", _Id);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        XtraMessageBox.Show("Record Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetItemList();
                    }
                    else
                    {
                        //XtraMessageBox.Show("Record cant be delete because its in use in another tables", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error :" + ex.Message);
                }

               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}