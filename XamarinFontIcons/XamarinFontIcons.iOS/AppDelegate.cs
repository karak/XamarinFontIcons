﻿using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace XamarinFontIcons.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            /*
            var font = UIFont.FontNamesForFamilyName("Font Awesome 5 Free");
            if (font == null || font.Length == 0) throw new RuntimeException("Font Not Found!");
            System.Diagnostics.Debug.WriteLine(string.Join(", ", font));
            */
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}