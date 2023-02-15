﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.SqlTypes;

namespace SoftStocksData
{

    public class SoftStocksDBConfiguration : DbConfiguration
    {
        public SoftStocksDBConfiguration()
        {
            this.SetDefaultConnectionFactory(new System.Data.Entity.Infrastructure.SqlConnectionFactory("Data Source=(LocalDB)\\MSSQLLocalDB"));
            this.SetProviderServices("System.Data.SqlClient", System.Data.Entity.SqlServer.SqlProviderServices.Instance);
            // SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
            // SetDefaultConnectionFactory(new LocalDbConnectionFactory("C:\\Programming\\Inventory-Management-System\\SoftStocks\\SoftStocksData\\SoftStocksDB.mdf"));
        }

        
    }

    [DbConfigurationType(typeof(SoftStocksDBConfiguration))]
    public class SoftStocksDBContext : DbContext
    {
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Credential> Credentials { get; set; }
        public DbSet<Keyboard> Keyboards { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

    }

    public class Staff
    {
        [Key]
        public int Id { get; set; }
        public int Title { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Role { get; set; }
        public DateTime DateOfBirth { get; set; }
        public float Salary { get; set; }
    }

    public class Credential
    {
        [Key]
        public string Username { get; set; }
        [Required]
        public string StaffId { get; set; }
        [Required]
        public string Password { get; set; }
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
}