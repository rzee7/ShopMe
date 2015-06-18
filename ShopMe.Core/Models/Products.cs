using System;

namespace ShopMe.Core
{
	public class Products
	{
		public Products ()
		{
		}
		private int _ProductId;
		public int ProductId
		{
			get {return _ProductId; }
			set{ _ProductId = value;}
		}
		private int _CategoryID;
		public int CategoryID
		{
			get {return _CategoryID; }
			set{ _CategoryID = value;}
		}

		private int _ProductName;
		public int ProductName
		{
			get {return _ProductName; }
			set{ _ProductName = value;}
		}

		private bool _IsFreeShipping;
		public bool IsFreeShipping
		{
			get {return _IsFreeShipping; }
			set{ _IsFreeShipping = value;}
		}

		private decimal _AdditionalShipingCharge;
		public decimal AdditionalShipingCharge
		{
			get {return _AdditionalShipingCharge; }
			set{ _AdditionalShipingCharge = value;}
		}

		private int _StockQuantity;
		public int StockQuantity
		{
			get {return _StockQuantity; }
			set{ _StockQuantity = value;}
		}

		private decimal _Price;
		public decimal Price
		{
			get {return _Price; }
			set{ _Price = value;}
		}

		private decimal _OldPrice;
		public decimal OldPrice
		{
			get {return _OldPrice; }
			set{ _OldPrice = value;}
		}

		private decimal _ProductCost;
		public decimal ProductCost
		{
			get {return _ProductCost; }
			set{ _ProductCost = value;}
		}

		private decimal _SpecialPrice;
		public decimal SpecialPrice
		{
			get {return _SpecialPrice; }
			set{ _SpecialPrice = value;}
		}

		private bool _HasDiscountsApplied;
		public bool HasDiscountsApplied
		{
			get {return _HasDiscountsApplied; }
			set{ _HasDiscountsApplied = value;}
		}


		private decimal _Weight;
		public decimal Weight
		{
			get {return _Weight; }
			set{ _Weight = value;}
		}

		private decimal _Length;
		public decimal Length
		{
			get {return _Length; }
			set{ _Length = value;}
		}

		private decimal _Width;
		public decimal Width
		{
			get {return _Width; }
			set{ _Width = value;}
		}

		private decimal _Height;
		public decimal Height
		{
			get {return _Height; }
			set{ _Height = value;}
		}

		private DateTime _AvailableEndDateTimeUtc;
		public DateTime AvailableEndDateTimeUtc
		{
			get { return _AvailableEndDateTimeUtc; }
			set { _AvailableEndDateTimeUtc = value; }
		}

		private DateTime _AvailableStartDateTimeUtc;
		public DateTime AvailableStartDateTimeUtc
		{
			get { return _AvailableStartDateTimeUtc; }
			set { _AvailableStartDateTimeUtc = value; }
		}

		private bool _ISActive;
		public bool ISActive
		{
			get {return _ISActive; }
			set{ _ISActive = value;}
		}

		private bool _IsDelete;
		public bool IsDelete
		{
			get {return _IsDelete; }
			set{ _IsDelete = value;}
		}

		private int _DisplayOrder;
		public int DisplayOrder
		{
			get {return _DisplayOrder; }
			set{ _DisplayOrder = value;}
		}

		private DateTime _CreatedOnUtc;
		public DateTime CreatedOnUtc
		{
			get { return _CreatedOnUtc; }
			set { _CreatedOnUtc = value; }
		}

		private DateTime _ModifiedonUtc;
		public DateTime ModifiedonUtc
		{
			get { return _ModifiedonUtc; }
			set { _ModifiedonUtc = value; }
		}

	}

}

