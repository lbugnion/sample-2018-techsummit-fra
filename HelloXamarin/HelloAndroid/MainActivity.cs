using Android.App;
using Android.Widget;
using Android.OS;
using HelloXamarin.Data;
using System;

namespace HelloAndroid
{
    [Activity(Label = "HelloAndroid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            var button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += async (s, e) =>
            {
                var text = FindViewById<TextView>(Resource.Id.MyText);

                try
                {
                    text.Text = "Please wait";
                    var service = new YoutubeService();
                    text.Text = await service.Refresh();
                }
                catch (Exception ex)
                {
                    text.Text = ex.Message;
                }
            };
        }
    }
}

