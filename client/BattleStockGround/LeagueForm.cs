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
	public partial class LeagueForm : Form
	{
		MainForm main_frm;
		string league_code;
		int left_money;
		public LeagueForm(LeagueView LV1, string lc, string lm)
		{
			InitializeComponent();
			LeagueView LV = LV1;
			main_frm = LV1.main_frm;
			league_code = lc;
			left_money = Int32.Parse(lm);

			// 메인 폼의 주식을 가져오는 부분
			foreach (ListViewItem item in main_frm.listView1.Items)
			{
				listView1.Items.Add((ListViewItem)item.Clone());
			}

			// 해당 리그의 소유중인 주식 리스트를 가져오는 부분
			string send = "ownlist:" + main_frm.id + ":" + league_code + ":$";
			// return text
			// 
			string return_flag = ClientSocket.Communication(send);
			string[] stock_flag = return_flag.Split('$');
			string[] stock_inf;
			/*
                stock_flag[0] = 첫번째 소유 주식 줄 (stock_code:amount:)
                stock_flag[1] = 두번째 소유 주식 줄
                ...
                stock_flag[9] = 마지막 소유 주식 줄
            */
			for (int i = 0; i < stock_flag.Length - 1; i++)
			{
				stock_inf = stock_flag[i].Split(':');
				ListViewItem item = new ListViewItem(stock_inf[0]);

				// 해당 주식을 주식 리스트에서 검색
				string stock_name = "";
				int price = 0;
				for (int j = 0; listView2.Items.Count > j; j++)
				{
					// 종목 코드가 동일한 주식 발견시
					if (stock_inf[0] == listView2.Items[j].Text)
					{
						// 해당 주식의 종목명과 현재가를 저장 후 루프 탈출
						stock_name = listView2.Items[j].SubItems[1].Text;
						price = Int32.Parse(listView2.Items[j].SubItems[2].Text);
						break;
					}
				}

				// 루프가 종료되었는데 종목명이 그대로 null인 경우 : 해당 종목코드를 가지는 주식이 삭제된 경우
				if (stock_name == null)
				{
					MessageBox.Show("일부 주식 데이터가 삭제되어 더 이상 존재하지 않는 주식을 포함하고 있습니다.", "존재하지 않는 주식", MessageBoxButtons.OK, MessageBoxIcon.Error);
					main_frm.Close();
				}

				// 서브아이템 1 : 종목명 = 위에서 구한 stock_name
				// 서브아이템 2 : 가치 = ( 위에서 구한 price * 서버에서 받아온 amount)
				// 서브아이템 3 : 수량 = 서버에서 받아온 amount
				item.SubItems.Add(stock_name);
				item.SubItems.Add((price * Int32.Parse(stock_inf[1])).ToString());
				item.SubItems.Add(stock_inf[i]);
				listView2.Items.Add(item);
			}

			// 라벨에 현재 가진 금액을 출력
			label1.Text = left_money.ToString();
		}

		private void listView2_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
		{
			e.Cancel = true;
			e.NewWidth = this.listView2.Columns[e.ColumnIndex].Width;
		}
		private void listView1_ColumnWidthChanging_1(object sender, ColumnWidthChangingEventArgs e)
		{
			e.Cancel = true;
			e.NewWidth = this.listView1.Columns[e.ColumnIndex].Width;
		}

		// 리스트뷰의 항목을 선택할 때 해당 주식의 주식 코드와 가격을 계산하여 텍스트박스에 입력
		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			textBox1.Text = listView1.FocusedItem.SubItems[0].Text;
			int price = Int32.Parse(listView1.FocusedItem.SubItems[2].Text);
			textBox3.Text = (price * numericUpDown1.Value).ToString();//NumberForm.insertComma3((price * numericUpDown1.Value).ToString());
		}

		// 주문하기 버튼
		// CASE 1 : 가격이 현재 소지금보다 클 경우	-> 리턴
		// CASE 2 : 아무런 주식을 선택하지 않은 경우 -> 리턴
		// CASE 3 : 전체 주식 리스트에서 선택한 경우 -> 해당 주식이 소유중인지 검사 한다. 
		//															-> 소유중일 경우 : 소유한 주식 값을 변경한다.
		//															-> 소유중이 아닐 경우 : 새로운 주식을 추가한다.
		// CASE 2 : 소유중 주식 리스트에서 주식을 선택한 경우 -> 해당 주식 값을 변경한다.
		private void btn_order_Click(object sender, EventArgs e)
		{
			// 가격이 현재 소지금보다 클 경우
			if (left_money < Int32.Parse(textBox3.Text))
			{
				MessageBox.Show("돈이 부족하여 거래할 수 없습니다.", "소지금 부족", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			// 아무런 주식도 선택하지 않았을 때
			else if (textBox1.Text == "")
			{
				return;
			}
			// 그 외의 경우 : 주식 구매 처리
			else
			{
				int index = 0;
				// true : 소유중인 주식, false : 소유중이지 않은 주식
				bool isOwn = false;
				string resultString = "";
				int amount;
				// 선택한 주식이 이미 소유중인 주식인지 검사
				for (int i = 0; listView2.Items.Count > i; i++)
				{
					string compareText = listView2.Items[i].Text;
					if (compareText == textBox1.Text)
					{
						index = i;
						isOwn = true;
						break;
					}
				}

				// 소유중인 주식의 경우 -> 가지고있는 주식 리스트에서 편집
				if (isOwn)
				{
					listView2.Items[index].SubItems[2].Text = (Int32.Parse(listView2.Items[index].SubItems[2].Text) + Int32.Parse(textBox3.Text)).ToString();
					amount = Int32.Parse(listView2.Items[index].SubItems[3].Text) + (int)numericUpDown1.Value;
					listView2.Items[index].SubItems[3].Text = amount.ToString();
					left_money -= Int32.Parse(textBox3.Text);
					label1.Text = left_money.ToString();
					resultString = ":update:$";
				}
				// 소유중이지 않은 주식의 경우 -> 새로운 주식 아이템을 가지고 있는 주식 리스트에 추가
				else
				{
					left_money -= Int32.Parse(textBox3.Text);
					label1.Text = left_money.ToString();
					ListViewItem item = new ListViewItem(textBox1.Text);
					item.SubItems.Add(listView1.FocusedItem.SubItems[1].Text);
					item.SubItems.Add(textBox3.Text);
					amount = (int)numericUpDown1.Value;
					item.SubItems.Add(amount.ToString());
					listView2.Items.Add(item);
					resultString = ":insert:$";
				}

				// 작업 완료 후 서버에 결과를 전송
				// send = buy:league_code:id:stock_code:amount:left_money:(insert or update):$
				string send = "buy:" + league_code + ":" + main_frm.id + ":" + textBox1.Text + ":" + amount.ToString() + ":" + left_money.ToString() + resultString;
				if (ClientSocket.Communication(send) == "0:$")
				{
					MessageBox.Show("구매에 성공했습니다.", "구매 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		// CASE 1 : 아무런 주식을 선택하지 않은 경우 -> 리턴
		// CASE 2 : 주식을 선택할 경우 -> 해당 주식이 소유중인 주식인지 검사 한다.
		private void btn_Sell_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == null) return;
			else
			{
				int index = 0;
				// true : 소유중인 주식, false : 소유중이지 않은 주식
				int amount;
				string resultString = "";
				bool isOwn = false;
				// 선택한 주식이 이미 소유중인 주식인지 검사
				for (int i = 0; listView2.Items.Count > i; i++)
				{
					string compareText = listView2.Items[i].Text;
					if (compareText == textBox1.Text)
					{
						index = i;
						isOwn = true;
						break;
					}
				}

				// 소유중인 주식의 경우 -> 가지고있는 주식 리스트에서 편집
				if (isOwn)
				{
					// CASE 1 : 수량이 가진 주식 수보다 많은 경우			-> 거절
					// CASE 2 : 수량이 가진 주식 수와 같거나 적은 경우 -> 판매
					if (Int32.Parse(listView2.Items[index].SubItems[3].Text) < numericUpDown1.Value)
					{
						MessageBox.Show("가지고 있는 주식의 수량을 확인해 주십시오.", "판매 에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					// 전부 판매하는 경우 : 소유중 리스트에서 해당 주식 삭제
					else if (Int32.Parse(listView2.Items[index].SubItems[3].Text) == numericUpDown1.Value)
					{
						amount = (int)numericUpDown1.Value;
						listView2.Items.RemoveAt(index);
						left_money += Int32.Parse(textBox3.Text);
						label1.Text = left_money.ToString();
						resultString = ":delete:$";
					}
					// 일부 판매하는 경우 : 소유중 리스트에서 해당 주식 값 변경
					else
					{
						listView2.Items[index].SubItems[2].Text = (Int32.Parse(listView2.Items[index].SubItems[2].Text) - Int32.Parse(textBox3.Text)).ToString();
						amount = Int32.Parse(listView2.Items[index].SubItems[3].Text) - (int)numericUpDown1.Value;
						listView2.Items[index].SubItems[3].Text = amount.ToString();
						left_money += Int32.Parse(textBox3.Text);
						label1.Text = left_money.ToString();
						resultString = ":update:$";
					}
					// 작업 완료 후 서버에 결과를 전송
					// send = sell:league_code:id:stock_code:amount:left_money:(delete or update):$
					string send = "sell:" + league_code + ":" + main_frm.id + ":" + textBox1.Text + ":" + amount.ToString() + ":" + left_money.ToString() + resultString;
					if (ClientSocket.Communication(send) == "0:$")
					{
						MessageBox.Show("판매에 성공했습니다.", "판매 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				// 소유중이지 않은 주식의 경우 -> 거절
				else
				{
					left_money -= Int32.Parse(textBox3.Text);
					label1.Text = left_money.ToString();
					ListViewItem item = new ListViewItem(textBox1.Text);
					item.SubItems.Add(listView1.FocusedItem.SubItems[1].Text);
					item.SubItems.Add(textBox3.Text);
					item.SubItems.Add(numericUpDown1.Value.ToString());
					listView2.Items.Add(item);
				}
			}
		}

		// 수량 변경 이벤트
		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			// CASE 1 : 아무런 주식을 선택하지 않은 경우 -> 리턴
			// CASE 2 : 주식을 선택한 경우						-> 해당 주식의 가격을 계산하여 textBox3에 출력
			if (textBox1.Text == null)
			{
				return;
			}

			int price = Int32.Parse(listView1.FocusedItem.SubItems[2].Text);
			textBox3.Text = (price * numericUpDown1.Value).ToString(); //NumberForm.insertComma3((price * numericUpDown1.Value).ToString());

		}
	}
}
