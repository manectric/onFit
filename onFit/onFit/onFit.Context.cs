﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace onFit
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Karty> Karty { get; set; }
        public virtual DbSet<KartyZajecia> KartyZajecia { get; set; }
        public virtual DbSet<MiejsceZajec> MiejsceZajec { get; set; }
        public virtual DbSet<NazwaZajec> NazwaZajec { get; set; }
        public virtual DbSet<PoziomyZajec> PoziomyZajec { get; set; }
        public virtual DbSet<Zajecia> Zajecia { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }
        public virtual DbSet<TerminyZajec> TerminyZajec { get; set; }
    
        //public virtual ObjectResult<GlobalFilter_Result> GlobalFilter()
        //{
        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GlobalFilter_Result>("GlobalFilter");
        //}
    }
}
