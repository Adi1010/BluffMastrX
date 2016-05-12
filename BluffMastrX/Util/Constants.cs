using System;

namespace BluffMastrX.Util
{
	public static class Constants
	{
		/* Error Messages */

		public const string ERR_SCREENNAME_MISSING_TITLE = "ScreenName Missing";
		public const string ERR_SCREENNAME_MISSIN_MSG = "You need to put on your bluffing name";
		public const string ERR_GAMECODE_MISSING_TITLE = "Game Code Missing";
		public const string ERR_GAMECODE_MISSING_MSG = "Kallu kakulu dobbeya??";
		public const string ERR_WRONG_CODE_TITLE = "Incorrect Gamecode";
		public const string ERR_WRONG_CODE_MSG = "Either you or your friend are smoking something fishy";
		public const string ERR_JOIN_GAME_TITLE = "Error Joining Game";
		public const string ERR_JOIN_GAME_MSG = "Please try again later. Could not join the room with code";
		public const string ERR_NEED_PLAYERS_TITLE = "Patience!";
		public const string ERR_NEED_PLAYERS_MSG = "Need 3 or more players to enjoy bluffin'";

		/* Statuses */

		public const string STATUS_WAITING_TO_START = "Waiting for Captain to start the game...";
		public const string STATUS_NEED_MORE_PLAYERS = "Waiting for more players to join...";
		public const string STATUS_START_GAME = "Begin the Bluff Marathon";
		public const string STATUS_INNOCENT_TITLE = "Your heart is pure";
		public const string STATUS_INNOCENT_MSG = "You are not the BluffMastr. Put on your thinking hat, need to catch the BluffMastr";
		public const string STATUS_BLUFFMATR_TITLE = "Muhahaha";
		public const string STATUS_BLUFFMATR_MSG = "Time to Bluff and take your friends for a ride";

		/* Comments */

		public const string CMT_GAME_PREP = "Hold your breath. You could be the next BluffMastr!";

		/* Service Constants */

		public const string SVC_GAME_CAPTAIN = "gameCaptain";
		public const string SVC_GAME_BLUFFMASTER = "gameBluffMaster";
		public const string SVC_PROVIDER = "provider";
		public const string SVC_SCREEN_NAME = "screenName";
		public const string SVC_SHARED_TOKEN = "sharedToken";
		public const string SVC_GAME_DICT = "genericGameDict";
		public const string SVC_CURRENT_QUESTION = "currentQuestion";
		public const string SVC_QUESTION_TITLE = "title";

	}
}

