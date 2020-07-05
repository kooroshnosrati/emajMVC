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
    
    public partial class Tbl_Books
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Books()
        {
            this.Tbl_Discounts = new HashSet<Tbl_Discounts>();
            this.Tbl_Store = new HashSet<Tbl_Store>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public int AuthorID { get; set; }
        public int PagesCount { get; set; }
        public int Size { get; set; }
        public decimal Fi { get; set; }
        public int SubjectID { get; set; }
        public Nullable<int> TranslatorID { get; set; }
        public string Image { get; set; }
        public int CoverType { get; set; }
        public Nullable<long> ISBN { get; set; }
        public Nullable<System.DateTime> ReleasedDate { get; set; }
        public int circulation { get; set; }
        public bool IsTranslated { get; set; }
        public short Published { get; set; }
    
        public virtual Tbl_authorsAndTranslators Tbl_authorsAndTranslators { get; set; }
        public virtual Tbl_authorsAndTranslators Tbl_authorsAndTranslators1 { get; set; }
        public virtual Tbl_BooksCategories Tbl_BooksCategories { get; set; }
        public virtual Tbl_BooksCoverType Tbl_BooksCoverType { get; set; }
        public virtual Tbl_BooksSize Tbl_BooksSize { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Discounts> Tbl_Discounts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Store> Tbl_Store { get; set; }
    }
}