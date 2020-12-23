namespace BattleStockGround
{
	partial class MainForm
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.button_Portfolio = new System.Windows.Forms.Button();
			this.button_Ranking = new System.Windows.Forms.Button();
			this.button_League = new System.Windows.Forms.Button();
			this.button_Login = new System.Windows.Forms.Button();
			this.button_Profile = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label_Stock = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.listView3 = new System.Windows.Forms.ListView();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.listView2 = new System.Windows.Forms.ListView();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tabControl1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button_Portfolio
			// 
			this.button_Portfolio.BackColor = System.Drawing.Color.Transparent;
			this.button_Portfolio.Location = new System.Drawing.Point(13, 13);
			this.button_Portfolio.Name = "button_Portfolio";
			this.button_Portfolio.Size = new System.Drawing.Size(164, 49);
			this.button_Portfolio.TabIndex = 0;
			this.button_Portfolio.Text = "포트폴리오(Portfolio)";
			this.button_Portfolio.UseVisualStyleBackColor = false;
			this.button_Portfolio.Click += new System.EventHandler(this.button_Portfolio_Click);
			// 
			// button_Ranking
			// 
			this.button_Ranking.Location = new System.Drawing.Point(183, 13);
			this.button_Ranking.Name = "button_Ranking";
			this.button_Ranking.Size = new System.Drawing.Size(164, 49);
			this.button_Ranking.TabIndex = 1;
			this.button_Ranking.Text = "랭킹(Ranking)";
			this.button_Ranking.UseVisualStyleBackColor = true;
			this.button_Ranking.Click += new System.EventHandler(this.button_Ranking_Click);
			// 
			// button_League
			// 
			this.button_League.Location = new System.Drawing.Point(353, 13);
			this.button_League.Name = "button_League";
			this.button_League.Size = new System.Drawing.Size(164, 49);
			this.button_League.TabIndex = 2;
			this.button_League.Text = "리그(League)";
			this.button_League.UseVisualStyleBackColor = true;
			this.button_League.Click += new System.EventHandler(this.button_League_Click);
			// 
			// button_Login
			// 
			this.button_Login.Location = new System.Drawing.Point(948, 12);
			this.button_Login.Name = "button_Login";
			this.button_Login.Size = new System.Drawing.Size(107, 21);
			this.button_Login.TabIndex = 3;
			this.button_Login.Text = "로그인";
			this.button_Login.UseVisualStyleBackColor = true;
			this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
			// 
			// button_Profile
			// 
			this.button_Profile.Location = new System.Drawing.Point(835, 12);
			this.button_Profile.Name = "button_Profile";
			this.button_Profile.Size = new System.Drawing.Size(107, 21);
			this.button_Profile.TabIndex = 4;
			this.button_Profile.Text = "내정보";
			this.button_Profile.UseVisualStyleBackColor = true;
			// 
			// listView1
			// 
			this.listView1.BackColor = System.Drawing.SystemColors.Window;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.listView1.ForeColor = System.Drawing.SystemColors.Window;
			this.listView1.FullRowSelect = true;
			this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView1.Location = new System.Drawing.Point(13, 90);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(585, 468);
			this.listView1.TabIndex = 5;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView1_ColumnWidthChanging);
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "종목코드";
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "종목명";
			this.columnHeader1.Width = 115;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "현재가";
			this.columnHeader2.Width = 80;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "거래량";
			// 
			// columnHeader4
			// 
			this.columnHeader4.DisplayIndex = 5;
			this.columnHeader4.Text = "저가";
			this.columnHeader4.Width = 80;
			// 
			// columnHeader5
			// 
			this.columnHeader5.DisplayIndex = 4;
			this.columnHeader5.Text = "고가";
			this.columnHeader5.Width = 69;
			// 
			// label_Stock
			// 
			this.label_Stock.AutoSize = true;
			this.label_Stock.Location = new System.Drawing.Point(13, 72);
			this.label_Stock.Name = "label_Stock";
			this.label_Stock.Size = new System.Drawing.Size(53, 12);
			this.label_Stock.TabIndex = 6;
			this.label_Stock.Text = "주식시장";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Location = new System.Drawing.Point(737, 90);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(318, 333);
			this.tabControl1.TabIndex = 9;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.listView3);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(310, 307);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "뉴스";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// listView3
			// 
			this.listView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listView3.Location = new System.Drawing.Point(0, 0);
			this.listView3.Name = "listView3";
			this.listView3.Size = new System.Drawing.Size(310, 307);
			this.listView3.TabIndex = 0;
			this.listView3.UseCompatibleStateImageBehavior = false;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.listView2);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(310, 307);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "공지사항";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// listView2
			// 
			this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listView2.Location = new System.Drawing.Point(0, 0);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(310, 307);
			this.listView2.TabIndex = 0;
			this.listView2.UseCompatibleStateImageBehavior = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(902, 463);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(131, 23);
			this.button1.TabIndex = 10;
			this.button1.Text = "데이터전송테스트";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(902, 488);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(131, 23);
			this.button2.TabIndex = 11;
			this.button2.Text = "기타 테스트";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(902, 517);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(131, 23);
			this.button3.TabIndex = 12;
			this.button3.Text = "직렬화 테스트";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(761, 463);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(135, 23);
			this.button4.TabIndex = 13;
			this.button4.Text = "파일전송 테스트";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "시가총액(천만원)";
			this.columnHeader6.Width = 117;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1067, 564);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.label_Stock);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.button_Profile);
			this.Controls.Add(this.button_Login);
			this.Controls.Add(this.button_League);
			this.Controls.Add(this.button_Ranking);
			this.Controls.Add(this.button_Portfolio);
			this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(1083, 603);
			this.MinimumSize = new System.Drawing.Size(1083, 603);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BattleStockGround";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.tabControl1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_Portfolio;
		private System.Windows.Forms.Button button_Ranking;
		private System.Windows.Forms.Button button_League;
		private System.Windows.Forms.Button button_Profile;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.Label label_Stock;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.ListView listView3;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		public System.Windows.Forms.Button button_Login;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
		public System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader6;
	}
}

