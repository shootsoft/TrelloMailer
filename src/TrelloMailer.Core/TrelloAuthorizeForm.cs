using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TrelloMailer.Core
{
    public partial class TrelloAuthorizeForm : Form
    {
        string token = string.Empty;

        public TrelloAuthorizeForm(string url)
        {
            InitializeComponent();
            webBrowser1.Navigate(url);
        }

        internal string GetToken()
        {
            return token;   
        }

        private void TrelloAuthorizeForm_Load(object sender, EventArgs e)
        {

        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            if (e.Url.ToString() == "https://trello.com/1/token/approve" && webBrowser1.DocumentText != null)
            {
                Regex r = new Regex("<pre>(?<token>(.|\n)*?)</pre>");
                Match m = r.Match(webBrowser1.DocumentText);
                if (m.Success && m.Groups["token"].Success)
                {
                    token = m.Groups["token"].Value.Trim();
                    Debug.WriteLine(token);
                }
                this.DialogResult = System.Windows.Forms.DialogResult.OK;

            }
        }
    }
}
