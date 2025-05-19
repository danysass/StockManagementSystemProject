using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagment.Models
{
   


    internal class ItemClass
    {


        private string connectionString;

       
        public void CreateItem(string nameEnglish, string nameArabic, string nameFrench, string displayName, string code, int? parentId, bool? isParent, string referenceNumber, string barcodeNumber, int? unitId, string picture, int? categoryId, double? minOrderQty, double? maxOrderQty, double? orderPoint, double? maxLevel, double? minLevel, double? standardOrderQty, bool? isSellable, bool? isPurchasable, bool? expires, int? quantityOnHand, double? similarQuantityNet, int? prefferedSupplierId, double? lastPurchasePrice, int? lastPurchaseCurrencyId, DateTime? lastPurchaseDate, int? lastPurchaseSupplierId, double? bestPurchasePrice, int? bestPurchaseCurrencyId, DateTime? bestPurchaseDate, int? bestPurchaseSupplierId, string description, int? surgerySetId, int? purchaseUnitId, decimal? pFactor, string mohCode, double? publicPriceLbp, int? minNoDaysForExDate, bool? hasVat, double? vatValue, int? countryOriginId, int? medicalProcedureId, double? acu, bool? isActive, int? createdById, DateTime? createdDate, int? updatedById, DateTime? updatedDate, string presentation, int? presentationUnitId, decimal? presentationFactor, double? presentationPublicPriceLbp, double? foreignAcu, double? localLastPurchasePrice, double? foreignLastPurchasePrice)
        {
            string query = @"INSERT INTO [Items] ([NameEnglish], [NameArabic], [NameFrench], [DisplayName], [Code], [ParentID], [IsParent], [ReferenceNumber], [BarcodeNumber], [UnitID], [Picture], [CategoryID], [MinOrderQty], [MaxOrderQty], [OrderPoint], [MaxLevel], [MinLevel], [StandardOrderQty], [IsSellable], [IsPurchasable], [Expires], [QuantityOnHand], [SimilarQuantityNet], [PrefferedSupplierID], [LastPurchasePrice], [LastPurchaseCurrencyID], [LastPurchaseDate], [LastPurchaseSupplierID], [BestPurchasePrice], [BestPurchaseCurrencyID], [BestPurchaseDate], [BestPurchaseSupplierID], [Description], [SurgerySetID], [PurchaseUnitID], [PFactor], [MOHCode], [PublicPriceLBP], [MinNoDaysforExDate], [HasVAT], [VATValue], [CountryOriginID], [MedicalProcedureID], [ACU], [IsActive], [CreatedByID], [CreatedDate], [UpdatedByID], [UpdatedDate], [Presentation], [PresentationUnitID], [PresentationFactor], [PresentationPublicPriceLBP], [ForeignACU], [LocalLastPurchasePrice], [ForeignLastPurchasePrice])
                        VALUES (@NameEnglish, @NameArabic, @NameFrench, @DisplayName, @Code, @ParentID, @IsParent, @ReferenceNumber, @BarcodeNumber, @UnitID, @Picture, @CategoryID, @MinOrderQty, @MaxOrderQty, @OrderPoint, @MaxLevel, @MinLevel, @StandardOrderQty, @IsSellable, @IsPurchasable, @Expires, @QuantityOnHand, @SimilarQuantityNet, @PrefferedSupplierID, @LastPurchasePrice, @LastPurchaseCurrencyID, @LastPurchaseDate, @LastPurchaseSupplierID, @BestPurchasePrice, @BestPurchaseCurrencyID, @BestPurchaseDate, @BestPurchaseSupplierID, @Description, @SurgerySetID, @PurchaseUnitID, @PFactor, @MOHCode, @PublicPriceLBP, @MinNoDaysforExDate, @HasVAT, @VATValue, @CountryOriginID, @MedicalProcedureID, @ACU, @IsActive, @CreatedByID, @CreatedDate, @UpdatedByID, @UpdatedDate, @Presentation, @PresentationUnitID, @PresentationFactor, @PresentationPublicPriceLBP, @ForeignACU, @LocalLastPurchasePrice, @ForeignLastPurchasePrice)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NameEnglish", nameEnglish);
                    command.Parameters.AddWithValue("@NameArabic", nameArabic);
                    command.Parameters.AddWithValue("@NameFrench", nameFrench);
                    command.Parameters.AddWithValue("@DisplayName", displayName);
                    command.Parameters.AddWithValue("@Code", code);
                    command.Parameters.AddWithValue("@ParentID", (object)parentId ?? DBNull.Value);
                    command.Parameters.AddWithValue("@IsParent", (object)isParent ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ReferenceNumber", referenceNumber);
                    command.Parameters.AddWithValue("@BarcodeNumber", barcodeNumber);
                    command.Parameters.AddWithValue("@UnitID", (object)unitId ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Picture", picture);
                    command.Parameters.AddWithValue("@CategoryID", (object)categoryId ?? DBNull.Value);
                    command.Parameters.AddWithValue("@MinOrderQty", (object)minOrderQty ?? DBNull.Value);
                    command.Parameters.AddWithValue("@MaxOrderQty", (object)maxOrderQty ?? DBNull.Value);
                    command.Parameters.AddWithValue("@OrderPoint", (object)orderPoint ?? DBNull.Value);
                    command.Parameters.AddWithValue("@MaxLevel", (object)maxLevel ?? DBNull.Value);
                    command.Parameters.AddWithValue("@MinLevel", (object)minLevel ?? DBNull.Value);
                    command.Parameters.AddWithValue("@StandardOrderQty", (object)standardOrderQty ?? DBNull.Value);
                    command.Parameters.AddWithValue("@IsSellable", (object)isSellable ?? DBNull.Value);
                    command.Parameters.AddWithValue("@IsPurchasable", (object)isPurchasable ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Expires", (object)expires ?? DBNull.Value);
                    command.Parameters.AddWithValue("@QuantityOnHand", (object)quantityOnHand ?? DBNull.Value);
                    command.Parameters.AddWithValue("@SimilarQuantityNet", (object)similarQuantityNet ?? DBNull.Value);
                    command.Parameters.AddWithValue("@PrefferedSupplierID", (object)prefferedSupplierId ?? DBNull.Value);
                    command.Parameters.AddWithValue("@LastPurchasePrice", (object)lastPurchasePrice ?? DBNull.Value);
                    command.Parameters.AddWithValue("@LastPurchaseCurrencyID", (object)lastPurchaseCurrencyId ?? DBNull.Value);
                    command.Parameters.AddWithValue("@LastPurchaseDate", (object)lastPurchaseDate ?? DBNull.Value);
                    command.Parameters.AddWithValue("@LastPurchaseSupplierID", (object)lastPurchaseSupplierId ?? DBNull.Value);
                    command.Parameters.AddWithValue("@BestPurchasePrice", (object)bestPurchasePrice ?? DBNull.Value);
                    command.Parameters.AddWithValue("@BestPurchaseCurrencyID", (object)bestPurchaseCurrencyId ?? DBNull.Value);
                    command.Parameters.AddWithValue("@BestPurchaseDate", (object)bestPurchaseDate ?? DBNull.Value);
                    command.Parameters.AddWithValue("@BestPurchaseSupplierID", (object)bestPurchaseSupplierId ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@SurgerySetID", (object)surgerySetId ?? DBNull.Value);
                    command.Parameters.AddWithValue("@PurchaseUnitID", (object)purchaseUnitId ?? DBNull.Value);
                    command.Parameters.AddWithValue("@PFactor", (object)pFactor ?? DBNull.Value);
                    command.Parameters.AddWithValue("@MOHCode", mohCode);
                    command.Parameters.AddWithValue("@PublicPriceLBP", (object)publicPriceLbp ?? DBNull.Value);
                    command.Parameters.AddWithValue("@MinNoDaysforExDate", (object)minNoDaysForExDate ?? DBNull.Value);
                    command.Parameters.AddWithValue("@HasVAT", (object)hasVat ?? DBNull.Value);
                    command.Parameters.AddWithValue("@VATValue", (object)vatValue ?? DBNull.Value);
                    command.Parameters.AddWithValue("@CountryOriginID", (object)countryOriginId ?? DBNull.Value);
                    command.Parameters.AddWithValue("@MedicalProcedureID", (object)medicalProcedureId ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ACU", (object)acu ?? DBNull.Value);
                    command.Parameters.AddWithValue("@IsActive", (object)isActive ?? DBNull.Value);
                    command.Parameters.AddWithValue("@CreatedByID", (object)createdById ?? DBNull.Value);
                    command.Parameters.AddWithValue("@CreatedDate", (object)createdDate ?? DBNull.Value);
                    command.Parameters.AddWithValue("@UpdatedByID", (object)updatedById ?? DBNull.Value);
                    command.Parameters.AddWithValue("@UpdatedDate", (object)updatedDate ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Presentation", presentation);
                    command.Parameters.AddWithValue("@PresentationUnitID", (object)presentationUnitId ?? DBNull.Value);
                    command.Parameters.AddWithValue("@PresentationFactor", (object)presentationFactor ?? DBNull.Value);
                    command.Parameters.AddWithValue("@PresentationPublicPriceLBP", (object)presentationPublicPriceLbp ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ForeignACU", (object)foreignAcu ?? DBNull.Value);
                    command.Parameters.AddWithValue("@LocalLastPurchasePrice", (object)localLastPurchasePrice ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ForeignLastPurchasePrice", (object)foreignLastPurchasePrice ?? DBNull.Value);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateItem(int itemId, string nameEnglish, string nameArabic, string nameFrench, string displayName, string code, int? parentId, bool? isParent, string referenceNumber, string barcodeNumber, int? unitId, string picture, int? categoryId, double? minOrderQty, double? maxOrderQty, double? orderPoint, double? maxLevel, double? minLevel, double? standardOrderQty, bool? isSellable, bool? isPurchasable, bool? expires, int? quantityOnHand, double? similarQuantityNet, int? prefferedSupplierId, double? lastPurchasePrice, int? lastPurchaseCurrencyId, DateTime? lastPurchaseDate, int? lastPurchaseSupplierId, double? bestPurchasePrice, int? bestPurchaseCurrencyId, DateTime? bestPurchaseDate, int? bestPurchaseSupplierId, string description, int? surgerySetId, int? purchaseUnitId, decimal? pFactor, string mohCode, double? publicPriceLbp, int? minNoDaysForExDate, bool? hasVat, double? vatValue, int? countryOriginId, int? medicalProcedureId, double? acu, bool? isActive, int? updatedById, DateTime? updatedDate, string presentation, int? presentationUnitId, decimal? presentationFactor, double? presentationPublicPriceLbp, double? foreignAcu, double? localLastPurchasePrice, double? foreignLastPurchasePrice)
        {
            string query = @"UPDATE [Items] SET [NameEnglish] = @NameEnglish, [NameArabic] = @NameArabic, [NameFrench] = @NameFrench, [DisplayName] = @DisplayName, [Code] = @Code, [ParentID] = @ParentID, [IsParent] = @IsParent, [ReferenceNumber] = @ReferenceNumber, [BarcodeNumber] = @BarcodeNumber, [UnitID] = @UnitID, [Picture] = @Picture, [CategoryID] = @CategoryID, [MinOrderQty] = @MinOrderQty, [MaxOrderQty] = @MaxOrderQty, [OrderPoint] = @OrderPoint, [MaxLevel] = @MaxLevel, [MinLevel] = @MinLevel, [StandardOrderQty] = @StandardOrderQty, [IsSellable] = @IsSellable, [IsPurchasable] = @IsPurchasable, [Expires] = @Expires, [QuantityOnHand] = @QuantityOnHand, [SimilarQuantityNet] = @SimilarQuantityNet, [PrefferedSupplierID] = @PrefferedSupplierID, [LastPurchasePrice] = @LastPurchasePrice, [LastPurchaseCurrencyID] = @LastPurchaseCurrencyID, [LastPurchaseDate] = @LastPurchaseDate, [LastPurchaseSupplierID] = @LastPurchaseSupplierID, [BestPurchasePrice] = @BestPurchasePrice, [BestPurchaseCurrencyID] = @BestPurchaseCurrencyID, [BestPurchaseDate] = @BestPurchaseDate, [BestPurchaseSupplierID] = @BestPurchaseSupplierID, [Description] = @Description, [SurgerySetID] = @SurgerySetID, [PurchaseUnitID] = @PurchaseUnitID, [PFactor] = @PFactor, [MOHCode] = @MOHCode, [PublicPriceLBP] = @PublicPriceLBP, [MinNoDaysforExDate] = @MinNoDaysforExDate, [HasVAT] = @HasVAT, [VATValue] = @VATValue, [CountryOriginID] = @CountryOriginID, [MedicalProcedureID] = @MedicalProcedureID, [ACU] = @ACU, [IsActive] = @IsActive, [UpdatedByID] = @UpdatedByID, [UpdatedDate] = @UpdatedDate, [Presentation] = @Presentation, [PresentationUnitID] = @PresentationUnitID, [PresentationFactor] = @PresentationFactor, [PresentationPublicPriceLBP] = @PresentationPublicPriceLBP, [ForeignACU] = @ForeignACU, [LocalLastPurchasePrice] = @LocalLastPurchasePrice, [ForeignLastPurchasePrice] = @ForeignLastPurchasePrice
                        WHERE [Id] = @ItemId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    //command.Parameters.AddWithValue("@ItemId", itemId);
                    //command.Parameters.AddWithValue("@NameEnglish", nameEnglish);
                    //command.Parameters.AddWithValue("@NameArabic", nameArabic);
                    //command.Parameters.AddWithValue("@NameFrench", nameFrench);
                    //command.Parameters.AddWithValue("@DisplayName", displayName);
                    //command.Parameters.AddWithValue("@Code", code);
                    //command.Parameters.AddWithValue("@ParentID", (object)parentId ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@IsParent", (object)isParent ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@ReferenceNumber", referenceNumber);
                    //command.Parameters.AddWithValue("@BarcodeNumber", barcodeNumber);
                    //command.Parameters.AddWithValue("@UnitID", (object)unitId ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@Picture", picture);
                    //command.Parameters.AddWithValue("@CategoryID", (object)categoryId ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@MinOrderQty", (object)minOrderQty ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@MaxOrderQty", (object)maxOrderQty ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@OrderPoint", (object)orderPoint ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@MaxLevel", (object)maxLevel ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@MinLevel", (object)minLevel ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@StandardOrderQty", (object)standardOrderQty ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@IsSellable", (object)isSellable ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@IsPurchasable", (object)isPurchasable ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@Expires", (object)expires ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@QuantityOnHand", (object)quantityOnHand ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@SimilarQuantityNet", (object)similarQuantityNet ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@PrefferedSupplierID", (object)prefferedSupplierId ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@LastPurchasePrice", (object)lastPurchasePrice ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@LastPurchaseCurrencyID", (object)lastPurchaseCurrencyId ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@LastPurchaseDate", (object)lastPurchaseDate ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@LastPurchaseSupplierID", (object)lastPurchaseSupplierId ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@BestPurchasePrice", (object)bestPurchasePrice ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@BestPurchaseCurrencyID", (object)bestPurchaseCurrencyId ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@BestPurchaseDate", (object)bestPurchaseDate ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@BestPurchaseSupplierID", (object)bestPurchaseSupplierId ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@Description", description);
                    //command.Parameters.AddWithValue("@SurgerySetID", (object)surgerySetId ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@PurchaseUnitID", (object)purchaseUnitId ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@PFactor", (object)pFactor ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@MOHCode", mohCode);
                    //command.Parameters.AddWithValue("@PublicPriceLBP", (object)publicPriceLbp ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@MinNoDaysforExDate", (object)minNoDaysForExDate ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@HasVAT", (object)hasVat ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@VATValue", (object)vatValue ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@CountryOriginID", (object)countryOriginId ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@MedicalProcedureID", (object)medicalProcedureId ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@ACU", (object)acu ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@IsActive", (object)isActive ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@CreatedByID", (object)createdById ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@CreatedDate", (object)createdDate ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@UpdatedByID", (object)updatedById ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@UpdatedDate", (object)updatedDate ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@Presentation", presentation);
                    //command.Parameters.AddWithValue("@PresentationUnitID", (object)presentationUnitId ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@PresentationFactor", (object)presentationFactor ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@PresentationPublicPriceLBP", (object)presentationPublicPriceLbp ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@ForeignACU", (object)foreignAcu ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@LocalLastPurchasePrice", (object)localLastPurchasePrice ?? DBNull.Value);
                    //command.Parameters.AddWithValue("@ForeignLastPurchasePrice", (object)foreignLastPurchasePrice ?? DBNull.Value);

                }
            }
        }
            }
            }
