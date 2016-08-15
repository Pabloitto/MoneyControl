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
using MoneyControl.Droid.Utils;

namespace MoneyControl.Droid.Base
{
    [Activity(Label = "BaseActivity")]
    public abstract class ActivityBase : Activity
    {
        protected AndroidActivityHelper ActivityHelper { get; private set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            this.Start();
        }

        private bool TryToStartActivity()
        {
            try
            {
                this.InitComponents();
                this.BindEvents();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public abstract void ExecSetContentView();
        public abstract void InitComponents();
        public abstract void BindEvents();

        public virtual void Start()
        {
            this.ActivityHelper = new AndroidActivityHelper(this);
            this.ExecSetContentView();
            this.TryToStartActivity();
        }
    }
}