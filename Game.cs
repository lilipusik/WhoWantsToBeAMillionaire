using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WhoWantsToBeAMillionaire
{
	public partial class Game : Form
	{
		private Random rnd = new Random();
		int level = 0, money;
		Question currentQuestion;
		string namePlayer;

		int usedHints = 0;
		bool mistake = false, people = false;

		public Game()
		{
			InitializeComponent();

			namePlayer = Interaction.InputBox("Как вас зовут?");

			string smoney = "";
			while (!lstLevel.Items.Contains(smoney))
				smoney = Interaction.InputBox("Какая сумма будет несгораемой?");
			lbControlSum.Text += smoney;
			money = lstLevel.Items.Count - lstLevel.Items.IndexOf(smoney);

			NextStep();
			timerCall.Tick += timerCall_Tick;
		}

		private void btnAgain_Click(object sender, EventArgs e)
		{
			Application.Restart();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void NextStep()
		{
			Button[] btns = new Button[] { btnAnswerA, btnAnswerB, btnAnswerC, btnAnswerD };
			Array.ForEach(btns, x => x.Enabled = true);

			if (level == money) btnControlSum.Enabled = true;

			level++;
			currentQuestion = Question.GetQuestion(level);
			ShowQuestion(currentQuestion);
			lstLevel.SelectedIndex = lstLevel.Items.Count - level;
		}

		private void GameOver()
		{
			if (btnControlSum.Enabled && level != 14)
			{
				level = int.Parse(lstLevel.Items[lstLevel.Items.Count - money].ToString().Replace(" ", ""));
				MessageBox.Show("Вы проиграли, но забираете с собой контрольную сумму!");
			}
			else if (level == 14)
			{
				level = int.Parse(lstLevel.Items[lstLevel.Items.Count - 1].ToString().Replace(" ", ""));
				MessageBox.Show("Вы победили!");
			}
			else
			{
				level = 0;
				MessageBox.Show("Вы проиграли!");
			}
			Controls.Cast<Control>().ToList().ForEach(ctrl => ctrl.Visible = false);
			lblResult.Text += "\n" + level;
			dataRecords.Visible = labelRecords.Visible = btnClose.Visible = btnAgain.Visible = lblResult.Visible = true;

			Record.InsertPlayer(namePlayer, level);

			dataRecords.DataSource = Record.GetRecords();
		}

		private void ShowQuestion(Question q)
		{
			lblQuestion.Text = q.Text;
			btnAnswerA.Text = q.Answers[0];
			btnAnswerB.Text = q.Answers[1];
			btnAnswerC.Text = q.Answers[2];
			btnAnswerD.Text = q.Answers[3];
		}

		private void btnControlSum_Click(object sender, EventArgs e)
		{
			GameOver();
		}

		private void btnAnswer_Click(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			if (currentQuestion.RightAnswer == int.Parse(button.Tag.ToString()))
			{
				mistake = false;
				NextStep();
			}
			else if (!mistake)
			{
				GameOver();
			}

			else // если используется подсказка "право на ошибку"
			{
				mistake = false;
				MessageBox.Show("У вас есть еще одна попытка!");
				button.Enabled = false;
			}

			if (people) // если используется подсказка "помощь зала" или "звонок другу"
			{
				Button[] btns = new Button[] { btnAnswerA, btnAnswerB, btnAnswerC, btnAnswerD };
				Array.ForEach(btns, x => x.BackColor = Color.White);
				people = false;
			}
		}

		private void bntEnabledFalse(int numBtn)
		{
			Button[] btnsHints = new Button[] { btnCallFriend, btnHallHelp, btnMistake,
				btnReplaceQst, bntFiftyFifty };

			if (usedHints == 4)
				Array.ForEach(btnsHints, x => x.Enabled = false);
			else
				btnsHints[numBtn].Enabled = false;
		}

		private void bntFiftyFifty_Click(object sender, EventArgs e) // 50/50 +
		{
			usedHints++;

			Button[] btns = new Button[] { btnAnswerA, btnAnswerB, btnAnswerC, btnAnswerD };

			int count = 0;
			while (count < 2)
			{
				int n = rnd.Next(4);
				int answer = int.Parse(btns[n].Tag.ToString());

				if (answer != currentQuestion.RightAnswer && btns[n].Enabled)
				{
					btns[n].Enabled = false;
					count++;
				}
			}
			bntEnabledFalse(4);
		}

		private void PeopleHelp(int hint)
		{
			people = true;
			Button[] btns = new Button[] { btnAnswerA, btnAnswerB, btnAnswerC, btnAnswerD };
			if (hint == 1) // помощь зала
				btns = btns.Where(btn => btn.Enabled).ToArray();


			double chance = rnd.NextDouble();
			int rightAnswer = currentQuestion.RightAnswer - 1;
			if (chance < 0.7 - 0.02 * level)
				btns[rightAnswer].BackColor = Color.GreenYellow;
			else
			{
				int wrongAnswer;
				do wrongAnswer = rnd.Next(btns.Count());
				while (wrongAnswer == rightAnswer);
				btns[wrongAnswer].BackColor = Color.GreenYellow;
			}
		}

		private void btnHallHelp_Click(object sender, EventArgs e) // помощь зала +
		{
			usedHints++;
			PeopleHelp(1);
			bntEnabledFalse(1);
		}

		private void timerCall_Tick(object sender, EventArgs e)
		{
			progressCall.PerformStep();
			if (progressCall.Value == progressCall.Maximum)
			{
				timerCall.Stop();
				PeopleHelp(2);

				Control[] gameover = new Control[] { labelRecords, dataRecords, btnAgain, btnClose, lblResult };
				Controls.Cast<Control>().ToList().
					Where(x => !gameover.Contains(x)).ToList().
					ForEach(ctrl => ctrl.Visible = true);
				Control[] controls = new Control[] { btnAnswerA, btnAnswerB, btnAnswerC, btnAnswerD, lblQuestion, picture };
				Array.ForEach(controls, x => x.Enabled = true);
				progressCall.Visible = false;
			}
		}

		private void btnCallFriend_Click(object sender, EventArgs e) // звонок другу +
		{
			usedHints++;

			List<string> names = Friend.GetFriends();
			string namesFriends = string.Join("\n", names.ToArray());

			string choiceName = Interaction.InputBox("Как зовут друга, которому хотите позвонить?\n" + namesFriends);
			if (names.Contains(choiceName))
			{
				Control[] controls = new Control[] { btnAnswerA, btnAnswerB, btnAnswerC, btnAnswerD, lblQuestion, picture };
				Controls.Cast<Control>().ToList().
					Where(x => !controls.Contains(x)).ToList().
					ForEach(ctrl => ctrl.Visible = false);
				Array.ForEach(controls, x => x.Enabled = false);

				timerCall.Enabled = progressCall.Enabled = true;
				progressCall.Visible = true;
				timerCall.Start();
				bntEnabledFalse(0); 
			}
			else
			{
				MessageBox.Show("Такого имени друга не найдено! Попробуйте снова.");
				usedHints--;
				btnCallFriend_Click(sender, e);
			}
		}

		private void btnMistake_Click(object sender, EventArgs e) // право на ошибку +
		{
			usedHints++;
			mistake = true;
			bntEnabledFalse(2);
		}

		private void btnReplaceQst_Click(object sender, EventArgs e) // замена вопроса +
		{
			usedHints++;
			level--;
			NextStep();
			bntEnabledFalse(3);
		}
	}
}
