namespace DigitalXEntityLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;
    using System.Data.Entity.Spatial;

    [DataContract]
    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            Invoiceds = new HashSet<Invoiced>();
            OrderDetails = new HashSet<OrderDetail>();
        }
        [DataMember]
        public int OrderID { get; set; }
        [DataMember]
        public int CustomerID { get; set; }
        [DataMember]
        public int AddressID { get; set; }
        [DataMember]
        public DateTime OrderDate { get; set; }
        [DataMember]
        public bool Complete { get; set; }
        [DataMember]
        public Address Address { get; set; }
        [DataMember]
        public Customer Customer { get; set; }
        [DataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<Invoiced> Invoiceds { get; set; }
        [DataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
