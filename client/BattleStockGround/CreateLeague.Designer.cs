namespace BattleStockGround
{
    partial class CreateLeague
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.rbtn_public = new System.Windows.Forms.RadioButton();
            this.rbtn_private = new System.Windows.Forms.RadioButton();
            this.tbox_code = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbox_codeChk = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "시작일";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 21);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(86, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 21);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "종료일";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(86, 125);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 21);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "시작금액";
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(18, 218);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(216, 41);
            this.btn_create.TabIndex = 6;
            this.btn_create.Text = "생성";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // rbtn_public
            // 
            this.rbtn_public.AutoSize = true;
            this.rbtn_public.Checked = true;
            this.rbtn_public.Location = new System.Drawing.Point(30, 26);
            this.rbtn_public.Name = "rbtn_public";
            this.rbtn_public.Size = new System.Drawing.Size(71, 16);
            this.rbtn_public.TabIndex = 7;
            this.rbtn_public.TabStop = true;
            this.rbtn_public.Text = "공개리그";
            this.rbtn_public.UseVisualStyleBackColor = true;
            this.rbtn_public.CheckedChanged += new System.EventHandler(this.rbtn_public_CheckedChanged);
            // 
            // rbtn_private
            // 
            this.rbtn_private.AutoSize = true;
            this.rbtn_private.Location = new System.Drawing.Point(128, 26);
            this.rbtn_private.Name = "rbtn_private";
            this.rbtn_private.Size = new System.Drawing.Size(83, 16);
            this.rbtn_private.TabIndex = 8;
            this.rbtn_private.Text = "비공개리그";
            this.rbtn_private.UseVisualStyleBackColor = true;
            this.rbtn_private.CheckedChanged += new System.EventHandler(this.rbtn_private_CheckedChanged);
            // 
            // tbox_code
            // 
            this.tbox_code.Location = new System.Drawing.Point(86, 152);
            this.tbox_code.Name = "tbox_code";
            this.tbox_code.PasswordChar = '*';
            this.tbox_code.ReadOnly = true;
            this.tbox_code.Size = new System.Drawing.Size(148, 21);
            this.tbox_code.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "가입코드";
            // 
            // tbox_codeChk
            // 
            this.tbox_codeChk.Location = new System.Drawing.Point(86, 179);
            this.tbox_codeChk.Name = "tbox_codeChk";
            this.tbox_codeChk.PasswordChar = '*';
            this.tbox_codeChk.ReadOnly = true;
            this.tbox_codeChk.Size = new System.Drawing.Size(148, 21);
            this.tbox_codeChk.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "코드확인";
            // 
            // CreateLeague
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 280);
            this.Controls.Add(this.tbox_codeChk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbox_code);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbtn_private);
            this.Controls.Add(this.rbtn_public);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "CreateLeague";
            this.Text = "CreateLeague";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.RadioButton rbtn_public;
        private System.Windows.Forms.RadioButton rbtn_private;
        private System.Windows.Forms.TextBox tbox_code;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbox_codeChk;
        private System.Windows.Forms.Label label5;
    }
}