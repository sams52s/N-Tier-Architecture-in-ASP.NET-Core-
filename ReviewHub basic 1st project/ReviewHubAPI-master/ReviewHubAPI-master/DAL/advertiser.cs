//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class advertiser
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public Nullable<int> CompanyCategoryId { get; set; }
        public Nullable<int> PaymentId { get; set; }
    
        public virtual company_categories company_categories { get; set; }
        public virtual user user { get; set; }
    }
}