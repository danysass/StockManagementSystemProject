using System;
using System.Data.SqlClient;
namespace StockManagment.Models
{
    public class StockCountHead
    {
        public int Id { get; set; }
        public string SerialNumber { get; set; }
        public int? WareHouseID { get; set; }
        public DateTime? CountDate { get; set; }
        public double? TotalCountQty { get; set; }
        public double? TotalAvailableQty { get; set; }
        public double? TotalAmount { get; set; }
        public int? CurrencyID { get; set; }
        public double? ForeignAmount { get; set; }
        public double? LocalAmount { get; set; }
        public string Notes { get; set; }
        public string PreparedBy { get; set; }
        public int? CreatedByID { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedByID { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsConfirmed { get; set; }
        public int? ConfirmedByID { get; set; }
        public DateTime? ConfirmedDate { get; set; }
        public bool? IsApproved { get; set; }
        public int? ApprovedByID { get; set; }
        public DateTime? ApprovedDate { get; set; }

    }


public class StockCountHeadRepository
    {
        private string connectionString;

  

        public int Create(StockCountHead stockCountHead)
        {
            int newId = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

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

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SerialNumber", (object)stockCountHead.SerialNumber ?? DBNull.Value);
                        command.Parameters.AddWithValue("@WareHouseID", (object)stockCountHead.WareHouseID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CountDate", (object)stockCountHead.CountDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@TotalCountQty", (object)stockCountHead.TotalCountQty ?? DBNull.Value);
                        command.Parameters.AddWithValue("@TotalAvailableQty", (object)stockCountHead.TotalAvailableQty ?? DBNull.Value);
                        command.Parameters.AddWithValue("@TotalAmount", (object)stockCountHead.TotalAmount ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CurrencyID", (object)stockCountHead.CurrencyID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ForeignAmount", (object)stockCountHead.ForeignAmount ?? DBNull.Value);
                        command.Parameters.AddWithValue("@LocalAmount", (object)stockCountHead.LocalAmount ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Notes", (object)stockCountHead.Notes ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PreparedBy", (object)stockCountHead.PreparedBy ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedByID", (object)stockCountHead.CreatedByID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedDate", (object)stockCountHead.CreatedDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@UpdatedByID", (object)stockCountHead.UpdatedByID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@UpdatedDate", (object)stockCountHead.UpdatedDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@IsConfirmed", (object)stockCountHead.IsConfirmed ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ConfirmedByID", (object)stockCountHead.ConfirmedByID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ConfirmedDate", (object)stockCountHead.ConfirmedDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@IsApproved", (object)stockCountHead.IsApproved ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ApprovedByID", (object)stockCountHead.ApprovedByID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ApprovedDate", (object)stockCountHead.ApprovedDate ?? DBNull.Value);

                        newId = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while creating stock count head: " + ex.Message);
            }
            return newId;
        }

        public StockCountHead GetById(int id)
        {
            StockCountHead stockCountHead = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM StockCountHead WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                stockCountHead = MapStockCountHead(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving stock count head: " + ex.Message);
            }
            return stockCountHead;
        }

        public void Update(StockCountHead stockCountHead)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                    UPDATE StockCountHead 
                    SET SerialNumber = @SerialNumber, WareHouseID = @WareHouseID, CountDate = @CountDate, 
                    TotalCountQty = @TotalCountQty, TotalAvailableQty = @TotalAvailableQty, TotalAmount = @TotalAmount, 
                    CurrencyID = @CurrencyID, ForeignAmount = @ForeignAmount, LocalAmount = @LocalAmount, 
                    Notes = @Notes, PreparedBy = @PreparedBy, CreatedByID = @CreatedByID, CreatedDate = @CreatedDate, 
                    UpdatedByID = @UpdatedByID, UpdatedDate = @UpdatedDate, IsConfirmed = @IsConfirmed, 
                    ConfirmedByID = @ConfirmedByID, ConfirmedDate = @ConfirmedDate, IsApproved = @IsApproved, 
                    ApprovedByID = @ApprovedByID, ApprovedDate = @ApprovedDate
                    WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SerialNumber", (object)stockCountHead.SerialNumber ?? DBNull.Value);
                        command.Parameters.AddWithValue("@WareHouseID", (object)stockCountHead.WareHouseID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CountDate", (object)stockCountHead.CountDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@TotalCountQty", (object)stockCountHead.TotalCountQty ?? DBNull.Value);
                        command.Parameters.AddWithValue("@TotalAvailableQty", (object)stockCountHead.TotalAvailableQty ?? DBNull.Value);
                        command.Parameters.AddWithValue("@TotalAmount", (object)stockCountHead.TotalAmount ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CurrencyID", (object)stockCountHead.CurrencyID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ForeignAmount", (object)stockCountHead.ForeignAmount ?? DBNull.Value);
                        command.Parameters.AddWithValue("@LocalAmount", (object)stockCountHead.LocalAmount ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Notes", (object)stockCountHead.Notes ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PreparedBy", (object)stockCountHead.PreparedBy ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedByID", (object)stockCountHead.CreatedByID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedDate", (object)stockCountHead.CreatedDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@UpdatedByID", (object)stockCountHead.UpdatedByID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@UpdatedDate", (object)stockCountHead.UpdatedDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@IsConfirmed", (object)stockCountHead.IsConfirmed ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ConfirmedByID", (object)stockCountHead.ConfirmedByID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ConfirmedDate", (object)stockCountHead.ConfirmedDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@IsApproved", (object)stockCountHead.IsApproved ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ApprovedByID", (object)stockCountHead.ApprovedByID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ApprovedDate", (object)stockCountHead.ApprovedDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Id", stockCountHead.Id);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while updating stock count head: " + ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM StockCountHead WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while deleting stock count head: " + ex.Message);
            }
        }

        private StockCountHead MapStockCountHead(SqlDataReader reader)
        {
            return new StockCountHead
            {
                Id = (int)reader["Id"],
                SerialNumber = reader["SerialNumber"] != DBNull.Value ? (string)reader["SerialNumber"] : null,
                WareHouseID = reader["WareHouseID"] != DBNull.Value ? (int)reader["WareHouseID"] : (int?)null,
                CountDate = reader["CountDate"] != DBNull.Value ? (DateTime)reader["CountDate"] : (DateTime?)null,
                TotalCountQty = reader["TotalCountQty"] != DBNull.Value ? (double)reader["TotalCountQty"] : (double?)null,
                TotalAvailableQty = reader["TotalAvailableQty"] != DBNull.Value ? (double)reader["TotalAvailableQty"] : (double?)null,
                TotalAmount = reader["TotalAmount"] != DBNull.Value ? (double)reader["TotalAmount"] : (double?)null,
                CurrencyID = reader["CurrencyID"] != DBNull.Value ? (int)reader["CurrencyID"] : (int?)null,
                ForeignAmount = reader["ForeignAmount"] != DBNull.Value ? (double)reader["ForeignAmount"] : (double?)null,
                LocalAmount = reader["LocalAmount"] != DBNull.Value ? (double)reader["LocalAmount"] : (double?)null,
                Notes = reader["Notes"] != DBNull.Value ? (string)reader["Notes"] : null,
                PreparedBy = reader["PreparedBy"] != DBNull.Value ? (string)reader["PreparedBy"] : null,
                CreatedByID = reader["CreatedByID"] != DBNull.Value ? (int)reader["CreatedByID"] : (int?)null,
                CreatedDate = reader["CreatedDate"] != DBNull.Value ? (DateTime)reader["CreatedDate"] : (DateTime?)null,
                UpdatedByID = reader["UpdatedByID"] != DBNull.Value ? (int)reader["UpdatedByID"] : (int?)null,
                UpdatedDate = reader["UpdatedDate"] != DBNull.Value ? (DateTime)reader["UpdatedDate"] : (DateTime?)null,
                IsConfirmed = reader["IsConfirmed"] != DBNull.Value ? (bool)reader["IsConfirmed"] : (bool?)null,
                ConfirmedByID = reader["ConfirmedByID"] != DBNull.Value ? (int)reader["ConfirmedByID"] : (int?)null,
                ConfirmedDate = reader["ConfirmedDate"] != DBNull.Value ? (DateTime)reader["ConfirmedDate"] : (DateTime?)null,
                IsApproved = reader["IsApproved"] != DBNull.Value ? (bool)reader["IsApproved"] : (bool?)null,
                ApprovedByID = reader["ApprovedByID"] != DBNull.Value ? (int)reader["ApprovedByID"] : (int?)null,
                ApprovedDate = reader["ApprovedDate"] != DBNull.Value ? (DateTime)reader["ApprovedDate"] : (DateTime?)null
            };
        }
    }

}
