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
    
    public partial class prisonerSatyIn
    {
        public int prisonerid { get; set; }
        public int prisonerCellid { get; set; }
        public System.DateTime since { get; set; }
    
        public virtual prisonerCell prisonerCell { get; set; }
        public virtual Prisoner Prisoner { get; set; }
    }
}
