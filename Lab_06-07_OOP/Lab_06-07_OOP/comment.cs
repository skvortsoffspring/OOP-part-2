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
    
    public partial class comment
    {
        public int CommentID { get; set; }
        public Nullable<int> CommentProductID { get; set; }
        public Nullable<int> CommentUserID { get; set; }
        public string Comment1 { get; set; }
    
        public virtual product product { get; set; }
    }
}
