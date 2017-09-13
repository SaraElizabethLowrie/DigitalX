namespace DigitalXEntityLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;
    using System.Data.Entity.Spatial;

    [DataContract]
    [Table("OrderDetail")]
    public partial class OrderDetail
    {
        [DataMember]
        [Key]
        public int DetailID { get; set; }
        [DataMember]
        public int OrderID { get; set; }
        [DataMember]
        public int ProductID { get; set; }
        [DataMember]
        public int Quantity { get; set; }
        [DataMember]
        public bool Packaged { get; set; }
        [DataMember]
        public int? PackagedBy { get; set; }
        [DataMember]
        public Employee Employee { get; set; }
        [DataMember]
        public Order Order { get; set; }
        [DataMember]
        public Product Product { get; set; }
    }
}
