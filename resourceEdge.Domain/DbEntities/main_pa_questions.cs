//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace resourceEdge.Domain.DbEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class main_pa_questions
    {
        public int id { get; set; }
        public Nullable<int> pa_category_id { get; set; }
        public string question { get; set; }
        public string description { get; set; }
        public Nullable<bool> module_flag { get; set; }
        public Nullable<bool> isactive { get; set; }
        public Nullable<int> createdby { get; set; }
        public Nullable<int> createdby_role { get; set; }
        public Nullable<int> createdby_group { get; set; }
        public Nullable<int> modifiedby { get; set; }
        public Nullable<int> modifiedby_role { get; set; }
        public Nullable<int> modifiedby_group { get; set; }
        public Nullable<System.DateTime> createddate { get; set; }
        public Nullable<System.DateTime> modifieddate { get; set; }
        public Nullable<bool> isused { get; set; }
    }
}