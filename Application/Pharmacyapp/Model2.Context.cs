﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pharmacyapp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StockDBEntities : DbContext
    {
        public StockDBEntities()
            : base("name=StockDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<medicine> medicines { get; set; }
        public virtual DbSet<SoldedMedicine> SoldedMedicines { get; set; }
        public virtual DbSet<stock> stocks { get; set; }
    }
}
