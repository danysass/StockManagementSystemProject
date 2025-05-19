using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagment.Models
{
    internal class PurchaseDeliveryDetail
    {


        public void InsertPurchaseDeliveryDetail(int lineNumber, int? purchaseDeliveryID, string purchaseDeliveryCode, int? purchaseOrderDetailID, int? itemID, int? itemBrandID, int? unitID, decimal? orderPrice, decimal? deliveryPrice, decimal? orderedQuantity, decimal? receivedQuantity, string notes, decimal? poDiscountPercentage, decimal? poDiscountAmount, decimal? discountPercentage, decimal? discountAmount, decimal? unitDiscountedPrice, decimal? expectedGratisQuantity, bool? isFreeItem, decimal? receivedGratisQuantity, int? freeItemParentID, int? currencyID, decimal? subTotal, decimal? factor, decimal? totalDiscountedPrice, decimal? qtyPurchase, decimal? localAmount, decimal? foreignAmount, bool? isDifferentQuantity, bool? isDifferentUnitPrice, bool? isDifferentGratis, bool? isDifferentFreeItems, bool? isDifferentExpiryDate, bool? isDifferentDiscount, bool? isNotMatch, bool? hasVAT, decimal? totalVATAmount, decimal? vatPercentage, decimal? totalNetAmount, decimal? stockUnitCost, int? createdByID, DateTime? createdDate, int? updatedByID, DateTime? updatedDate, decimal? localExRate, decimal? foreignExRate, decimal? returnedQty, decimal? returnedGratisQty)
        {
            using (SqlConnection connection = new SqlConnection(""))
            {
                string query = @"INSERT INTO PurchaseDeliveryDetail (LineNumber, PurchaseDeliveryID, PurchaseDeliveryCode, PurchaseOrderDetailID, ItemID, ItemBrandID, UnitID, OrderPrice, DeliveryPrice, OrderedQuantity, RecievedQuantity, Notes, PODiscountPercentage, PODiscountAmount, DiscountPercentage, DiscountAmount, UnitDiscountedPrice, ExpectedGratisQuantity, IsFreeItem, RecievedGratisQuantity, FreeItemParentID, CurrencyID, SubTotal, Factor, TotalDiscountedPrice, QtyPurchase, LocalAmount, ForeignAmount, IsDifferentQuantity, IsDifferentUnitPrice, IsDifferentGratis, IsDifferentFreeItems, IsDifferentExpiryDate, IsDifferentDiscount, IsNotMatch, HasVAT, TotalVATAmount, VATPercentage, TotalNetAmount, StockUnitCost, CreatedByID, CreatedDate, UpdatedByID, UpdatedDate, LocalExRate, ForeignExRate, ReturnedQty, ReturnedGratisQty) 
                             VALUES (@LineNumber, @PurchaseDeliveryID, @PurchaseDeliveryCode, @PurchaseOrderDetailID, @ItemID, @ItemBrandID, @UnitID, @OrderPrice, @DeliveryPrice, @OrderedQuantity, @RecievedQuantity, @Notes, @PODiscountPercentage, @PODiscountAmount, @DiscountPercentage, @DiscountAmount, @UnitDiscountedPrice, @ExpectedGratisQuantity, @IsFreeItem, @RecievedGratisQuantity, @FreeItemParentID, @CurrencyID, @SubTotal, @Factor, @TotalDiscountedPrice, @QtyPurchase, @LocalAmount, @ForeignAmount, @IsDifferentQuantity, @IsDifferentUnitPrice, @IsDifferentGratis, @IsDifferentFreeItems, @IsDifferentExpiryDate, @IsDifferentDiscount, @IsNotMatch, @HasVAT, @TotalVATAmount, @VATPercentage, @TotalNetAmount, @StockUnitCost, @CreatedByID, @CreatedDate, @UpdatedByID, @UpdatedDate, @LocalExRate, @ForeignExRate, @ReturnedQty, @ReturnedGratisQty)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@LineNumber", lineNumber);
                command.Parameters.AddWithValue("@PurchaseDeliveryID", (object)purchaseDeliveryID ?? DBNull.Value);
                command.Parameters.AddWithValue("@PurchaseDeliveryCode", purchaseDeliveryCode);
                command.Parameters.AddWithValue("@PurchaseOrderDetailID", (object)purchaseOrderDetailID ?? DBNull.Value);
                command.Parameters.AddWithValue("@ItemID", (object)itemID ?? DBNull.Value);
                command.Parameters.AddWithValue("@ItemBrandID", (object)itemBrandID ?? DBNull.Value);
                command.Parameters.AddWithValue("@UnitID", (object)unitID ?? DBNull.Value);
                command.Parameters.AddWithValue("@OrderPrice", (object)orderPrice ?? DBNull.Value);
                command.Parameters.AddWithValue("@DeliveryPrice", (object)deliveryPrice ?? DBNull.Value);
                command.Parameters.AddWithValue("@OrderedQuantity", (object)orderedQuantity ?? DBNull.Value);
                command.Parameters.AddWithValue("@RecievedQuantity", (object)receivedQuantity ?? DBNull.Value);
                command.Parameters.AddWithValue("@Notes", notes);
                command.Parameters.AddWithValue("@PODiscountPercentage", (object)poDiscountPercentage ?? DBNull.Value);
                command.Parameters.AddWithValue("@PODiscountAmount", (object)poDiscountAmount ?? DBNull.Value);
                command.Parameters.AddWithValue("@DiscountPercentage", (object)discountPercentage ?? DBNull.Value);
                command.Parameters.AddWithValue("@DiscountAmount", (object)discountAmount ?? DBNull.Value);
                command.Parameters.AddWithValue("@UnitDiscountedPrice", (object)unitDiscountedPrice ?? DBNull.Value);
                command.Parameters.AddWithValue("@ExpectedGratisQuantity", (object)expectedGratisQuantity ?? DBNull.Value);
                command.Parameters.AddWithValue("@IsFreeItem", (object)isFreeItem ?? DBNull.Value);
                command.Parameters.AddWithValue("@RecievedGratisQuantity", (object)receivedGratisQuantity ?? DBNull.Value);
                command.Parameters.AddWithValue("@FreeItemParentID", (object)freeItemParentID ?? DBNull.Value);
                command.Parameters.AddWithValue("@CurrencyID", (object)currencyID ?? DBNull.Value);
                command.Parameters.AddWithValue("@SubTotal", (object)subTotal ?? DBNull.Value);
                command.Parameters.AddWithValue("@Factor", (object)factor ?? DBNull.Value);
                command.Parameters.AddWithValue("@TotalDiscountedPrice", (object)totalDiscountedPrice ?? DBNull.Value);
                command.Parameters.AddWithValue("@QtyPurchase", (object)qtyPurchase ?? DBNull.Value);
                command.Parameters.AddWithValue("@LocalAmount", (object)localAmount ?? DBNull.Value);
                command.Parameters.AddWithValue("@ForeignAmount", (object)foreignAmount ?? DBNull.Value);
                command.Parameters.AddWithValue("@IsDifferentQuantity", (object)isDifferentQuantity ?? DBNull.Value);
                command.Parameters.AddWithValue("@IsDifferentUnitPrice", (object)isDifferentUnitPrice ?? DBNull.Value);
                command.Parameters.AddWithValue("@IsDifferentGratis", (object)isDifferentGratis ?? DBNull.Value);
                command.Parameters.AddWithValue("@IsDifferentFreeItems", (object)isDifferentFreeItems ?? DBNull.Value);
                command.Parameters.AddWithValue("@IsDifferentExpiryDate", (object)isDifferentExpiryDate ?? DBNull.Value);
                command.Parameters.AddWithValue("@IsDifferentDiscount", (object)isDifferentDiscount ?? DBNull.Value);
                command.Parameters.AddWithValue("@IsNotMatch", (object)isNotMatch ?? DBNull.Value);
                command.Parameters.AddWithValue("@HasVAT", (object)hasVAT ?? DBNull.Value);
                command.Parameters.AddWithValue("@TotalVATAmount", (object)totalVATAmount ?? DBNull.Value);
                command.Parameters.AddWithValue("@VATPercentage", (object)vatPercentage ?? DBNull.Value);
                command.Parameters.AddWithValue("@TotalNetAmount", (object)totalNetAmount ?? DBNull.Value);
                command.Parameters.AddWithValue("@StockUnitCost", (object)stockUnitCost ?? DBNull.Value);
                command.Parameters.AddWithValue("@CreatedByID", (object)createdByID ?? DBNull.Value);
                command.Parameters.AddWithValue("@CreatedDate", (object)createdDate ?? DBNull.Value);
                command.Parameters.AddWithValue("@UpdatedByID", (object)updatedByID ?? DBNull.Value);
                command.Parameters.AddWithValue("@UpdatedDate", (object)updatedDate ?? DBNull.Value);
                command.Parameters.AddWithValue("@LocalExRate", (object)localExRate ?? DBNull.Value);
                command.Parameters.AddWithValue("@ForeignExRate", (object)foreignExRate ?? DBNull.Value);
                command.Parameters.AddWithValue("@ReturnedQty", (object)returnedQty ?? DBNull.Value);
                command.Parameters.AddWithValue("@ReturnedGratisQty", (object)returnedGratisQty ?? DBNull.Value);

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

        public void UpdatePurchaseDeliveryDetail(int id, int lineNumber, int? purchaseDeliveryID, string purchaseDeliveryCode, int? purchaseOrderDetailID, int? itemID, int? itemBrandID, int? unitID, decimal? orderPrice, decimal? deliveryPrice, decimal? orderedQuantity, decimal? receivedQuantity, string notes, decimal? poDiscountPercentage, decimal? poDiscountAmount, decimal? discountPercentage, decimal? discountAmount, decimal? unitDiscountedPrice, decimal? expectedGratisQuantity, bool? isFreeItem, decimal? receivedGratisQuantity, int? freeItemParentID, int? currencyID, decimal? subTotal, decimal? factor, decimal? totalDiscountedPrice, decimal? qtyPurchase, decimal? localAmount, decimal? foreignAmount, bool? isDifferentQuantity, bool? isDifferentUnitPrice, bool? isDifferentGratis, bool? isDifferentFreeItems, bool? isDifferentExpiryDate, bool? isDifferentDiscount, bool? isNotMatch, bool? hasVAT, decimal? totalVATAmount, decimal? vatPercentage, decimal? totalNetAmount, decimal? stockUnitCost, int? createdByID, DateTime? createdDate, int? updatedByID, DateTime? updatedDate, decimal? localExRate, decimal? foreignExRate, decimal? returnedQty, decimal? returnedGratisQty)
        {
            using (SqlConnection connection = new SqlConnection(""))
            {
                string query = @"UPDATE PurchaseDeliveryDetail 
                         SET LineNumber = @LineNumber, PurchaseDeliveryID = @PurchaseDeliveryID, PurchaseDeliveryCode = @PurchaseDeliveryCode, PurchaseOrderDetailID = @PurchaseOrderDetailID, ItemID = @ItemID, ItemBrandID = @ItemBrandID, UnitID = @UnitID, OrderPrice = @OrderPrice, DeliveryPrice = @DeliveryPrice, OrderedQuantity = @OrderedQuantity, RecievedQuantity = @RecievedQuantity, Notes = @Notes, PODiscountPercentage = @PODiscountPercentage, PODiscountAmount = @PODiscountAmount, DiscountPercentage = @DiscountPercentage, DiscountAmount = @DiscountAmount, UnitDiscountedPrice = @UnitDiscountedPrice, ExpectedGratisQuantity = @ExpectedGratisQuantity, IsFreeItem = @IsFreeItem, RecievedGratisQuantity = @RecievedGratisQuantity, FreeItemParentID = @FreeItemParentID, CurrencyID = @CurrencyID, SubTotal = @SubTotal, Factor = @Factor, TotalDiscountedPrice = @TotalDiscountedPrice, QtyPurchase = @QtyPurchase, LocalAmount = @LocalAmount, ForeignAmount = @ForeignAmount, IsDifferentQuantity = @IsDifferentQuantity, IsDifferentUnitPrice = @IsDifferentUnitPrice, IsDifferentGratis = @IsDifferentGratis, IsDifferentFreeItems = @IsDifferentFreeItems, IsDifferentExpiryDate = @IsDifferentExpiryDate, IsDifferentDiscount = @IsDifferentDiscount, IsNotMatch = @IsNotMatch, HasVAT = @HasVAT, TotalVATAmount = @TotalVATAmount, VATPercentage = @VATPercentage, TotalNetAmount = @TotalNetAmount, StockUnitCost = @StockUnitCost, CreatedByID = @CreatedByID, CreatedDate = @CreatedDate, UpdatedByID = @UpdatedByID, UpdatedDate = @UpdatedDate, LocalExRate = @LocalExRate, ForeignExRate = @ForeignExRate, ReturnedQty = @ReturnedQty, ReturnedGratisQty = @ReturnedGratisQty 
                         WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@LineNumber", lineNumber);
                command.Parameters.AddWithValue("@PurchaseDeliveryID", (object)purchaseDeliveryID ?? DBNull.Value);
                command.Parameters.AddWithValue("@PurchaseDeliveryCode", purchaseDeliveryCode);
                command.Parameters.AddWithValue("@PurchaseOrderDetailID", (object)purchaseOrderDetailID ?? DBNull.Value);
                command.Parameters.AddWithValue("@ItemID", (object)itemID ?? DBNull.Value);
                command.Parameters.AddWithValue("@ItemBrandID", (object)itemBrandID ?? DBNull.Value);
                command.Parameters.AddWithValue("@UnitID", (object)unitID ?? DBNull.Value);
                command.Parameters.AddWithValue("@OrderPrice", (object)orderPrice ?? DBNull.Value);
                command.Parameters.AddWithValue("@DeliveryPrice", (object)deliveryPrice ?? DBNull.Value);
                command.Parameters.AddWithValue("@OrderedQuantity", (object)orderedQuantity ?? DBNull.Value);
                command.Parameters.AddWithValue("@RecievedQuantity", (object)receivedQuantity ?? DBNull.Value);
                command.Parameters.AddWithValue("@Notes", notes);
                command.Parameters.AddWithValue("@PODiscountPercentage", (object)poDiscountPercentage ?? DBNull.Value);
                command.Parameters.AddWithValue("@PODiscountAmount", (object)poDiscountAmount ?? DBNull.Value);
                command.Parameters.AddWithValue("@DiscountPercentage", (object)discountPercentage ?? DBNull.Value);
                command.Parameters.AddWithValue("@DiscountAmount", (object)discountAmount ?? DBNull.Value);
                command.Parameters.AddWithValue("@UnitDiscountedPrice", (object)unitDiscountedPrice ?? DBNull.Value);
                command.Parameters.AddWithValue("@ExpectedGratisQuantity", (object)expectedGratisQuantity ?? DBNull.Value);
                command.Parameters.AddWithValue("@IsFreeItem", (object)isFreeItem ?? DBNull.Value);
                command.Parameters.AddWithValue("@RecievedGratisQuantity", (object)receivedGratisQuantity ?? DBNull.Value);
                command.Parameters.AddWithValue("@FreeItemParentID", (object)freeItemParentID ?? DBNull.Value);
                command.Parameters.AddWithValue("@CurrencyID", (object)currencyID ?? DBNull.Value);
                command.Parameters.AddWithValue("@SubTotal", (object)subTotal ?? DBNull.Value);
                command.Parameters.AddWithValue("@Factor", (object)factor ?? DBNull.Value);
                command.Parameters.AddWithValue("@TotalDiscountedPrice", (object)totalDiscountedPrice ?? DBNull.Value);
                command.Parameters.AddWithValue("@QtyPurchase", (object)qtyPurchase ?? DBNull.Value);
                command.Parameters.AddWithValue("@LocalAmount", (object)localAmount ?? DBNull.Value);
                command.Parameters.AddWithValue("@ForeignAmount", (object)foreignAmount ?? DBNull.Value);
                command.Parameters.AddWithValue("@IsDifferentQuantity", (object)isDifferentQuantity ?? DBNull.Value);
                command.Parameters.AddWithValue("@IsDifferentUnitPrice", (object)isDifferentUnitPrice ?? DBNull.Value);
                command.Parameters.AddWithValue("@IsDifferentGratis", (object)isDifferentGratis ?? DBNull.Value);
                command.Parameters.AddWithValue("@IsDifferentFreeItems", (object)isDifferentFreeItems ?? DBNull.Value);
                command.Parameters.AddWithValue("@IsDifferentExpiryDate", (object)isDifferentExpiryDate ?? DBNull.Value);
                command.Parameters.AddWithValue("@IsDifferentDiscount", (object)isDifferentDiscount ?? DBNull.Value);
                command.Parameters.AddWithValue("@IsNotMatch", (object)isNotMatch ?? DBNull.Value);
                command.Parameters.AddWithValue("@HasVAT", (object)hasVAT ?? DBNull.Value);
                command.Parameters.AddWithValue("@TotalVATAmount", (object)totalVATAmount ?? DBNull.Value);
                command.Parameters.AddWithValue("@VATPercentage", (object)vatPercentage ?? DBNull.Value);
                command.Parameters.AddWithValue("@TotalNetAmount", (object)totalNetAmount ?? DBNull.Value);
                command.Parameters.AddWithValue("@StockUnitCost", (object)stockUnitCost ?? DBNull.Value);
                command.Parameters.AddWithValue("@CreatedByID", (object)createdByID ?? DBNull.Value);
                command.Parameters.AddWithValue("@CreatedDate", (object)createdDate ?? DBNull.Value);
                command.Parameters.AddWithValue("@UpdatedByID", (object)updatedByID ?? DBNull.Value);
                command.Parameters.AddWithValue("@UpdatedDate", (object)updatedDate ?? DBNull.Value);
                command.Parameters.AddWithValue("@LocalExRate", (object)localExRate ?? DBNull.Value);
                command.Parameters.AddWithValue("@ForeignExRate", (object)foreignExRate ?? DBNull.Value);
                command.Parameters.AddWithValue("@ReturnedQty", (object)returnedQty ?? DBNull.Value);
                command.Parameters.AddWithValue("@ReturnedGratisQty", (object)returnedGratisQty ?? DBNull.Value);

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




    }
}