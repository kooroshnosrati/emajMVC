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
    
    public partial class Tbl_Store
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Store()
        {
            this.Tbl_OrderDetail = new HashSet<Tbl_OrderDetail>();
        }
    
        public int ID { get; set; }
        public int ProductTypeID { get; set; }
        public int ProductID { get; set; }
        public long Count { get; set; }
    
        public virtual Tbl_Books Tbl_Books { get; set; }
        public virtual Tbl_ProductsType Tbl_ProductsType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_OrderDetail> Tbl_OrderDetail { get; set; }
    }
}