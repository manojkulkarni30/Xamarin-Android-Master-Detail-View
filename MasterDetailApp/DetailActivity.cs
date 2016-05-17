using Android.App;
using Android.OS;
using System;

namespace MasterDetailApp
{
    [Activity(Label = "Detail View",ParentActivity =typeof(MainActivity))]
    public class DetailActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Detail);
        }
    }
}