//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment
    {
        public Payment()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public int PaymentID { get; set; }
        public int Type { get; set; }
        public Nullable<decimal> CreditAmount { get; set; }
        public Nullable<decimal> DebitAmount { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public Nullable<System.DateTime> PaymentDateTime { get; set; }
    
        public virtual ICollection<Order> Orders { get; set; }
        public virtual PaymentType PaymentType { get; set; }
    }
}
