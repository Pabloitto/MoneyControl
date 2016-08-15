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

namespace MoneyControl.Droid.Utils
{
    public class TabsHelper
    {
        private Activity _activity;

        public TabsHelper(Activity activity)
        {
            this._activity = activity;
        }

        public void Add(int fragmentId , string tabText, int iconResourceId, Fragment view)
        {
            var tab = this._activity.ActionBar.NewTab();

            tab.SetIcon(iconResourceId);
            tab.SetText(tabText);
            
            tab.TabSelected += delegate (object sender, ActionBar.TabEventArgs e)
            {
                var fragment = this._activity.FragmentManager.FindFragmentById(fragmentId);
                if (fragment != null)
                {
                    e.FragmentTransaction.Remove(fragment);
                }
                e.FragmentTransaction.Add(fragmentId, view);
            };

            tab.TabUnselected += delegate (object sender, ActionBar.TabEventArgs e)
            {
                e.FragmentTransaction.Remove(view);
            };

            this._activity.ActionBar.AddTab(tab);
        }
    }
}