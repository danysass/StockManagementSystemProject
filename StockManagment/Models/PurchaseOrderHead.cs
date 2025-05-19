using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagment.Models
{
    internal class PurchaseOrderHead
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? SupplierID { get; set; }
        public string PreparedBy { get; set; }
        public DateTime? SentDate { get; set; }
        public bool? OrderSent { get; set; }
        public string SentType { get; set; }
        public bool? Received { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public string ReceivedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedMachine { get; set; }
        public string CreatedUser { get; set; }
    }
}
