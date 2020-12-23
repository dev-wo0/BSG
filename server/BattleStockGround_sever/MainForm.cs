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
using MySql.Data.MySqlClient;
using System.Collections;
using System.Drawing.Imaging;
using System.IO;

//Server 0.1version
namespace BattleStockGround_sever
{
    public partial class MainForm : Form
    {                                  
        TcpListener server = null;
        TcpClient client = null;
        static int counter = 0;

        public MainForm()
        {           
           
            InitializeComponent();
                  

            Thread t = new Thread(InitSocket);
            t.IsBackground = true;
            t.Start();      
        }

        private void InitSocket()
        {
            server = new TcpListener(IPAddress.Any,9000);
            client = default(TcpClient);
            server.Start();
            DisplayText(">> Server Started");

            while (true)
            {
                try
                {
                    counter++;
                    client = server.AcceptTcpClient();
                    DisplayText(">> Accept connection from client");

                    handleClient h_client = new handleClient();
                    h_client.OnReceived += new handleClient.MessageDisplayHandler(DisplayText);
                    h_client.OnCalculated += new handleClient.CalculateClientCounter(CalculateCounter);
                    h_client.startClient(client, counter);
                   
                }
                catch (SocketException se)
                {
                    Trace.WriteLine(string.Format("InitSocket - SocketException : {0}", se.Message));
                }
                catch (Exception ex)
                {
                    Trace.WriteLine(string.Format("InitSocket - Exception : {0}", ex.Message));
                }
            }
        }

        private void DisplayText(string text)
        {
            if (listBox1.InvokeRequired)
            {
                listBox1.BeginInvoke(new MethodInvoker(delegate
                {
                    listBox1.Items.Add(text + Environment.NewLine);
                }));
            }
            else
                listBox1.Items.Add(text + Environment.NewLine);
        }
        
        private void CalculateCounter()
        {
            counter--;
        }
          

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
          {
             
               if (client != null)
               {
                    client.Close();
                    client = null;
               }

               if (server != null)
               {
                    server.Stop();
                    server = null;
               }
          }        
     }
}
