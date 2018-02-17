//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace aymk_database.Database
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using System.Runtime.Serialization;
    public partial class CatalogMarket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CatalogMarket()
        {
            this.Alert = new HashSet<Alert>();
        }
    
        public int id { get; set; }
        public int exchangeId { get; set; }
        public string name { get; set; }
        public string firstCode { get; set; }
        public string secondCode { get; set; }
        public string logoUrl { get; set; }
        public System.DateTime createdAt { get; set; }
        public bool active { get; set; }
        public decimal lastSell { get; set; }
        public decimal lastBuy { get; set; }
        public decimal volume { get; set; }
        public decimal sellMin5 { get; set; }
        public decimal sellMax5 { get; set; }
        public decimal buyMin5 { get; set; }
        public decimal buyMax5 { get; set; }
        public decimal volume5 { get; set; }
        public Nullable<System.DateTime> updatedAt { get; set; }
    
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    	[JsonIgnore]
        [IgnoreDataMember]
    	    
        public virtual ICollection<Alert> Alert { get; set; }
        public virtual CatalogExchange CatalogExchange { get; set; }
    }
}