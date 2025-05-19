using DevExpress.DataProcessing.InMemoryDataProcessor;
using DevExpress.Office.Utils;
using DevExpress.Pdf.Native.BouncyCastle.Utilities.Collections;
using DevExpress.PivotGrid.OLAP.Mdx;
using DevExpress.Xpo.DB.Helpers;
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
    public partial class StockRequestDeliveryForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public StockRequestDeliveryForm()
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
            fromWarehouseIDSpinEdit.Properties.DataSource = ValueListClass.GetFullList("VLRequestType");
            fromWarehouseIDSpinEdit.Properties.ValueMember = "Id";
            fromWarehouseIDSpinEdit.Properties.DisplayMember = "Name";

            //Users
            //RequestedbySearchLookUpEdit
            createdByIDSpinEdit.Properties.DataSource = ValueListClass.GetUsers();
            createdByIDSpinEdit.Properties.ValueMember = "Id";
            createdByIDSpinEdit.Properties.DisplayMember = "Name";




            //DivisionSearchLookUpEdit
            departmentIDSpinEdit.Properties.DataSource = ValueListClass.GetFullList("VLDepartment");
            departmentIDSpinEdit.Properties.ValueMember = "Id";
            departmentIDSpinEdit.Properties.DisplayMember = "Name";


            //RequestedbySearchLookUpEdit
            //ApprovedBySearchLookUpEdit.Properties.DataSource = ValueListClass.GetUsers();
            //ApprovedBySearchLookUpEdit.Properties.ValueMember = "Id";
            //ApprovedBySearchLookUpEdit.Properties.DisplayMember = "Name";;
            ////RejectedBySearchLookUpEdit
            //RejectedBySearchLookUpEdit.Properties.DataSource = ValueListClass.GetUsers();
            //RejectedBySearchLookUpEdit.Properties.ValueMember = "Id";
            //RejectedBySearchLookUpEdit.Properties.DisplayMember = "Name";
            //ClosedBySearchLookUpEdit


            //Confirmed By
            approvedByIDSpinEdit.Properties.DataSource = ValueListClass.GetUsers();
            approvedByIDSpinEdit.Properties.ValueMember = "Id";
            approvedByIDSpinEdit.Properties.DisplayMember = "Name";


            //Units
            unitIDSpinEdit.Properties.DataSource = ValueListClass.GetFullList("VLUnits");
            unitIDSpinEdit.Properties.ValueMember = "Id";
            unitIDSpinEdit.Properties.DisplayMember = "Name";
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
                deliveryDateDateEdit.EditValue=DateTime.Now;

                isApprovedCheckEdit.CheckState = CheckState.Unchecked;
              
            }
            else
            {

                //Load head 
                Gethead();
                idSpinEdit.EditValue=_Id;
                 CodeTextEdit.Text=HeadDataTable.Rows[0]["SerialNumber"].ToString();
                 requisitionIDSpinEdit.EditValue = HeadDataTable.Rows[0]["RequisitionID"].ToString();
                   requisitionCodeTextEdit.Text = HeadDataTable.Rows[0]["RequisitionCode"].ToString();
               fromWarehouseIDSpinEdit.EditValue =HeadDataTable.Rows[0]["FromWarehouseID"].ToString();
                  departmentIDSpinEdit.EditValue =HeadDataTable.Rows[0]["DepartmentID"].ToString();
                  deliveryDateDateEdit.EditValue =HeadDataTable.Rows[0]["DeliveryDate"].ToString();
               
                 createdByIDSpinEdit.EditValue =HeadDataTable.Rows[0]["CreatedByID"].ToString();
       
             
                  isApprovedCheckEdit.EditValue =HeadDataTable.Rows[0]["IsApproved"].ToString();
                 approvedByIDSpinEdit.EditValue =HeadDataTable.Rows[0]["ApprovedByID"].ToString();
                   approvedDateDateEdit.EditValue =HeadDataTable.Rows[0]["ApprovedDate"].ToString();
               



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
                {
                    string query = @"INSERT INTO StockRequisitionDeliveryHead(RequisitionID, RequisitionCode, FromWarehouseID, DepartmentID, DeliveryDate, CreatedDate, CreatedByID, UpdatedByID, UpdatedDate, IsApproved, ApprovedByID, ApprovedDate, IsPosted, PostedByID, PostedDate)
                             VALUES(@RequisitionID, @RequisitionCode, @FromWarehouseID, @DepartmentID, @DeliveryDate, @CreatedDate, @CreatedByID, 
                    @UpdatedByID, @UpdatedDate, @IsApproved, @ApprovedByID, @ApprovedDate, @IsPosted, @PostedByID, @PostedDate)";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    
                    cmd.Parameters.AddWithValue("@RequisitionID", requisitionIDSpinEdit.EditValue ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@RequisitionCode", requisitionCodeTextEdit.Text);
                    cmd.Parameters.AddWithValue("@FromWarehouseID", fromWarehouseIDSpinEdit.EditValue ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@DepartmentID", departmentIDSpinEdit.EditValue ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@DeliveryDate", deliveryDateDateEdit.EditValue ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@CreatedByID", createdByIDSpinEdit.EditValue ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@UpdatedByID", createdByIDSpinEdit.EditValue ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@UpdatedDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@IsApproved", isApprovedCheckEdit.EditValue ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@ApprovedByID", approvedByIDSpinEdit.EditValue ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@ApprovedDate", approvedDateDateEdit.EditValue ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@IsPosted", false);
                    cmd.Parameters.AddWithValue("@PostedByID", -1);
                    cmd.Parameters.AddWithValue("@PostedDate", DBNull.Value);

                    string query2 = "Select @@Identity";
                    connection.Open();
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = query2;

                    _Id = Convert.ToInt32(cmd.ExecuteScalar());

                    if (_Id > 0)
                    {

                        CodeTextEdit.Text = ValueListClass.GenerateIndexCode("SD");
                        string query3 = "update StockRequisitionDeliveryHead set SerialNumber=@SerialNumber where id=@id";
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

            
            string query = @"UPDATE StockRequisitionDeliveryHead 
                             SET SerialNumber = @SerialNumber,
RequisitionID = @RequisitionID, RequisitionCode = @RequisitionCode, 
FromWarehouseID = @FromWarehouseID, DepartmentID = @DepartmentID, DeliveryDate = @DeliveryDate, CreatedDate = @CreatedDate, CreatedByID = @CreatedByID, UpdatedByID = @UpdatedByID, UpdatedDate = @UpdatedDate, IsApproved = @IsApproved, ApprovedByID = @ApprovedByID, ApprovedDate = @ApprovedDate, IsPosted = @IsPosted, PostedByID = @PostedByID, PostedDate = @PostedDate 
                             WHERE Id = @Id"; ;

                    //RecievedQuantity
                    using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                       
                        cmd.Parameters.AddWithValue("@SerialNumber", CodeTextEdit.Text);
                        cmd.Parameters.AddWithValue("@RequisitionID", requisitionIDSpinEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@RequisitionCode", requisitionCodeTextEdit.Text);
                        cmd.Parameters.AddWithValue("@FromWarehouseID", fromWarehouseIDSpinEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@DepartmentID", departmentIDSpinEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@DeliveryDate", deliveryDateDateEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@CreatedByID", createdByIDSpinEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@UpdatedByID", createdByIDSpinEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@UpdatedDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@IsApproved", isApprovedCheckEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ApprovedByID", approvedByIDSpinEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ApprovedDate", approvedDateDateEdit.EditValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@IsPosted", false);
                        cmd.Parameters.AddWithValue("@PostedByID", -1);
                        cmd.Parameters.AddWithValue("@PostedDate", DBNull.Value);

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
                    string sql = @"select * from StockRequisitionDeliveryHead where id=@id";
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
                if (fromWarehouseIDSpinEdit.Text.Trim() == "")
                {

                    MessageBox.Show("Type  Required");
                    fromWarehouseIDSpinEdit.Select();
                    return false;


                }
                if (departmentIDSpinEdit.Text.Trim() == "")
                {

                    MessageBox.Show("Department Required");
                    departmentIDSpinEdit.Select();
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

                        CodeTextEdit.Text = ValueListClass.GenerateIndexCode("SD");
                        string query3 = "update StockRequisitionDeliveryHead set SerialNumber=@SerialNumber where id=@id";
                        cmd.Parameters.AddWithValue("@SerialNumber", CodeTextEdit.Text);
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
            {
                try
                {


                    string query = @"INSERT INTO StockRequisitionDeliveryDetail (FK_ID, FK_SerialNumber, RequestedItemID, ItemId, UnitID, DeliveryQuantity, PreparedQuantity, StkCostCenterID, IsCancelled, CancelledDate, CancelledByID, IsAcceptedReturned, AcceptedReturnedByID, AcceptedReturnedQuantity, AcceptedReturnedDate, ItemName, ItemCode) 
                         VALUES (@FK_ID, @FK_SerialNumber, @RequestedItemID, @ItemId, @UnitID, @DeliveryQuantity, @PreparedQuantity, @StkCostCenterID, @IsCancelled, @CancelledDate, @CancelledByID, @IsAcceptedReturned, @AcceptedReturnedByID, @AcceptedReturnedQuantity, @AcceptedReturnedDate, @ItemName, @ItemCode)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FK_ID", _Id);
                    command.Parameters.AddWithValue("@FK_SerialNumber", CodeTextEdit.Text);
                    command.Parameters.AddWithValue("@RequestedItemID", requisitionIDSpinEdit.EditValue ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ItemId", gridView1.GetRowCellValue(gridView1.FocusedRowHandle, ("Id")));
                    command.Parameters.AddWithValue("@UnitID", unitIDSpinEdit.EditValue ?? DBNull.Value);
                    command.Parameters.AddWithValue("@DeliveryQuantity", deliveryQuantityTextEdit.EditValue ?? DBNull.Value);
                    command.Parameters.AddWithValue("@PreparedQuantity", 0);
                    command.Parameters.AddWithValue("@StkCostCenterID", 0);
                    command.Parameters.AddWithValue("@IsCancelled", false);
                    command.Parameters.AddWithValue("@CancelledDate", DBNull.Value);
                    command.Parameters.AddWithValue("@CancelledByID", DBNull.Value);
                    command.Parameters.AddWithValue("@IsAcceptedReturned", false);
                    command.Parameters.AddWithValue("@AcceptedReturnedByID", DBNull.Value);
                    command.Parameters.AddWithValue("@AcceptedReturnedQuantity", DBNull.Value);
                    command.Parameters.AddWithValue("@AcceptedReturnedDate", DBNull.Value);
                    command.Parameters.AddWithValue("@ItemName", ItemSearchLookUpEdit.Text);
                    command.Parameters.AddWithValue("@ItemCode", ItemSearchLookUpEdit.EditValue);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return false;
                    }
                    return true;
                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    return false;
                }

            }
        }
        private bool DeleteItem(int RowId)
        {
            using (SqlConnection connection = new SqlConnection(AAServerCon.GetServerConnection()))
                try
                {


                    string query = @"delete from  PurchaseRequestDetail where Id=@ID";

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
                string sql = @"select * from  StockRequisitionDeliveryDetail where FK_ID=@FK_Id ";
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



                //if (ClosedCheckEdit.CheckState == CheckState.Checked)
                //{
                //    MessageBox.Show("Request Closed");
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

                    SaveItem();
                    GetItemList();
                    deliveryQuantityTextEdit.EditValue = 1;
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


            if (fromWarehouseIDSpinEdit.Text.Trim() == "")
            {

                MessageBox.Show("From Warehouse  Required");
                fromWarehouseIDSpinEdit.Select();
                return ;


            }
            if (departmentIDSpinEdit.Text.Trim() == "")
            {

                MessageBox.Show("Department Required");
                departmentIDSpinEdit.Select();
                return ;


            }
            SaveHead();

            if (ListGridView.RowCount > 0)
            {
                //Update Detail
                for (int i = 0; i < ListGridView.RowCount; ++i)
                {
                    int Qte = Convert.ToInt32(ListGridView.GetRowCellValue(i, "DeliveryQuantity"));
                    int rowid = Convert.ToInt32(ListGridView.GetRowCellValue(i, "ID"));
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = AAServerCon.GetServerConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    cmd.CommandText = @"update    StockRequisitionDeliveryDetail set DeliveryQuantity=@DeliveryQuantity where Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", rowid);
                    cmd.Parameters.AddWithValue("@DeliveryQuantity", Qte);
                    cmd.ExecuteNonQuery();
                    con.Close();




                }

            }
            GetItemList();
            MessageBox.Show("Record Saved");

            //save Detail
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
                //if (ClosedCheckEdit.CheckState==CheckState.Checked)
                //{
                //    MessageBox.Show("Request Closed");
                //    return;
                //}
                //else
                //{
                //    //Delete 

                //    DeleteItem(Convert.ToInt32(ListGridView.GetRowCellValue(ListGridView.FocusedRowHandle, "Id")));

                //    GetItemList();
                //}
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void repositoryItemButtonEdit1_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
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
                    cmd.CommandText = @"delete from  StockRequisitionDeliveryDetail  where Id=@Id";
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
    }
}