﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaCalculoweb
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CalculoEntities : DbContext
    {
        public CalculoEntities()
            : base("name=CalculoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CalculosResultados> CalculosResultados { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<TipoActividadBase> TipoActividadBase { get; set; }
        public DbSet<TipoInfraestructura> TipoInfraestructura { get; set; }
        public DbSet<TipoOperacion> TipoOperacion { get; set; }
        public DbSet<TipoServicioBrindado> TipoServicioBrindado { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<TipoTicket> TipoTicket { get; set; }
        public DbSet<AspNetRoles> AspNetRoles { get; set; }
        public DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public DbSet<AspNetUsers> AspNetUsers { get; set; }
    }
}
