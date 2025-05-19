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

    public class StockRequisitionDetailRepository
    {
        private readonly string connectionString;

        public StockRequisitionDetailRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void CreateStockRequisitionDetail(string FK_RequestNumber, int StkRequisitionID, int ItemID, string ItemName,
                                               int UnitID, decimal QuantityRequest, decimal QuantityDelivered, bool IsDelivered,
                                               DateTime? DeliveredDate, int? DeliveredByID, decimal? QuantityExisted, bool IsCancelled,
                                               DateTime? CancelledDate, int? CancelledByID, bool IsReturned, decimal? QuantityReturned,
                                               DateTime? ReturnedDate, int? ReturnReasonID, int? ReturnedByID, decimal? AccpetedQuantity)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
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
                        command.Parameters.AddWithValue("@FK_RequestNumber", FK_RequestNumber);
                        command.Parameters.AddWithValue("@StkRequisitionID", StkRequisitionID);
                        command.Parameters.AddWithValue("@ItemID", ItemID);
                        command.Parameters.AddWithValue("@ItemName", ItemName);
                        command.Parameters.AddWithValue("@UnitID", UnitID);
                        command.Parameters.AddWithValue("@QuantityRequest", QuantityRequest);
                        command.Parameters.AddWithValue("@QuantityDelivered", QuantityDelivered);
                        command.Parameters.AddWithValue("@IsDelivered", IsDelivered);
                        command.Parameters.AddWithValue("@DeliveredDate", DeliveredDate ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@DeliveredByID", DeliveredByID ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@QuantityExisted", QuantityExisted ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@IsCancelled", IsCancelled);
                        command.Parameters.AddWithValue("@CancelledDate", CancelledDate ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@CancelledByID", CancelledByID ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@IsReturned", IsReturned);
                        command.Parameters.AddWithValue("@QuantityReturned", QuantityReturned ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@ReturnedDate", ReturnedDate ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@ReturnReasonID", ReturnReasonID ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@ReturnedByID", ReturnedByID ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@AccpetedQuantity", AccpetedQuantity ?? (object)DBNull.Value);
     command.Parameters.AddWithValue("@ItemCode", AccpetedQuantity ?? (object)DBNull.Value);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                // You might handle the error in a more specific way here based on your application's requirements.
            }
        }

        //public StockRequisitionDetail Read(int id)
        //{
        //    StockRequisitionDetail stockRequisitionDetail = null;

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        string sqlQuery = "SELECT * FROM StockRequisitionDetail WHERE ID = @ID";
        //        SqlCommand command = new SqlCommand(sqlQuery, connection);
        //        command.Parameters.AddWithValue("@ID", id);

        //        try
        //        {
        //            connection.Open();
        //            SqlDataReader reader = command.ExecuteReader();
        //            if (reader.Read())
        //            {
        //                stockRequisitionDetail = new StockRequisitionDetail
        //                {
        //                    ID = (int)reader["ID"],
        //                    FK_RequestNumber = reader["FK_RequestNumber"].ToString(),
        //                    StkRequisitionID = (int)reader["StkRequisitionID"],
        //                    ItemID = (int)reader["ItemID"],
        //                    ItemName = reader["ItemName"].ToString(),
        //                    UnitID = (int)reader["UnitID"],
        //                    QuantityRequest = (decimal)reader["QuantityRequest"],
        //                    QuantityDelivered = (decimal)reader["QuantityDelivered"],
        //                    IsDelivered = (bool)reader["IsDelivered"],
        //                    DeliveredDate = (DateTime)reader["DeliveredDate"],
        //                    DeliveredByID = (int)reader["DeliveredByID"],
        //                    QuantityExisted = (decimal)reader["QuantityExisted"],
        //                    IsCancelled = (bool)reader["IsCancelled"],
        //                    CancelledDate = (DateTime)reader["CancelledDate"],
        //                    CancelledByID = (int)reader["CancelledByID"],
        //                    IsReturned = (bool)reader["IsReturned"],
        //                    QuantityReturned = (decimal)reader["QuantityReturned"],
        //                    ReturnedDate = (DateTime)reader["ReturnedDate"],
        //                    ReturnReasonID = (int)reader["ReturnReasonID"],
        //                    ReturnedByID = (int)reader["ReturnedByID"],
        //                    AccpetedQuantity = (decimal)reader["AccpetedQuantity"]
        //                };
        //            }
        //            reader.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("Error: " + ex.Message);
        //        }
        //    }

        //    return stockRequisitionDetail;
        //}

        public void Update()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = @"UPDATE StockRequisitionDetail SET 
                                FK_RequestNumber = @FK_RequestNumber, 
                                StkRequisitionID = @StkRequisitionID, 
                                ItemID = @ItemID, 
                                ItemName = @ItemName, 
                                UnitID = @UnitID, 
                                QuantityRequest = @QuantityRequest,
                                QuantityDelivered = @QuantityDelivered, 
                                IsDelivered = @IsDelivered, 
                                DeliveredDate = @DeliveredDate, 
                                DeliveredByID = @DeliveredByID, 
                                QuantityExisted = @QuantityExisted,
                                IsCancelled = @IsCancelled, 
                                CancelledDate = @CancelledDate, 
                                CancelledByID = @CancelledByID, 
                                IsReturned = @IsReturned, 
                                QuantityReturned = @QuantityReturned, 
                                ReturnedDate = @ReturnedDate,
                                ReturnReasonID = @ReturnReasonID, 
                                ReturnedByID = @ReturnedByID, 
                                AccpetedQuantity = @AccpetedQuantity 
                                WHERE ID = @ID";

                SqlCommand command = new SqlCommand(sqlQuery, connection);
                //command.Parameters.AddWithValue("@ID", stockRequisitionDetail.ID);
                //command.Parameters.AddWithValue("@FK_RequestNumber", stockRequisitionDetail.FK_RequestNumber);
                //command.Parameters.AddWithValue("@StkRequisitionID", stockRequisitionDetail.StkRequisitionID);
                //command.Parameters.AddWithValue("@ItemID", stockRequisitionDetail.ItemID);
                //command.Parameters.AddWithValue("@ItemName", stockRequisitionDetail.ItemName);
                //command.Parameters.AddWithValue("@UnitID", stockRequisitionDetail.UnitID);
                //command.Parameters.AddWithValue("@QuantityRequest", stockRequisitionDetail.QuantityRequest);
                //command.Parameters.AddWithValue("@QuantityDelivered", stockRequisitionDetail.QuantityDelivered);
                //command.Parameters.AddWithValue("@IsDelivered", stockRequisitionDetail.IsDelivered);
                //command.Parameters.AddWithValue("@DeliveredDate", stockRequisitionDetail.DeliveredDate);
                //command.Parameters.AddWithValue("@DeliveredByID", stockRequisitionDetail.DeliveredByID);
            }
            }
        } 
    }