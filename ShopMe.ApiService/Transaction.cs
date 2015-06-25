//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopMe.ApiService
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public int Id { get; set; }
        public string TransactionId { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public System.DateTime CreatedOnUtc { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}