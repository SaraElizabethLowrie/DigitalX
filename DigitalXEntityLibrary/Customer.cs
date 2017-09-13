namespace DigitalXEntityLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;
    using System.Data.Entity.Spatial;

    [DataContract]
    [Table("Customer")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Orders = new HashSet<Order>();
            Addresses = new HashSet<Address>();
            Contacts = new HashSet<Contact>();
        }
        [DataMember]
        public int CustomerID { get; set; }
        [DataMember]
        //[RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "The username must be letters only.")]
        //[StringLength(50, ErrorMessage = "Must be between 3 and 10 characters long", MinimumLength = 3)]
        [StringLength(50)]
        public string UserName { get; set; }
        [DataMember]
        [StringLength(50)]
        public string FirstName { get; set; }
        [DataMember]
        [StringLength(50)]
        public string LastName { get; set; }
        [DataMember]
        [StringLength(50)]
        public string Password { get; set; }
        [DataMember]
        [StringLength(50)]
        public string Email { get; set; }
        [DataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<Order> Orders { get; set; }
        [DataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<Address> Addresses { get; set; }
        [DataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<Contact> Contacts { get; set; }
    }
}
