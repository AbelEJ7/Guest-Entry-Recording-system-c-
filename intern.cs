//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Guest_Entry_Recording_System
{
    using System;
    using System.Collections.Generic;
    
    public partial class intern
    {
        public long id { get; set; }
        public long user_id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string role { get; set; }
        public string status { get; set; }
        public string school { get; set; }
        public string supervisor { get; set; }
        public string photo { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
        public string phone { get; set; }
        public string School_id { get; set; }
    
        public virtual user user { get; set; }
    }
}
