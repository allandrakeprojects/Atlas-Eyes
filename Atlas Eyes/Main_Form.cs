using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Atlas_Eyes
{
    public partial class Main_Form : Form
    {
        private string[] player_list = { "testgg", "448888", "laoying222", "448888" };
        private bool isMaintenance = false;
        private int count_dataGridView = 0;
        private int current_player = 0;
        private string player_id;
        private string player_name;
        private string player_name_inner;

        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate("http://cs.tianfa86.org/account/login");
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser.ReadyState == WebBrowserReadyState.Complete)
            {
                if (e.Url == webBrowser.Url)
                {
                    if (webBrowser.Url.ToString().Equals("http://cs.tianfa86.org/account/login"))
                    {
                        webBrowser.Document.GetElementById("csname").SetAttribute("value", "tfrain");
                        webBrowser.Document.GetElementById("cspwd").SetAttribute("value", "djrain123$$");
                        webBrowser.Document.Window.ScrollTo(0, webBrowser.Document.Window.Size.Height);
                    }

                    if (webBrowser.Url.ToString().Equals("http://cs.tianfa86.org/player/list"))
                    {
                        //webBrowser.Visible = false;
                        //panel_settings.Visible = true;

                        try
                        {
                            webBrowser.Document.GetElementById("s_keyword").SetAttribute("value", player_list[current_player]);
                            webBrowser.Document.GetElementById("s_submit").InvokeMember("Click");
                            timer_search_preview.Start();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
            }
        }

        bool FindLinkToClick(HtmlElement root, string text, ref HtmlElement found)
        {
            foreach (var child in root.Children)
            {
                var element = (HtmlElement)child;
                if (element.InnerText == text)
                {
                    found = element.Parent;
                    return true;
                }
                if (FindLinkToClick(element, text, ref found))
                    return true;
            }
            return false;
        }

        private void timer_search_preview_Tick(object sender, EventArgs e)
        {
            timer_search_preview.Stop();
            HtmlElementCollection spans = webBrowser.Document.GetElementsByTagName("span");

            foreach (HtmlElement span in spans)
            {
                if (span.OuterHtml.ToString().Contains(player_list[current_player]))
                {
                    string remove_brackets = Regex.Match(span.OuterHtml.ToString(), @"\(([^)]*)\)").Groups[1].Value;
                    string[] results = remove_brackets.Replace("'", "").Split(',');

                    int count = 0;

                    foreach (string result in results)
                    {
                        count++;

                        if (count == 1)
                        {
                            player_id = result.Replace(" ", "");
                        } else if (count == 2)
                        {
                            player_name = result.Replace(" ", "");
                        }
                    }

                    timer_get_data.Start();

                    //player_name_inner = span.InnerHtml.ToString()


                    break;
                }
            }
        }

        private void timer_get_data_Tick(object sender, EventArgs e)
        {
            timer_get_data.Stop();



            var cookies = FullWebBrowserCookie.GetCookieInternal(webBrowser.Url, false);
            WebClient wc = new WebClient();
            wc.Headers.Add("Cookie: " + cookies);
            wc.Encoding = Encoding.UTF8;
            wc.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            string result = wc.DownloadString("http://cs.tianfa86.org/kzb/gp/v1/gps?playerid=" + player_id);
            MessageBox.Show(Uri.UnescapeDataString(result));
            










            //GetAsync("http://cs.tianfa86.org/kzb/gp/v1/gps?playerid=21321321");

            //webBrowser.Navigate("http://cs.tianfa86.org/kzb/gp/v1/gps?playerid=21321321");

            //MessageBox.Show(webBrowser.DocumentText);

            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //System.IO.File.WriteAllBytes(path, webBrowser.("http://cs.tianfa86.org/kzb/gp/v1/gps?playerid=21321321"));

            //CookieContainer cookieJar = new CookieContainer();
            //string[] cookies = webBrowser.Document.Cookie.Split(new char[] { '=' });
            //cookieJar.Add(new Cookie(cookies[0], cookies[1], "/", "http://cs.tianfa86.org/account/login"));
            //CookieAwareWebClient client = new CookieAwareWebClient(cookieJar);

            //Uri uri = new Uri("http://cs.tianfa86.org/kzb/gp/v1/gps?playerid=21321321");
            //MessageBox.Show(uri.ToString());

            //client.DownloadStringCompleted += (sender_webclient, e_webclient) =>
            //{
            //    string result = e_webclient.Result;
            //    MessageBox.Show(result);
            //};

            //client.DownloadStringAsync(uri);

            //MessageBox.Show(player_id + " ---- " + player_name);
        }










































        public static Decimal ExtractDecimalFromString(string str)
        {

            Regex digits = new Regex(@"^\D*?((-?(\d+(\.\d+)?))|(-?\.\d+)).*");
            Match mx = digits.Match(str);
            //Console.WriteLine("Input {0} - Digits {1} {2}", str, mx.Success, mx.Groups);

            return mx.Success ? Convert.ToDecimal(mx.Groups[1].Value) : 0;
        }

        private void dataGridView_result_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView_result.Rows[0].Selected = false;
        }

        private void dataGridView_result_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
