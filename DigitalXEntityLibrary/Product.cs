namespace DigitalXEntityLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;
    using System.Data.Entity.Spatial;

    [DataContract]
    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
        [DataMember]
        public int ProductID { get; set; }
        [DataMember]
        public int RetailerID { get; set; }
        [DataMember]
        public int SubCategoryID { get; set; }
        [DataMember]
        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }
        [DataMember]
        [Required]
        [StringLength(255)]
        public string ProductDescription { get; set; }
        [DataMember]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        [DataMember]
        public int UnitsInStock { get; set; }
        [DataMember]
        public byte[] Picture { get; set; }
        [DataMember]
        public bool? IsDiscontinued { get; set; }
        [DataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<OrderDetail> OrderDetails { get; set; }
        [DataMember]
        public ProductSubCategory ProductSubCategory { get; set; }
        [DataMember]
        public Retailer Retailer { get; set; }
    }
}
