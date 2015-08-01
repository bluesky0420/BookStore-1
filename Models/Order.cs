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
    
    public partial class Order
    {
        public Order()
        {
            this.OrdersItems = new HashSet<OrdersItem>();
        }
    
        public int id { get; set; }
        public string ordernum { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<int> num { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<int> customer { get; set; }
        public string receiverName { get; set; }
        public string receiverPhone { get; set; }
        public string receiverAddress { get; set; }
    
        public virtual Customer Customer1 { get; set; }
        public virtual ICollection<OrdersItem> OrdersItems { get; set; }
    }
}
