using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleStockGround
{
	public partial class CreateLeague : Form
	{
		LeagueView LV;
		public CreateLeague(LeagueView LV1)
		{
			InitializeComponent();
			LV = LV1;
		}

		private void rbtn_public_CheckedChanged(object sender, EventArgs e)     //공개
		{
			if (rbtn_public.Checked)
			{
				tbox_code.ReadOnly = true;
				tbox_codeChk.ReadOnly = true;
				tbox_code.Text = tbox_codeChk.Text = "";
			}
			else if (rbtn_private.Checked)
			{
				tbox_code.ReadOnly = false;
				tbox_codeChk.ReadOnly = false;
			}
		}

		private void rbtn_private_CheckedChanged(object sender, EventArgs e)    //비공개
		{
			if (rbtn_public.Checked)
			{
				tbox_code.ReadOnly = true;
				tbox_codeChk.ReadOnly = true;
				tbox_code.Text = tbox_codeChk.Text = "";
			}
			else if (rbtn_private.Checked)
			{
				tbox_code.ReadOnly = false;
				tbox_codeChk.ReadOnly = false;
			}
		}

		private void btn_create_Click(object sender, EventArgs e)       //생성
		{
			for (int i = 0; i < LV.listView2.Items.Count; i++)
			{
				if (LV.listView2.Items[i].SubItems[1].Text == LV.id && LV.listView2.Items[i].SubItems[3].Text != "종료")  //자신이 만든 대기중인 리그가 있을 때 또 못만듬
				{
					MessageBox.Show("이미 본인이 만들어진 리그가 있습니다.");
				}
			}

			string[] return_flag;
			string msg = ClientSocket.Communication("create:" + LV.id + ":" + textBox1.Text + ":" + textBox2.Text + ":" + textBox3.Text + ":$");
			//create + id + 시작일 + 종료일 + 시작금액

			return_flag = msg.Split(':');
			if (return_flag[0] == "0")
			{
				MessageBox.Show(LV.id + "님의 리그가 생성 되었습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			else if (return_flag[0] == "1")
			{
				MessageBox.Show(LV.id + "님은 이미 생성한 리그가 있습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("잘못된 값입니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}