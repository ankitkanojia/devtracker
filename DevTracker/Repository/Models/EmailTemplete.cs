//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repository.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmailTemplete
    {
        public long EmailTempleteId { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string HashTag { get; set; }
        public string FromEmail { get; set; }
        public string BccEmail { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> CreatedDateInt { get; set; }
        public long CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> UpdatedDateInt { get; set; }
        public Nullable<long> UpdatedBy { get; set; }
    }
}
