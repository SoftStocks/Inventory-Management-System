using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlTypes;
using System.Net;

namespace SoftStocksData
{
    [DbConfigurationType(typeof(SoftStocksDBConfiguration))]
    public class SoftStocksDBContext : DbContext
    {
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Credential> Credentials { get; set; }
        public DbSet<Keyboard> Keyboards { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<KeyboardRequest> KeyboardRequests { get; set; }
        public DbSet<PurchaseRequest> PurchaseRequests { get; set; }

    }

    public class SoftStocksDBConfiguration : DbConfiguration
    {
        public SoftStocksDBConfiguration()
        {
            this.SetDefaultConnectionFactory(new SqlConnectionFactory("Data Source=(LocalDB)\\MSSQLLocalDB;Integrated Security=True")); //Data Source=(LocalDB)\\MSSQLLocalDB
            this.SetProviderServices("System.Data.SqlClient", System.Data.Entity.SqlServer.SqlProviderServices.Instance);
        }

    }
    
    public class Keyboard
    {
        [Key]
        public int ModelNumber { get; set; }
        public int SupplierId { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public SqlMoney Price { get; set; }
    }

    public class KeyboardRequest
    {
        [Key]
        public int Id { get; set; }
        public string ModelNumber { get; set; }
        public int PurchaseRequestId { get; set; }
    }

    public class Supplier
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string PrimaryContact { get; set; }
        public string BusinessAddress { get; set; }
        public int NumberOfPurchases { get; set; }
    }

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