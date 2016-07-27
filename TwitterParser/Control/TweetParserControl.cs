using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using HtmlAgilityPack;
using System.Data;
using System.Drawing;

namespace TwitterParser.Control
{
    public class TweetParserControl
    {
        public Dictionary<string, string> kelime;
        public WebBrowser wBrowser;
        public ListView listParserNode { get; set; }

        public void TweetPaerserLoad(string hashtag)
        {
            string url = "//twitter.com/hashtag/" + hashtag + "?src=tren";
            wBrowser.Navigate(url);
            wBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(wBrowser_DocumentCompleted);
        }

        public void TweetParserLoad()
        {
            getTwitterTweetParser();
        }

        void wBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (listParserNode.Items.Count == 0) 
            {
                getTwitterTweetParser();
            }
        }

        static string userName = string.Empty;
        static string message = string.Empty;
        static string link = string.Empty;

        private void getTwitterTweetParser()
        {
            wBrowser.DocumentText.Remove(0);

            StreamReader sReader = new StreamReader(wBrowser.DocumentStream, Encoding.GetEncoding(1254));
            string readText = sReader.ReadToEnd();
            HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();
            htmlDoc.LoadHtml(readText);

            try
            {
                foreach (HtmlNode parseUser in htmlDoc.DocumentNode.SelectNodes("//*[contains(@class,'username js-action-profile-name')]"))
                {
                    userName = string.Empty;
                    userName = parseUser.InnerText;
                    listParserNode.Items.Add(userName);
                }

                int listCount =-1;
                foreach (HtmlNode parseMessage in htmlDoc.DocumentNode.SelectNodes("//*[contains(@class,'TweetTextSize  js-tweet-text tweet-text')]"))
                {
                    string aKelime=string.Empty;
                    listCount++;
                    message = string.Empty;
                    message = parseMessage.InnerText;
                    int result = -1;
                    string anahtarKelime=string.Empty;
                    if (kelime.TryGetValue("AnahtarKelime", out aKelime))
                    {
                        anahtarKelime = aKelime;
                    }

                    if (listCount < listParserNode.Items.Count)
                        if (anahtarKelime != string.Empty)
                        {
                            result = message.IndexOf(anahtarKelime);
                            if (result > -1)
                            {
                                listParserNode.Items[listCount].SubItems.Add(message);
                                listParserNode.Items[listCount].BackColor = Color.Red;
                            }
                        }
                    if(result==-1)
                    listParserNode.Items[listCount].SubItems.Add(message);
                }

                int count = -1;
                foreach (HtmlNode parselink in htmlDoc.DocumentNode.SelectNodes("//a[@class='tweet-timestamp js-permalink js-nav js-tooltip']"))
                {
                    count++;
                    link = string.Empty;
                    link = parselink.Attributes["href"].Value;
                    if (count < listParserNode.Items.Count)
                    listParserNode.Items[count].SubItems.Add(link);
                }
            }
            catch { }
        }
    }
}
