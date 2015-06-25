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
using ShopMe.Core;

namespace ShopMe.Droid
{
    public class ProductsAdapter  : BaseAdapter<Product>
    {
        private Activity ActivityContext;
        private List<Product> Items;
        public ProductsAdapter(Activity context, List<Product> _Items)
        {
            ActivityContext = context;
            Items = _Items;
        }

        public override Product this[int position]
        {
            get { return Items != null ? Items[position] : new Product(); }
        }

        public override int Count
        {
            get { return Items.Count; }
        }

        public override long GetItemId(int position)
        {
            return 1;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = Items[position];
            View view = convertView;
            if (view == null)
                view = ActivityContext.LayoutInflater.Inflate(Resource.Layout.ProductItemLayout, parent, false);
            view.FindViewById<TextView>(Resource.Id.lblProductTitle).Text = item.ProductName;
            view.FindViewById<TextView>(Resource.Id.lblProductPrice).Text = item.Price.ToString();
            view.FindViewById<ImageView>(Resource.Id.productImageView).SetImageResource(item.Image);

            return view;
        }
    }
}