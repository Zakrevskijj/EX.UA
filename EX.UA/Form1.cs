using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Net;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Web;
using System.Text.RegularExpressions;
using System.Net.NetworkInformation;

namespace EX.UA
{
    public partial class MainFrm : Form
    {
        private int g;
        static StreamWriter _sw = new StreamWriter(new FileInfo("Log.txt").FullName, true);
        private List<Film> films = new List<Film>();
        private static List <Thread>_thr=new List<Thread>();

        public MainFrm()
        {
            InitializeComponent();
            notifyIcon1.Visible = false;
        }

        private bool Check(int i)//возвращет fаlse если ошибка
        {
            if (InternetAccessCheck())
            {
                try
                {
                    string resp;
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.ex.ua/search?s=" + HttpUtility.UrlEncode(films[i].Name));
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                    {
                        resp = sr.ReadToEnd();
                    }
                    //Парсим с полученной страницы результаты,тексты,картинки и ссылки
                    int y = resp.IndexOf("Поиск \"");
                    resp = resp.Substring(y, resp.IndexOf("</table>", y) - y);
                    films[i].Results = Result(resp, i, 1);
                    films[i].Links = Result(resp, i, 2);
                    films[i].Text = Result(resp, i, 3);
                    films[i].images = Result(resp, i, 4);
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }

        private void Find(object k)
        {
            lock (new object())
            {
                int i = (int)k;
                bool suc;
                int interval = films[i].Interval;
                while (true)
                {
                    suc = Check(i);
                    if (suc)
                        Globals.Succeeded++;
                    else
                    {
                        Globals.Errors++;
                        Log("Error in the checking of the film:" + films[i].Name, true);
                    }
                    Thread.Sleep(TimeSpan.FromHours(films[i].Interval));
                }
            }
        }

        private List<string> Result(string resp, int i, int l)
        {
            List<string> results = new List<string>();
            int k = 0;
            string str = "", str1 = "";
            switch (l)
            {
                case 1:
                    do
                    {
                        k = resp.IndexOf("alt='", k) + 5;
                        if (k == 4) break;
                        str = "";
                        while (resp[k] != '\'')
                        {
                            str += resp[k++];
                        }
                        results.Add(str);
                    }
                    while (k != 4);
                    break;
                case 2:

                    do
                    {
                        k = resp.IndexOf("<a href='", k) + 9;
                        str = "";
                        while (resp[k] != '\'')
                        {
                            str += resp[k++];
                        }
                        results.Add("ex.ua" + str);
                        k = resp.IndexOf("<tr><td>", k) + 8;
                    } while (k != 7);
                    break;
                case 3:
                    do
                    {
                        k = resp.IndexOf("<span class=modify_time>, ", k) + 26;
                        str = "";
                        while (resp[k] != '<')
                        {
                            str += resp[k++];
                        }
                        str1 = resp.Substring(resp.IndexOf("</small>", k - 1) + 8, resp.IndexOf("...", k) - resp.IndexOf("</small>", k - 1) - 8);
                        str1 = str1.Replace("<b>", "").Replace("</b>", "").Replace("<p>", "").Replace("</p>", "").Replace("<a>", "").Replace("</a>", "").Replace("<br>", Environment.NewLine);
                        str += Environment.NewLine + str1;
                        results.Add(Regex.Replace(str, @"</?.+?>", ""));
                        k = resp.IndexOf("<tr><td>", k) + 8;
                    } while (k != 7);

                    break;
                case 4:
                    do
                    {
                        k = resp.IndexOf("img src='", k) + 9;
                        if (k == 8) break;
                        str = "";
                        while (resp[k] != '\'')
                        {
                            str += resp[k++];
                        }
                        results.Add(str);
                    }
                    while (k != 8);
                    break;
            }
            return results;
        }

        #region FormEvents

        private void OKButtn_Click(object sender, EventArgs e)
        {
            if (FilmTxtbox.Text != "")
            {
                int interval = 5;
                if (IntervalBox.Text != "")
                    interval = Convert.ToInt32(IntervalBox.Text);
                films.Add(new Film(FilmTxtbox.Text, interval));
                FilmsTable.Rows.Add(FilmTxtbox.Text, interval);
                FilmTxtbox.Clear();
                IntervalBox.ResetText();
                _thr.Add(new Thread(Find));
                _thr[FilmsTable.Rows.Count-1].Start(FilmsTable.Rows.Count-1);
            }
            else MessageBox.Show("Enter some value in Name");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ActivateBtn.Text == "Turn off")
            {
                ActivateBtn.Text = "Activate";
                Stop();
            }
            else
            {
                if (films.Count > 0)
                {
                    ActivateBtn.Text = "Turn off";
                    Start();
                }
                else MessageBox.Show("Add some film(s)!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _sw.Close();
            _sw = new StreamWriter(new FileInfo("Log.txt").FullName, false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _sw.Close();
            Process.Start("Log.txt");
            _sw = new StreamWriter(new FileInfo("Log.txt").FullName, true);
        }

        private void FilmsTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ResultsTable.Rows.Clear();
                g = e.RowIndex;//индекс строки
                if (films[g].Results.Count == 0)
                {
                    MessageBox.Show("No Results.");
                    ClearResults();
                    return;
                }
                foreach (string str in films[g].Results)
                    ResultsTable.Rows.Add(str);
                string image = "", text = "";
                if (films[g].images == null)
                    image = "http://www.iconsearch.ru/uploads/icons/humano2/128x128/gtk-no.png";
                else
                    image = films[g].images[0];
                if (films[g].Text == null || films[g].Text[e.RowIndex] == "notext")
                    text = "No description";
                else
                    text = films[g].Text[e.RowIndex];

                PreviewAdd(films[g].Links[0], text, films[g].Results[0], image);
            }
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            films.RemoveAt(e.RowIndex);
            Stop();
            Start();
            ClearResults();
            if (e.RowIndex < FilmsTable.Rows.Count)
                g = e.RowIndex;
            else
            {
                g = e.RowIndex - 1;
                if (FilmsTable.Rows.Count != 0)
                {
                    if (films[g].Results.Count == 0)
                    {
                        MessageBox.Show("No results for second sample in the list.");
                        return;
                    }
                }
                else return;
            }
            foreach (string str in films[g].Results)
                ResultsTable.Rows.Add(str);
            PreviewAdd(films[g].Links[0], films[g].Text[0], films[g].Results[0], films[g].images[0]);
        }

        private void GUI_Tick(object sender, EventArgs e)
        {
            SucBox.Text = Globals.Succeeded.ToString();
            ErrBox.Text = Globals.Errors.ToString();
            if (AliveThreads() == 0)
                ActivateBtn.Text = "Activate";
            else ActivateBtn.Text = "Turn off";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stop();
            Log("Application Closed at:", true);
            _sw.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Log("Application Started at:", true);
            InternetAccessCheck();
        }

        #endregion

        #region MyFuncs(PreviewAdd,Log,Start,Stop,InternetAccessCheck,ClearResults)
        private bool PreviewAdd(string link, string text, string result, string image)
        {
            if (result != null)
                if (link != null)
                {
                    linkLabel1.Text = link;
                    if (text != null)
                        richTextBox1.Text = text;
                    label1.Text = result;
                    if (image != null)
                        pictureBox1.Image = new System.Drawing.Bitmap(new System.IO.MemoryStream(new System.Net.WebClient().DownloadData(image))); ;
                    pictureBox1.Visible = true;
                    richTextBox1.Visible = true;
                }
                else return false;
            else return false;
            return true;

        }
        private static void Log(string log, bool date)
        {
            lock (new object())
            {
                if (date)
                    _sw.WriteLine(log + DateTime.Now.ToString());
                else
                    _sw.WriteLine(log);
            }
        }
        private void Start()
        {
            Log("Checking started at:", true);
            for (int k = 0; k < FilmsTable.Rows.Count; k++)
            {
                _thr.Add(new Thread(Find));
                _thr[k].Start(k);
            }
        }
        private void Stop()
        {
            int g = 0;
            try
            {
                foreach (Thread th in _thr)
                {
                    if (th != null && th.IsAlive)
                    {
                        g++;
                        th.Abort();
                    }
                }
                if (g != 0)
                    Log("Checking stopped("+g+" threads killed).", false);
                _thr.Clear();
            }
            catch (Exception)
            {
                Log("Error in killing threads!", true);
            }
        }
        private static int AliveThreads()
        {
            int j = 0;
            if (_thr != null)
                foreach (Thread th in _thr)
                    if (th != null && th.IsAlive == true)
                        j++;
            return j;
        }
        private bool InternetAccessCheck()
        {
            IPStatus status = IPStatus.Unknown;
            try
            {
                status = new Ping().Send("google.com").Status;
            }
            catch { }
            if (status != IPStatus.Success)
            {
                MessageBox.Show("У вас проблемы с интернет соединением.");
                return false;
            }
            return true;
        }
        private void ClearResults()
        {
            ResultsTable.Rows.Clear();
            label1.Text = "";
            linkLabel1.Text = "";
            pictureBox1.Image = null;
            pictureBox1.Invalidate();
            richTextBox1.Clear();
            richTextBox1.Visible = false;
            pictureBox1.Visible = false;
        }
        #endregion

        #region Tray
        private void button2_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            this.Visible = false;
            notifyIcon1.Visible = true;
            Log("Moved to tray", false);
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            notifyIcon1.Visible = false;
            this.ShowInTaskbar = true;
            Log("Moved out from tray", false);
        }
        #endregion

        private void ResultsTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex==0)
            {
                g = FilmsTable.CurrentCell.RowIndex;
                string image = "", text = "";
                if (films[g].images == null)
                    image = "http://www.iconsearch.ru/uploads/icons/humano2/128x128/gtk-no.png";
                else
                    image = films[g].images[e.RowIndex];
                if (films[g].Text == null || films[g].Text[e.RowIndex] == "notext")
                    text = "No description";
                else
                    text = films[g].Text[e.RowIndex];
                PreviewAdd(films[g].Links[e.RowIndex], text, films[g].Results[e.RowIndex], image);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://" + linkLabel1.Text);
        }

        private void FilmTxtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                OKButtn.PerformClick();
        }

        private void FilmsTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int g=e.RowIndex;
            FilmsTable.CurrentCell = FilmsTable.Rows[FilmsTable.Rows.Count - 1].Cells[0];
            if (Check(g))
            {
                if (films[g].Results.Count == 0)
                {
                    MessageBox.Show("No results.");
                    return;
                }
            }
            else
            {
                Log("Error in the checking of the film:" + films[g].Name, true);
                return;
            }
            ResultsTable.Rows.Clear();
            foreach (string str in films[g].Results)
                ResultsTable.Rows.Add(str);
            if (films[g].images != null && films[g].images.Count != 0)
                PreviewAdd(films[g].Links[0], films[g].Text[0], films[g].Results[0], films[g].images[0]);
        }

        private void repeatSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public class Film
        {
            public int Interval;
            public string Name;
            public List<string> Results;
            public List<string> Links;
            public List<string> Text;
            public List<string> images;
            public Film(string name, int interval)
            {
                Name = name; Interval = interval;
            }
        }

        public static class Globals
        {
            public static int Errors;
            public static int Succeeded;
        }

    }
}
