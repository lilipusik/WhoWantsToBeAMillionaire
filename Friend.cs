using System.Collections.Generic;
using System.Data.SQLite;

namespace WhoWantsToBeAMillionaire
{
	class Friend
	{
		public string Name { get; private set; }

		private Friend(SQLiteDataReader dr)
		{
			Name = dr["Name"].ToString();
		}

		public static List<string> GetFriends()
		{
			SQLiteConnection cn = Connection.OpenConnect();
			var cmd = new SQLiteCommand(@"select Name from Friends", cn);
			var dr = cmd.ExecuteReader();

			List<string> names = new List<string>();
			while (dr.Read())
				names.Add((new Friend(dr)).Name);

			dr.Close();
			cn.Close();
			return names;
		}
	}
}
