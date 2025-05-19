using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagment.Models
{
    using System;

    public class TransactionHead
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string TransactionType { get; set; }
        public int? SupplierId { get; set; }
        public string AccountNumber { get; set; }
        public string AccountingLabel { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public int? Currency { get; set; }
        public decimal? TauxLBP { get; set; }
        public decimal? TauxUSD { get; set; }
        public decimal? TVA { get; set; }
        public decimal? TVAAmmount { get; set; }
        public decimal? Discount { get; set; }
        public decimal? DiscountLBP { get; set; }
        public decimal? DiscountUSD { get; set; }
        public decimal? TotalCurrency { get; set; }
        public decimal? TotalLBP { get; set; }
        public decimal? TotalUSD { get; set; }
        public decimal? DiscountValue { get; set; }
        public decimal? TVAValue { get; set; }
        public decimal? NetCurrency { get; set; }
        public decimal? NetLBP { get; set; }
        public decimal? NetUSD { get; set; }
        public bool? Printed { get; set; }
        public DateTime? PrintedDate { get; set; }
        public bool? Locked { get; set; }
        public DateTime? LockedDate { get; set; }
        public bool? Transfered { get; set; }
        public DateTime? TransferedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedMachine { get; set; }

        // Constructor
        public TransactionHead()
        {
            // You can set default values or perform additional initialization here if needed
        }
    }

}
