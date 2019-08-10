using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Media;
using Environment = System.Environment;
using System;

namespace LcarsHangman
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Activity
    {
        // Sound test  
        MediaPlayer player;
        // Sound test
        private Button btnStart;
        private RadioButton Rb1, Rb2, Rb3;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            btnStart = FindViewById<Button>(Resource.Id.btnStart);
            RadioButton Rb1 = FindViewById<RadioButton>(Resource.Id.Rb1);
            RadioButton Rb2 = FindViewById<RadioButton>(Resource.Id.Rb2);
            RadioButton Rb3 = FindViewById<RadioButton>(Resource.Id.Rb3);

            btnStart.Click += BtnStart_Click;
            Rb1.Click += Rb1_Click;
            Rb2.Click += Rb1_Click;
            Rb3.Click += Rb1_Click;




        }
        // link this to start button
        private void BtnStart_Click(object sender, EventArgs e)
        {
            Button fakebutton = (Button)sender;
            fakBut(fakebutton.Text);

        }
        private void fakBut(string FakButswitch)
        {
            {
                switch (FakButswitch)
                {
                    case "1":
                        // do stuff here
                        break;

                    case "2":
                        // do stuff here
                        break;

                    case "3":
                        // do stuff here
                        break;

                    case "4":
                        // do stuff here
                        break;
                }
            }
        }
        // link this to all the radio buttons
        private void Rb1_Click(object sender, System.EventArgs e)
        {
            RadioButton fkRb = new RadioButton;
            fkRb = (RadioButton)sender;
        }

        // make a method for buttons
        private void fakRadio(string FakRaswitch)
        {
            switch (FakRaswitch)
            {
                case "1":
                    // do stuff
                    break;

                case "2":
                    // do stuff
                    break;

                case "3":
                    // do stuff
                    break;


            }
        }





        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}