using Android.App;
using Android.Widget;
using Android.OS;
using BarChart;
using System;
using Android.Views;
using Android.Support.V7.App;

namespace XamarinBarChart
{
    [Activity(Label = "XamarinBarChart", MainLauncher = true, Icon = "@drawable/icon",Theme ="@style/Theme.AppCompat.Light.NoActionBar")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var data = new[] {10f,20f,100f,50f,20f };
            var chart = new BarChartView(this)
            {
                ItemsSource = Array.ConvertAll(data,v=>new BarModel { Value = v})
            };

            AddContentView(chart, new ViewGroup.LayoutParams(
                WindowManagerLayoutParams.MatchParent, 
                WindowManagerLayoutParams.MatchParent));
        }
    }
}

