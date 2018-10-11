using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace ListView
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : ListActivity //AppCompatActivity
    {
        readonly string[] countries = new string[] { "eesti", "rootsi", "leedu", "soome", "syria" };

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            //SetContentView(Resource.Layout.activity_main);

            ListAdapter = new CustomAdapter(this, countries);

            ListView.ItemClick += ListView_ItemClick;
        }

        private void ListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(Application, ((TextView)e.View).Text, ToastLength.Long).Show();
        }
    }
}