using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftStocksData.Entities.Purchases
{
    public class PurchaseRequest
    {
        [Key]
        public int Id { get; set; }
        public int KeyboardRequestId { get; set; }
        public int Quantity { get; set; }
        public int StaffId { get; set; }
        public bool Approved { get; set; }
    }
}
