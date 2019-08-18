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
            thread1.Suspend();
            thread2.Suspend();
        }
        public static void startpausedvideo(ref ImageBox imgbox)
        {
            dest = imgbox;
            thread1 = new Thread(utility.playaudiofile);
            thread2 = new Thread(utility.ReadandDrawFromFile);
            thread1.Start();
            thread2.Start();
        }
        public static void startover(ref ImageBox imgbox)
        {
            utility.ReadandDrawFromFileCall(ref imgbox);
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
        public static Image<Rgb, Byte> aa = new Image<Rgb, Byte>(960, 317);
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
            public int time;
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
        public static ImageBox dest = new ImageBox();
        public static Thread thread1 = new Thread(utility.playaudiofile);
        public static Thread thread2 = new Thread(utility.ReadandDrawFromFile);
        public static void ReadandDrawFromFileCall(ref ImageBox imgbox)
        {
            dest = imgbox;
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
        public static void ReadandDrawFromFile()
        {
            aa = new Image<Rgb, Byte>(960, 317);
            //aa = new Image<Rgb, Byte>(514, 162);
            dest.Image = aa;
            string json;
            List<mydata> mylocaldatalist = new List<mydata>();
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
        public static HttpResponseMessage authstr;
        public static string dbfile = "";
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
            utility.authstr = (await client.SendAsync(request));
            var authstring = "error";
            if (utility.authstr != null)
            {
                authstring = utility.authstr.ToString();
            }
            Console.WriteLine(authstring);
            MessageBox.Show(authstring.ToString());
        }
        public static void createdatabase()
        {
            SQLiteConnection.CreateFile(utility.dbfile);

            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source="+dbfile+";Version=3;");
            m_dbConnection.Open();

            string sql = "create table Auth (token varchar(100), ExpiryDate DateTime, IssueDate DateTime)";

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
