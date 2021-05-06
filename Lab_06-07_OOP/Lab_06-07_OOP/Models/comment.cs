namespace Lab_06_07_OOP
{
    using System;
    using System.Collections.Generic;
    public class comment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]

        public comment()
        {
            products = new HashSet<product>();
            users = new HashSet<user>();
        }
        public int CommentUserID { get; set; }
        public int CommentProductID { get; set; }
        public string Comment { get; set; }
        
        public virtual ICollection<product> products { get; set; }
        public virtual ICollection<user> users { get; set; }
    }
}