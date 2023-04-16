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
		[Required]
		public long Identifier { get; set; }
		[Required]
        public int ModelNumber { get; set; }
		[Required]
		public int Quantity { get; set; }
        public string Status { get; set; }
		public int StaffId { get; set; }
		public DateTime DateCreated { get; set; }
	}
}
