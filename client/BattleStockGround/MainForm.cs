using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Collections;

namespace BattleStockGround
{
    public partial class MainForm : Form
    {
        // Test할때는 loginStatus = true
        public bool loginStatus = true;
        public string id = "test_user";

        // 서버에 연결하지 않고 접속시 true로 설정
        public bool isTest = false;

        string return_stock = "";   //처음 스트링 다 붙이기
        string[] stock_flag;        //다 붙인 스트링 $로 split
        string[] stock_inf;         //1줄씩 된 주식 정보 :로 split
        public System.Windows.Forms.Timer timer;
        public MainForm()
        {
            InitializeComponent();
            if (!isTest)
            {
                ClientSocket.InitSocket();
                return_stock = ClientSocket.Communication("stock:$");
                stock_flag = return_stock.Split('$');
                /*
                stock_flag[0] = 첫번째 주식 줄 (주식종목:카카오:1000:1000:1000)
                stock_flag[1] = 두번째 주식 줄
                ...
                stock_flag[9] = 마지막 주식 줄
                */

                for (int i = 0; i < stock_flag.Length - 1; i++)
                {
                    stock_inf = stock_flag[i].Split(':');
                    ListViewItem itm = new ListViewItem(stock_inf[0].ToString());
                    for (int j = 1; j < 6; j++)
                    {
                        itm.SubItems.Add(stock_inf[j].ToString());
                    }
                    listView1.Items.Add(itm);
                }
            }
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 10000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            SetAlternatingRowColors(listView1, Color.RoyalBlue, Color.FromArgb(0, 0, 64));
        }

        void timer_Tick(object sender, EventArgs e)
        {
            pingCheck();
        }

        public void pingCheck()
        {
            //MessageBox.Show("timer tick");
            /*
            try
            {
                ClientSocket.FileTransfer("fileTest");
            }
            catch (Exception ex)
            {
                timer.Stop();
                MessageBox.Show(ex.ToString(), "연결 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            stream.Flush();
            */
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = this.listView1.Columns[e.ColumnIndex].Width;
        }

        private void button_Login_Click(object sender, EventArgs e)     //로그인
        {
            LoginForm a = new LoginForm(this);
            a.ShowDialog();
        }

        private void button_Portfolio_Click(object sender, EventArgs e) //포트폴리오
        {
            if (loginStatus)
            {
                PortfolioForm portfolioForm = new PortfolioForm(this);
                portfolioForm.ShowDialog();
            }
            else
                MessageBox.Show("로그인 하세요.");
        }

        private void button_Ranking_Click(object sender, EventArgs e)   //랭킹
        {
            if (loginStatus)
            {
                RankForm a = new RankForm(this);
                a.Show();
            }
            else
                MessageBox.Show("로그인 하세요.");
        }

        private void button_League_Click(object sender, EventArgs e)    //리그
        {
            if (loginStatus)
            {
                LeagueView LV = new LeagueView(this);
                LV.Show();
            }
            else
                MessageBox.Show("로그인 하세요.");
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClientSocket.QuitSocket();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            testForm t = new testForm();
            t.ShowDialog();
        }

        public void SetAlternatingRowColors(ListView lst, Color color1, Color color2)
        {
            foreach (ListViewItem item in lst.Items)
            {
                if ((item.Index % 2) == 0)
                    item.BackColor = color1;
                else
                    item.BackColor = color2;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            testForm2 t = new testForm2();
            t.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serializeTest s = new serializeTest();
            s.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)  //파일전송 테스트
        {
            FileTransferTest f = new FileTransferTest();
            f.ShowDialog();
        }
    }
}
