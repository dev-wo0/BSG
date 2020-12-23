namespace BattleStockGround
{
    partial class LeagueView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.리그만들기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.column_number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.column_leaguename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.column_startDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.column_endDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.column_startM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.column_code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.listView2 = new System.Windows.Forms.ListView();
			this.column_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.column_League = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.column_money = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.column_State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.column_leaguecode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.리그만들기ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(783, 24);
			this.menuStrip1.TabIndex = 12;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 리그만들기ToolStripMenuItem
			// 
			this.리그만들기ToolStripMenuItem.Name = "리그만들기ToolStripMenuItem";
			this.리그만들기ToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
			this.리그만들기ToolStripMenuItem.Text = "리그 만들기";
			this.리그만들기ToolStripMenuItem.Click += new System.EventHandler(this.리그만들기ToolStripMenuItem_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.listView1);
			this.groupBox1.Location = new System.Drawing.Point(14, 200);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(752, 171);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "리그목록";
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_number,
            this.column_leaguename,
            this.column_startDate,
            this.column_endDate,
            this.column_startM,
            this.column_code});
			this.listView1.FullRowSelect = true;
			this.listView1.Location = new System.Drawing.Point(6, 28);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(735, 137);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick_1);
			// 
			// column_number
			// 
			this.column_number.Text = "상태";
			this.column_number.Width = 98;
			// 
			// column_leaguename
			// 
			this.column_leaguename.Text = "리그이름";
			this.column_leaguename.Width = 137;
			// 
			// column_startDate
			// 
			this.column_startDate.Text = "시작일";
			this.column_startDate.Width = 140;
			// 
			// column_endDate
			// 
			this.column_endDate.Text = "종료일";
			this.column_endDate.Width = 110;
			// 
			// column_startM
			// 
			this.column_startM.Text = "시작금액";
			this.column_startM.Width = 181;
			// 
			// column_code
			// 
			this.column_code.Text = "리그코드";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.listView2);
			this.groupBox2.Location = new System.Drawing.Point(14, 23);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(752, 171);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "가입목록";
			// 
			// listView2
			// 
			this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_num,
            this.column_League,
            this.column_money,
            this.column_State,
            this.column_leaguecode});
			this.listView2.FullRowSelect = true;
			this.listView2.Location = new System.Drawing.Point(6, 28);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(735, 137);
			this.listView2.TabIndex = 0;
			this.listView2.UseCompatibleStateImageBehavior = false;
			this.listView2.View = System.Windows.Forms.View.Details;
			this.listView2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView2_MouseDoubleClick);
			// 
			// column_num
			// 
			this.column_num.Text = "순번";
			this.column_num.Width = 61;
			// 
			// column_League
			// 
			this.column_League.Text = "가입리그";
			this.column_League.Width = 221;
			// 
			// column_money
			// 
			this.column_money.Text = "현재자산";
			this.column_money.Width = 327;
			// 
			// column_State
			// 
			this.column_State.Text = "상태";
			// 
			// column_leaguecode
			// 
			this.column_leaguecode.Text = "리그코드";
			// 
			// LeagueView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(783, 395);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "LeagueView";
			this.Text = "LeagueView";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 리그만들기ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader column_number;
        private System.Windows.Forms.ColumnHeader column_leaguename;
        private System.Windows.Forms.ColumnHeader column_startDate;
        private System.Windows.Forms.ColumnHeader column_endDate;
        private System.Windows.Forms.ColumnHeader column_startM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColumnHeader column_num;
        private System.Windows.Forms.ColumnHeader column_League;
        private System.Windows.Forms.ColumnHeader column_money;
        private System.Windows.Forms.ColumnHeader column_State;
        private System.Windows.Forms.ColumnHeader column_code;
        private System.Windows.Forms.ColumnHeader column_leaguecode;
		public System.Windows.Forms.ListView listView1;
		public System.Windows.Forms.ListView listView2;
	}
}