using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BattleStockGround
{
	public partial class LoginForm : Form
	{
		MainForm frm;
		public LoginForm(MainForm frm1)
		{
			InitializeComponent();
            frm = frm1;
		}

		private void button2_Click(object sender, EventArgs e)  //회원가입
		{
			SigninForm signinForm = new SigninForm(this);
			signinForm.ShowDialog();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(textBox1.Text == "")
			{
				MessageBox.Show("ID를 입력하세요.", "ID입력", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			string[] return_flag;
			string msg = ClientSocket.Communication("login:" + textBox1.Text + ":" + textBox2.Text + ":$");

			return_flag = msg.Split(':');
			if (return_flag[0] == "0")
			{
				MessageBox.Show(textBox1.Text + "님 로그인 되었습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
				frm.id = textBox1.Text;
				frm.loginStatus = true;
				frm.button_Login.Text = "로그아웃";
				Close();
			}
			else if (return_flag[0] == "1")
			{
				MessageBox.Show("존재하지 않는 ID입니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if(return_flag[0] == "2")
			{
				MessageBox.Show("비밀번호가 일치하지 않습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
