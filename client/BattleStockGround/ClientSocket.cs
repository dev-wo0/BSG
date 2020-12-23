using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;


namespace BattleStockGround
{
    class ClientSocket
    {
        public static TcpClient socket = new TcpClient();

        public static void InitSocket()
        {
            try
            {
                socket.Connect("127.0.0.1", 9000);
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void QuitSocket()
        {
            socket.Close();
        }

        public static string Communication(string value)    //String 주고 받기
        {
            NetworkStream Stream2 = socket.GetStream();
            byte[] sbuffer = Encoding.Unicode.GetBytes(value);
            Stream2.Write(sbuffer, 0, sbuffer.Length);
            Stream2.Flush();

            byte[] rbuffer = new byte[1024];
            Stream2.Read(rbuffer, 0, rbuffer.Length);
            string msg = Encoding.Unicode.GetString(rbuffer);
            return msg;
        }
    }
}