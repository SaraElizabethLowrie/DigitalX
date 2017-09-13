namespace DigitalXEntityLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;
    using System.Data.Entity.Spatial;

    [DataContract]
    [Table("Address")]
    public partial class Address
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Address()
        {
            Orders = new HashSet<Order>();
            Customers = new HashSet<Customer>();
            Employees = new HashSet<Employee>();
        }
        [DataMember]
        public int AddressID { get; set; }
        [DataMember]
        public int AddressType { get; set; }
        [DataMember]
        [StringLength(50)]
        public string Street { get; set; }
        [DataMember]
        [StringLength(50)]
        public string Suburb { get; set; }
        [DataMember]
        [StringLength(50)]
        public string City { get; set; }
        [DataMember]
        [StringLength(10)]
        public string PostalCode { get; set; }
        [DataMember]
        [StringLength(50)]
        public string Country { get; set; }
        [DataMember]
        public AddressType AddressType1 { get; set; }
        [DataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<Order> Orders { get; set; }
        [DataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<Customer> Customers { get; set; }
        [DataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<Employee> Employees { get; set; }
    }
}
