using System;
using System.Collections.Generic;
using Xamarin.Forms;
using BluffMastrX.Util;
using XLabs.Platform.Device;
using XLabs.Ioc;


namespace BluffMastrX
{
	public partial class Landing : ContentPage
	{
		public Landing ()
		{
			InitializeComponent ();
			AppLabel.WidthRequest = BluffMastrX.Util.Constants.DEVICE_WIDTH_INCHES;

		}

		void NewGame(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty (ScreeNameField.Text))
				DisplayAlert (Constants.ERR_SCREENNAME_MISSING_TITLE, Constants.ERR_SCREENNAME_MISSIN_MSG, "OK");
			else
				Navigation.PushModalAsync(new Staging (ScreeNameField.Text, true));
		}

		void JoinGame(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(ScreeNameField.Text))
				DisplayAlert(Constants.ERR_SCREENNAME_MISSING_TITLE, Constants.ERR_SCREENNAME_MISSIN_MSG, "OK");
			else
				Navigation.PushModalAsync(new Staging (ScreeNameField.Text, false));
		}
	}
}

