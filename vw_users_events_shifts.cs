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
    
    public partial class vw_users_events_shifts
    {
        public string userID { get; set; }
        public string password { get; set; }
        public string userEmail { get; set; }
        public string membershipNo { get; set; }
        public string userFetURL { get; set; }
        public Nullable<int> userTotalCredits { get; set; }
        public Nullable<int> userCreditsUserd { get; set; }
        public string adminComments { get; set; }
        public string alias { get; set; }
        public string eventID { get; set; }
        public string eventName { get; set; }
        public string eventInfo { get; set; }
        public Nullable<System.DateTime> eventDate { get; set; }
        public Nullable<System.DateTime> eventStartTime { get; set; }
        public Nullable<System.DateTime> eventEndTime { get; set; }
        public Nullable<System.DateTime> eventSetupTime { get; set; }
        public Nullable<System.DateTime> eventTeardownTime { get; set; }
        public Nullable<System.DateTime> eventConcessionStartTime { get; set; }
        public Nullable<System.DateTime> eventConcessionEndTime { get; set; }
        public Nullable<int> eventConcessionSlots { get; set; }
        public Nullable<System.DateTime> eventFrontDeskStartTime { get; set; }
        public Nullable<System.DateTime> eventFrontDeskEndTime { get; set; }
        public Nullable<int> eventFrontDeskSlots { get; set; }
        public string orgID { get; set; }
        public string shiftID { get; set; }
        public string shiftType { get; set; }
        public Nullable<System.DateTime> shiftStartTime { get; set; }
        public Nullable<System.DateTime> shiftEndTime { get; set; }
        public Nullable<int> shiftCredit { get; set; }
    }
}