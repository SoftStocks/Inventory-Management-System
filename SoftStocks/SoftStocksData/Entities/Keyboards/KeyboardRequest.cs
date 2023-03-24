using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftStocksData.Keyboards
{
    public class KeyboardRequest
    {
        [Key]
        public int Id { get; set; }
        public int ModelNumber { get; set; }
        public int PurchaseRequestId { get; set; }
    }
}
