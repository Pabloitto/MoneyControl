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
using MoneyControl.Droid.Base;
using MoneyControl.Entities.Base;
using MoneyControl.Entities.Accounts;
using MoneyControl.Droid.Adapters;

namespace MoneyControl.Droid.Fragments.Menu
{
    public sealed class HomeTabFragment : FragmentBase
    {
        private ListView listView;

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);
            var movements = new List<Movement>();

            for (int i = 0; i < 50; i++)
            {
                movements.Add(new Input() { Name = "Deposito nomina " + (i + 1) });
            }

            listView = this.View.FindViewById<ListView>(Resource.Id.movementsListView);

            listView.Adapter = new GenericAdapter<Movement>(this.Activity, movements, "Name");

            listView.FastScrollEnabled = true;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.HomeTabFragment, container, false);
        }
    }
}