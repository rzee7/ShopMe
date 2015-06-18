using System;

namespace ShopMe.Core
{
	public class Category
	{
		public Category ()
		{
			
		}

		public Int32 CategoryId { get; set; }
		public string CategoryName { get; set;}
		public bool IsActive { get; set;}
		public DateTime CreatedOnUtc { get; set;}
		public Nullable<DateTime> UpdatedOnUtc { get; set; }
	}
}

