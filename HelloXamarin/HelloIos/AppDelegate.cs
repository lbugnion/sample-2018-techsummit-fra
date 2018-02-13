using Foundation;
using HelloXamarin.CommonUi;
using UIKit;
using Xamarin.Forms;

namespace HelloIos
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        // class-level declarations
        public static AppDelegate Shared;
        public static UIStoryboard Storyboard = UIStoryboard.FromName("Main", null);

        private UIViewController _aboutController;
        private ViewController _mainController;
        private UINavigationController _navigation;

        public override UIWindow Window
        {
            get;
            set;
        }

        // Show Xamarin.Forms About Page

        public void ShowAbout()
        {
            if (_aboutController == null)
            {
                _aboutController = new AboutPage().CreateViewController();
            }

            // And push it onto the navigation stack
            _navigation.PushViewController(_aboutController, true);
        }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            Forms.Init();

            Shared = this;
            Window = new UIWindow(UIScreen.MainScreen.Bounds);
            _mainController = Storyboard.InstantiateInitialViewController() as ViewController;
            _navigation = new UINavigationController(_mainController);

            Window.RootViewController = _navigation;
            Window.MakeKeyAndVisible();

            return true;
        }
    }
}