//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Tbl_Discounts
    {
        public int ID { get; set; }
        public int ProductTypeID { get; set; }
        public int ProductID { get; set; }
        public short DiscountPercent { get; set; }
    
        public virtual Tbl_Books Tbl_Books { get; set; }
        public virtual Tbl_ProductsType Tbl_ProductsType { get; set; }
    }
}