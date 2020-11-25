using SimpleTCP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;
        public static string writePath = @"D:\hta.txt";
        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.StringEncoder = Encoding.UTF8;
            server.DelimiterDataReceived += Server_DataReceived;
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                string MessageString = e.MessageString.Substring(0, e.MessageString.IndexOf('@'));
                string Data = e.MessageString.Split('@')[1];
                txtStatus.Text += "Получены команда: " + MessageString + "\r\n";
                switch(MessageString)
                {
                    case "show":
                        {
                            e.ReplyLine(string.Format("{0}", ShowCompany()));
                            break;
                        }
                    case "remove":
                        {
                            RemoveCompany(Data);
                            e.ReplyLine(string.Format("{0}", ShowCompany()));
                            break;
                        }
                    case "add":
                        {
                            AddCompany(Data);
                            e.ReplyLine(string.Format("{0}", ShowCompany()));
                            break;
                        }
                    case "search":
                        {
                            e.ReplyLine(string.Format("{0}", SearchCompany(Data)));
                            break;
                        }
                }
            });
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            txtStatus.Text += "Запус сервера..." + "\r\n";
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(txtHost.Text);
            server.Start(ip, Convert.ToInt32(txtPort.Text));
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
                server.Stop();
            txtStatus.Text += "Остановка сервера..." + "\r\n";
        }

        public string ShowCompany()
        {
            List<string> companies = new List<string>();
            using (StreamReader sr = new StreamReader(writePath, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    companies.Add(line);
                }
            }

            return String.Join("#", companies);
        }

        public void RemoveCompany(string str)
        {
            var lines = File.ReadAllLines(writePath).ToList();

            for (int i = 0; i < lines.Count; i++)
            {
                string line = lines[i];
                if (line == str)
                {
                    lines.RemoveAt(Convert.ToInt32(i));
                    File.WriteAllLines(writePath, lines);
                    break;
                }
            }
        }
        public void AddCompany(string str)
        {
            using (StreamWriter sw = File.AppendText(writePath))
            {
                sw.WriteLine(str);
            }
        }

        public string SearchCompany(string str)
        {
            StreamReader lines = new StreamReader(writePath, Encoding.Default);
            while (!lines.EndOfStream)
            {
                string st = lines.ReadLine();
                if (st.StartsWith(str))
                {
                    return st;
                }
            }

            return null;
        }

    }
}
