//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVK
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shift
    {
        public string shiftID { get; set; }
        public Nullable<System.DateTime> shiftStartTime { get; set; }
        public Nullable<System.DateTime> shiftEndTime { get; set; }
        public Nullable<int> shiftCredit { get; set; }
        public string shiftType { get; set; }
        public string eventID { get; set; }
        public string userID { get; set; }
    
        public virtual Event Event { get; set; }
        public virtual User User { get; set; }
    }
}