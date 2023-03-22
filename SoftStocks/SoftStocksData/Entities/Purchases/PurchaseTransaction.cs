using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftStocksData.Entities.Purchases
{
    public class PurchaseTransaction
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int PurchaseRequestId { get; set; }
        [Required]
        public string Type { get; set; }
    }
}
