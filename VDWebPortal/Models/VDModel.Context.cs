﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VDWebPortal.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VaishaliDairyDBEntities : DbContext
    {
        public VaishaliDairyDBEntities()
            : base("name=VaishaliDairyDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<M_CategoryMaster> M_CategoryMaster { get; set; }
        public virtual DbSet<M_Master> M_Master { get; set; }
        public virtual DbSet<M_SubCategoryMaster> M_SubCategoryMaster { get; set; }
        public virtual DbSet<T_NewsMasters> T_NewsMasters { get; set; }
    }
}