using System.Data.SQLite;

namespace WhoWantsToBeAMillionaire
{
	class Connection
	{
		public static SQLiteConnection OpenConnect()
		{
			SQLiteConnection cn = new SQLiteConnection();
			cn.ConnectionString = @"Data Source=WhoWantsToBeAMillionaire.db;Version=3";
			cn.Open();
			return cn;
		}
	}
}
