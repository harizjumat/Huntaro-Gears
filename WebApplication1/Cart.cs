//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cart
    {
        public int ID { get; set; }
        public string ClientID { get; set; }
        public int ProductID { get; set; }
        public int Amount { get; set; }
        public Nullable<System.DateTime> DatePurchased { get; set; }
        public bool IsInCart { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
