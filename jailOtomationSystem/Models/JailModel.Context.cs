﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class JailEntities : DbContext
    {
        public JailEntities()
            : base("name=JailEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdministratorAccount> AdministratorAccounts { get; set; }
        public virtual DbSet<facility> facilities { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<officer> officers { get; set; }
        public virtual DbSet<officerRoom> officerRooms { get; set; }
        public virtual DbSet<officerStayIn> officerStayIns { get; set; }
        public virtual DbSet<OfficerWorkA> OfficerWorkAs { get; set; }
        public virtual DbSet<prisonerCell> prisonerCells { get; set; }
        public virtual DbSet<prisonerSatyIn> prisonerSatyIns { get; set; }
        public virtual DbSet<PrisonerWorkA> PrisonerWorkAs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<time> times { get; set; }
        public virtual DbSet<visit> visits { get; set; }
        public virtual DbSet<visitTime> visitTimes { get; set; }
        public virtual DbSet<Prisoner> Prisoners { get; set; }
    
        public virtual ObjectResult<Nullable<System.TimeSpan>> GetAvailableAppointments(Nullable<int> numberOfVisitsAtTheSameTime)
        {
            var numberOfVisitsAtTheSameTimeParameter = numberOfVisitsAtTheSameTime.HasValue ?
                new ObjectParameter("numberOfVisitsAtTheSameTime", numberOfVisitsAtTheSameTime) :
                new ObjectParameter("numberOfVisitsAtTheSameTime", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<System.TimeSpan>>("GetAvailableAppointments", numberOfVisitsAtTheSameTimeParameter);
        }
    }
}
