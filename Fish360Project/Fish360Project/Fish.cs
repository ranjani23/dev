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
    
    public partial class Fish
    {
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<double> weight { get; set; }
        public Nullable<double> length { get; set; }
        public string species { get; set; }
        public Nullable<System.DateTime> caughtDate { get; set; }
        public Nullable<int> tripId { get; set; }
        public byte[] notes { get; set; }
        public Nullable<System.TimeSpan> caughtTime { get; set; }
    
        public virtual Species Species1 { get; set; }
        public virtual Trips Trips { get; set; }
    }
}
