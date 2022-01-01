//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FunitureManager.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.Order_Detail = new HashSet<Order_Detail>();
        }
    
        public System.Guid Id { get; set; }
        public System.DateTime Date { get; set; }
        public decimal Price { get; set; }
        public System.Guid Id_User { get; set; }
        public System.Guid Id_Manager { get; set; }
        public string Status { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual Manager Manager { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<Order_Detail> Order_Detail { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual User User { get; set; }
    }
}
