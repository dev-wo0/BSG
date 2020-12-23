namespace BattleStockGround
{
    partial class LeagueForm
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.btn_Sell = new System.Windows.Forms.Button();
			this.btn_order = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.listView2 = new System.Windows.Forms.ListView();
			this.column_code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.column_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.column_money = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.column_amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(84, 31);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(154, 21);
			this.textBox1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(25, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "종목코드";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(25, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 12);
			this.label3.TabIndex = 5;
			this.label3.Text = "주문수량";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(25, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 12);
			this.label4.TabIndex = 7;
			this.label4.Text = "주문가격";
			// 
			// textBox3
			// 
			this.textBox3.Enabled = false;
			this.textBox3.Location = new System.Drawing.Point(84, 85);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(154, 21);
			this.textBox3.TabIndex = 6;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.numericUpDown1);
			this.groupBox1.Controls.Add(this.btn_Sell);
			this.groupBox1.Controls.Add(this.btn_order);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Location = new System.Drawing.Point(490, 29);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(268, 163);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "주문입력";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(84, 59);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(154, 21);
			this.numericUpDown1.TabIndex = 10;
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// btn_Sell
			// 
			this.btn_Sell.Location = new System.Drawing.Point(135, 112);
			this.btn_Sell.Name = "btn_Sell";
			this.btn_Sell.Size = new System.Drawing.Size(127, 34);
			this.btn_Sell.TabIndex = 9;
			this.btn_Sell.Text = "판매";
			this.btn_Sell.UseVisualStyleBackColor = true;
			this.btn_Sell.Click += new System.EventHandler(this.btn_Sell_Click);
			// 
			// btn_order
			// 
			this.btn_order.Location = new System.Drawing.Point(6, 112);
			this.btn_order.Name = "btn_order";
			this.btn_order.Size = new System.Drawing.Size(123, 34);
			this.btn_order.TabIndex = 8;
			this.btn_order.Text = "구입";
			this.btn_order.UseVisualStyleBackColor = true;
			this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.listView2);
			this.groupBox2.Location = new System.Drawing.Point(12, 29);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(472, 163);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "자산현황";
			// 
			// listView2
			// 
			this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_code,
            this.column_name,
            this.column_money,
            this.column_amount});
			this.listView2.Location = new System.Drawing.Point(6, 20);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(460, 137);
			this.listView2.TabIndex = 0;
			this.listView2.UseCompatibleStateImageBehavior = false;
			this.listView2.View = System.Windows.Forms.View.Details;
			this.listView2.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView2_ColumnWidthChanging);
			// 
			// column_code
			// 
			this.column_code.Text = "종목코드";
			// 
			// column_name
			// 
			this.column_name.Text = "종목명";
			this.column_name.Width = 174;
			// 
			// column_money
			// 
			this.column_money.Text = "가치";
			this.column_money.Width = 142;
			// 
			// column_amount
			// 
			this.column_amount.Text = "소유 개수";
			this.column_amount.Width = 79;
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
			this.listView1.Location = new System.Drawing.Point(18, 216);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(740, 276);
			this.listView1.TabIndex = 10;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView1_ColumnWidthChanging_1);
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "종목코드";
			this.columnHeader9.Width = 86;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "종목명";
			this.columnHeader1.Width = 149;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "현재가";
			this.columnHeader2.Width = 104;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "거래량";
			this.columnHeader3.Width = 100;
			// 
			// columnHeader4
			// 
			this.columnHeader4.DisplayIndex = 5;
			this.columnHeader4.Text = "저가";
			this.columnHeader4.Width = 62;
			// 
			// columnHeader5
			// 
			this.columnHeader5.DisplayIndex = 4;
			this.columnHeader5.Text = "고가";
			this.columnHeader5.Width = 75;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "시가총액(천만원)";
			this.columnHeader6.Width = 159;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(363, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 12);
			this.label1.TabIndex = 11;
			this.label1.Text = "label1";
			// 
			// LeagueForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(779, 513);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "LeagueForm";
			this.Text = "LeagueForm";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader column_name;
        private System.Windows.Forms.ColumnHeader column_money;
        private System.Windows.Forms.ColumnHeader column_amount;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Button btn_Sell;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColumnHeader column_code;
	}
}