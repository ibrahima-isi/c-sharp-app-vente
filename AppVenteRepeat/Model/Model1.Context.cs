﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppVenteRepeat.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bdVenteEntities1 : DbContext
    {
        public bdVenteEntities1()
            : base("name=bdVenteEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<Produit1> Produit1 { get; set; }
        public virtual DbSet<Profil> Profils { get; set; }
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; }
    }
}