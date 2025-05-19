using System;
using System.Data;
using System.Data.SqlClient;

public class StockRequisitionDeliveryHead
{
    private string connectionString;

    public StockRequisitionDeliveryHead(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public void InsertStockRequisitionDeliveryHead(string serialNumber, int? requisitionID, string requisitionCode, int? fromWarehouseID, int? departmentID, DateTime? deliveryDate, DateTime? createdDate, int? createdByID, int? updatedByID, DateTime? updatedDate, bool? isApproved, int? approvedByID, DateTime? approvedDate, bool? isPosted, int? postedByID, DateTime? postedDate)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = @"INSERT INTO StockRequisitionDeliveryHead (SerialNumber, RequisitionID, RequisitionCode, FromWarehouseID, DepartmentID, DeliveryDate, CreatedDate, CreatedByID, UpdatedByID, UpdatedDate, IsApproved, ApprovedByID, ApprovedDate, IsPosted, PostedByID, PostedDate)
                             VALUES (@SerialNumber, @RequisitionID, @RequisitionCode, @FromWarehouseID, @DepartmentID, @DeliveryDate, @CreatedDate, @CreatedByID, @UpdatedByID, @UpdatedDate, @IsApproved, @ApprovedByID, @ApprovedDate, @IsPosted, @PostedByID, @PostedDate)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SerialNumber", serialNumber);
            command.Parameters.AddWithValue("@RequisitionID", (object)requisitionID ?? DBNull.Value);
            command.Parameters.AddWithValue("@RequisitionCode", requisitionCode);
            command.Parameters.AddWithValue("@FromWarehouseID", (object)fromWarehouseID ?? DBNull.Value);
            command.Parameters.AddWithValue("@DepartmentID", (object)departmentID ?? DBNull.Value);
            command.Parameters.AddWithValue("@DeliveryDate", (object)deliveryDate ?? DBNull.Value);
            command.Parameters.AddWithValue("@CreatedDate", (object)createdDate ?? DBNull.Value);
            command.Parameters.AddWithValue("@CreatedByID", (object)createdByID ?? DBNull.Value);
            command.Parameters.AddWithValue("@UpdatedByID", (object)updatedByID ?? DBNull.Value);
            command.Parameters.AddWithValue("@UpdatedDate", (object)updatedDate ?? DBNull.Value);
            command.Parameters.AddWithValue("@IsApproved", (object)isApproved ?? DBNull.Value);
            command.Parameters.AddWithValue("@ApprovedByID", (object)approvedByID ?? DBNull.Value);
            command.Parameters.AddWithValue("@ApprovedDate", (object)approvedDate ?? DBNull.Value);
            command.Parameters.AddWithValue("@IsPosted", (object)isPosted ?? DBNull.Value);
            command.Parameters.AddWithValue("@PostedByID", (object)postedByID ?? DBNull.Value);
            command.Parameters.AddWithValue("@PostedDate", (object)postedDate ?? DBNull.Value);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }

    public void UpdateStockRequisitionDeliveryHead(int id, string serialNumber, int? requisitionID, string requisitionCode, int? fromWarehouseID, int? departmentID, DateTime? deliveryDate, DateTime? createdDate, int? createdByID, int? updatedByID, DateTime? updatedDate, bool? isApproved, int? approvedByID, DateTime? approvedDate, bool? isPosted, int? postedByID, DateTime? postedDate)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = @"UPDATE StockRequisitionDeliveryHead 
                             SET SerialNumber = @SerialNumber, RequisitionID = @RequisitionID, RequisitionCode = @RequisitionCode, FromWarehouseID = @FromWarehouseID, DepartmentID = @DepartmentID, DeliveryDate = @DeliveryDate, CreatedDate = @CreatedDate, CreatedByID = @CreatedByID, UpdatedByID = @UpdatedByID, UpdatedDate = @UpdatedDate, IsApproved = @IsApproved, ApprovedByID = @ApprovedByID, ApprovedDate = @ApprovedDate, IsPosted = @IsPosted, PostedByID = @PostedByID, PostedDate = @PostedDate 
                             WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@SerialNumber", serialNumber);
            command.Parameters.AddWithValue("@RequisitionID", (object)requisitionID ?? DBNull.Value);
            command.Parameters.AddWithValue("@RequisitionCode", requisitionCode);
            command.Parameters.AddWithValue("@FromWarehouseID", (object)fromWarehouseID ?? DBNull.Value);
            command.Parameters.AddWithValue("@DepartmentID", (object)departmentID ?? DBNull.Value);
            command.Parameters.AddWithValue("@DeliveryDate", (object)deliveryDate ?? DBNull.Value);
            command.Parameters.AddWithValue("@CreatedDate", (object)createdDate ?? DBNull.Value);
            command.Parameters.AddWithValue("@CreatedByID", (object)createdByID ?? DBNull.Value);
            command.Parameters.AddWithValue("@UpdatedByID", (object)updatedByID ?? DBNull.Value);
            command.Parameters.AddWithValue("@UpdatedDate", (object)updatedDate ?? DBNull.Value);
            command.Parameters.AddWithValue("@IsApproved", (object)isApproved ?? DBNull.Value);
            command.Parameters.AddWithValue("@ApprovedByID", (object)approvedByID ?? DBNull.Value);
            command.Parameters.AddWithValue("@ApprovedDate", (object)approvedDate ?? DBNull.Value);
            command.Parameters.AddWithValue("@IsPosted", (object)isPosted ?? DBNull.Value);
            command.Parameters.AddWithValue("@PostedByID", (object)postedByID ?? DBNull.Value);
            command.Parameters.AddWithValue("@PostedDate", (object)postedDate ?? DBNull.Value);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }

    public void DeleteStockRequisitionDeliveryHead(int id)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = @"DELETE FROM StockRequisitionDeliveryHead WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }

    public DataTable SelectAllStockRequisitionDeliveryHead()
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = @"SELECT * FROM StockRequisitionDeliveryHead";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            try
            {
                connection.Open();
                adapter.Fill(dt);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        return dt;
    }
}
