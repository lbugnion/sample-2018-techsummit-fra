// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace HelloIos
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton AboutButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton MyButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel MyText { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (AboutButton != null) {
                AboutButton.Dispose ();
                AboutButton = null;
            }

            if (MyButton != null) {
                MyButton.Dispose ();
                MyButton = null;
            }

            if (MyText != null) {
                MyText.Dispose ();
                MyText = null;
            }
        }
    }
}