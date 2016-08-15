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
using MoneyControl.Droid.Utils;
using MoneyControl.Droid.Fragments.Menu;

namespace MoneyControl.Droid
{
    [Activity(Label = "Welcome")]
    public class WelcomeMenuActivity : ActivityBase
    {
        private TabsHelper _tabHelper;

        public override void ExecSetContentView()
        {
            base.SetContentView(Resource.Layout.WelcomeMenuView);
        }

        public override void InitComponents()
        {
            this._tabHelper = new TabsHelper(this);
            int fragmentContainerId = Resource.Id.fragmentContainer;

            ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;

            _tabHelper.Add(fragmentContainerId, "Home", Resource.Drawable.home, new HomeTabFragment());
            _tabHelper.Add(fragmentContainerId, "Accounts", Resource.Drawable.account, new AccountTabFragment());
            _tabHelper.Add(fragmentContainerId, "Configuration", Resource.Drawable.config, new ConfigTabFragment());
        }

        public override void BindEvents()
        {
            
        }
    }
}