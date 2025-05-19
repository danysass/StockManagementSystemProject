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



    public class PurchaseDeliveryClass
    {


    

        static string connectionString = "Your_Connection_String_Here";

   

        static int CreatePurchaseDelivery(string serialNumber, int purchaseOrderId, DateTime deliveryDate, int deliveredById,
            int orderedQuantity, int receivedQuantity, string notes, bool isCompleted, bool isApproved, int? approvedById,
            DateTime? approvedDate, decimal? discountPercentage, decimal? discountAmount, decimal? totalAmount, int wareHouseId,
            float localAmount, float foreignAmount, string voucherNumber, string referenceNumber, DateTime? referenceDate,
            int currencyId, int purchaseDeliveryUpdatedReasonId, bool isReOpened, DateTime? reOpenedDate, int? reOpenedById,
            bool isDifferentCurrency, bool isDifferentDeliveryDate, bool isDifferentQuantity, bool isDifferentUnitPrice,
            bool isDifferentGratis, bool isDifferentFreeItems, bool isDifferentExpiryDate, bool isNotMatch,
            string purchaseInvoiceFilePath, bool isPosted, DateTime? postingTime, int? postedById, int createdById,
            DateTime createdDate, int updatedById, DateTime updatedDate, decimal localExRate, decimal foreignExRate,
            int projectId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                INSERT INTO PurchaseDeliveryHead 
                (SerialNumber, PurchaseOrderID, DeliveryDate, DeliveredByID, OrderedQuantity, RecievedQuantity, Notes,
                IsCompleted, IsApproved, ApprovedByID, ApprovedDate, DiscountPercentage, DiscountAmount, TotalAmount, WareHouseID,
                LocalAmount, ForeignAmount, VoucherNumber, ReferenceNumber, ReferenceDate, CurrencyID, PurchaseDeliveryUpdatedReasonID,
                IsReOpened, ReOpenedDate, ReOpenedByID, IsDifferentCurrency, IsDifferentDeliveryDate, IsDifferentQuantity, IsDifferentUnitPrice,
                IsDifferentGratis, IsDifferentFreeItems, IsDifferentExpiryDate, IsNotMatch, PurchaseInvoiceFilePath, IsPosted, PostingTime,
                PostedByID, CreatedByID, CreatedDate, UpdatedByID, UpdatedDate, LocalExRate, ForeignExRate, ProjectID)
                VALUES 
                (@SerialNumber, @PurchaseOrderID, @DeliveryDate, @DeliveredByID, @OrderedQuantity, @RecievedQuantity, @Notes,
                @IsCompleted, @IsApproved, @ApprovedByID, @ApprovedDate, @DiscountPercentage, @DiscountAmount, @TotalAmount, @WareHouseID,
                @LocalAmount, @ForeignAmount, @VoucherNumber, @ReferenceNumber, @ReferenceDate, @CurrencyID, @PurchaseDeliveryUpdatedReasonID,
                @IsReOpened, @ReOpenedDate, @ReOpenedByID, @IsDifferentCurrency, @IsDifferentDeliveryDate, @IsDifferentQuantity, @IsDifferentUnitPrice,
                @IsDifferentGratis, @IsDifferentFreeItems, @IsDifferentExpiryDate, @IsNotMatch, @PurchaseInvoiceFilePath, @IsPosted, @PostingTime,
                @PostedByID, @CreatedByID, @CreatedDate, @UpdatedByID, @UpdatedDate, @LocalExRate, @ForeignExRate, @ProjectID);
                SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SerialNumber", serialNumber);
                    command.Parameters.AddWithValue("@PurchaseOrderID", purchaseOrderId);
                    command.Parameters.AddWithValue("@DeliveryDate", deliveryDate);
                    command.Parameters.AddWithValue("@DeliveredByID", deliveredById);
                    command.Parameters.AddWithValue("@OrderedQuantity", orderedQuantity);
                    command.Parameters.AddWithValue("@RecievedQuantity", receivedQuantity);
                    command.Parameters.AddWithValue("@Notes", notes);
                    command.Parameters.AddWithValue("@IsCompleted", isCompleted);
                    command.Parameters.AddWithValue("@IsApproved", isApproved);
                    command.Parameters.AddWithValue("@ApprovedByID", approvedById ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@ApprovedDate", approvedDate ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@DiscountPercentage", discountPercentage ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@DiscountAmount", discountAmount ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@TotalAmount", totalAmount ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@WareHouseID", wareHouseId);
                    command.Parameters.AddWithValue("@LocalAmount", localAmount);
                    command.Parameters.AddWithValue("@ForeignAmount", foreignAmount);
                    command.Parameters.AddWithValue("@VoucherNumber", voucherNumber);
                    command.Parameters.AddWithValue("@ReferenceNumber", referenceNumber);
                    command.Parameters.AddWithValue("@ReferenceDate", referenceDate ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@CurrencyID", currencyId);
                    command.Parameters.AddWithValue("@PurchaseDeliveryUpdatedReasonID", purchaseDeliveryUpdatedReasonId);
                    command.Parameters.AddWithValue("@IsReOpened", isReOpened);
                    command.Parameters.AddWithValue("@ReOpenedDate", reOpenedDate ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@ReOpenedByID", reOpenedById ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@IsDifferentCurrency", isDifferentCurrency);
                    command.Parameters.AddWithValue("@IsDifferentDeliveryDate", isDifferentDeliveryDate);
                    command.Parameters.AddWithValue("@IsDifferentQuantity", isDifferentQuantity);
                    command.Parameters.AddWithValue("@IsDifferentUnitPrice", isDifferentUnitPrice);
                    command.Parameters.AddWithValue("@IsDifferentGratis", isDifferentGratis);
                    command.Parameters.AddWithValue("@IsDifferentFreeItems", isDifferentFreeItems);
                    command.Parameters.AddWithValue("@IsDifferentExpiryDate", isDifferentExpiryDate);
                    command.Parameters.AddWithValue("@IsNotMatch", isNotMatch);
                    command.Parameters.AddWithValue("@PurchaseInvoiceFilePath", purchaseInvoiceFilePath);
                    command.Parameters.AddWithValue("@IsPosted", isPosted);
                    command.Parameters.AddWithValue("@PostingTime", postingTime ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@PostedByID", postedById ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@CreatedByID", createdById);
                    command.Parameters.AddWithValue("@CreatedDate", createdDate);
                    command.Parameters.AddWithValue("@UpdatedByID", updatedById);
                    command.Parameters.AddWithValue("@UpdatedDate", updatedDate);
                    command.Parameters.AddWithValue("@LocalExRate", localExRate);
                    command.Parameters.AddWithValue("@ForeignExRate", foreignExRate);
                    command.Parameters.AddWithValue("@ProjectID", projectId);

                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        static PurchaseDeliveryHead GetPurchaseDeliveryById(int purchaseDeliveryId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM PurchaseDeliveryHead WHERE Id = @PurchaseDeliveryId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PurchaseDeliveryId", purchaseDeliveryId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            //return ;
                        }
                    }
                }
            }

            return null;
        }

        static void UpdatePurchaseDelivery(int purchaseDeliveryId, string serialNumber, int purchaseOrderId, DateTime deliveryDate, int deliveredById,
            int orderedQuantity, int receivedQuantity, string notes, bool isCompleted, bool isApproved, int? approvedById,
            DateTime? approvedDate, decimal? discountPercentage, decimal? discountAmount, decimal? totalAmount, int wareHouseId,
            float localAmount, float foreignAmount, string voucherNumber, string referenceNumber, DateTime? referenceDate,
            int currencyId, int purchaseDeliveryUpdatedReasonId, bool isReOpened, DateTime? reOpenedDate, int? reOpenedById,
            bool isDifferentCurrency, bool isDifferentDeliveryDate, bool isDifferentQuantity, bool isDifferentUnitPrice,
            bool isDifferentGratis, bool isDifferentFreeItems, bool isDifferentExpiryDate, bool isNotMatch,
            string purchaseInvoiceFilePath, bool isPosted, DateTime? postingTime, int? postedById, int createdById,
            DateTime createdDate, int updatedById, DateTime updatedDate, decimal localExRate, decimal foreignExRate,
            int projectId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                UPDATE PurchaseDeliveryHead 
                SET SerialNumber = @SerialNumber, PurchaseOrderID = @PurchaseOrderID, DeliveryDate = @DeliveryDate, DeliveredByID = @DeliveredByID,
                OrderedQuantity = @OrderedQuantity, RecievedQuantity = @RecievedQuantity, Notes = @Notes, IsCompleted = @IsCompleted,
                IsApproved = @IsApproved, ApprovedByID = @ApprovedByID, ApprovedDate = @ApprovedDate, DiscountPercentage = @DiscountPercentage,
                DiscountAmount = @DiscountAmount, TotalAmount = @TotalAmount, WareHouseID = @WareHouseID, LocalAmount = @LocalAmount,
                ForeignAmount = @ForeignAmount, VoucherNumber = @VoucherNumber, ReferenceNumber = @ReferenceNumber, ReferenceDate = @ReferenceDate,
                CurrencyID = @CurrencyID, PurchaseDeliveryUpdatedReasonID = @PurchaseDeliveryUpdatedReasonID, IsReOpened = @IsReOpened,
                ReOpenedDate = @ReOpenedDate, ReOpenedByID = @ReOpenedByID, IsDifferentCurrency = @IsDifferentCurrency,
                IsDifferentDeliveryDate = @IsDifferentDeliveryDate, IsDifferentQuantity = @IsDifferentQuantity, IsDifferentUnitPrice = @IsDifferentUnitPrice,
                IsDifferentGratis = @IsDifferentGratis, IsDifferentFreeItems = @IsDifferentFreeItems, IsDifferentExpiryDate = @IsDifferentExpiryDate,
                IsNotMatch = @IsNotMatch, PurchaseInvoiceFilePath = @PurchaseInvoiceFilePath, IsPosted = @IsPosted, PostingTime = @PostingTime,
                PostedByID = @PostedByID, CreatedByID = @CreatedByID, CreatedDate = @CreatedDate, UpdatedByID = @UpdatedByID,
                UpdatedDate = @UpdatedDate, LocalExRate = @LocalExRate, ForeignExRate = @ForeignExRate, ProjectID = @ProjectID
                WHERE Id = @PurchaseDeliveryId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PurchaseDeliveryId", purchaseDeliveryId);
                    command.Parameters.AddWithValue("@SerialNumber", serialNumber);
                    command.Parameters.AddWithValue("@PurchaseOrderID", purchaseOrderId);
                    command.Parameters.AddWithValue("@DeliveryDate", deliveryDate);
                    command.Parameters.AddWithValue("@DeliveredByID", deliveredById);
                    command.Parameters.AddWithValue("@OrderedQuantity", orderedQuantity);
                    command.Parameters.AddWithValue("@RecievedQuantity", receivedQuantity);
                    command.Parameters.AddWithValue("@Notes", notes);
                    command.Parameters.AddWithValue("@IsCompleted", isCompleted);
                    command.Parameters.AddWithValue("@IsApproved", isApproved);
                    command.Parameters.AddWithValue("@ApprovedByID", approvedById ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@ApprovedDate", approvedDate ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@DiscountPercentage", discountPercentage ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@DiscountAmount", discountAmount ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@TotalAmount", totalAmount ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@WareHouseID", wareHouseId);
                    command.Parameters.AddWithValue("@LocalAmount", localAmount);
                    command.Parameters.AddWithValue("@ForeignAmount", foreignAmount);
                    command.Parameters.AddWithValue("@VoucherNumber", voucherNumber);
                    command.Parameters.AddWithValue("@ReferenceNumber", referenceNumber);
                    command.Parameters.AddWithValue("@ReferenceDate", referenceDate ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@CurrencyID", currencyId);
                    command.Parameters.AddWithValue("@PurchaseDeliveryUpdatedReasonID", purchaseDeliveryUpdatedReasonId);
                    command.Parameters.AddWithValue("@IsReOpened", isReOpened);
                    command.Parameters.AddWithValue("@ReOpenedDate", reOpenedDate ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@ReOpenedByID", reOpenedById ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@IsDifferentCurrency", isDifferentCurrency);
                    command.Parameters.AddWithValue("@IsDifferentDeliveryDate", isDifferentDeliveryDate);
                    command.Parameters.AddWithValue("@IsDifferentQuantity", isDifferentQuantity);
                    command.Parameters.AddWithValue("@IsDifferentUnitPrice", isDifferentUnitPrice);
                    command.Parameters.AddWithValue("@IsDifferentGratis", isDifferentGratis);
                    command.Parameters.AddWithValue("@IsDifferentFreeItems", isDifferentFreeItems);
                    command.Parameters.AddWithValue("@IsDifferentExpiryDate", isDifferentExpiryDate);
                    command.Parameters.AddWithValue("@IsNotMatch", isNotMatch);
                    command.Parameters.AddWithValue("@PurchaseInvoiceFilePath", purchaseInvoiceFilePath);
                    command.Parameters.AddWithValue("@IsPosted", isPosted);
                    command.Parameters.AddWithValue("@PostingTime", postingTime ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@PostedByID", postedById ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@CreatedByID", createdById);
                    command.Parameters.AddWithValue("@CreatedDate", createdDate);
                    command.Parameters.AddWithValue("@UpdatedByID", updatedById);
                    command.Parameters.AddWithValue("@UpdatedDate", updatedDate);
                    command.Parameters.AddWithValue("@LocalExRate", localExRate);
                    command.Parameters.AddWithValue("@ForeignExRate", foreignExRate);
                    command.Parameters.AddWithValue("@ProjectID", projectId);

                    command.ExecuteNonQuery();
                }
            }
        }

        static void DeletePurchaseDelivery(int purchaseDeliveryId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM PurchaseDeliveryHead WHERE Id = @PurchaseDeliveryId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PurchaseDeliveryId", purchaseDeliveryId);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Utility method to map data from SqlDataReader to PurchaseDeliveryHead object


        // Utility method to display purchase delivery details
        static void DisplayPurchaseDelivery(PurchaseDeliveryHead purchaseDelivery)
        {
            if (purchaseDelivery != null)
            {
                Console.WriteLine($"ID: {purchaseDelivery.Id}");
                Console.WriteLine($"Serial Number: {purchaseDelivery.SerialNumber}");
                // Display other properties similarly
            }
            else
            {
                Console.WriteLine("Purchase delivery not found.");
            }
        }
    }


    public class PurchaseDeliveryHead
    {
        public int Id { get; set; }
        public string SerialNumber { get; set; }
        public int? PurchaseOrderID { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int? DeliveredByID { get; set; }
        public int? OrderedQuantity { get; set; }
        public int? RecievedQuantity { get; set; }
        public string Notes { get; set; }
        public bool? IsCompleted { get; set; }
        public bool? IsApproved { get; set; }
        public int? ApprovedByID { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? WareHouseID { get; set; }
        public double? LocalAmount { get; set; }
        public double? ForeignAmount { get; set; }
        public string VoucherNumber { get; set; }
        public string ReferenceNumber { get; set; }
        public DateTime? ReferenceDate { get; set; }
        public int? CurrencyID { get; set; }
        public int? PurchaseDeliveryUpdatedReasonID { get; set; }
        public bool? IsReOpened { get; set; }
        public DateTime? ReOpenedDate { get; set; }
        public int? ReOpenedByID { get; set; }
        public bool? IsDifferentCurrency { get; set; }
        public bool? IsDifferentDeliveryDate { get; set; }
        public bool? IsDifferentQuantity { get; set; }
        public bool? IsDifferentUnitPrice { get; set; }
        public bool? IsDifferentGratis { get; set; }
        public bool? IsDifferentFreeItems { get; set; }
        public bool? IsDifferentExpiryDate { get; set; }
        public bool? IsNotMatch { get; set; }
        public string PurchaseInvoiceFilePath { get; set; }
        public bool? IsPosted { get; set; }
        public DateTime? PostingTime { get; set; }
        public int? PostedByID { get; set; }
        public int? CreatedByID { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedByID { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public decimal? LocalExRate { get; set; }
        public decimal? ForeignExRate { get; set; }
        public int? ProjectID { get; set; }
    }
}
