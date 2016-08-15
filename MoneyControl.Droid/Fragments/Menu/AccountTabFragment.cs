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
using MoneyControl.Entities.Accounts;
using MoneyControl.Droid.Adapters;

namespace MoneyControl.Droid.Fragments.Menu
{
    public sealed class AccountTabFragment : FragmentBase
    {
        private ListView listView;

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);
            var accounts = new List<Account>();

            for (int i = 0; i < 3; i++)
            {
                accounts.Add(new Account() { Name = "Account " + (i + 1) });
            }

            listView = this.View.FindViewById<ListView>(Resource.Id.accountListView);

            listView.Adapter = new GenericAdapter<Account>(this.Activity, accounts, "Name");

            listView.FastScrollEnabled = true;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.AccountTabFragment, container, false);
        }
    }
}