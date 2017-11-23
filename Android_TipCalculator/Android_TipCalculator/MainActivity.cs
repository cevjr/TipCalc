using Android.App;
using Android.Widget;
using Android.OS;

namespace Android_TipCalculator
{
    [Activity(Label = "Android_TipCalculator", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
        }
    }
}

