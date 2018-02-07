using Foundation;
using HelloXamarin.Data;
using System;
using UIKit;

namespace HelloIos
{
    public partial class MainViewController : UIViewController
    {
        public MainViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            AboutButton.TouchUpInside += (s, e) =>
            {
                AppDelegate.Shared.ShowAbout();
            };

            MyButton.TouchUpInside += async (s, e) =>
            {
                try
                {
                    MyLabel.Text = "Please wait";
                    var service = new YoutubeService();
                    MyLabel.Text = await service.Refresh();
                }
                catch (Exception ex)
                {
                    MyLabel.Text = ex.Message;
                }
            };
        }
    }
}