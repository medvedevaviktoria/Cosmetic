namespace Cosmetic.AppModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        public bool IsNew()
        {
            return (IdOrder == 0);
        }

        public double TotalPriceWithDiscount
        {
            get
            {
                double sum = 0;

                foreach (var orderProducts in this.OrderProducts)
                {
                    double price = orderProducts.Product.Price;
                    double discount = orderProducts.Product.Discount;
                    double priceWithDiscount = price * ((100 - discount) / 100);
                    sum += priceWithDiscount * orderProducts.Amount;
                }
                return sum;
            }
        }

        public double TotalPriceWithoutDiscount
        {
            get
            {
                double sum = 0;

                foreach (var orderProducts in this.OrderProducts)
                {
                    double price = orderProducts.Product.Price;
                    sum += price * orderProducts.Amount;
                }
                return sum;
            }
        }

        public double TotalDiscountPercent
        {
            get
            {
                double sum = TotalPriceWithoutDiscount;
                double sumWithDiscount = TotalPriceWithDiscount;

                if (sum == 0)
                {
                    return 0;
                }
                else
                {
                    return (sum - sumWithDiscount) / sum * 100;
                }
            }
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderProducts = new HashSet<OrderProduct>();
        }

        [Key]
        public int IdOrder { get; set; }

        [Column(TypeName = "date")]
        public DateTime OrderDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime OrderDeliveryDate { get; set; }

        public int OfficeId { get; set; }

        public int UserId { get; set; }

        public int Code { get; set; }

        public int OrderStatusId { get; set; }

        public virtual Office Office { get; set; }

        public virtual OrderStatu OrderStatus { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
