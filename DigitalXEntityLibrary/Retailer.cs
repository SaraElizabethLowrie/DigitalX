namespace DigitalXEntityLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;
    using System.Data.Entity.Spatial;

    [DataContract]
    [Table("Retailer")]
    public partial class Retailer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Retailer()
        {
            Products = new HashSet<Product>();
        }
        [DataMember]
        public int RetailerID { get; set; }
        [DataMember]
        [Column("Retailer")]
        [Required]
        [StringLength(50)]
        public string Retailer1 { get; set; }
        [DataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<Product> Products { get; set; }
    }
}
