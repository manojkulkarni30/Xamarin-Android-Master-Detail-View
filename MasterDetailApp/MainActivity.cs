using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace MasterDetailApp
{
    [Activity(Label = "Master Detail App", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button button = FindViewById<Button>(Resource.Id.btnClick);

            button.Click += delegate { StartActivity(typeof(DetailActivity)); };

        }
    }
}

