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

    public class StockWasteHead
    {
        private string connectionString;
        public int Id { get; set; }
        public string SerialNumber { get; set; }
        public int? ConsumerID { get; set; }
        public int? WareHouseID { get; set; }
        public int? StkWasteTypeID { get; set; }
        public int? WasteReasonID { get; set; }
        public DateTime? WasteDate { get; set; }
        public double? TotalWasteQty { get; set; }
        public double? TotalAmount { get; set; }
        public int? CurrencyID { get; set; }
        public double? ForeignAmount { get; set; }
        public double? LocalAmount { get; set; }
        public string Notes { get; set; }
        public bool? IsApproved { get; set; }
        public int? ApprovedByID { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public int? CreatedByID { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedByID { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsPosted { get; set; }
        public DateTime? PostedDate { get; set; }
        public int? PostedByID { get; set; }
        public bool? IsConfirmed { get; set; }
        public int? ConfirmedByID { get; set; }
        public DateTime? ConfirmationDate { get; set; }
        public StockWasteHead(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public int Create(StockWasteHead wasteHead)
        {
            int newId = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                    INSERT INTO StockWasteHead 
                    (SerialNumber, ConsumerID, WareHouseID, StkWasteTypeID, WasteReasonID, WasteDate, TotalWasteQty, TotalAmount, 
                    CurrencyID, ForeignAmount, LocalAmount, Notes, IsApproved, ApprovedByID, ApprovedDate, CreatedByID, CreatedDate, 
                    UpdatedByID, UpdatedDate, IsPosted, PostedDate, PostedByID, IsConfirmed, ConfirmedByID, ConfirmationDate)
                    VALUES 
                    (@SerialNumber, @ConsumerID, @WareHouseID, @StkWasteTypeID, @WasteReasonID, @WasteDate, @TotalWasteQty, @TotalAmount,
                    @CurrencyID, @ForeignAmount, @LocalAmount, @Notes, @IsApproved, @ApprovedByID, @ApprovedDate, @CreatedByID, @CreatedDate,
                    @UpdatedByID, @UpdatedDate, @IsPosted, @PostedDate, @PostedByID, @IsConfirmed, @ConfirmedByID, @ConfirmationDate);
                    SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SerialNumber", (object)wasteHead.SerialNumber ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ConsumerID", (object)wasteHead.ConsumerID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@WareHouseID", (object)wasteHead.WareHouseID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@StkWasteTypeID", (object)wasteHead.StkWasteTypeID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@WasteReasonID", (object)wasteHead.WasteReasonID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@WasteDate", (object)wasteHead.WasteDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@TotalWasteQty", (object)wasteHead.TotalWasteQty ?? DBNull.Value);
                        command.Parameters.AddWithValue("@TotalAmount", (object)wasteHead.TotalAmount ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CurrencyID", (object)wasteHead.CurrencyID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ForeignAmount", (object)wasteHead.ForeignAmount ?? DBNull.Value);
                        command.Parameters.AddWithValue("@LocalAmount", (object)wasteHead.LocalAmount ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Notes", (object)wasteHead.Notes ?? DBNull.Value);
                        command.Parameters.AddWithValue("@IsApproved", (object)wasteHead.IsApproved ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ApprovedByID", (object)wasteHead.ApprovedByID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ApprovedDate", (object)wasteHead.ApprovedDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedByID", (object)wasteHead.CreatedByID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedDate", (object)wasteHead.CreatedDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@UpdatedByID", (object)wasteHead.UpdatedByID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@UpdatedDate", (object)wasteHead.UpdatedDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@IsPosted", (object)wasteHead.IsPosted ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PostedDate", (object)wasteHead.PostedDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PostedByID", (object)wasteHead.PostedByID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@IsConfirmed", (object)wasteHead.IsConfirmed ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ConfirmedByID", (object)wasteHead.ConfirmedByID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ConfirmationDate", (object)wasteHead.ConfirmationDate ?? DBNull.Value);

                        newId = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while creating stock waste head: " + ex.Message);
            }
            return newId;
        }

        public StockWasteHead GetById(int id)
        {
            StockWasteHead wasteHead = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM StockWasteHead WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                //wasteHead = MapStockWasteHead(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving stock waste head: " + ex.Message);
            }
            return wasteHead;
        }

        public void Update(StockWasteHead wasteHead)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                    UPDATE StockWasteHead 
                    SET SerialNumber = @SerialNumber, ConsumerID = @ConsumerID, WareHouseID = @WareHouseID, StkWasteTypeID = @StkWasteTypeID,
                    WasteReasonID = @WasteReasonID, WasteDate = @WasteDate, TotalWasteQty = @TotalWasteQty, TotalAmount = @TotalAmount, 
                    CurrencyID = @CurrencyID, ForeignAmount = @ForeignAmount, LocalAmount = @LocalAmount, Notes = @Notes, IsApproved = @IsApproved,
                    ApprovedByID = @ApprovedByID, ApprovedDate = @ApprovedDate, CreatedByID = @CreatedByID, CreatedDate = @CreatedDate, 
                    UpdatedByID = @UpdatedByID, UpdatedDate = @UpdatedDate, IsPosted = @IsPosted, PostedDate = @PostedDate, PostedByID = @PostedByID,
                    IsConfirmed = @IsConfirmed, ConfirmedByID = @ConfirmedByID, ConfirmationDate = @ConfirmationDate
                    WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SerialNumber", (object)wasteHead.SerialNumber ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ConsumerID", (object)wasteHead.ConsumerID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@WareHouseID", (object)wasteHead.WareHouseID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@StkWasteTypeID", (object)wasteHead.StkWasteTypeID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@WasteReasonID", (object)wasteHead.WasteReasonID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@WasteDate", (object)wasteHead.WasteDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@TotalWasteQty", (object)wasteHead.TotalWasteQty ?? DBNull.Value);
                        command.Parameters.AddWithValue("@TotalAmount", (object)wasteHead.TotalAmount ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CurrencyID", (object)wasteHead.CurrencyID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ForeignAmount", (object)wasteHead.ForeignAmount ?? DBNull.Value);
                        command.Parameters.AddWithValue("@LocalAmount", (object)wasteHead.LocalAmount ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Notes", (object)wasteHead.Notes ?? DBNull.Value);
                        command.Parameters.AddWithValue("@IsApproved", (object)wasteHead.IsApproved ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ApprovedByID", (object)wasteHead.ApprovedByID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ApprovedDate", (object)wasteHead.ApprovedDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedByID", (object)wasteHead.CreatedByID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedDate", (object)wasteHead.CreatedDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@UpdatedByID", (object)wasteHead.UpdatedByID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@UpdatedDate", (object)wasteHead.UpdatedDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@IsPosted", (object)wasteHead.IsPosted ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PostedDate", (object)wasteHead.PostedDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PostedByID", (object)wasteHead.PostedByID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@IsConfirmed", (object)wasteHead.IsConfirmed ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ConfirmedByID", (object)wasteHead.ConfirmedByID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ConfirmationDate", (object)wasteHead.ConfirmationDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Id", wasteHead.Id);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while updating stock waste head: " + ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM StockWasteHead WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while deleting stock waste head: " + ex.Message);
            }
        }

        //private StockWasteHead MapStockWasteHead(SqlDataReader reader)
        //{
        //    return new StockWasteHead();
        //    //using (SqlConnection connection = new SqlConnection(connectionString))
        //    //{
        //    //    connection.Open();
        //    //    return new StockWasteHead
        //    //    {
        //    //        Id = (int)reader["Id"],
        //    //        SerialNumber = reader["SerialNumber"] != DBNull.Value ? (string)reader["SerialNumber"] : null,
        //    //        ConsumerID = reader["ConsumerID"] != DBNull.Value ? (int)reader["ConsumerID"] : (int?)null,
        //    //        WareHouseID = reader["WareHouseID"] != DBNull.Value ? (int)reader["WareHouseID"] : (int?)null,
        //    //        StkWasteTypeID = reader["StkWasteTypeID"] != DBNull.Value ? (int)reader["StkWasteTypeID"] : (int?)null,
        //    //        WasteReasonID = reader["WasteReasonID"] != DBNull.Value ? (int)reader["WasteReasonID"] : (int?)null,
        //    //        WasteDate = reader["WasteDate"] != DBNull.Value ? (DateTime)reader["WasteDate"] : (DateTime?)null,
        //    //        TotalWasteQty = reader["TotalWasteQty"] != DBNull.Value ? (double)reader["TotalWasteQty"] : (double?)null,
        //    //        TotalAmount = reader["TotalAmount"] != DBNull.Value ? (double)reader["TotalAmount"] : (double?)null,
        //    //        CurrencyID = reader["CurrencyID"] != DBNull.Value ? (int)reader["CurrencyID"] : (int?)null,
        //    //        ForeignAmount = reader["ForeignAmount"] != DBNull.Value ? (double)reader["ForeignAmount"] : (double?)null,
        //    //        LocalAmount = reader["LocalAmount"] != DBNull.Value ? (double)reader["LocalAmount"] : (double?)null,
        //    //        Notes = reader["Notes"] != DBNull.Value ? (string)reader["Notes"] : null,
        //    //        IsApproved = reader["IsApproved"] != DBNull.Value ? (bool)reader["IsApproved"] : (bool?)null,
        //    //        ApprovedByID = reader["ApprovedByID"] != DBNull.Value ? (int)reader["ApprovedByID"] : (int?)null,
        //    //        ApprovedDate = reader["ApprovedDate"] != DBNull.Value ? (DateTime)reader["ApprovedDate"] : (DateTime?)null,
        //    //        CreatedByID = reader["CreatedByID"] != DBNull.Value ? (int)reader["CreatedByID"] : (int?)null,
        //    //        CreatedDate = reader["CreatedDate"] != DBNull.Value ? (DateTime)reader["CreatedDate"] : (DateTime?)null,
        //    //        UpdatedByID = reader["UpdatedByID"] != DBNull.Value ? (int)reader["UpdatedByID"] : (int?)null,
        //    //        UpdatedDate = reader["UpdatedDate"] != DBNull.Value ? (DateTime)reader["UpdatedDate"] : (DateTime?)null,
        //    //        IsPosted = reader["IsPosted"] != DBNull.Value ? (bool)reader["IsPosted"] : (bool?)null,
        //    //        PostedDate = reader["PostedDate"] != DBNull.Value ? (DateTime)reader["PostedDate"] : (DateTime?)null,
        //    //        PostedByID = reader["PostedByID"] != DBNull.Value ? (int)reader["PostedByID"] : (int?)null,
        //    //        IsConfirmed = reader["IsConfirmed"] != DBNull.Value ? (bool)reader["IsConfirmed"] : (bool?)null,
        //    //        ConfirmedByID = reader["ConfirmedByID"] != DBNull.Value ? (int)reader["ConfirmedByID"] : (int?)null,
        //    //        ConfirmationDate = reader["ConfirmationDate"] != DBNull.Value ? (DateTime)reader["ConfirmationDate"] : (DateTime?)null
        //    //    };
        //    //}
        //}
    }

}
