using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftStocksData
{
    public class Credential
    {
        [Key]
        public string Username { get; set; }
        [Required]
        public int StaffId { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
