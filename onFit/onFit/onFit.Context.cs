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
    
    public partial class Main_onFitEntities : DbContext
    {
        public Main_onFitEntities()
            : base("name=Main_onFitEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Dla_Kogo> Dla_Kogo { get; set; }
        public virtual DbSet<Dni> Dni { get; set; }
        public virtual DbSet<Grupa> Grupa { get; set; }
        public virtual DbSet<Karty_Szkoly_Intersekcja> Karty_Szkoly_Intersekcja { get; set; }
        public virtual DbSet<Kiedy_Zajecia> Kiedy_Zajecia { get; set; }
        public virtual DbSet<Poziomy> Poziomy { get; set; }
        public virtual DbSet<Szkoly> Szkoly { get; set; }
        public virtual DbSet<Typy_Kart> Typy_Kart { get; set; }
        public virtual DbSet<Typy_Tanca> Typy_Tanca { get; set; }
    }
}
