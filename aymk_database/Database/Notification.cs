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
    public partial class Notification
    {
        public long id { get; set; }
        public Nullable<int> accountId { get; set; }
        public string notificationType { get; set; }
        public string notificationTitle { get; set; }
        public string notificationContent { get; set; }
        public Nullable<System.DateTime> notificationDate { get; set; }
    
        public virtual Account Account { get; set; }
    }
}
