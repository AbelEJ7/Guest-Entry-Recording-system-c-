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
    
    public partial class rrequest
    {
        public long id { get; set; }
        public long user_id { get; set; }
        public string name { get; set; }
        public string reason { get; set; }
        public string status { get; set; }
        public Nullable<System.DateTime> specificDate { get; set; }
        public Nullable<System.DateTime> from { get; set; }
        public Nullable<System.DateTime> to { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
    
        public virtual user user { get; set; }
    }
}
