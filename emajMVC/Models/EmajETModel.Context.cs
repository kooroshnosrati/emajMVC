﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace emajMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EmajDBEntities : DbContext
    {
        public EmajDBEntities()
            : base("name=EmajDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tbl_authorsAndTranslators> Tbl_authorsAndTranslators { get; set; }
        public virtual DbSet<Tbl_Banners> Tbl_Banners { get; set; }
        public virtual DbSet<Tbl_Books> Tbl_Books { get; set; }
        public virtual DbSet<Tbl_BooksCategories> Tbl_BooksCategories { get; set; }
        public virtual DbSet<Tbl_BooksCoverType> Tbl_BooksCoverType { get; set; }
        public virtual DbSet<Tbl_BooksSize> Tbl_BooksSize { get; set; }
        public virtual DbSet<Tbl_Customer> Tbl_Customer { get; set; }
        public virtual DbSet<Tbl_Discounts> Tbl_Discounts { get; set; }
        public virtual DbSet<Tbl_Order> Tbl_Order { get; set; }
        public virtual DbSet<Tbl_ProductsType> Tbl_ProductsType { get; set; }
        public virtual DbSet<Tbl_Store> Tbl_Store { get; set; }
        public virtual DbSet<Tbl_OrderDetail> Tbl_OrderDetail { get; set; }
    }
}
