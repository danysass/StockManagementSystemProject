using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.SqlClient;
using StockManagment.Models;
using System.Data;
namespace StockManagment.Services
{
    internal class PurshaseOrderService
    {


       
           
            public void CreatePurchaseOrderHead(PurchaseOrderHead purchaseOrder)
            {
                using (SqlConnection connection = new SqlConnection(AAServerCon.GetServerConnection()))
                {
                    connection.Open();

                    string sql = "INSERT INTO PurchaseOrderHead (Code, OrderDate, SupplierID, PreparedBy, SentDate, OrderSent, SentType, Received, ReceivedDate, ReceivedBy, CreatedDate, CreatedMachine, CreatedUser) " +
                                 "VALUES (@Code, @OrderDate, @SupplierID, @PreparedBy, @SentDate, @OrderSent, @SentType, @Received, @ReceivedDate, @ReceivedBy, @CreatedDate, @CreatedMachine, @CreatedUser)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Code", purchaseOrder.Code);
                        command.Parameters.AddWithValue("@OrderDate", purchaseOrder.OrderDate);
                        command.Parameters.AddWithValue("@SupplierID", purchaseOrder.SupplierID);
                        command.Parameters.AddWithValue("@PreparedBy", purchaseOrder.PreparedBy);
                        command.Parameters.AddWithValue("@SentDate", purchaseOrder.SentDate);
                        command.Parameters.AddWithValue("@OrderSent", purchaseOrder.OrderSent);
                        command.Parameters.AddWithValue("@SentType", purchaseOrder.SentType);
                        command.Parameters.AddWithValue("@Received", purchaseOrder.Received);
                        command.Parameters.AddWithValue("@ReceivedDate", purchaseOrder.ReceivedDate);
                        command.Parameters.AddWithValue("@ReceivedBy", purchaseOrder.ReceivedBy);
                        command.Parameters.AddWithValue("@CreatedDate", purchaseOrder.CreatedDate);
                        command.Parameters.AddWithValue("@CreatedMachine", purchaseOrder.CreatedMachine);
                        command.Parameters.AddWithValue("@CreatedUser", purchaseOrder.CreatedUser);

                        command.ExecuteNonQuery();
                    }
                }
            }
            DataTable PurshaseOrderHeadDataTable = null;
            public PurchaseOrderHead GetPurchaseOrderHeadById(PurchaseOrderHead purchaseOrder, int id)
            {
                PurshaseOrderHeadDataTable = new DataTable();
                using (SqlConnection connection = new SqlConnection(AAServerCon.GetServerConnection()))
                {
                    connection.Open();

                    string sql = "SELECT * FROM PurchaseOrderHead WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                PurshaseOrderHeadDataTable.Load(reader);
                            }
                        }
                    }
                }

                return null;
            }

            public void UpdatePurchaseOrderHead(PurchaseOrderHead purchaseOrder)
            {
                using (SqlConnection connection = new SqlConnection(AAServerCon.GetServerConnection()))
                {
                    connection.Open();

                    string sql = "UPDATE PurchaseOrderHead SET Code = @Code, OrderDate = @OrderDate, SupplierID = @SupplierID, " +
                                 "PreparedBy = @PreparedBy, SentDate = @SentDate, OrderSent = @OrderSent, SentType = @SentType, " +
                                 "Received = @Received, ReceivedDate = @ReceivedDate, ReceivedBy = @ReceivedBy, " +
                                 "CreatedDate = @CreatedDate, CreatedMachine = @CreatedMachine, CreatedUser = @CreatedUser " +
                                 "WHERE Id = @Id";

                }
            } 
        
        
        } 
    
    
    
    }
