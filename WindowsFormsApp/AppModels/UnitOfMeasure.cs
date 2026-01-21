namespace Cosmetic.AppModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UnitOfMeasure")]
    public partial class UnitOfMeasure
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UnitOfMeasure()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        public int IdUnitOfMeasure { get; set; }

        [Required]
        [StringLength(10)]
        public string UnitOfMeasureName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
