//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab_06_07_OOP
{
    using System;
    using System.Collections.Generic;
    
    public partial class productsubcategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public productsubcategory()
        {
            this.products = new HashSet<product>();
        }
    
        public int SubcategoryID { get; set; }
        public Nullable<int> SubcategoryCategoryID { get; set; }
        public string SubcategoryName { get; set; }
    
        public virtual productcategory productcategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<product> products { get; set; }
    }
}