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
    
    public partial class order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public order()
        {
            this.orderdetails = new HashSet<orderdetail>();
        }
    
        public int OrderID { get; set; }
        public Nullable<int> OrderUserID { get; set; }
        public string OrderCountry { get; set; }
        public string OrderCity { get; set; }
        public string OrderAddress { get; set; }
        public string OrderZip { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public string OrderTrackingNumber { get; set; }
        public Nullable<double> OrderAmount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orderdetail> orderdetails { get; set; }
        public virtual user user { get; set; }
    }
}
