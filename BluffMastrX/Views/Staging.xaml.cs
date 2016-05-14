using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace BluffMastrX
{
	public partial class Staging : ContentPage
	{
		private ObservableCollection<string> CurrentUsers;
		//private bool IsGameCreator;

		public Staging (string userName, bool isGameCreator)
		{
			InitializeComponent ();
			CurrentUsers = new ObservableCollection<string>{userName};
			UserList.ItemsSource = CurrentUsers;
			GameCreator.IsVisible = isGameCreator;
			GamePlayer.IsVisible = !isGameCreator;
		}

		void LeaveGame(object sender, EventArgs e)
		{
			Navigation.PopModalAsync();
		}
	}
}

