using Android.App;
using Android.Widget;
using Android.OS;

namespace Android_TipCalculator
{
    [Activity(Label = "Android_TipCalculator", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            //Change
            SetContentView(Resource.Layout.Main);
        }
    }
}

