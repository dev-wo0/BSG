using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Diagnostics;

namespace BattleStockGround
{
    public partial class Loading : Form
    {
        public Loading(MainForm m)
        {
            InitializeComponent();
            /*
            new Thread(delegate ()
            {
                if ((flag_string = ClientSocket.InitSocket()) != "0")
                {
                    MessageBox.Show(flag_string, "Error");
                    this.Close();
                    m.Close();
                }
            }).Start();
            
            if(flag_string == "0")
            {
                MessageBox.Show("서버와 연결 되었습니다.", "Success");
                this.Close();
            }*/
        }
    }
}
