//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace jailOtomationSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class visit
    {
        public int visitorID { get; set; }
        public int prisonerid { get; set; }
        public string visiterName { get; set; }
        public string visiterSurname { get; set; }
        public string relashionship { get; set; }
        public System.DateTime dateOfVisit { get; set; }
        public string purposeOfVisit { get; set; }
        public string stuffBringed { get; set; }
        public bool IsAccepted { get; set; }
        public Nullable<System.TimeSpan> VisitTime { get; set; }
    
        public virtual Prisoner Prisoner { get; set; }
    }
}
