//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fish360Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class Trips
    {
        public Trips()
        {
            this.Fish = new HashSet<Fish>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
        public Nullable<System.DateTime> endDate { get; set; }
        public Nullable<int> userId { get; set; }
        public string notes { get; set; }
    
        public virtual ICollection<Fish> Fish { get; set; }
        public virtual Users Users { get; set; }
    }
}
