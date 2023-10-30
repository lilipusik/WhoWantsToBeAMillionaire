using System.Data.SQLite;

namespace WhoWantsToBeAMillionaire
{
	class Question
	{
		public string Text { get; private set; }
		public string[] Answers { get; private set; }
		public int RightAnswer { get; private set; }
		public int Level { get; private set; }

		private Question(SQLiteDataReader dr)
		{
			Text = dr["QuestionText"].ToString();
			Answers = new string[4] { dr["Answer1"].ToString(), dr["Answer2"].ToString(), dr["Answer3"].ToString(), dr["Answer4"].ToString()};
			RightAnswer = int.Parse(dr["RightAnswer"].ToString());
			Level = int.Parse(dr["Level"].ToString());
		}

		public static Question GetQuestion(int level)
		{
			SQLiteConnection cn = Connection.OpenConnect();
			var cmd = new SQLiteCommand($@"select * from Questions WHERE Level={level} order by Random() LIMIT 1", cn);
			var dr = cmd.ExecuteReader();
			dr.Read();
			Question q = new Question(dr);
			dr.Close();
			cn.Close();
			return q;
		}
	}
}
