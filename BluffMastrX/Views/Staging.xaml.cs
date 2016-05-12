using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BluffMastrX
{
	public partial class Staging : ContentPage
	{
		public Staging ()
		{
			InitializeComponent ();
		}

		void LeaveGame(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new Landing ());
		}
	}
}

