namespace PriyatniyShelestApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Agent")]
    public partial class Agent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Agent()
        {
            AgentPriorityHistory = new HashSet<AgentPriorityHistory>();
            ProductSale = new HashSet<ProductSale>();
            Shop = new HashSet<Shop>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        public int AgentTypeID { get; set; }

        [StringLength(300)]
        public string Address { get; set; }

        [Required]
        [StringLength(12)]
        public string INN { get; set; }

        [StringLength(9)]
        public string KPP { get; set; }

        [StringLength(100)]
        public string DirectorName { get; set; }

        [Required]
        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(100)]
        public string Logo { get; set; }

        public int Priority { get; set; }

        public virtual AgentType AgentType { get; set; }

        public int Sales
        {
            get
            {
                int chel = 0;
                foreach (var item in ProductSale)
                {
                    if (item.SaleDate.Year + 1 > DateTime.Now.Year -4)
                        chel += item.ProductCount;
                }
                return chel;
            }
        }

        public string Discount 
        { 
            get 
            {
                int discount = 0;
                foreach (var item in ProductSale)
                {
                    discount += item.ProductCount * (int)item.Product.MinCostForAgent;
                }
                if (discount > 10000 && discount <= 50000)
                    return "5%";
                if (discount > 50000 && discount <= 150000)
                    return "10%";
                if (discount > 150000 && discount <= 500000)
                    return "20%";
                if (discount > 50000)
                    return "25%";
                else
                    return "0%";
            } 
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgentPriorityHistory> AgentPriorityHistory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductSale> ProductSale { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop> Shop { get; set; }
    }
}
