using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using System.Data.SqlClient;
namespace StockManagment.Models
{
 

    public class StockWasteDetail
    {
        public int Id { get; set; }
        public int? UnitID { get; set; }
        public int? ItemID { get; set; }
        public int? WasteID { get; set; }
        public double? Price { get; set; }
        public double? Quantity { get; set; }
        public double? TotalAmount { get; set; }
        public int? CurrencyID { get; set; }
        public double? LocalAmount { get; set; }
        public double? ForeignAmount { get; set; }
        public double? AvailableQuantityOnHand { get; set; }
        public string Notes { get; set; }
        public int? CreatedByID { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedByID { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string ItemCode { get; set; }
        public string ItemDetail { get; set; }
    }


public class StockWasteDetailRepository
    {
        private string connectionString;

        public StockWasteDetailRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public int Create(StockWasteDetail wasteDetail)
        {
            int newId = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                    INSERT INTO StockWasteDetail 
                    (UnitID, ItemID, WasteID, Price, Quantity, TotalAmount, CurrencyID, LocalAmount, ForeignAmount, AvailableQuantityOnHand,
                    Notes, CreatedByID, CreatedDate, UpdatedByID, UpdatedDate, ItemCode, ItemDetail)
                    VALUES 
                    (@UnitID, @ItemID, @WasteID, @Price, @Quantity, @TotalAmount, @CurrencyID, @LocalAmount, @ForeignAmount, @AvailableQuantityOnHand,
                    @Notes, @CreatedByID, @CreatedDate, @UpdatedByID, @UpdatedDate, @ItemCode, @ItemDetail);
                    SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UnitID", (object)wasteDetail.UnitID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ItemID", (object)wasteDetail.ItemID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@WasteID", (object)wasteDetail.WasteID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Price", (object)wasteDetail.Price ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Quantity", (object)wasteDetail.Quantity ?? DBNull.Value);
                        command.Parameters.AddWithValue("@TotalAmount", (object)wasteDetail.TotalAmount ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CurrencyID", (object)wasteDetail.CurrencyID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@LocalAmount", (object)wasteDetail.LocalAmount ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ForeignAmount", (object)wasteDetail.ForeignAmount ?? DBNull.Value);
                        command.Parameters.AddWithValue("@AvailableQuantityOnHand", (object)wasteDetail.AvailableQuantityOnHand ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Notes", (object)wasteDetail.Notes ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedByID", (object)wasteDetail.CreatedByID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedDate", (object)wasteDetail.CreatedDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@UpdatedByID", (object)wasteDetail.UpdatedByID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@UpdatedDate", (object)wasteDetail.UpdatedDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ItemCode", (object)wasteDetail.ItemCode ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ItemDetail", (object)wasteDetail.ItemDetail ?? DBNull.Value);

                        newId = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while creating stock waste detail: " + ex.Message);
            }
            return newId;
        }

        public StockWasteDetail GetById(int id)
        {
            StockWasteDetail wasteDetail = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM StockWasteDetail WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                wasteDetail = MapStockWasteDetail(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving stock waste detail: " + ex.Message);
            }
            return wasteDetail;
        }

        public void Update(StockWasteDetail wasteDetail)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                    UPDATE StockWasteDetail 
                    SET UnitID = @UnitID, ItemID = @ItemID, WasteID = @WasteID, Price = @Price, Quantity = @Quantity, 
                    TotalAmount = @TotalAmount, CurrencyID = @CurrencyID, LocalAmount = @LocalAmount, ForeignAmount = @ForeignAmount,
                    AvailableQuantityOnHand = @AvailableQuantityOnHand, Notes = @Notes, CreatedByID = @CreatedByID, CreatedDate = @CreatedDate, 
                    UpdatedByID = @UpdatedByID, UpdatedDate = @UpdatedDate, ItemCode = @ItemCode, ItemDetail = @ItemDetail
                    WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UnitID", (object)wasteDetail.UnitID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ItemID", (object)wasteDetail.ItemID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@WasteID", (object)wasteDetail.WasteID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Price", (object)wasteDetail.Price ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Quantity", (object)wasteDetail.Quantity ?? DBNull.Value);
                        command.Parameters.AddWithValue("@TotalAmount", (object)wasteDetail.TotalAmount ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CurrencyID", (object)wasteDetail.CurrencyID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@LocalAmount", (object)wasteDetail.LocalAmount ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ForeignAmount", (object)wasteDetail.ForeignAmount ?? DBNull.Value);
                        command.Parameters.AddWithValue("@AvailableQuantityOnHand", (object)wasteDetail.AvailableQuantityOnHand ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Notes", (object)wasteDetail.Notes ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedByID", (object)wasteDetail.CreatedByID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedDate", (object)wasteDetail.CreatedDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@UpdatedByID", (object)wasteDetail.UpdatedByID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@UpdatedDate", (object)wasteDetail.UpdatedDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ItemCode", (object)wasteDetail.ItemCode ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ItemDetail", (object)wasteDetail.ItemDetail ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Id", wasteDetail.Id);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while updating stock waste detail: " + ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM StockWasteDetail WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while deleting stock waste detail: " + ex.Message);
            }
        }

        private StockWasteDetail MapStockWasteDetail(SqlDataReader reader)
        {
            return new StockWasteDetail
            {
                Id = (int)reader["Id"],
                UnitID = reader["UnitID"] != DBNull.Value ? (int)reader["UnitID"] : (int?)null,
                ItemID = reader["ItemID"] != DBNull.Value ? (int)reader["ItemID"] : (int?)null,
                WasteID = reader["WasteID"] != DBNull.Value ? (int)reader["WasteID"] : (int?)null,
                Price = reader["Price"] != DBNull.Value ? (double)reader["Price"] : (double?)null,
                Quantity = reader["Quantity"] != DBNull.Value ? (double)reader["Quantity"] : (double?)null,
                TotalAmount = reader["TotalAmount"] != DBNull.Value ? (double)reader["TotalAmount"] : (double?)null,
                CurrencyID = reader["CurrencyID"] != DBNull.Value ? (int)reader["CurrencyID"] : (int?)null,
                LocalAmount = reader["LocalAmount"] != DBNull.Value ? (double)reader["LocalAmount"] : (double?)null,
                ForeignAmount = reader["ForeignAmount"] != DBNull.Value ? (double)reader["ForeignAmount"] : (double?)null,
                AvailableQuantityOnHand = reader["AvailableQuantityOnHand"] != DBNull.Value ? (double)reader["AvailableQuantityOnHand"] : (double?)null,
                Notes = reader["Notes"] != DBNull.Value ? (string)reader["Notes"] : null,
                CreatedByID = reader["CreatedByID"] != DBNull.Value ? (int)reader["CreatedByID"] : (int?)null,
                CreatedDate = reader["CreatedDate"] != DBNull.Value ? (DateTime)reader["CreatedDate"] : (DateTime?)null,
                UpdatedByID = reader["UpdatedByID"] != DBNull.Value ? (int)reader["UpdatedByID"] : (int?)null,
                UpdatedDate = reader["UpdatedDate"] != DBNull.Value ? (DateTime)reader["UpdatedDate"] : (DateTime?)null,
                ItemCode = reader["ItemCode"] != DBNull.Value ? (string)reader["ItemCode"] : null,
                ItemDetail = reader["ItemDetail"] != DBNull.Value ? (string)reader["ItemDetail"] : null
            };
        }
    }





}
