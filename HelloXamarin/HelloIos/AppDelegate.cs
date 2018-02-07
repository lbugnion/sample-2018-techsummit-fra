using Foundation;
using HelloXamarin.CommonUi;
using UIKit;
using Xamarin.Forms;

namespace HelloIos
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        public static AppDelegate Shared;
        public static UIStoryboard Storyboard = UIStoryboard.FromName("Main", null);

        private UIWindow _window;
        private UINavigationController _navigation;
        private MainViewController _mainController;
        private UIViewController _aboutController;

        public override UIWindow Window
        {
            get;
            set;
        }

        public void ShowAbout()
        {
            if (_aboutController == null)
            {
                // #2 Use it
                _aboutController = new AboutPage().CreateViewController();
            }

            // And push it onto the navigation stack
            _navigation.PushViewController(_aboutController, true);
        }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            Forms.Init();

            Shared = this;
            _window = new UIWindow(UIScreen.MainScreen.Bounds);

            _mainController = Storyboard.InstantiateInitialViewController() as MainViewController;
            _navigation = new UINavigationController(_mainController);

            _window.RootViewController = _navigation;
            _window.MakeKeyAndVisible();

            return true;
        }

        public override void OnResignActivation(UIApplication application)
        {
            // Invoked when the application is about to move from active to inactive state.
            // This can occur for certain types of temporary interruptions (such as an incoming phone call or SMS message) 
            // or when the user quits the application and it begins the transition to the background state.
            // Games should use this method to pause the game.
        }

        public override void DidEnterBackground(UIApplication application)
        {
            // Use this method to release shared resources, save user data, invalidate timers and store the application state.
            // If your application supports background exection this method is called instead of WillTerminate when the user quits.
        }

        public override void WillEnterForeground(UIApplication application)
        {
            // Called as part of the transiton from background to active state.
            // Here you can undo many of the changes made on entering the background.
        }

        public override void OnActivated(UIApplication application)
        {
            // Restart any tasks that were paused (or not yet started) while the application was inactive. 
            // If the application was previously in the background, optionally refresh the user interface.
        }

        public override void WillTerminate(UIApplication application)
        {
            // Called when the application is about to terminate. Save data, if needed. See also DidEnterBackground.
        }
    }
}


