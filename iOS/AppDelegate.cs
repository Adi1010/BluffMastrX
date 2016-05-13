using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using XLabs.Forms;
using XLabs.Ioc;
using XLabs.Platform.Device;

namespace BluffMastrX.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : XFormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();

			var container = new SimpleContainer ();
			container.Register<IDevice> (t => AppleDevice.CurrentDevice);

			Resolver.SetResolver (container.GetResolver ());

			LoadApplication (new App ());

			return base.FinishedLaunching (app, options);
		}
	}
}

