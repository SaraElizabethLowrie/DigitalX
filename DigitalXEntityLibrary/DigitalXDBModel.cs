namespace DigitalXEntityLibrary
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DigitalXDBModel : DbContext
    {
        public DigitalXDBModel()
            : base("name=DigitalXDBEntities")
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<AddressType> AddressTypes { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<ContactType> ContactTypes { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Invoiced> Invoiceds { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<ProductSubCategory> ProductSubCategories { get; set; }
        public virtual DbSet<Retailer> Retailers { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Shipper> Shippers { get; set; }
        public virtual DbSet<ShipperOption> ShipperOptions { get; set; }
        public virtual DbSet<ShippingLocation> ShippingLocations { get; set; }
        public virtual DbSet<ShippingMethod> ShippingMethods { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .Property(e => e.PostalCode)
                .IsFixedLength();

            modelBuilder.Entity<Address>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Address)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.Customers)
                .WithMany(e => e.Addresses)
                .Map(m => m.ToTable("CustomerAddress").MapLeftKey("AddressID").MapRightKey("CustomerID"));

            modelBuilder.Entity<Address>()
                .HasMany(e => e.Employees)
                .WithMany(e => e.Addresses)
                .Map(m => m.ToTable("EmployeeAddress").MapLeftKey("AddressID").MapRightKey("EmployeeID"));

            modelBuilder.Entity<AddressType>()
                .HasMany(e => e.Addresses)
                .WithRequired(e => e.AddressType1)
                .HasForeignKey(e => e.AddressType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contact>()
                .HasMany(e => e.Customers)
                .WithMany(e => e.Contacts)
                .Map(m => m.ToTable("CustomerContact").MapLeftKey("ContactID").MapRightKey("CustomerID"));

            modelBuilder.Entity<Contact>()
                .HasMany(e => e.Employees)
                .WithMany(e => e.Contacts)
                .Map(m => m.ToTable("EmployeeContact").MapLeftKey("ContactID").MapRightKey("EmployeeID"));

            modelBuilder.Entity<ContactType>()
                .HasMany(e => e.Contacts)
                .WithRequired(e => e.ContactType1)
                .HasForeignKey(e => e.ContactType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Invoiceds)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.OrderDetails)
                .WithOptional(e => e.Employee)
                .HasForeignKey(e => e.PackagedBy);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Roles)
                .WithMany(e => e.Employees)
                .Map(m => m.ToTable("EmployeeRoles").MapLeftKey("EmployeeID").MapRightKey("RoleID"));

            modelBuilder.Entity<Order>()
                .HasMany(e => e.Invoiceds)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductCategory>()
                .HasMany(e => e.ProductSubCategories)
                .WithRequired(e => e.ProductCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductSubCategory>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.ProductSubCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Retailer>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Retailer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Shipper>()
                .HasMany(e => e.ShipperOptions)
                .WithRequired(e => e.Shipper)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ShipperOption>()
                .HasMany(e => e.Invoiceds)
                .WithRequired(e => e.ShipperOption)
                .HasForeignKey(e => e.ShippingOption)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ShippingLocation>()
                .HasMany(e => e.ShipperOptions)
                .WithRequired(e => e.ShippingLocation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ShippingMethod>()
                .HasMany(e => e.ShipperOptions)
                .WithRequired(e => e.ShippingMethod)
                .WillCascadeOnDelete(false);
        }
    }
}
