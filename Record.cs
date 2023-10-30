using System.Data;
using System.Data.SQLite;

namespace WhoWantsToBeAMillionaire
{
	class Record
	{
		public string Name { get; private set; }
		public int Score { get; private set; }

		private Record(SQLiteDataReader dr)
		{
			Name = dr["Name"].ToString();
			Score = int.Parse(dr["Score"].ToString());
		}

		public static void InsertPlayer(string name, int score)
		{
			SQLiteConnection cn = Connection.OpenConnect();
			var cmd1 = new SQLiteCommand("INSERT INTO Records (Name,Score) VALUES (@name,@score)", cn);
			cmd1.Parameters.AddWithValue("@name", name);
			cmd1.Parameters.AddWithValue("@score", score);
			cmd1.ExecuteNonQuery();
			cn.Close();
		}

		public static DataTable GetRecords()
		{
			SQLiteConnection cn = Connection.OpenConnect();
			var cmd2 = new SQLiteCommand("SELECT * from Records order by Score DESC LIMIT 10", cn);
			var dr = cmd2.ExecuteReader();

			DataTable dt = new DataTable();
			dt.Columns.Add("Место");
			dt.Columns.Add("Участники");
			dt.Columns.Add("Результат");

			int k = 1;
			while (dr.Read())
			{
				DataRow r = dt.NewRow();
				r["Место"] = k++;
				r["Участники"] = (new Record(dr)).Name;
				r["Результат"] = (new Record(dr)).Score;
				dt.Rows.Add(r);
			}
			dr.Close();
			cn.Close();

			return dt;
		}
	}
}
