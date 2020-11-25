using SimpleTCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpClient client;
        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DelimiterDataReceived += Client_DataReceived;
        }
        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                ParseData(e.MessageString);
            });
        }
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            client.Connect(txtHost.Text, Convert.ToInt32(txtPort.Text));
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (radioBtnShow.Checked == true)
            {
                client.WriteLineAndGetReply("show@", TimeSpan.FromSeconds(1));
            }
            if (radioBtnRemove.Checked == true)
            {
                client.WriteLineAndGetReply("remove@" + listItem.SelectedItem, TimeSpan.FromSeconds(1));
            }
            if (radioBtnAdd.Checked == true)
            {
                client.WriteLineAndGetReply("add@" + textBox2.Text + " count employees: " + textBox3.Text, TimeSpan.FromSeconds(1));
            }
            if (radioBtnEdit.Checked == true)
            {
                client.WriteLineAndGetReply("remove@" + listItem.SelectedItem, TimeSpan.FromSeconds(1));
                client.WriteLineAndGetReply("add@" + textBox2.Text + " count employees: " + textBox3.Text, TimeSpan.FromSeconds(1));
            }
        }

        public List<string> ParseData(string str)
        {
            listItem.Items.Clear();
            List<string> lines = new List<string>();

            lines = str.Split('#').ToList<string>();
            foreach(string item in lines)
            {
                listItem.Items.Add(item);
            }
            return lines;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            client.WriteLineAndGetReply("search@" + textBox1.Text, TimeSpan.FromSeconds(1));
        }
    }
}
