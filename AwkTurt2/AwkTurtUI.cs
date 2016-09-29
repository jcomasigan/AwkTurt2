using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using HtmlAgilityPack;

namespace AwkTurtleCounter
{
    public class Tokens
    {
        public static string ConsumerKey = "";
        public static string ConsumerKeySecret = "";
        public static string AccessToken = "";
        public static string AccessTokenSecret = "";
    }

    public partial class AwkTurtUI : Form
    {
        #region Variables
        ChromiumWebBrowser browser;
        DataTable stringCollection = new DataTable();
        Timer timer = new Timer(); 
        #endregion
        public AwkTurtUI()
        {
            InitializeComponent();
            CefSettings settings = new CefSettings();
            CefSharp.Cef.Initialize();
            browser = new ChromiumWebBrowser("https://web.whatsapp.com/");
            panel1.Controls.Add(browser);
            stringCollection.Columns.Add("divContent", typeof(string));
            GetCodes();
        }

        private void ListenButton_Click(object sender, EventArgs e)
        {
            ParseWhatsAppHtmlDivs();
            timer.Interval = 3000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        
        private void GetCodes()
        {
            //Codes saved in local file so project can be posted in github
            string[] codes = System.IO.File.ReadAllLines(@"C:\Users\Jericho Masigan\Documents\Programming\oauthcode.txt");
            Tokens.ConsumerKey = codes[0];
            Tokens.ConsumerKeySecret = codes[1];
            Tokens.AccessToken = codes[2];
            Tokens.AccessTokenSecret = codes[3];

        }
    private void Timer_Tick(object sender, EventArgs e)
        {
            ParseWhatsAppHtmlDivs();
        }
        
        private bool MessagedAlreadyTweeted(string message)
        {
            //stops posting of duplicate tweets
            bool hasBeenTweeted = false;
            for(int i = 0; i < stringCollection.Rows.Count; i++)
            {
                if(stringCollection.Rows[i][0].ToString() == message)
                {
                    hasBeenTweeted = true;
                    return hasBeenTweeted;
                }
            }
            stringCollection.Rows.Add(message);

            return hasBeenTweeted;
        }

        public async void ParseWhatsAppHtmlDivs()
        {
            var htmlSource = await browser.GetSourceAsync();
            Clipboard.SetText(htmlSource);
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(htmlSource);

            HtmlNode whatsAppDivs = doc.DocumentNode;
            HtmlNodeCollection textBoxDivNode = whatsAppDivs.SelectNodes("//*[contains(@class,'bubble bubble-text')]"); //div that contains the messages
            foreach(HtmlNode node in textBoxDivNode)
            {
                if(!MessagedAlreadyTweeted(node.InnerText))
                {
                    AwkTwitt.ParseMessage(node.InnerText);
                }
            }
        }

        private void hideBrowserButton_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void showBrowserButton_Click(object sender, EventArgs e)
        {
            if(passwordBox.Text == "terminalV")
            {
                panel1.Show();
            }
            else
            {
                MessageBox.Show("Please enter the right password");
            }
        }
    }
}
