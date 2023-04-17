using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftStocksData.Entities.Keyboards
{
    public class Keyboard
    {
        [Key]
		public int ModelNumber { get; set; }
		[Required]
		public int Ident { get; set; }
		[Required]
		public int SupplierId { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public SqlMoney Price { get; set; }
    }
}
