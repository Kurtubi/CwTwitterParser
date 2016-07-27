using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TwitterParser.Control;

namespace TwitterParser
{
    public partial class frmTwitterParserPanel : Form
    {
        public frmTwitterParserPanel()
        {
            InitializeComponent();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            
            TweetParserControl tpc = new TweetParserControl();
            tpc.kelime = new Dictionary<string, string>();
            tpc.wBrowser = wbrowserTweet;
            tpc.kelime.Add("AnahtarKelime", textAnahtarKelime.Text);
            tpc.listParserNode = listTopic;
            listTopic.Items.Clear();
            tpc.TweetPaerserLoad(textHashTag.Text);
        }

        private void frmTwitterParserPanel_Load(object sender, EventArgs e)
        {
                wbrowserTweet.Navigate("https://www.twitter.com");
        }

        private void UserPageGoGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = listTopic.SelectedItems[0];
            string userName = item.SubItems[0].Text.Replace("@", "");
            if (userName != "")
            {
                wbrowserTweet.Navigate("https://www.twitter.com/" + userName);
            }
        }

        private void showTweetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = listTopic.SelectedItems[0];
            string link = item.SubItems[2].Text.Replace("@", "");
            if (link != "")
            {
                wbrowserTweet.Navigate("https://www.twitter.com/" + link);
            }
        }
        private void wbrowserTweet_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            
        }
    }
}
