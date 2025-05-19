using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagment.Services
{
    internal static class TransactionServices
    {

        //Insert Head


        public static  void InsertTransactionHead()
        {

            SqlConnection connection = new SqlConnection(AAServerCon.GetServerConnection());
            SqlCommand command = new SqlCommand();
            command.Connection = connection;    
            connection.Open();
                string query = @"INSERT INTO TransactionHead (Code, TransactionDate, TransactionType, SupplierId, AccountNumber, AccountingLabel, 
                            InvoiceNumber, InvoiceDate, Currency, TauxLBP, TauxUSD, TVA, TVAAmmount, Discount, DiscountLBP, DiscountUSD,
                            TotalCurrency, TotalLBP, TotalUSD, DiscountValue, TVAValue, NetCurrency, NetLBP, NetUSD, Printed, PrintedDate, 
                            Locked, LockedDate, Transfered, TransferedDate, CreatedDate, CreatedBy, CreatedMachine)
                            VALUES (@Code, @TransactionDate, @TransactionType, @SupplierId, @AccountNumber, @AccountingLabel, 
                            @InvoiceNumber, @InvoiceDate, @Currency, @TauxLBP, @TauxUSD, @TVA, @TVAAmmount, @Discount, @DiscountLBP, @DiscountUSD,
                            @TotalCurrency, @TotalLBP, @TotalUSD, @DiscountValue, @TVAValue, @NetCurrency, @NetLBP, @NetUSD, @Printed, @PrintedDate, 
                            @Locked, @LockedDate, @Transfered, @TransferedDate, @CreatedDate, @CreatedBy, @CreatedMachine)";
                            //command.Parameters.AddWithValue("@Code", transaction.Code);
                            //command.Parameters.AddWithValue("@TransactionDate", transaction.TransactionDate);
                            //command.Parameters.AddWithValue("@TransactionType", transaction.TransactionType);
                            //command.Parameters.AddWithValue("@SupplierId", transaction.SupplierId);
                            //command.Parameters.AddWithValue("@AccountNumber", transaction.AccountNumber);
                            //command.Parameters.AddWithValue("@AccountingLabel", transaction.AccountingLabel);
                            //command.Parameters.AddWithValue("@InvoiceNumber", transaction.InvoiceNumber);
                            //command.Parameters.AddWithValue("@InvoiceDate", transaction.InvoiceDate);
                            //command.Parameters.AddWithValue("@Currency", transaction.Currency);
                            //command.Parameters.AddWithValue("@TauxLBP", transaction.TauxLBP);
                            //command.Parameters.AddWithValue("@TauxUSD", transaction.TauxUSD);
                            //command.Parameters.AddWithValue("@TVA", transaction.TVA);
                            //command.Parameters.AddWithValue("@TVAAmmount", transaction.TVAAmmount);
                            //command.Parameters.AddWithValue("@Discount", transaction.Discount);
                            //command.Parameters.AddWithValue("@DiscountLBP", transaction.DiscountLBP);
                            //command.Parameters.AddWithValue("@DiscountUSD", transaction.DiscountUSD);
                            //command.Parameters.AddWithValue("@TotalCurrency", transaction.TotalCurrency);


                            command.ExecuteNonQuery();
                
            }
        


    }
}
