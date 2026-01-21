namespace Cosmetic.AppModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {

        public bool IsNew()
        {
            return (IdProduct == 0);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            OrderProducts = new HashSet<OrderProduct>();
        }

        [Key]
        public int IdProduct { get; set; }

        [Required]
        [StringLength(20)]
        public string Article { get; set; }

        public int ProductNameId { get; set; }

        public int UnitOfMeasureId { get; set; }

        public double Price { get; set; }

        public int MaxProductDiscountAmount { get; set; }

        public int ManufacturerId { get; set; }

        public int SupplierId { get; set; }

        public int CategoryId { get; set; }

        public double Discount { get; set; }

        public int ProductQuantityInStock { get; set; }

        [Required]
        [StringLength(150)]
        public string Description { get; set; }

        [StringLength(20)]
        public string Photo { get; set; }

        public virtual Category Category { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }

        public virtual ProductName ProductName { get; set; }

        public virtual Supplier Supplier { get; set; }

        public virtual UnitOfMeasure UnitOfMeasure { get; set; }
    }
}
