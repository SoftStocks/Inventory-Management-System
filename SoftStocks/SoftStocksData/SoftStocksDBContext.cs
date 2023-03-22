using SoftStocksData.Entities.Keyboards;
using SoftStocksData.Entities.Purchases;
using SoftStocksData.Entities.StaffMember;
using SoftStocksData.Entities.Supplier;
using SoftStocksData.Keyboards;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

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
            this.SetDefaultConnectionFactory(new SqlConnectionFactory("Server=tcp:softstocks.database.windows.net,1433;Initial Catalog=softstocksdb;Persist Security Info=False;User ID=CloudSA45aa00f9;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"));
            this.SetProviderServices("System.Data.SqlClient", System.Data.Entity.SqlServer.SqlProviderServices.Instance);
        }

    }

}