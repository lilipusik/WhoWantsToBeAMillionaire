namespace WhoWantsToBeAMillionaire
{
	partial class Game
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
			this.picture = new System.Windows.Forms.PictureBox();
			this.btnAnswerA = new System.Windows.Forms.Button();
			this.lblQuestion = new System.Windows.Forms.Label();
			this.btnAnswerB = new System.Windows.Forms.Button();
			this.btnAnswerC = new System.Windows.Forms.Button();
			this.btnAnswerD = new System.Windows.Forms.Button();
			this.lstLevel = new System.Windows.Forms.ListBox();
			this.bntFiftyFifty = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnHallHelp = new System.Windows.Forms.Button();
			this.btnCallFriend = new System.Windows.Forms.Button();
			this.btnMistake = new System.Windows.Forms.Button();
			this.btnReplaceQst = new System.Windows.Forms.Button();
			this.progressCall = new System.Windows.Forms.ProgressBar();
			this.timerCall = new System.Windows.Forms.Timer(this.components);
			this.lbControlSum = new System.Windows.Forms.Label();
			this.dataRecords = new System.Windows.Forms.DataGridView();
			this.labelRecords = new System.Windows.Forms.Label();
			this.btnControlSum = new System.Windows.Forms.Button();
			this.btnAgain = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.lblResult = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataRecords)).BeginInit();
			this.SuspendLayout();
			// 
			// picture
			// 
			this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
			this.picture.Location = new System.Drawing.Point(273, -19);
			this.picture.Name = "picture";
			this.picture.Size = new System.Drawing.Size(336, 266);
			this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picture.TabIndex = 0;
			this.picture.TabStop = false;
			// 
			// btnAnswerA
			// 
			this.btnAnswerA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAnswerA.Location = new System.Drawing.Point(197, 365);
			this.btnAnswerA.Name = "btnAnswerA";
			this.btnAnswerA.Size = new System.Drawing.Size(233, 85);
			this.btnAnswerA.TabIndex = 1;
			this.btnAnswerA.Tag = "1";
			this.btnAnswerA.Text = "button1";
			this.btnAnswerA.UseVisualStyleBackColor = true;
			this.btnAnswerA.Click += new System.EventHandler(this.btnAnswer_Click);
			// 
			// lblQuestion
			// 
			this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblQuestion.Location = new System.Drawing.Point(199, 263);
			this.lblQuestion.Name = "lblQuestion";
			this.lblQuestion.Size = new System.Drawing.Size(470, 89);
			this.lblQuestion.TabIndex = 2;
			this.lblQuestion.Text = "label1";
			// 
			// btnAnswerB
			// 
			this.btnAnswerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAnswerB.Location = new System.Drawing.Point(436, 365);
			this.btnAnswerB.Name = "btnAnswerB";
			this.btnAnswerB.Size = new System.Drawing.Size(233, 85);
			this.btnAnswerB.TabIndex = 3;
			this.btnAnswerB.Tag = "2";
			this.btnAnswerB.Text = "button2";
			this.btnAnswerB.UseVisualStyleBackColor = true;
			this.btnAnswerB.Click += new System.EventHandler(this.btnAnswer_Click);
			// 
			// btnAnswerC
			// 
			this.btnAnswerC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAnswerC.Location = new System.Drawing.Point(197, 456);
			this.btnAnswerC.Name = "btnAnswerC";
			this.btnAnswerC.Size = new System.Drawing.Size(233, 84);
			this.btnAnswerC.TabIndex = 4;
			this.btnAnswerC.Tag = "3";
			this.btnAnswerC.Text = "button3";
			this.btnAnswerC.UseVisualStyleBackColor = true;
			this.btnAnswerC.Click += new System.EventHandler(this.btnAnswer_Click);
			// 
			// btnAnswerD
			// 
			this.btnAnswerD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAnswerD.Location = new System.Drawing.Point(436, 456);
			this.btnAnswerD.Name = "btnAnswerD";
			this.btnAnswerD.Size = new System.Drawing.Size(233, 84);
			this.btnAnswerD.TabIndex = 5;
			this.btnAnswerD.Tag = "4";
			this.btnAnswerD.Text = "button4";
			this.btnAnswerD.UseVisualStyleBackColor = true;
			this.btnAnswerD.Click += new System.EventHandler(this.btnAnswer_Click);
			// 
			// lstLevel
			// 
			this.lstLevel.Enabled = false;
			this.lstLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lstLevel.FormattingEnabled = true;
			this.lstLevel.ItemHeight = 20;
			this.lstLevel.Items.AddRange(new object[] {
            "3 000 000",
            "1 500 000",
            "800 000",
            "400 000",
            "200 000",
            "100 000",
            "50 000",
            "25 000",
            "15 000",
            "10 000",
            "5 000",
            "3 000",
            "2 000",
            "1 000",
            "500"});
			this.lstLevel.Location = new System.Drawing.Point(802, 28);
			this.lstLevel.Name = "lstLevel";
			this.lstLevel.Size = new System.Drawing.Size(120, 324);
			this.lstLevel.TabIndex = 6;
			// 
			// bntFiftyFifty
			// 
			this.bntFiftyFifty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.bntFiftyFifty.Location = new System.Drawing.Point(27, 115);
			this.bntFiftyFifty.Name = "bntFiftyFifty";
			this.bntFiftyFifty.Size = new System.Drawing.Size(153, 48);
			this.bntFiftyFifty.TabIndex = 7;
			this.bntFiftyFifty.Text = "50/50";
			this.bntFiftyFifty.UseVisualStyleBackColor = true;
			this.bntFiftyFifty.Click += new System.EventHandler(this.bntFiftyFifty_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(41, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 25);
			this.label1.TabIndex = 8;
			this.label1.Text = "Подсказки";
			// 
			// btnHallHelp
			// 
			this.btnHallHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnHallHelp.Location = new System.Drawing.Point(27, 61);
			this.btnHallHelp.Name = "btnHallHelp";
			this.btnHallHelp.Size = new System.Drawing.Size(153, 48);
			this.btnHallHelp.TabIndex = 9;
			this.btnHallHelp.Text = "Помощь зала";
			this.btnHallHelp.UseVisualStyleBackColor = true;
			this.btnHallHelp.Click += new System.EventHandler(this.btnHallHelp_Click);
			// 
			// btnCallFriend
			// 
			this.btnCallFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnCallFriend.Location = new System.Drawing.Point(27, 169);
			this.btnCallFriend.Name = "btnCallFriend";
			this.btnCallFriend.Size = new System.Drawing.Size(153, 78);
			this.btnCallFriend.TabIndex = 10;
			this.btnCallFriend.Text = "Звонок другу";
			this.btnCallFriend.UseVisualStyleBackColor = true;
			this.btnCallFriend.Click += new System.EventHandler(this.btnCallFriend_Click);
			// 
			// btnMistake
			// 
			this.btnMistake.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnMistake.Location = new System.Drawing.Point(27, 253);
			this.btnMistake.Name = "btnMistake";
			this.btnMistake.Size = new System.Drawing.Size(153, 71);
			this.btnMistake.TabIndex = 11;
			this.btnMistake.Text = "Право на ошибку";
			this.btnMistake.UseVisualStyleBackColor = true;
			this.btnMistake.Click += new System.EventHandler(this.btnMistake_Click);
			// 
			// btnReplaceQst
			// 
			this.btnReplaceQst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnReplaceQst.Location = new System.Drawing.Point(27, 330);
			this.btnReplaceQst.Name = "btnReplaceQst";
			this.btnReplaceQst.Size = new System.Drawing.Size(153, 71);
			this.btnReplaceQst.TabIndex = 12;
			this.btnReplaceQst.Text = "Замена вопроса";
			this.btnReplaceQst.UseVisualStyleBackColor = true;
			this.btnReplaceQst.Click += new System.EventHandler(this.btnReplaceQst_Click);
			// 
			// progressCall
			// 
			this.progressCall.Location = new System.Drawing.Point(27, 456);
			this.progressCall.Maximum = 30000;
			this.progressCall.Name = "progressCall";
			this.progressCall.Size = new System.Drawing.Size(153, 52);
			this.progressCall.Step = 1000;
			this.progressCall.TabIndex = 13;
			this.progressCall.Visible = false;
			// 
			// timerCall
			// 
			this.timerCall.Interval = 1000;
			// 
			// lbControlSum
			// 
			this.lbControlSum.AutoSize = true;
			this.lbControlSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbControlSum.Location = new System.Drawing.Point(797, 386);
			this.lbControlSum.Name = "lbControlSum";
			this.lbControlSum.Size = new System.Drawing.Size(213, 25);
			this.lbControlSum.TabIndex = 14;
			this.lbControlSum.Text = "Контрольная сумма: ";
			// 
			// dataRecords
			// 
			this.dataRecords.AllowDrop = true;
			this.dataRecords.AllowUserToOrderColumns = true;
			this.dataRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataRecords.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataRecords.Location = new System.Drawing.Point(323, 115);
			this.dataRecords.Name = "dataRecords";
			this.dataRecords.RowHeadersWidth = 51;
			this.dataRecords.RowTemplate.Height = 24;
			this.dataRecords.Size = new System.Drawing.Size(506, 303);
			this.dataRecords.TabIndex = 17;
			this.dataRecords.Visible = false;
			// 
			// labelRecords
			// 
			this.labelRecords.AutoSize = true;
			this.labelRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelRecords.Location = new System.Drawing.Point(527, 61);
			this.labelRecords.Name = "labelRecords";
			this.labelRecords.Size = new System.Drawing.Size(152, 25);
			this.labelRecords.TabIndex = 18;
			this.labelRecords.Text = "Лучшие игроки";
			this.labelRecords.Visible = false;
			// 
			// btnControlSum
			// 
			this.btnControlSum.Enabled = false;
			this.btnControlSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnControlSum.Location = new System.Drawing.Point(802, 424);
			this.btnControlSum.Name = "btnControlSum";
			this.btnControlSum.Size = new System.Drawing.Size(328, 66);
			this.btnControlSum.TabIndex = 19;
			this.btnControlSum.Tag = "4";
			this.btnControlSum.Text = "Забрать контрольную сумму";
			this.btnControlSum.UseVisualStyleBackColor = true;
			this.btnControlSum.Click += new System.EventHandler(this.btnControlSum_Click);
			// 
			// btnAgain
			// 
			this.btnAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAgain.Location = new System.Drawing.Point(197, 456);
			this.btnAgain.Name = "btnAgain";
			this.btnAgain.Size = new System.Drawing.Size(328, 66);
			this.btnAgain.TabIndex = 20;
			this.btnAgain.Tag = "4";
			this.btnAgain.Text = "Начать заново";
			this.btnAgain.UseVisualStyleBackColor = true;
			this.btnAgain.Visible = false;
			this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
			// 
			// btnClose
			// 
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnClose.Location = new System.Drawing.Point(603, 456);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(328, 66);
			this.btnClose.TabIndex = 21;
			this.btnClose.Tag = "4";
			this.btnClose.Text = "Выйти из игры";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Visible = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// lblResult
			// 
			this.lblResult.AutoSize = true;
			this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblResult.Location = new System.Drawing.Point(928, 61);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(169, 25);
			this.lblResult.TabIndex = 22;
			this.lblResult.Text = "Ваш результат:  ";
			this.lblResult.Visible = false;
			// 
			// Game
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1142, 571);
			this.Controls.Add(this.btnControlSum);
			this.Controls.Add(this.lbControlSum);
			this.Controls.Add(this.progressCall);
			this.Controls.Add(this.btnReplaceQst);
			this.Controls.Add(this.btnMistake);
			this.Controls.Add(this.btnCallFriend);
			this.Controls.Add(this.btnHallHelp);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bntFiftyFifty);
			this.Controls.Add(this.lstLevel);
			this.Controls.Add(this.btnAnswerD);
			this.Controls.Add(this.btnAnswerC);
			this.Controls.Add(this.btnAnswerB);
			this.Controls.Add(this.lblQuestion);
			this.Controls.Add(this.btnAnswerA);
			this.Controls.Add(this.picture);
			this.Controls.Add(this.dataRecords);
			this.Controls.Add(this.labelRecords);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnAgain);
			this.Controls.Add(this.lblResult);
			this.MaximumSize = new System.Drawing.Size(1160, 618);
			this.MinimumSize = new System.Drawing.Size(1160, 618);
			this.Name = "Game";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WhoWantsToBeAMillioner?";
			((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataRecords)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox picture;
		private System.Windows.Forms.Button btnAnswerA;
		private System.Windows.Forms.Label lblQuestion;
		private System.Windows.Forms.Button btnAnswerB;
		private System.Windows.Forms.Button btnAnswerC;
		private System.Windows.Forms.Button btnAnswerD;
		private System.Windows.Forms.ListBox lstLevel;
		private System.Windows.Forms.Button bntFiftyFifty;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnHallHelp;
		private System.Windows.Forms.Button btnCallFriend;
		private System.Windows.Forms.Button btnMistake;
		private System.Windows.Forms.Button btnReplaceQst;
		private System.Windows.Forms.ProgressBar progressCall;
		private System.Windows.Forms.Timer timerCall;
		private System.Windows.Forms.Label lbControlSum;
		private System.Windows.Forms.DataGridView dataRecords;
		private System.Windows.Forms.Label labelRecords;
		private System.Windows.Forms.Button btnControlSum;
		private System.Windows.Forms.Button btnAgain;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label lblResult;
	}
}

