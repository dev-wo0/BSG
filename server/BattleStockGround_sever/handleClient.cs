using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.Collections;
using System.IO;

namespace BattleStockGround_sever
{
     class handleClient
     {
          public TcpClient clientSocket;
          int clientNo;
          string[] test;
          MySqlConnection MConn;
          public string Sql = "Server=localhost; Database=battle; uid=root; Pwd=root";

          /// <summary>
          /// 로그인 부울값
          /// </summary>
          /// <param login_chk="로그인 리턴값  Success = 성공 / Incorrect = PW불일치 / NoID = 계정 없음 / Enter = id/pw미입력"></param>
          /// <param return_name="DB안의 이름값"></param>
          string login_chk;
          string return_name = "False";

          /// <summary>
          /// ID중복확인 부울값
          /// </summary>
          /// <param id_chk="ID중복확인 리턴값    Already = 이미 있는 아이디 / Ok = 가능 아이디 / Notover5 = 5글자 이하입력"></param>
          string id_chk;

          /// <summary>
          /// 회원가입 부울값
          /// </summary>
          /// <param join_chk="회원가입 리턴값    Ok = 회원가입 완료 / NotEqual = 비밀번호 미일치 / NullName = 이름 입력 안함 / NullPW = 비밀번호 미입력"></param>
          string join_chk;

          string league_chk;
          string join_l_chk;
          string buy_chk;
          string sell_chk;


          object view_count;
          object stock_count;

          int test_count;
          byte[] sbuffer;

          string player;

          ArrayList al;

          public void startClient(TcpClient ClientSocket, int clientNo)
          {
               this.clientSocket = ClientSocket;
               this.clientNo = clientNo;

               Thread t_hanlder = new Thread(doChat);
               t_hanlder.IsBackground = true;
               t_hanlder.Start();
          }

          public delegate void MessageDisplayHandler(string text);
          public event MessageDisplayHandler OnReceived;

          public delegate void CalculateClientCounter();
          public event CalculateClientCounter OnCalculated;

          private void doChat()
          {
               NetworkStream stream = null;
               try
               {
                    byte[] buffer = new byte[1024];
                    string msg = string.Empty;
                    int bytes = 0;
                    int MessageCount = 0;
                    string qury= string.Empty;
 

                    while (true)
                    {
                         MConn = new MySqlConnection(Sql);
                         MConn.Open();
                         MessageCount++;
                         stream = clientSocket.GetStream();
                         bytes = stream.Read(buffer, 0, buffer.Length);
                         msg = Encoding.Unicode.GetString(buffer, 0, bytes);
                         msg = msg.Substring(0, msg.IndexOf("$"));

                         test = msg.Split(':');


                         /////////////////////////
                         /// Client - login버튼을 눌렀을때
                         /// test[0] = "login"
                         /// test[1] = "id"
                         /// test[2] = "pw"
                         /////////////////////////
                         if (test[0].ToString() == "login")
                         {
                              string sql = "select id, pw from user where id= '" + test[1] + "'";
                              var Comm = new MySqlCommand(sql, MConn);
                              var myRead = Comm.ExecuteReader();

                              if (test[1].ToString() != "" && test[2].ToString() != "")
                              {
                                   if (myRead.HasRows)
                                   {
                                        if (myRead.Read())
                                        {
                                             if (myRead["pw"].ToString() == test[2])
                                             {   //성공
                                                  login_chk = "0";
                                                  myRead.Close();

                                                  if (OnReceived != null)
                                                  {
                                                       OnReceived(test[0] + ":" + test[1] + "님이 접속하셨습니다.");
                                                       player = test[1].ToString();
                                                  }
                                             }
                                             else
                                             {   //비밀번호 불일치
                                                  login_chk = "2";
                                             }
                                        }
                                   }
                                   else
                                   {   //일치 계정 없음
                                        login_chk = "1";
                                   }
                              }
                              else
                              {
                                   login_chk = "3";
                              }

                         }
                         /////////////////////////
                         /// Client - ID_check버튼을 눌렀을때
                         /// test[0] = "idchk"
                         /// test[1] = "id"
                         /////////////////////////
                         else if (test[0].ToString() == "idchk")
                         {
                              if (test[1].ToString() != "" && test[1].Length > 4)    //나중에 영어 / 숫자만 들어갈수있게
                              {
                                   string sql = "select id from user where id= '" + test[1] + "'";
                                   var Comm = new MySqlCommand(sql, MConn);
                                   var myRead = Comm.ExecuteReader();
                                   if (myRead.HasRows)
                                   {
                                        id_chk = "1";    //아이디 중복
                                   }
                                   else
                                   {
                                        id_chk = "0";     //아이디 가능
                                   }
                              }
                              else
                              {
                                   id_chk = "1";    //아이디 5자리 이하 입력
                              }
                         }

                         /////////////////////////
                         /// Client - 회원가입버튼을 눌렀을때
                         /// test[0] = "join"
                         /// test[1] = "id"
                         /// test[2] = "pw"
                         /// test[3] = "pw_q"
                         /// test[4] = "pw_a"
                         /////////////////////////
                         else if (test[0].ToString() == "join")
                         {
                              if (test[1].ToString() != "" && test[2].ToString() != "" && test[3].ToString() != "" && test[4].ToString() != "")  // id, pw, pw_q, pw_a 공백 아닐 경우
                              {
                                   string sql = "insert into user(id, pw, pw_q, pw_a) values('" + test[1].ToString() + "', '" + test[2].ToString() + "', '" + test[3].ToString() + "' , '" + test[4].ToString() + "')";
                                   var Comm = new MySqlCommand(sql, MConn);
                                   int i = Comm.ExecuteNonQuery();
                                   if (i == 1)
                                   {   //회원가입 완료
                                        join_chk = "0";
                                   }
                              }

                              else
                              {   //회원가입 실패
                                   join_chk = "1";
                              }
                         }


                         /////////////////////////
                         /// Client - 리그생성 버튼을 눌렀을때
                         /// test[0] = "create"
                         /// test[1] = "league_name"
                         /// test[2] = "s_time"
                         /// test[3] = "e_time"
                         /// test[4] = "s_money"
                         /////////////////////////
                         else if (test[0].ToString() == "create")
                         {
                              if (test[1].ToString() != "" && test[2].ToString() != "" && test[3].ToString() != "" && test[4].ToString() != "")  // id, s_time, e_time, s_money 공백 아닐 경우
                              {                                
                                   string sql = "insert into battle.league(league_name, state, s_time, e_time, s_money) values('" + test[1].ToString() + "', '대기중', '" + test[2].ToString() + "', '" + test[3].ToString() + "' , '" + test[4].ToString() + "') ; insert into battle.portfolio(league_code, id, left_money) values((SELECT MAX(league_code) from battle.league), '" + test[1].ToString() + "', '" + test[4].ToString() + "');";
                                   var Comm = new MySqlCommand(sql, MConn);                               
                                   int i = Comm.ExecuteNonQuery();
                                   
                                   league_chk = "0";
                                   OnReceived(player + " making league.");
                              }

                              else
                              {   //리그생성 실패
                                   league_chk = "1";
                              }

                         }

                         /////////////////////////
                         /// Client - 리그목록 버튼을 눌렀을때
                         /// test[0] = "stock"
                         /////////////////////////
                         else if (test[0].ToString() == "stock")
                         {
                              string strSelect = "SELECT * FROM stock";
                              MySqlCommand cmd = new MySqlCommand(strSelect, MConn);
                              MySqlDataReader rdr = cmd.ExecuteReader();
                              while (rdr.Read())
                              {
                                   //직렬화                
                                   string serialize_Str = rdr["Stock_code"].ToString() + ":" + rdr["Stock_name"].ToString() + ":" + rdr["Now_Price"].ToString() + ":" + rdr["Volume"].ToString() + ":" + rdr["Highest_Price"].ToString() + ":" + rdr["Lowest_Price"].ToString() + ":$";
                                   qury += serialize_Str;

                              }                           
                              rdr.Close();

                              sbuffer = Encoding.Unicode.GetBytes(qury);
                              stream.Write(sbuffer, 0, sbuffer.Length);
                              stream.Flush();
                              OnReceived("Stock information given to user.");
                              qury = string.Empty;
                         }

                         /////////////////////////
                         /// Client - 리그목록 버튼을 눌렀을때
                         /// test[0] = "view1"
                         /// test[1] = "id"
                         /////////////////////////
                         else if (test[0].ToString() == "view1")
                         {
                              al = new ArrayList();
                              string sql = "SELECT league.league_name, portfolio.left_money, league.state, league.league_code FROM battle.league, battle.portfolio WHERE (battle.league.league_code = battle.portfolio.league_code) AND (battle.portfolio.id = '" + test[1].ToString() + "')";
                              MySqlCommand cmd = new MySqlCommand(sql, MConn);
                              MySqlDataReader rdr = cmd.ExecuteReader();

                             
                              while (rdr.Read())
                              {
                                   //직렬화                
                                   string serialize_Str = rdr["league_name"].ToString() + ":" + rdr["left_money"].ToString() + ":" + rdr["state"].ToString() + ":" + rdr["league_code"].ToString() + ":$";
                                   qury += serialize_Str;                                 
                              }
                           
                              
                              rdr.Close();
                              sbuffer = Encoding.Unicode.GetBytes(qury);
                              stream.Write(sbuffer, 0, sbuffer.Length);
                              stream.Flush();
                              OnReceived(test[0]);     
                              qury = string.Empty;
                         }

                         /////////////////////////
                         /// Client - 리그목록 버튼을 눌렀을때
                         /// test[0] = "view2"
                         /////////////////////////
                         else if (test[0].ToString() == "view2")
                         {
                              al = new ArrayList();
                              string sql = "SELECT * FROM battle.league WHERE (battle.league.state='대기중') OR (battle.league.state='게임중') ";
                              MySqlCommand cmd = new MySqlCommand(sql, MConn);
                              MySqlDataReader rdr = cmd.ExecuteReader();


                              while (rdr.Read())
                              {
                                   //직렬화                
                                   string serialize_Str = rdr["state"].ToString() + ":" + rdr["league_name"].ToString() + ":" + rdr["s_time"].ToString() + ":" + rdr["e_time"].ToString() + ":" + rdr["s_money"].ToString() + ":" + rdr["league_code"].ToString() + ":$";
                                   qury += serialize_Str;
                              }
                        
                              rdr.Close();
                              sbuffer = Encoding.Unicode.GetBytes(qury);
                              stream.Write(sbuffer, 0, sbuffer.Length);
                              stream.Flush();
                              OnReceived(test[0]);
                              qury = string.Empty;
                         }

                         /////////////////////////
                         /// Client - 다른 인원이 방에 참가했을 때
                         /// test[0] = "join_l"
                         /// test[1] = "league_code"
                         /// test[2] = "id"
                         /////////////////////////
                         else if (test[0].ToString() == "join_l")
                         {
                              string sql = "insert into battle.portfolio(league_code, id, left_money) values('" + test[1].ToString() + "', '" + test[2].ToString() + "', (select s_money FROM battle.league WHERE league_code='" + test[1].ToString() + "'))"; 
                              var Comm = new MySqlCommand(sql, MConn);
                              int i = Comm.ExecuteNonQuery();

                              join_l_chk = "0";
                              OnReceived(test[0]);
                         }

                         /////////////////////////
                         /// Client - 주식 구매를 할 때
                         /// test[0] = "buy"
                         /// test[1] = "league_code"
                         /// test[2] = "id"
                         /// test[3] = "stock_code"
                         /// test[4] = "amount"
                         /// test[5] = "left_money"
                         /// test[6] = "update" or "insert"
                         /////////////////////////
                         else if (test[0].ToString() == "buy")
                         {
                             if(test[6].ToString() == "update")
                              {
                                   string sql = "update battle.play_log set amount='" + test[4].ToString() + "' where No = (select * from (select No from battle.play_log where (league_code='" + test[1].ToString() + "') and (id='" + test[2].ToString() + "') and (stock_code='" + test[3].ToString() + "')) as b);              update battle.portfolio set left_money= '" + test[5].ToString() + "' where No = (select * from (select No from battle.portfolio where (league_code='" + test[1].ToString() + "') and (id='" + test[2].ToString() + "')) as b);";
                                   var Comm = new MySqlCommand(sql, MConn);
                                   int i = Comm.ExecuteNonQuery();

                                   buy_chk = "0";
                                   OnReceived(test[0]);
                              }

                             else if(test[6].ToString() == "insert")
                              {
                                   string sql = "insert into battle.play_log (league_code, id, stock_code) values ('" + test[1].ToString() + "','" + test[2].ToString() + "','" + test[3].ToString() + "');             update battle.portfolio set left_money= '" + test[5].ToString() + "' where No = (select * from (select No from battle.portfolio where (league_code='" + test[1].ToString() + "') and (id='" + test[2].ToString() + "')) as b);";
                                   var Comm = new MySqlCommand(sql, MConn);
                                   int i = Comm.ExecuteNonQuery();

                                   buy_chk = "0";
                                   OnReceived(test[0]);
                              }
                         }

                         /////////////////////////
                         /// Client - 주식 판매를 할 때
                         /// test[0] = "sell"
                         /// test[1] = "league_code"
                         /// test[2] = "id"
                         /// test[3] = "stock_code"
                         /// test[4] = "amount"
                         /// test[5] = "left_money"
                         /// test[6] = "update" or "delete"
                         /////////////////////////
                         else if (test[0].ToString() == "sell")
                         {
                              if (test[6].ToString() == "update")
                              {
                                   string sql = "update battle.play_log set amount='" + test[4].ToString() + "' where No = (select * from (select No from battle.play_log where (league_code='" + test[1].ToString() + "') and (id='" + test[2].ToString() + "') and (stock_code='" + test[3].ToString() + "')) as b);              update battle.portfolio set left_money= '" + test[5].ToString() + "' where No = (select * from (select No from battle.portfolio where (league_code='" + test[1].ToString() + "') and (id='" + test[2].ToString() + "')) as b);";
                                   var Comm = new MySqlCommand(sql, MConn);
                                   int i = Comm.ExecuteNonQuery();

                                   sell_chk = "0";
                                   OnReceived(test[0]);
                              }

                              else if (test[6].ToString() == "delete")
                              {
                                   string sql = "delete from battle.play_log where No = (select * from (select No from battle.play_log where (league_code='" + test[1].ToString() + "') and (id='" + test[2].ToString() + "') and (stock_code='" + test[3].ToString() + "')) as b);             update battle.portfolio set left_money= '" + test[5].ToString() + "' where No = (select * from (select No from battle.portfolio where (league_code='" + test[1].ToString() + "') and (id='" + test[2].ToString() + "')) as b);";
                                   var Comm = new MySqlCommand(sql, MConn);
                                   int i = Comm.ExecuteNonQuery();

                                   sell_chk = "0";
                                   OnReceived(test[0]);
                              }
                         }



                         if (test[0] == "login")    //로그인일때
                         {
                              msg = login_chk + ":" + return_name.ToString() + ":";
                              sbuffer = Encoding.Unicode.GetBytes(msg);
                              stream.Write(sbuffer, 0, sbuffer.Length);
                              stream.Flush();
                         }
                         else if (test[0] == "idchk")    //ID Check일때
                         {
                              msg = id_chk + ":";
                              sbuffer = Encoding.Unicode.GetBytes(msg);
                              stream.Write(sbuffer, 0, sbuffer.Length);
                              stream.Flush();
                         }
                         else if (test[0] == "join")
                         {
                              msg = join_chk + ":";
                              sbuffer = Encoding.Unicode.GetBytes(msg);
                              stream.Write(sbuffer, 0, sbuffer.Length);
                              stream.Flush();
                         }

                         else if (test[0] == "create")    //league 생성일때
                         {
                              msg = league_chk + ":";
                              sbuffer = Encoding.Unicode.GetBytes(msg);
                              stream.Write(sbuffer, 0, sbuffer.Length);
                              stream.Flush();
                         }

                         else if (test[0] == "join_l")   
                         {
                              msg = join_l_chk + ":";
                              sbuffer = Encoding.Unicode.GetBytes(msg);
                              stream.Write(sbuffer, 0, sbuffer.Length);
                              stream.Flush();
                         }

                         else if (test[0] == "buy")
                         {
                              msg = buy_chk + ":";
                              sbuffer = Encoding.Unicode.GetBytes(msg);
                              stream.Write(sbuffer, 0, sbuffer.Length);
                              stream.Flush();
                         }

                         else if (test[0] == "sell")
                         {
                              msg = sell_chk + ":";
                              sbuffer = Encoding.Unicode.GetBytes(msg);
                              stream.Write(sbuffer, 0, sbuffer.Length);
                              stream.Flush();
                         }


                         MConn.Close();
                    }
               }
               catch (SocketException se)
               {
                    Trace.WriteLine(string.Format("doChat - SocketException : {0}", se.Message));

                    if (clientSocket != null)
                    {
                         clientSocket.Close();
                         stream.Close();
                    }

                    if (OnCalculated != null)
                         OnCalculated();
               }
               catch (Exception ex)
               {
                    Trace.WriteLine(string.Format("doChat - Exception : {0}", ex.Message));

                    if (clientSocket != null)
                    {
                         clientSocket.Close();
                         stream.Close();
                    }

                    if (OnCalculated != null)
                         OnCalculated();
               }
          }
     }
}
