namespace DigitalXEntityLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ShipperOption
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShipperOption()
        {
            Invoiceds = new HashSet<Invoiced>();
        }

        [Key]
        public int ShippingID { get; set; }

        public int ShipperID { get; set; }

        public int LocationID { get; set; }

        public int MethodID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoiced> Invoiceds { get; set; }

        public virtual Shipper Shipper { get; set; }

        public virtual ShippingLocation ShippingLocation { get; set; }

        public virtual ShippingMethod ShippingMethod { get; set; }
    }
}
