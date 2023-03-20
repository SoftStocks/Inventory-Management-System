using System.ComponentModel.DataAnnotations;

namespace SoftStocksData
{
    public class Staff
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Title { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Role { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        public float Salary { get; set; }
    }
}
