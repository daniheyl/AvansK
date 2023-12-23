using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Core.Domain;
using Core.DomainServices;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class FoodPackageDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public DbSet<FoodPackage> FoodPackages { get; set; } 

    public FoodPackageDbContext(DbContextOptions<FoodPackageDbContext> contextOptions) : base(contextOptions)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Server=(localdb)\mssqllocaldb;Database=FoodPackage5;Trusted_Connection=True");
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>().HasData(
            new Product() { Id = 1, Name = "Hamburger", ContainsAlcohol = false, Picture = "NA" },
            new Product() { Id = 2, Name = "Bier", ContainsAlcohol = true, Picture = "NA" },
            new Product() { Id = 3, Name = "Danoontje", ContainsAlcohol = false, Picture = "NA" });

        modelBuilder.Entity<FoodPackage>().HasData(
            new FoodPackage() { Id = 1, Name = "pakket 1" },
            new FoodPackage() { Id = 2, Name = "pakket 2" }
            );
        modelBuilder.Entity<PackageDetail>().HasData(
            new PackageDetail() { Id = 1, FoodPackageId = 1, ProductId = 1 },
            new PackageDetail() { Id = 2, FoodPackageId = 1, ProductId = 2 }
            );
        List<FoodPackage> fp = new List<FoodPackage>
        {
            new FoodPackage(){ Id = 1, Name = "pakket 1"},
            new FoodPackage() { Id = 2, Name = "pakket 2"}
        };

        //List<Product> productList = new List<Product>{
        //    new Product() { Id = 1, Name = "Hamburger", ContainsAlcohol = false, Picture = "NA" },
        //    new Product() { Id = 2, Name = "Bier", ContainsAlcohol = true, Picture = "NA" },
        //    new Product() { Id = 3, Name = "Danoontje", ContainsAlcohol = false, Picture = "NA" }
        //};

        //List<FoodPackage> fp = new List<FoodPackage>
        //{
        //    new FoodPackage(){ Id = 1, Name = "pakket 1"},
        //    new FoodPackage() { Id = 2, Name = "pakket 2"}
        //};
        //fp[0].Products = productList;
        //fp[1].Products = productList;

        //modelBuilder.Entity<Product>().HasData(
        //    productList
        //);

        //modelBuilder.Entity<FoodPackage>().HasData(
        //    fp
        //);
        ////modelBuilder.Entity<PackageDetail>().HasData(
        ////    new PackageDetail() { Id = 1, FoodPackageId = 1, ProductId = 1 },
        ////    new PackageDetail() { Id = 2, FoodPackageId = 1, ProductId = 2 }
        ////    );
    }

}
