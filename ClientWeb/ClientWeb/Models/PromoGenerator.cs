//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PromoGenerator
    {
        public int PromoRightID { get; set; }
        public int CategoryID { get; set; }
        public string ImageURL { get; set; }
        public string AltText { get; set; }
        public string OfferTag { get; set; }
        public string Title { get; set; }
        public Nullable<bool> isDeleted { get; set; }
    
        public virtual Category Category { get; set; }
    }
}