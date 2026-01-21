using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Cosmetic.AppModels
{
    public partial class ContextDB : DbContext
    {
        public ContextDB()
            : base("name=ContextDB")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<Office> Offices { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderProduct> OrderProducts { get; set; }
        public virtual DbSet<OrderStatu> OrderStatus { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductName> ProductNames { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<UnitOfMeasure> UnitOfMeasures { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Category)
                .HasForeignKey(e => e.CategoryId);

            modelBuilder.Entity<Manufacturer>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Manufacturer)
                .HasForeignKey(e => e.ManufacturerId);

            modelBuilder.Entity<Office>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Office)
                .HasForeignKey(e => e.OfficeId);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderProducts)
                .WithRequired(e => e.Order)
                .HasForeignKey(e => e.OrderId);

            modelBuilder.Entity<OrderStatu>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.OrderStatu)
                .HasForeignKey(e => e.OrderStatusId);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.OrderProducts)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.ProductId);

            modelBuilder.Entity<ProductName>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.ProductName)
                .HasForeignKey(e => e.ProductNameId);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.RoleId);

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Supplier)
                .HasForeignKey(e => e.SupplierId);

            modelBuilder.Entity<UnitOfMeasure>()
                .Property(e => e.UnitOfMeasureName)
                .IsFixedLength();

            modelBuilder.Entity<UnitOfMeasure>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.UnitOfMeasure)
                .HasForeignKey(e => e.UnitOfMeasureId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.UserId);
        }
    }
}
