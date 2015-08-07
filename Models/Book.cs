//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.CartItems = new HashSet<CartItem>();
            this.OrdersItems = new HashSet<OrdersItem>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string author { get; set; }
        public string description { get; set; }
        public Nullable<int> categoryId { get; set; }
        public string imageUrl { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<long> pageview { get; set; }
        public Nullable<long> sale { get; set; }
        public Nullable<long> stock { get; set; }
    
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CartItem> CartItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdersItem> OrdersItems { get; set; }
    }
}
