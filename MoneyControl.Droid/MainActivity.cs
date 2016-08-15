using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using MoneyControl.Droid.Base;

namespace MoneyControl.Droid
{
    [Activity(Label = "MoneyControl.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : ActivityBase
    {
        private Button SignInButton { get; set; }

        public override void ExecSetContentView()
        {
            base.SetContentView(Resource.Layout.Main);
        }

        public override void InitComponents()
        {
            this.SignInButton = FindViewById<Button>(Resource.Id.SignInButton);
        }

        public override void BindEvents()
        {
            this.SignInButton.Click += delegate
            {
                this.ActivityHelper.InitNewActivity<WelcomeMenuActivity>();
            };
        }
    }
}

