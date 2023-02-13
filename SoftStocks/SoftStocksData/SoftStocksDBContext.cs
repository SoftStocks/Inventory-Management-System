using System.Collections.Generic;
using System.Data.SqlTypes;
using Microsoft.EntityFrameworkCore;

namespace SoftStocksData;

public class SoftStocksDBContext : DbContext
{
    public DbSet<Staff> Staff { get; set; }
    public DbSet<Credentials> Credentials { get; set; }
    public DbSet<Keyboard> Keyboards { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Server=(localdb)\mssqllocaldb;Database=SoftStocksDB;Trusted_Connection=True");
    }
}

public class Staff
{
    public int Id { get; set; }
    public int Title { get; set; }
    public string FirstName { get; set; }
    public string? LastName { get; set; }
    public string Role { get; set; }
    public DateTime DateOfBirth { get; set; }
    public float? Salary { get; set; }
}

public class Credentials
{
    public int UserName { get; set; }
    public string StaffId { get; set; }
    public string Password { get; set; }
}

public class Keyboard
{
    public int ModelNumber { get; set; }
    public int SupplierId { get; set; }
    public int Quantity { get; set; }
    public string? Description { get; set; }
    public SqlMoney Price { get; set; }
}

public class Supplier
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ContactNumber { get; set; }
    public string? PrimaryContact { get; set; }
    public string BusinessAddress { get; set; }
    public int? NumberOfPurchases { get; set; }
}