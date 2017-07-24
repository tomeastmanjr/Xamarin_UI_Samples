using System;
using System.Collections.Generic;
using System.Linq;
using Plugin.Settings;
using Plugin.Settings.Abstractions;

using Foundation;
using UIKit;


namespace toms_tests.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
