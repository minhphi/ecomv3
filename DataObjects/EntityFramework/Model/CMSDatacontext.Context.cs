﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataObjects.EntityFramework.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class LaminhCMSEntities : DbContext
    {
        public LaminhCMSEntities()
            : base("name=LaminhCMSEntities")
        {
        }
        public LaminhCMSEntities(string conn)
            : base(conn)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public DbSet<CMS_Page_UserControl> CMS_Page_UserControl { get; set; }
        public DbSet<CMS_UserControl> CMS_UserControl { get; set; }
        public DbSet<CMS_Page> CMS_Page { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceProduct> InvoiceProducts { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
