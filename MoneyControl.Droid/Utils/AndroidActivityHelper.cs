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
    public class AndroidActivityHelper
    {
        private Activity _activity;

        public AndroidActivityHelper(Activity activity)
        {
            this._activity = activity;
        }

        public T GetValueFromExtras<T>(string key) where T : struct
        {
            return this.GetValueFromExtras<T>(this._activity.Intent, key);
        }

        public T GetValueFromExtras<T>(Intent ident, string key) where T : struct
        {
            var strValue = ident.Extras.GetString(key);
            return (T)Convert.ChangeType(strValue, typeof(T));
        }

        public Intent GetIntentWithExtra(IDictionary<string, object> extra)
        {
            var intent = new Intent();

            if (extra != null)
            {
                foreach (var item in extra)
                {
                    intent.PutExtra(item.Key, item.Value.ToString());
                }
            }

            return intent;
        }

        public void InitNewActivity<T>() where T : Activity
        {
            var intent = new Intent(this._activity, typeof(T));
            this._activity.StartActivity(intent);
        }

        public void InitNewActivity<T>(IDictionary<string, object> extra, int? requestCode = null) where T : Activity
        {
            var intent = GetIntentWithExtra(extra);
            intent.SetClass(this._activity, typeof(T));

            if (requestCode != null)
            {
                this._activity.StartActivityForResult(intent, requestCode.Value);
                return;
            }

            this._activity.StartActivity(intent);
        }

        public void InitNewActivity(string action, Android.Net.Uri data = null)
        {
            var intent = new Intent(action);
            if (data != null)
            {
                intent.SetData(data);
            }
            this._activity.StartActivity(intent);
        }
    }
}