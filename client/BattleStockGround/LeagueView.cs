using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace BattleStockGround
{
    public partial class LeagueView : Form
    {
        public string id;
        public MainForm main_frm;
        public string league_code;
        public string left_money;

        string return_join = "";   //처음 스트링 다 붙이기
        string[] join_flag;        //다 붙인 스트링 $로 split
        string[] join_inf;         //1줄씩 된 주식 정보 :로 split

        string return_view = "";   //처음 스트링 다 붙이기
        string[] view_flag;        //다 붙인 스트링 $로 split
        string[] view_inf;         //1줄씩 된 주식 정보 :로 split

        //test할때true
        bool istest = false;

        public LeagueView(MainForm frm)
        {
            InitializeComponent();
            main_frm = frm;
            id = main_frm.id;

            if (!istest)
            {
                ssibal();
            }
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)   //column 고정
        {
            e.Cancel = true;
            e.NewWidth = this.listView1.Columns[e.ColumnIndex].Width;
        }

        private void 리그만들기ToolStripMenuItem_Click(object sender, EventArgs e)   //리그만들기
        {
            CreateLeague CL = new CreateLeague(this);
            CL.ShowDialog();
            ssibal();
        }

        private void listView2_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)   //column 고정
        {
            e.Cancel = true;
            e.NewWidth = this.listView2.Columns[e.ColumnIndex].Width;
        }

        public void ssibal()
        {
            return_join = ClientSocket.Communication("view1:" + id + ":$");  //join_view.bin - 가입된 리그 목록 직렬화 파일
            return_view = ClientSocket.Communication("view2:$");           //league_view.bin - 리그 목록 직렬화 파일

            listView1.Items.Clear();
            listView2.Items.Clear();
            join_flag = return_join.Split('$');
            /*
            join_flag[0] = 첫번째 가입목록 줄 (가입리그 : 자산상태 : 상태 : 리그코드)
            join_flag[1] = 두번째 가입목록 줄
            ...
            join_flag[9] = 마지막 가입목록 줄
            */

            for (int i = 0; i < join_flag.Length - 1; i++)
            {
                join_inf = join_flag[i].Split(':');
                ListViewItem itm = new ListViewItem((i + 1).ToString());
                for (int j = 0; j < 4; j++)
                {
                    itm.SubItems.Add(join_inf[j].ToString());
                }
                listView2.Items.Add(itm);
            }


            view_flag = return_view.Split('$');
            /*
            view_flag[0] = 첫번째 리그목록 줄 (상태 : 방제 : 시작일 : 종료일 : 시작금액 : 리그코드)
            view_flag[1] = 두번째 리그목록 줄
            ...
            view_flag[9] = 마지막 리그목록 줄
            */

            for (int i = 0; i < view_flag.Length - 1; i++)
            {
                view_inf = view_flag[i].Split(':');
                ListViewItem itm = new ListViewItem(view_inf[0].ToString());
                for (int j = 1; j < 6; j++)
                {
                    itm.SubItems.Add(view_inf[j].ToString());
                }
                listView1.Items.Add(itm);
            }
        }

        private void listView1_MouseDoubleClick_1(object sender, MouseEventArgs e)      // 리그목록 더블클릭
        {
            bool flag = false;
            string state = listView1.FocusedItem.SubItems[0].Text;  //상태
            league_code = listView1.FocusedItem.SubItems[5].Text;   //리그코드

            for (int i = 0; i < listView2.Items.Count; i++)
            {
                if (league_code == listView2.Items[i].SubItems[4].Text)  //자신이 가입한 리그일때
                {
                    if (state == "대기중")
                    {
                        MessageBox.Show("아직 리그가 시작되지 않았습니다.");
                        flag = true;
                        break;
                    }
                    else if (state == "게임중")
                    {
                        left_money = listView2.Items[i].SubItems[2].Text;    //현재 자산(남은 돈)
                        LeagueForm LF = new LeagueForm(this, league_code, left_money);
                        LF.ShowDialog();                                    //(현재 자산 : left_money), (리그코드 : league_code), (ID : id) - 전역변수들
                        flag = true;
                        break;
                    }
                }
            }

            if(!flag)                      //자신이 가입한 리그가 아닐때
            {
                if (state == "대기중")
                {
                    string[] return_flag2;
                    string msg = ClientSocket.Communication("join_l:" + league_code + ":" + id + ":$");
                    return_flag2 = msg.Split(':');

                    if (return_flag2[0] == "0")
                    {
                        MessageBox.Show("리그에 정상적으로 참가되었습니다.");
                        ssibal();
                    }
                }
                else if (state == "게임중")
                {
                    MessageBox.Show("게임이 시작된 리그는 참가할 수 없습니다.");
                }
            }
            
        }

        private void listView2_MouseDoubleClick(object sender, MouseEventArgs e)        //가입된 리그에 더블클릭
        {
            string state = listView2.FocusedItem.SubItems[3].Text;  //상태
            league_code = listView2.FocusedItem.SubItems[4].Text;   //리그코드
            if (state == "대기중")
            {
                MessageBox.Show("아직 리그가 시작되지 않았습니다.");
            }
            else if (state == "게임중")
            {
                left_money = listView2.FocusedItem.SubItems[2].Text;    //현재 자산(남은 돈)
                LeagueForm LF = new LeagueForm(this, league_code, left_money);
                LF.ShowDialog();                                    //(현재 자산 : left_money), (리그코드 : league_code). (ID : id) - 전역변수들
            }
            else if (state == "종료")
            {
                League_Result LR = new League_Result();
                LR.ShowDialog();
            }
        }
    }
}