﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Program_Librarie.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LabDataContext : DbContext
    {
        public LabDataContext()
            : base("name=LabDataContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<achizitie> achizitie { get; set; }
        public virtual DbSet<autor> autor { get; set; }
        public virtual DbSet<birotica> birotica { get; set; }
        public virtual DbSet<carte> carte { get; set; }
        public virtual DbSet<client> client { get; set; }
        public virtual DbSet<domeniu> domeniu { get; set; }
        public virtual DbSet<editura> editura { get; set; }
        public virtual DbSet<linieachizitie> linieachizitie { get; set; }
        public virtual DbSet<linieoferta> linieoferta { get; set; }
        public virtual DbSet<linievanzare> linievanzare { get; set; }
        public virtual DbSet<oferta> oferta { get; set; }
        public virtual DbSet<plata> plata { get; set; }
        public virtual DbSet<produs> produs { get; set; }
        public virtual DbSet<tipprodus> tipprodus { get; set; }
        public virtual DbSet<utilizator> utilizator { get; set; }
        public virtual DbSet<vanzari> vanzari { get; set; }
        public virtual DbSet<cartedetaliu> cartedetaliu { get; set; }
        public virtual DbSet<furnizor> furnizor { get; set; }
    }
}
