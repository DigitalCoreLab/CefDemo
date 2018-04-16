using CefSharp;
using CefSharp.WinForms;
using System;
using System.Windows.Forms;

namespace CefDemo
{
    public partial class FormMain : Form
    {
        private ChromiumWebBrowser browser;
        private CefSettings settings;
        public FormMain()
        {
            InitializeComponent();
            InitializeWebBrowser();
        }
        private void InitializeWebBrowser()
        {
            settings = new CefSettings();
            settings.UserAgent = "Mozila 5.0";

            Cef.Initialize(settings);

            browser = new ChromiumWebBrowser(string.Empty) { Dock = DockStyle.Fill };

            Controls.Add(browser);
        }
        
        private void btnLoad_Click(object sender, EventArgs e)
        {
            browser.Load(txtUrl.Text);
        }
    }
}
