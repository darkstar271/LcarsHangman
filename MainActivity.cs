using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace LcarsHangman
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Button btnStart;
        private RadioButton Rb1, Rb2, Rb3;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            btnStart = FindViewById<Button>(Resource.Id.btnStart);
            Rb1 = FindViewById<RadioButton>(Resource.Id.Rb1);
            Rb2 = FindViewById<RadioButton>(Resource.Id.Rb2);
            Rb3 = FindViewById<RadioButton>(Resource.Id.Rb3);

            Rb1.Click += Rb1_Click;
            btnStart.Click += BtnStart_Click;
        }
        // link this to start button
        private void BtnStart_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        // link this to all the radio buttons
        private void Rb1_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        // make a method for buttons






        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}