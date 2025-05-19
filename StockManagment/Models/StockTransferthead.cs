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

    public class StockTransferHeadRepository
    {
        private readonly string connectionString;

        public StockTransferHeadRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Create(StockTransferHead stockTransferHead)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"INSERT INTO StockTransferHead (SerialNumber, TransferDate, FromWarehouseID, ToWarehouseID,
                                TransferQuantity, CurrencyID, TotalAmount, LocalAmount, ForeignAmount, PreparedBy, ApprovedByID,
                                ApprovedDate, IsApproved, IsConfirmed, ConfirmedByID, ConfirmationDate, Notes, CreatedByID,
                                CreatedDate, UpdatedByID, UpdatedDate)
                             VALUES (@SerialNumber, @TransferDate, @FromWarehouseID, @ToWarehouseID, @TransferQuantity,
                                @CurrencyID, @TotalAmount, @LocalAmount, @ForeignAmount, @PreparedBy, @ApprovedByID,
                                @ApprovedDate, @IsApproved, @IsConfirmed, @ConfirmedByID, @ConfirmationDate, @Notes,
                                @CreatedByID, @CreatedDate, @UpdatedByID, @UpdatedDate)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SerialNumber", stockTransferHead.SerialNumber);
                    command.Parameters.AddWithValue("@TransferDate", stockTransferHead.TransferDate);
                    command.Parameters.AddWithValue("@FromWarehouseID", stockTransferHead.FromWarehouseID);
                    command.Parameters.AddWithValue("@ToWarehouseID", stockTransferHead.ToWarehouseID);
                    command.Parameters.AddWithValue("@TransferQuantity", stockTransferHead.TransferQuantity);
                    command.Parameters.AddWithValue("@CurrencyID", stockTransferHead.CurrencyID);
                    command.Parameters.AddWithValue("@TotalAmount", stockTransferHead.TotalAmount);
                    command.Parameters.AddWithValue("@LocalAmount", stockTransferHead.LocalAmount);
                    command.Parameters.AddWithValue("@ForeignAmount", stockTransferHead.ForeignAmount);
                    command.Parameters.AddWithValue("@PreparedBy", stockTransferHead.PreparedBy);
                    command.Parameters.AddWithValue("@ApprovedByID", stockTransferHead.ApprovedByID);
                    command.Parameters.AddWithValue("@ApprovedDate", stockTransferHead.ApprovedDate);
                    command.Parameters.AddWithValue("@IsApproved", stockTransferHead.IsApproved);
                    command.Parameters.AddWithValue("@IsConfirmed", stockTransferHead.IsConfirmed);
                    command.Parameters.AddWithValue("@ConfirmedByID", stockTransferHead.ConfirmedByID);
                    command.Parameters.AddWithValue("@ConfirmationDate", stockTransferHead.ConfirmationDate);
                    command.Parameters.AddWithValue("@Notes", stockTransferHead.Notes);
                    command.Parameters.AddWithValue("@CreatedByID", stockTransferHead.CreatedByID);
                    command.Parameters.AddWithValue("@CreatedDate", stockTransferHead.CreatedDate);
                    command.Parameters.AddWithValue("@UpdatedByID", stockTransferHead.UpdatedByID);
                    command.Parameters.AddWithValue("@UpdatedDate", stockTransferHead.UpdatedDate);
                    command.ExecuteNonQuery();
                }
            }
        }

        public StockTransferHead Read(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM StockTransferHead WHERE Id = @Id";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new StockTransferHead
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                SerialNumber = reader.GetString(reader.GetOrdinal("SerialNumber")),
                                TransferDate = reader.GetDateTime(reader.GetOrdinal("TransferDate")),
                                FromWarehouseID = reader.GetInt32(reader.GetOrdinal("FromWarehouseID")),
                                ToWarehouseID = reader.GetInt32(reader.GetOrdinal("ToWarehouseID")),
                                TransferQuantity = reader.GetDecimal(reader.GetOrdinal("TransferQuantity")),
                                CurrencyID = reader.GetInt32(reader.GetOrdinal("CurrencyID")),
                                TotalAmount = reader.GetDecimal(reader.GetOrdinal("TotalAmount")),
                                LocalAmount = reader.GetDecimal(reader.GetOrdinal("LocalAmount")),
                                ForeignAmount = reader.GetDecimal(reader.GetOrdinal("ForeignAmount")),
                                PreparedBy = reader.GetString(reader.GetOrdinal("PreparedBy")),
                                ApprovedByID = reader.IsDBNull(reader.GetOrdinal("ApprovedByID")) ? null : (int?)reader.GetInt32(reader.GetOrdinal("ApprovedByID")),
                                ApprovedDate = reader.IsDBNull(reader.GetOrdinal("ApprovedDate")) ? null : (DateTime?)reader.GetDateTime(reader.GetOrdinal("ApprovedDate")),
                                IsApproved = reader.GetBoolean(reader.GetOrdinal("IsApproved")),
                                IsConfirmed = reader.GetBoolean(reader.GetOrdinal("IsConfirmed")),
                                ConfirmedByID = reader.IsDBNull(reader.GetOrdinal("ConfirmedByID")) ? null : (int?)reader.GetInt32(reader.GetOrdinal("ConfirmedByID")),
                                ConfirmationDate = reader.IsDBNull(reader.GetOrdinal("ConfirmationDate")) ? null : (DateTime?)reader.GetDateTime(reader.GetOrdinal("ConfirmationDate")),
                                Notes = reader.IsDBNull(reader.GetOrdinal("Notes")) ? null : reader.GetString(reader.GetOrdinal("Notes")),
                                CreatedByID = reader.GetInt32(reader.GetOrdinal("CreatedByID")),
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

        public void Update(StockTransferHead stockTransferHead)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"UPDATE StockTransferHead SET SerialNumber = @SerialNumber, TransferDate = @TransferDate,
                                FromWarehouseID = @FromWarehouseID, ToWarehouseID = @ToWarehouseID,
                                TransferQuantity = @TransferQuantity, CurrencyID = @CurrencyID, TotalAmount = @TotalAmount,
                                LocalAmount = @LocalAmount, ForeignAmount = @ForeignAmount, PreparedBy = @PreparedBy,
                                ApprovedByID = @ApprovedByID, ApprovedDate = @ApprovedDate, IsApproved = @IsApproved,
                                IsConfirmed = @IsConfirmed, ConfirmedByID = @ConfirmedByID, ConfirmationDate = @ConfirmationDate,
                                Notes = @Notes, CreatedByID = @CreatedByID, CreatedDate = @CreatedDate,
                                UpdatedByID = @UpdatedByID, UpdatedDate = @UpdatedDate
                             WHERE Id = @Id";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SerialNumber", stockTransferHead.SerialNumber);
                    command.Parameters.AddWithValue("@TransferDate", stockTransferHead.TransferDate);
                    command.Parameters.AddWithValue("@FromWarehouseID", stockTransferHead.FromWarehouseID);
                    command.Parameters.AddWithValue("@ToWarehouseID", stockTransferHead.ToWarehouseID);
                    command.Parameters.AddWithValue("@TransferQuantity", stockTransferHead.TransferQuantity);
                    command.Parameters.AddWithValue("@CurrencyID", stockTransferHead.CurrencyID);
                    command.Parameters.AddWithValue("@TotalAmount", stockTransferHead.TotalAmount);
                    command.Parameters.AddWithValue("@LocalAmount", stockTransferHead.LocalAmount);
                    command.Parameters.AddWithValue("@ForeignAmount", stockTransferHead.ForeignAmount);
                    command.Parameters.AddWithValue("@PreparedBy", stockTransferHead.PreparedBy);
                    command.Parameters.AddWithValue("@ApprovedByID", stockTransferHead.ApprovedByID ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@ApprovedDate", stockTransferHead.ApprovedDate ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@IsApproved", stockTransferHead.IsApproved);
                    command.Parameters.AddWithValue("@IsConfirmed", stockTransferHead.IsConfirmed);
                    command.Parameters.AddWithValue("@ConfirmedByID", stockTransferHead.ConfirmedByID ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@ConfirmationDate", stockTransferHead.ConfirmationDate ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Notes", stockTransferHead.Notes ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@CreatedByID", stockTransferHead.CreatedByID);
                    command.Parameters.AddWithValue("@CreatedDate", stockTransferHead.CreatedDate);
                    command.Parameters.AddWithValue("@UpdatedByID", stockTransferHead.UpdatedByID ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@UpdatedDate", stockTransferHead.UpdatedDate ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Id", stockTransferHead.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM StockTransferHead WHERE Id = @Id";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }

    public class StockTransferHead
    {
        public int Id { get; set; }
        public string SerialNumber { get; set; }
        public DateTime? TransferDate { get; set; }
        public int? FromWarehouseID { get; set; }
        public int? ToWarehouseID { get; set; }
        public decimal? TransferQuantity { get; set; }
        public int? CurrencyID { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? LocalAmount { get; set; }
        public decimal? ForeignAmount { get; set; }
        public string PreparedBy { get; set; }
        public int? ApprovedByID { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public bool IsApproved { get; set; }
        public bool IsConfirmed { get; set; }
        public int? ConfirmedByID { get; set; }
        public DateTime? ConfirmationDate { get; set; }
        public string Notes { get; set; }
        public int CreatedByID { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedByID { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }

}
