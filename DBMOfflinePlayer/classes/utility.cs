using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System.IO;
using System.Threading;
using WMPLib;
using Newtonsoft;
using System.Net.Http;
using System.Data.SQLite;
using Newtonsoft.Json;
using System.Net;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using DBMOfflinePlayer.classes;

namespace DBMOfflinePlayer
{
    class utility
    {
        public static WindowsMediaPlayer player = new WindowsMediaPlayer();
        public static Stopwatch time = new Stopwatch();
        public static void startstopwatch()
        {
            time.Start();
        }
        public static void pausevideo()
        {
            if(thread1.ThreadState == System.Threading.ThreadState.Running && thread2.ThreadState == System.Threading.ThreadState.Running)
            {
                thread1.Suspend();
                thread2.Suspend();
            }
            else
            {
                thread2.Suspend();
            }
            
        }
        public static void startpausedvideo(ref ImageBox imgbox)
        {
            if(thread1.ThreadState == System.Threading.ThreadState.Suspended && thread2.ThreadState == System.Threading.ThreadState.Suspended)
            {
                thread1.Resume();
                thread2.Resume();
            }
            else
            {
                thread2.Resume();
            }


            //dest = imgbox;
            //thread1 = new Thread(utility.playaudiofile);
            //thread2 = new Thread(utility.ReadandDrawFromFile);
            //thread1.Start();
            //thread2.Start();

        }
        public static void startover(ref ImageBox imgbox)
        {
            utility.ReadandDrawFromFileCall(ref imgbox,ref  utility.currentTime,utility.myform);
        }
        public static string audiofile = @"C:\Users\Dc\Documents\Sound recordings\komal.m4a";
        public static void playaudiofile()
        {
            player.URL = audiofile;
            player.controls.play();
            thread1.Abort();
        }
        public static void ImageBoxMouseMove(ref ImageBox imageBox1, ref object sender, ref MouseEventArgs e, ref TextBox textBox1, ref ImageBox dest)
        {
            int offsetX = (int)(e.Location.X / imageBox1.ZoomScale);
            int offsetY = (int)(e.Location.Y / imageBox1.ZoomScale);
            int horizontalScrollBarValue = imageBox1.HorizontalScrollBar.Visible ? (int)imageBox1.HorizontalScrollBar.Value : 0;
            int verticalScrollBarValue = imageBox1.VerticalScrollBar.Visible ? (int)imageBox1.VerticalScrollBar.Value : 0;
            textBox1.Text = Convert.ToString(offsetX + horizontalScrollBarValue) + "." + Convert.ToString(offsetY + verticalScrollBarValue);
            drawAndWriteOnImageBox(ref dest, ref offsetX, ref offsetY);

        }
        public static Image<Rgb, Byte> aa = new Image<Rgb, Byte>(1024, 370);
        public static Point previous1 = new Point(0, 0);
        public static void drawAndWriteOnImageBox(ref ImageBox dest, ref int x, ref int y)
        {
            Point a = new Point(x, y);
            if (previous1.X == 0 && previous1.Y == 0)
            {
                previous1 = a;
            }

            LineSegment2D line = new LineSegment2D(previous1, a);
            aa.Draw(line, new Rgb(Color.White), 1);
            previous1 = a;

            dest.Image = aa;

            WriteToFile(ref x, ref y);
        }
        public class mydata
        {
            public int x;
            public int y;
            public double time;
        }
        public class authdata
        {
            [JsonProperty("access_token")]
            public string access_token { get; set; }
            [JsonProperty("token_type")]
            public string token_type { get; set; }
            [JsonProperty("expires_in")]
            public double expires_in { get; set; }
            [JsonProperty("userName")]
            public string userName { get; set; }
            [JsonProperty(".issued")]
            public DateTime issued { get; set; }
            [JsonProperty(".expires")]
            public DateTime expires { get; set; }
        }
        public static List<mydata> mydatalist = new List<utility.mydata>();
        public static void savetofile()
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(mydatalist.ToArray());
            System.IO.File.WriteAllText(textfileName, json);
        }
        public static Point previous = new Point(0, 0);
        public static void drawOnImageBox(ref ImageBox dest, ref int x, ref int y)
        {

            Point a = new Point(x, y);
            if (previous.X == 0 && previous.Y == 0)
            {
                previous = a;
            }

            LineSegment2D line = new LineSegment2D(previous, a);
            aa.Draw(line, new Rgb(Color.WhiteSmoke), 1);
            previous = a;
            dest.Image = aa;
        }
        public static Label currentTime = new Label();
        public static ImageBox dest = new ImageBox();
        public static Thread thread1 = new Thread(utility.playaudiofile);
        public static Thread thread2 = new Thread(utility.ReadandDrawFromFile);
        public static forms.offlineplayer myform;
        public static void ReadandDrawFromFileCall(ref ImageBox imgbox, ref Label cTime, forms.offlineplayer form1)
        {
            myform = form1;
            dest = imgbox;
            currentTime = cTime;
            utility.previous = new Point(0, 0);
            utility.previous1 = new Point(0, 0);
            if (thread1.ThreadState == System.Threading.ThreadState.Aborted && thread2.ThreadState == System.Threading.ThreadState.Aborted)
            {
                thread1 = new Thread(utility.playaudiofile);

                thread2 = new Thread(utility.ReadandDrawFromFile);
                thread1.Start();
                thread2.Start();
            }
            else if (thread1.ThreadState == System.Threading.ThreadState.Aborted)
            {
                thread1 = new Thread(utility.playaudiofile);
                thread1.Start();
                thread2.Start();
            }
            else if (thread2.ThreadState == System.Threading.ThreadState.Aborted)
            {
                thread2 = new Thread(utility.ReadandDrawFromFile);
                thread1.Start();
                thread2.Start();
            }
            else
            {

                thread1 = new Thread(utility.playaudiofile);

                thread2 = new Thread(utility.ReadandDrawFromFile);
                thread1.Start();
                thread2.Start();

            }

        }
        public static Stopwatch readtime = new Stopwatch();
        //public static string filepath;
        public static string textfileName = @"C:\Users\Dc\Desktop\komal.json";
        public static List<mydata> mylocaldatalist = new List<mydata>();
        public static void ReadandDrawFromFile()
        {
            aa = new Image<Rgb, Byte>(1024, 370);
            //aa = new Image<Rgb, Byte>(514, 162);
            dest.Image = aa;
            string json;
            
            using (StreamReader r = new StreamReader(textfileName))
            {
                json = r.ReadToEnd();
                mylocaldatalist = Newtonsoft.Json.JsonConvert.DeserializeObject<List<mydata>>(json);
            }
            double counter = mylocaldatalist[mylocaldatalist.Count() - 1].time;
            int x, y;
            readtime.Reset();
            readtime.Start();
            while (readtime.ElapsedMilliseconds <= counter)
            {
                double times = readtime.ElapsedMilliseconds;
                double seconds = Math.Ceiling(times / 1000);
                utility.setCurrentTime(ref currentTime, ref seconds);
                if (mylocaldatalist.Any(t => t.time == times))
                {
                    x = mylocaldatalist.Find(t1 => t1.time == times).x;
                    y = mylocaldatalist.Find(t2 => t2.time == times).y;
                    drawOnImageBox(ref dest, ref x, ref y);
                }
            }

            Console.WriteLine("Finished");
            utility.previous = new Point(0, 0);
            utility.previous1 = new Point(0, 0);
            thread2.Abort();
        }
        public static double trackbartime;
        public static TrackBar trackbar = new TrackBar();
        public static Thread videothread = new Thread(utility.ReadandDrawFromFileonSpecificTime);
        public static void ReadandDrawFromFileOnSpecificTimeCall(ref ImageBox imgbox, ref Label cTime, forms.offlineplayer form1, double time, ref TrackBar tr)
        {
            
            myform = form1;
            dest = imgbox;
            currentTime = cTime;
            trackbartime = time;
            trackbar = tr;
            utility.previous = new Point(0, 0);
            utility.previous1 = new Point(0, 0);
            if (thread1.ThreadState == System.Threading.ThreadState.Aborted && thread2.ThreadState == System.Threading.ThreadState.Aborted)
            {
               
            }
            else if (thread1.ThreadState == System.Threading.ThreadState.Aborted)
            {
              
                thread2.Abort();
            }
            else if (thread2.ThreadState == System.Threading.ThreadState.Aborted)
            {
               
                thread2.Abort();
            }
            else
            {

                thread1.Abort();
                thread2.Abort();

            }
            if(utility.videothread.ThreadState == System.Threading.ThreadState.Running || utility.videothread.ThreadState != System.Threading.ThreadState.Aborted)
            {
                utility.videothread.Abort();
                utility.videothread = new Thread(utility.ReadandDrawFromFileonSpecificTime);
            }
            utility.videothread.Start();
        }
        public static void ReadandDrawFromFileonSpecificTime()
        {
            double time = utility.trackbartime;
            aa = new Image<Rgb, Byte>(1024, 370);
            //aa = new Image<Rgb, Byte>(514, 162);
            dest.Image = aa;
            
            double counter = mylocaldatalist[mylocaldatalist.Count() - 1].time;
            int x, y;
            double timeinmiliseconds = time * 1000;
            var offsetTimeStamp = TimeSpan.FromMilliseconds(timeinmiliseconds);
            var watch = new StopWatchWithOffset(offsetTimeStamp);
            watch.Start();
            while (watch.ElapsedTimeSpan.TotalMilliseconds <= counter)
            {
                double times = watch.ElapsedTimeSpan.TotalMilliseconds;
                double seconds = Math.Ceiling(times / 1000);
                utility.setCurrentTime(ref currentTime, ref seconds);
                if (mylocaldatalist.Any(t => t.time == Math.Ceiling(times)))
                {
                    x = mylocaldatalist.Find(t1 => t1.time == Math.Ceiling(times)).x;
                    y = mylocaldatalist.Find(t2 => t2.time == Math.Ceiling(times)).y;
                    drawOnImageBox(ref dest, ref x, ref y);
                }
            }

            Console.WriteLine("Finished");
            utility.previous = new Point(0, 0);
            utility.previous1 = new Point(0, 0);
            
        }
        public static void setCurrentTime(ref Label label,ref double time)
        {
            SetText(utility.myform, label, time.ToString());
        
        }
        public static double getTotalVideoDuration()
        {
            if(utility.getTotalVideoTime() >= utility.GetSoundLength())
            {
                return Math.Ceiling(utility.getTotalVideoTime());
            }
            return Math.Ceiling(utility.GetSoundLength());
        }
        delegate void SetTextCallback(Form f, Label ctrl, string text);
        /// <summary>
        /// Set text property of various controls
        /// </summary>
        /// <param name="form">The calling form</param>
        /// <param name="ctrl"></param>
        /// <param name="text"></param>
        public static void SetText(Form form, Label ctrl, string text)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (ctrl.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                form.Invoke(d, new object[] { form, ctrl, text });
            }
            else
            {
                ctrl.Text = text;
            }
        }
        public static double getTotalVideoTime()
        {
           
            string json;
            List<mydata> mylocaldatalist = new List<mydata>();
            using (StreamReader r = new StreamReader(textfileName))
            {
                json = r.ReadToEnd();
                mylocaldatalist = Newtonsoft.Json.JsonConvert.DeserializeObject<List<mydata>>(json);
            }
            double counter = mylocaldatalist[mylocaldatalist.Count() - 1].time;
            counter = counter / 1000;
            
            return counter;
        }
        [DllImport("winmm.dll")]
        private static extern uint mciSendString(
            string command,
            StringBuilder returnValue,
            int returnLength,
            IntPtr winHandle);

        public static double GetSoundLength()
        {
            string fileName = utility.audiofile;
            StringBuilder lengthBuf = new StringBuilder(32);

            mciSendString(string.Format("open \"{0}\" type waveaudio alias wave", fileName), null, 0, IntPtr.Zero);
            mciSendString("status wave length", lengthBuf, lengthBuf.Capacity, IntPtr.Zero);
            mciSendString("close wave", null, 0, IntPtr.Zero);

            double length = 0;
            double.TryParse(lengthBuf.ToString(), out length);

            return length;
        }
        public static void clearimagebox(ref ImageBox dest)
        {

            aa = new Image<Rgb, Byte>(514, 162);
            dest.Image = aa;
            thread1.Abort();
            thread2.Abort();
            previous = new Point(0, 0);
            previous1 = new Point(0, 0);
        }
        public static void WriteToFile(ref int myx, ref int myy)
        {

            try
            {
                utility.mydatalist.Add(new mydata()
                {
                    x = myx,
                    y = myy,
                    time = Convert.ToInt32(time.ElapsedMilliseconds)
                });

            }
            catch
            {

            }
        }
        public static string authstr;
        public static string dbfile = "";
        public static authdata userauthdata = new authdata();
        public static bool authenticated = false;
        public static async void authenticate(string username, string password)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64354");
            var request = new HttpRequestMessage(HttpMethod.Post, "/Token");

            var keyValues = new List<KeyValuePair<string, string>>();
            keyValues.Add(new KeyValuePair<string, string>("username", username));
            keyValues.Add(new KeyValuePair<string, string>("password", password));
            keyValues.Add(new KeyValuePair<string, string>("grant_type", "password"));

            request.Content = new FormUrlEncodedContent(keyValues);
            var response = (await client.PostAsync("http://localhost:64354/token", request.Content));

            //utility.authstr = (await client.SendAsync(request));

            if (response.StatusCode.ToString() == "OK")
            {
                var strResp = await response.Content.ReadAsStringAsync();
                parseTokenString(ref strResp);
                SaveTokenInDatabase();
                utility.authenticated = true;
                MessageBox.Show("Authenticated Successfully!");
                return;
            }
            else if (response.StatusCode.ToString() == "BadRequest")
            {
                utility.authenticated = false;
                MessageBox.Show("Invalid Username or Password");
            }
        }
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static void parseTokenString(ref string strResp)
        {
            utility.userauthdata = JsonConvert.DeserializeObject<authdata>(strResp);
        }
        public static async void getRefreshToken(string prevtoken)
        {
      
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64354");
            var request = new HttpRequestMessage(HttpMethod.Post, "/Token");

            var keyValues = new List<KeyValuePair<string, string>>();
            keyValues.Add(new KeyValuePair<string, string>("refresh_token", prevtoken));
            
            keyValues.Add(new KeyValuePair<string, string>("grant_type", "refresh_token"));

            request.Content = new FormUrlEncodedContent(keyValues);
            var response = (await client.PostAsync("http://localhost:64354/token", request.Content));
            //utility.authstr = (await client.SendAsync(request));
            var strResp = await response.Content.ReadAsStringAsync();
        }
        public static void SaveTokenInDatabase()
        {
            

            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=" + utility.dbfile + ";Version=3;");
            m_dbConnection.Open();
            
            var value =  utility.ConvertStringToHex(utility.userauthdata.access_token, System.Text.Encoding.Unicode) + "," + utility.userauthdata.token_type + "," + utility.userauthdata.expires_in + "," + utility.userauthdata.userName+"," + utility.userauthdata.issued + "," + utility.userauthdata.expires;
            string sql = "INSERT INTO AuthData(access_token ,token_type , expires_in ,userName , IssueDate , ExpiryDate) VALUES('"+ utility.ConvertStringToHex(utility.userauthdata.access_token, System.Text.Encoding.Unicode) +"','"+ utility.userauthdata.token_type +"','"+ utility.userauthdata.expires_in + "','"+ utility.userauthdata.userName +"','"+ utility.userauthdata.issued +"','"+ utility.userauthdata.expires +"');";

            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            m_dbConnection.Close();
        }
        public static string ConvertStringToHex(String input, System.Text.Encoding encoding)
        {
            Byte[] stringBytes = encoding.GetBytes(input);
            StringBuilder sbBytes = new StringBuilder(stringBytes.Length * 2);
            foreach (byte b in stringBytes)
            {
                sbBytes.AppendFormat("{0:X2}", b);
            }
            return sbBytes.ToString();
        }
        
        public static string ConvertHexToString(String hexInput, System.Text.Encoding encoding)
        {
            int numberChars = hexInput.Length;
            byte[] bytes = new byte[numberChars / 2];
            for (int i = 0; i < numberChars; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hexInput.Substring(i, 2), 16);
            }
            return encoding.GetString(bytes);
        }
        public static void createdatabase()
        {
            SQLiteConnection.CreateFile(utility.dbfile);

            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source="+dbfile+";Version=3;");
            m_dbConnection.Open();

            string sql = "create table AuthData(access_token varchar(500),token_type varchar(20), expires_in double,userName varchar(50), IssueDate DateTime, ExpiryDate DateTime)";

            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            sql = "create table WebLectures (name varchar(50), DownloadLink varchar(100))";

            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            sql = "create table DownloadedLectures (name varchar(50), DirectoryPath varchar(100))";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Close();
        }
    }
}
