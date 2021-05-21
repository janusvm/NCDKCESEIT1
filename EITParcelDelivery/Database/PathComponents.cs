//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EITParcelDelivery.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class PathComponents
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PathComponents()
        {
            this.Parcel = new HashSet<Parcel>();
            this.PathComponents1 = new HashSet<PathComponents>();
        }
    
        public int Id { get; set; }
        public int City { get; set; }
        public Nullable<System.DateTime> ArrivedAt { get; set; }
        public Nullable<int> NextDestination { get; set; }
    
        public virtual Cities Cities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Parcel> Parcel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PathComponents> PathComponents1 { get; set; }
        public virtual PathComponents PathComponents2 { get; set; }
    }
}
