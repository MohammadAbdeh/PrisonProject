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
    
    public partial class Job
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Job()
        {
            this.OfficerWorkAs = new HashSet<OfficerWorkA>();
            this.PrisonerWorkAs = new HashSet<PrisonerWorkA>();
        }
    
        public int jobID { get; set; }
        public string jobTitle { get; set; }
        public Nullable<System.TimeSpan> dailyStartingTime { get; set; }
        public Nullable<System.TimeSpan> dailyEndingTime { get; set; }
        public string JobDescription { get; set; }
        public int facilityid { get; set; }
        public int availablePositionsCount { get; set; }
        public string workerType { get; set; }
    
        public virtual facility facility { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OfficerWorkA> OfficerWorkAs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrisonerWorkA> PrisonerWorkAs { get; set; }
    }
}
