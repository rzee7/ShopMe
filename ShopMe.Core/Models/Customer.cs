using System;

namespace ShopMe.Core
{
	public class Customer
	{
		public Customer ()
		{
		}
		public int CustomerId {get;set;}
		public string EmailId {get;set;}
		public string Password {get;set;}
		public bool IsActive {get;set;}
		public bool IsDeleted {get;set;}
		public DateTime CreatedOnUtc {get;set;}
	}
}