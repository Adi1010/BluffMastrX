using System;

using Xamarin.Forms;
using XLabs.Ioc;
using XLabs.Platform.Device;
using BluffMastrX.Util;

namespace BluffMastrX
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			var container = new SimpleContainer ();
			container.Register<IDevice> (t => AppleDevice.CurrentDevice);
			Resolver.SetResolver (container.GetResolver ());

			var device = Resolver.Resolve<IDevice> ();
			Constants.DEVICE_WIDTH_PX = device.ScreenWidthInches ();
			Constants.DEVICE_WIDTH_INCHES = device.WidthRequestInInches (Constants.DEVICE_WIDTH_PX);


			MainPage = new Landing();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

