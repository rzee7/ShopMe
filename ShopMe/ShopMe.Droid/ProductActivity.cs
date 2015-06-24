using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using PRAAdapterLess;
using ShopMe.Core;

namespace ShopMe.Droid
{
    [Activity(Label = "ProductActivity", MainLauncher=true)]
    public class ProductActivity : Activity, IDataRowView<Product>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.ProductLayout);
            // Create your application here

            PRAService.Register<IDataRowView<Product>>(this);

            var productGrids = FindViewById<GridView>(Resource.Id.productGrid);
            productGrids.Adapter = new PRAAdapter<Product>(this, DataProvider.GetData());

        }

        View IDataRowView<Product>.GetDataRowView(int position, View convertView, ViewGroup parent, Product item)
        {
            View view = convertView;
            if (view == null)
                view = LayoutInflater.Inflate(Resource.Layout.ProductItemLayout, parent, false);
            view.FindViewById<TextView>(Resource.Id.lblProductTitle).Text = item.ProductName;
            view.FindViewById<TextView>(Resource.Id.lblProductPrice).Text = item.Price.ToString();
            view.FindViewById<ImageView>(Resource.Id.productImageView).SetImageResource(item.Image);

            return view;
        }
    }

    public class DataProvider
    {
        public static List<Product> GetData()
        {
            return new List<Product>() { new Product { ProductName = "Product 1", Image = Resource.Drawable.Icon, Price = 10 },
            new Product { ProductName = "Product 2", Image = Resource.Drawable.Icon, Price = 10 }};
        }
    }
}