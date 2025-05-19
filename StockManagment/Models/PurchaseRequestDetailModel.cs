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

    public class PurchaseRequestDetailRepository
    {
        private string connectionString;

        public PurchaseRequestDetailRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void InsertPurchaseRequestDetail(int purchaseRequestID, int itemID, int unitID, decimal reqQuantity, int orderQuantity, int receivedQuantity, int purchaseUnitID, decimal quantityPurchaseUnit, decimal purchaseFactor, bool excluded, bool isUrgent, bool isOrdered, int createdByID, DateTime createdDate, int updatedByID, DateTime updatedDate, decimal approvedQuantity)
        {
            string query = @"INSERT INTO PurchaseRequestDetail (PurchaseRequestID, ItemID, UnitID, ReqQuantity, OrderQuantity, ReceivedQuantity, PurchaseUnitID, QuantityPurchaseUnit, PurchaseFactor, Excluded, IsUrgent, IsOrdered, CreatedByID, CreatedDate, UpdatedByID, UpdatedDate, ApprovedQuantity)
                        VALUES (@PurchaseRequestID, @ItemID, @UnitID, @ReqQuantity, @OrderQuantity, @ReceivedQuantity, @PurchaseUnitID, @QuantityPurchaseUnit, @PurchaseFactor, @Excluded, @IsUrgent, @IsOrdered, @CreatedByID, @CreatedDate, @UpdatedByID, @UpdatedDate, @ApprovedQuantity)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@PurchaseRequestID", purchaseRequestID);
                command.Parameters.AddWithValue("@ItemID", itemID);
                command.Parameters.AddWithValue("@UnitID", unitID);
                command.Parameters.AddWithValue("@ReqQuantity", reqQuantity);
                command.Parameters.AddWithValue("@OrderQuantity", orderQuantity);
                command.Parameters.AddWithValue("@ReceivedQuantity", receivedQuantity);
                command.Parameters.AddWithValue("@PurchaseUnitID", purchaseUnitID);
                command.Parameters.AddWithValue("@QuantityPurchaseUnit", quantityPurchaseUnit);
                command.Parameters.AddWithValue("@PurchaseFactor", purchaseFactor);
                command.Parameters.AddWithValue("@Excluded", excluded);
                command.Parameters.AddWithValue("@IsUrgent", isUrgent);
                command.Parameters.AddWithValue("@IsOrdered", isOrdered);
                command.Parameters.AddWithValue("@CreatedByID", createdByID);
                command.Parameters.AddWithValue("@CreatedDate", createdDate);
                command.Parameters.AddWithValue("@UpdatedByID", updatedByID);
                command.Parameters.AddWithValue("@UpdatedDate", updatedDate);
                command.Parameters.AddWithValue("@ApprovedQuantity", approvedQuantity);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UpdatePurchaseRequestDetail(int id, int purchaseRequestID, int itemID, int unitID, decimal reqQuantity, int orderQuantity, int receivedQuantity, int purchaseUnitID, decimal quantityPurchaseUnit, decimal purchaseFactor, bool excluded, bool isUrgent, bool isOrdered, int updatedByID, DateTime updatedDate, decimal approvedQuantity)
        {
            string query = @"UPDATE PurchaseRequestDetail
                        SET PurchaseRequestID = @PurchaseRequestID,
                            ItemID = @ItemID,
                            UnitID = @UnitID,
                            ReqQuantity = @ReqQuantity,
                            OrderQuantity = @OrderQuantity,
                            ReceivedQuantity = @ReceivedQuantity,
                            PurchaseUnitID = @PurchaseUnitID,
                            QuantityPurchaseUnit = @QuantityPurchaseUnit,
                            PurchaseFactor = @PurchaseFactor,
                            Excluded = @Excluded,
                            IsUrgent = @IsUrgent,
                            IsOrdered = @IsOrdered,
                            UpdatedByID = @UpdatedByID,
                            UpdatedDate = @UpdatedDate,
                            ApprovedQuantity = @ApprovedQuantity
                        WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@PurchaseRequestID", purchaseRequestID);
                command.Parameters.AddWithValue("@ItemID", itemID);
                command.Parameters.AddWithValue("@UnitID", unitID);
                command.Parameters.AddWithValue("@ReqQuantity", reqQuantity);
                command.Parameters.AddWithValue("@OrderQuantity", orderQuantity);
                command.Parameters.AddWithValue("@ReceivedQuantity", receivedQuantity);
                command.Parameters.AddWithValue("@PurchaseUnitID", purchaseUnitID);
                command.Parameters.AddWithValue("@QuantityPurchaseUnit", quantityPurchaseUnit);
                command.Parameters.AddWithValue("@PurchaseFactor", purchaseFactor);
                command.Parameters.AddWithValue("@Excluded", excluded);
                command.Parameters.AddWithValue("@IsUrgent", isUrgent);
                command.Parameters.AddWithValue("@IsOrdered", isOrdered);
                command.Parameters.AddWithValue("@UpdatedByID", updatedByID);
                command.Parameters.AddWithValue("@UpdatedDate", updatedDate);
                command.Parameters.AddWithValue("@ApprovedQuantity", approvedQuantity);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeletePurchaseRequestDetail(int id)
        {
            string query = "DELETE FROM PurchaseRequestDetail WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable GetAllPurchaseRequestDetails()
        {
            string query = "SELECT * FROM PurchaseRequestDetail";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataRow GetPurchaseRequestDetailById(int id)
        {
            string query = "SELECT * FROM PurchaseRequestDetail WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        DataTable schemaTable = reader.GetSchemaTable();
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        return dataTable.Rows[0];
                    }
                    return null;
                }
            }
        }
    }

}
