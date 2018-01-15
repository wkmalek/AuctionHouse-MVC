namespace AuctionHouseMVC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Categories
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Categories()
        {
            Categories1 = new HashSet<Categories>();
        }

        public string ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [StringLength(128)]
        public string Pid { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Categories> Categories1 { get; set; }

        public virtual Categories Categories2 { get; set; }
    }
}
