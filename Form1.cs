using System;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace DNS_RESOLVER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Resolver(string strUrl)
        {
            StringBuilder sb = new StringBuilder();
            IPHostEntry host = Dns.GetHostByName(strUrl);
            foreach (IPAddress ip in host.AddressList)
            {
                sb.AppendLine("Host name: " + strUrl);
                sb.AppendLine("Adress: " + ip.ToString());
                txtresult.Text = sb.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Resolver(txtaddress.Text);
        }
    }
}
