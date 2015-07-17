using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Netaccess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Net.WebRequest request = System.Net.WebRequest.Create("https://www.google.co.in/?gws_rd=ssl");
            using (WebBrowser browser = new WebBrowser())
            {
                browser.Url = new Uri("http://www.google.co.in");
                browser.Document.All.GetElementsByName("q")[0].SetAttribute("Value", textBox1.Text);
                /*if (textBox1 != null)
                {
                    textBox1.InnerText = "Hello";
                }*/
                //repeate for textBox2....
            }

        }
    }
}
