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
using MoneyControl.Entities.Base;
using System.Reflection;

namespace MoneyControl.Droid.Adapters
{
    public class GenericAdapter<T> : BaseAdapter<T> where T : EntityBase
    {
        private List<T> _items;
        private Activity _context;
        private string _labelPropertyName;

        public GenericAdapter(Activity context, List<T> items, string labelPropertyName)
        {
            this._items = items;
            this._context = context;
            this._labelPropertyName = labelPropertyName;
        }

        public override T this[int position]
        {
            get
            {
                return _items[position];
            }
        }

        public override int Count
        {
            get
            {
                return _items.Count();
            }
        }

        public override long GetItemId(int position)
        {
            return _items[position].Id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = _items[position];

            if (convertView == null)
            {
                convertView = _context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem1, null);
            }

            convertView.FindViewById<TextView>(Android.Resource.Id.Text1).Text = GetPropertyValue(item, _labelPropertyName).ToString();

            return convertView;
        }


        private object GetPropertyValue(T item , string propertyName)
        {
            return typeof(T).GetProperty(propertyName,
                  BindingFlags.FlattenHierarchy |
                  BindingFlags.Instance |
                  BindingFlags.Public)
               .GetValue(item);
        }
    }
}