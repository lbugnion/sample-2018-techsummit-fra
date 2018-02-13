using HelloXamarin.Data;
using System;

using UIKit;

namespace HelloIos
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            MyButton.TouchUpInside += async (s, e) =>
            {
                try
                {
                    MyText.Text = "Please wait";
                    var service = new YoutubeService();
                    MyText.Text = await service.Refresh();
                }
                catch (Exception ex)
                {
                    MyText.Text = ex.Message;
                }
            };

            AboutButton.TouchUpInside += (s, e) =>
            {
                AppDelegate.Shared.ShowAbout();
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}