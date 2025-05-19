using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagment.Models
{
    using System;
    using System.Data;
    using System.Data.SqlClient;

    public class StockTransferDetailRepository
    {
        private readonly string connectionString;

        public StockTransferDetailRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Create(StockTransferDetail stockTransferDetail)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"INSERT INTO StockTransferDetail (StkTransferID, ItemID, UnitID, Quantity, CurrencyID,
                                TotalAmount, LocalAmount, ForeignAmount, ACU, CostPrice, CostCurrencyID, LocalCostPrice,
                                ForeignCostPrice, CreatedByID, CreatedDate, UpdatedByID, UpdatedDate)
                             VALUES (@StkTransferID, @ItemID, @UnitID, @Quantity, @CurrencyID, @TotalAmount, @LocalAmount,
                                @ForeignAmount, @ACU, @CostPrice, @CostCurrencyID, @LocalCostPrice, @ForeignCostPrice,
                                @CreatedByID, @CreatedDate, @UpdatedByID, @UpdatedDate)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StkTransferID", stockTransferDetail.StkTransferID);
                    command.Parameters.AddWithValue("@ItemID", stockTransferDetail.ItemID);
                    command.Parameters.AddWithValue("@UnitID", stockTransferDetail.UnitID);
                    command.Parameters.AddWithValue("@Quantity", stockTransferDetail.Quantity);
                    command.Parameters.AddWithValue("@CurrencyID", stockTransferDetail.CurrencyID);
                    command.Parameters.AddWithValue("@TotalAmount", stockTransferDetail.TotalAmount);
                    command.Parameters.AddWithValue("@LocalAmount", stockTransferDetail.LocalAmount);
                    command.Parameters.AddWithValue("@ForeignAmount", stockTransferDetail.ForeignAmount);
                    command.Parameters.AddWithValue("@ACU", stockTransferDetail.ACU);
                    command.Parameters.AddWithValue("@CostPrice", stockTransferDetail.CostPrice);
                    command.Parameters.AddWithValue("@CostCurrencyID", stockTransferDetail.CostCurrencyID);
                    command.Parameters.AddWithValue("@LocalCostPrice", stockTransferDetail.LocalCostPrice);
                    command.Parameters.AddWithValue("@ForeignCostPrice", stockTransferDetail.ForeignCostPrice);
                    command.Parameters.AddWithValue("@CreatedByID", stockTransferDetail.CreatedByID);
                    command.Parameters.AddWithValue("@CreatedDate", stockTransferDetail.CreatedDate);
                    command.Parameters.AddWithValue("@UpdatedByID", stockTransferDetail.UpdatedByID);
                    command.Parameters.AddWithValue("@UpdatedDate", stockTransferDetail.UpdatedDate);
                    command.ExecuteNonQuery();
                }
            }
        }

        public StockTransferDetail Read(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM StockTransferDetail WHERE ID = @ID";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new StockTransferDetail
                            {
                                ID = reader.GetInt32(reader.GetOrdinal("ID")),
                                StkTransferID = reader.IsDBNull(reader.GetOrdinal("StkTransferID")) ? null : (int?)reader.GetInt32(reader.GetOrdinal("StkTransferID")),
                                ItemID = reader.IsDBNull(reader.GetOrdinal("ItemID")) ? null : (int?)reader.GetInt32(reader.GetOrdinal("ItemID")),
                                UnitID = reader.IsDBNull(reader.GetOrdinal("UnitID")) ? null : (int?)reader.GetInt32(reader.GetOrdinal("UnitID")),
                                Quantity = reader.IsDBNull(reader.GetOrdinal("Quantity")) ? null : (float?)reader.GetFloat(reader.GetOrdinal("Quantity")),
                                CurrencyID = reader.IsDBNull(reader.GetOrdinal("CurrencyID")) ? null : (int?)reader.GetInt32(reader.GetOrdinal("CurrencyID")),
                                TotalAmount = reader.IsDBNull(reader.GetOrdinal("TotalAmount")) ? null : (float?)reader.GetFloat(reader.GetOrdinal("TotalAmount")),
                                LocalAmount = reader.IsDBNull(reader.GetOrdinal("LocalAmount")) ? null : (float?)reader.GetFloat(reader.GetOrdinal("LocalAmount")),
                                ForeignAmount = reader.IsDBNull(reader.GetOrdinal("ForeignAmount")) ? null : (float?)reader.GetFloat(reader.GetOrdinal("ForeignAmount")),
                                ACU = reader.IsDBNull(reader.GetOrdinal("ACU")) ? null : (float?)reader.GetFloat(reader.GetOrdinal("ACU")),
                                CostPrice = reader.IsDBNull(reader.GetOrdinal("CostPrice")) ? null : (float?)reader.GetFloat(reader.GetOrdinal("CostPrice")),
                                CostCurrencyID = reader.IsDBNull(reader.GetOrdinal("CostCurrencyID")) ? null : (int?)reader.GetInt32(reader.GetOrdinal("CostCurrencyID")),
                                LocalCostPrice = reader.IsDBNull(reader.GetOrdinal("LocalCostPrice")) ? null : (float?)reader.GetFloat(reader.GetOrdinal("LocalCostPrice")),
                                ForeignCostPrice = reader.IsDBNull(reader.GetOrdinal("ForeignCostPrice")) ? null : (float?)reader.GetFloat(reader.GetOrdinal("ForeignCostPrice")),
                                CreatedByID = reader.IsDBNull(reader.GetOrdinal("CreatedByID")) ? null : (int?)reader.GetInt32(reader.GetOrdinal("CreatedByID")),
                                CreatedDate = reader.GetDateTime(reader.GetOrdinal("CreatedDate")),
                                UpdatedByID = reader.IsDBNull(reader.GetOrdinal("UpdatedByID")) ? null : (int?)reader.GetInt32(reader.GetOrdinal("UpdatedByID")),
                                UpdatedDate = reader.IsDBNull(reader.GetOrdinal("UpdatedDate")) ? null : (DateTime?)reader.GetDateTime(reader.GetOrdinal("UpdatedDate"))
                            };
                        }
                    }
                }
            }
            return null;
        }

        public void Update(StockTransferDetail stockTransferDetail)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"UPDATE StockTransferDetail SET StkTransferID = @StkTransferID, ItemID = @ItemID,
                                UnitID = @UnitID, Quantity = @Quantity, CurrencyID = @CurrencyID, TotalAmount = @TotalAmount,
                                LocalAmount = @LocalAmount, ForeignAmount = @ForeignAmount, ACU = @ACU, CostPrice = @CostPrice,
                                CostCurrencyID = @CostCurrencyID, LocalCostPrice = @LocalCostPrice, ForeignCostPrice = @ForeignCostPrice,
                                CreatedByID = @CreatedByID, CreatedDate = @CreatedDate, UpdatedByID = @UpdatedByID,
                                UpdatedDate = @UpdatedDate
                             WHERE ID = @ID";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StkTransferID", stockTransferDetail.StkTransferID);
                    command.Parameters.AddWithValue("@ItemID", stockTransferDetail.ItemID);
                    command.Parameters.AddWithValue("@UnitID", stockTransferDetail.UnitID);
                    command.Parameters.AddWithValue("@Quantity", stockTransferDetail.Quantity);
                    command.Parameters.AddWithValue("@CurrencyID", stockTransferDetail.CurrencyID);
                    command.Parameters.AddWithValue("@TotalAmount", stockTransferDetail.TotalAmount);
                    command.Parameters.AddWithValue("@LocalAmount", stockTransferDetail.LocalAmount);
                    command.Parameters.AddWithValue("@ForeignAmount", stockTransferDetail.ForeignAmount);
                    command.Parameters.AddWithValue("@ACU", stockTransferDetail.ACU);
                    command.Parameters.AddWithValue("@CostPrice", stockTransferDetail.CostPrice);
                    command.Parameters.AddWithValue("@CostCurrencyID", stockTransferDetail.CostCurrencyID);
                    command.Parameters.AddWithValue("@LocalCostPrice", stockTransferDetail.LocalCostPrice);
                    command.Parameters.AddWithValue("@ForeignCostPrice", stockTransferDetail.ForeignCostPrice);
                    command.Parameters.AddWithValue("@CreatedByID", stockTransferDetail.CreatedByID);
                    command.Parameters.AddWithValue("@CreatedDate", stockTransferDetail.CreatedDate);
                    command.Parameters.AddWithValue("@UpdatedByID", stockTransferDetail.UpdatedByID);
                    command.Parameters.AddWithValue("@UpdatedDate", stockTransferDetail.UpdatedDate);
                    command.Parameters.AddWithValue("@ID", stockTransferDetail.ID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM StockTransferDetail WHERE ID = @ID";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }

    public class StockTransferDetail
    {
        public int ID { get; set; }
        public int? StkTransferID { get; set; }
        public int? ItemID { get; set; }
        public int? UnitID { get; set; }
        public float? Quantity { get; set; }
        public int? CurrencyID { get; set; }
        public float? TotalAmount { get; set; }
        public float? LocalAmount { get; set; }
        public float? ForeignAmount { get; set; }
        public float? ACU { get; set; }
        public float? CostPrice { get; set; }
        public int? CostCurrencyID { get; set; }
        public float? LocalCostPrice { get; set; }
        public float? ForeignCostPrice { get; set; }
        public int? CreatedByID { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedByID { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }

}
