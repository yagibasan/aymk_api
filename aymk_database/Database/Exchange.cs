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
    public partial class Exchange
    {
        public int accountId { get; set; }
        public int exchangeId { get; set; }
        public string publicKey { get; set; }
        public string privateKey { get; set; }
        public Nullable<bool> trading { get; set; }
        public System.DateTime createdAt { get; set; }
        public Nullable<System.DateTime> updatedAt { get; set; }
        public bool active { get; set; }
    
        public virtual CatalogExchange CatalogExchange { get; set; }
        public virtual Account Account { get; set; }
    }
}