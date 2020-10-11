using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ContestEnterer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_open_browser_Click(object sender, EventArgs e)
        {
            IWebDriver webDriver;
            webDriver = new ChromeDriver(); // TODO: put default, updateable in config
            webDriver.Url = "http://www.google.com";
        }
    }
}
