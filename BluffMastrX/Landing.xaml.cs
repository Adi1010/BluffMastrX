using System;
using System.Collections.Generic;
using Xamarin.Forms;
using BluffMastrX.Util;

namespace BluffMastrX
{
	public partial class Landing : ContentPage
	{
		public Landing ()
		{
			InitializeComponent ();
		}

		void NewGame(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(ScreeNameField.Text))
				DisplayAlert(Constants.ERR_SCREENNAME_MISSING_TITLE, Constants.ERR_SCREENNAME_MISSIN_MSG, "OK");
		}

		void JoinGame(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(ScreeNameField.Text))
				DisplayAlert(Constants.ERR_SCREENNAME_MISSING_TITLE, Constants.ERR_SCREENNAME_MISSIN_MSG, "OK");
		}
	}
}

