using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Atlas_Eyes
{
    public partial class Main_Form : Form
    {
        private string[] player_list = { "testgg", "448888", "laoying222", "448888" };
        private bool isMaintenance = false;
        private int count_dataGridView = 0;
        private int current_player = 0;

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
                        webBrowser.Visible = false;
                        panel_settings.Visible = true;

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
                    span.InvokeMember("click");
                    timer_view_player.Start();
                    break;

                }
            }
        }

        private void timer_view_player_Tick(object sender, EventArgs e)
        {
            timer_view_player.Stop();

            HtmlElementCollection spans = webBrowser.Document.GetElementsByTagName("a");

            foreach (HtmlElement span in spans)
            {
                if (span.OuterHtml.ToString().Contains("View player balance") || span.OuterHtml.ToString().Contains("查看玩家额度"))
                {
                    span.InvokeMember("click");
                    timer_get_value.Start();
                    break;
                }
            }
        }

        private void timer_get_value_Tick(object sender, EventArgs e)
        {
            timer_get_value.Stop();
            isMaintenance = false;

            HtmlElementCollection spans = webBrowser.Document.GetElementsByTagName("span");

            decimal total = 0;
            int count = 0;
            decimal main_wallet = 0;
            decimal gp_wallet = 0;

            foreach (HtmlElement span in spans)
            {
                if (span.OuterHtml.ToString().Contains("balance"))
                {
                    //int n = Int32.Parse(span.InnerHtml.ToString());

                    if (span.InnerHtml.ToString() == "维护")
                    {
                        MessageBox.Show(span.InnerHtml.ToString());
                        isMaintenance = true;
                    }
                    else
                    {
                        count++;
                        if (count == 1)
                        {
                            main_wallet = ExtractDecimalFromString(span.InnerHtml.ToString());
                            total += ExtractDecimalFromString(span.InnerHtml.ToString());
                        }
                        else
                        {
                            gp_wallet += ExtractDecimalFromString(span.InnerHtml.ToString());
                            total += ExtractDecimalFromString(span.InnerHtml.ToString());
                        }
                        //MessageBox.Show(ExtractDecimalFromString(span.InnerHtml.ToString()).ToString());
                        //string result_value = Regex.Replace(span.InnerHtml.ToString(), @"[.\D+]", "");
                        //MessageBox.Show(result_value);
                    }

                    //bool isNumeric = int.TryParse("123", out n);

                    //if (isNumeric)
                    //{
                    //    total += Int32.Parse(span.InnerHtml.ToString());
                    //}
                    //else
                    //{
                    //    isMaintenance = true;
                    //}
                }
            }

            if (decimal.Parse(textBox_threshold.Text) <= total)
            {
                if (!isMaintenance)
                {
                    dataGridView_result.Rows.Insert(0, player_list[current_player], main_wallet, gp_wallet, total);

                    string backcolor = "#EE3A59";
                    Color backcolor_change = ColorTranslator.FromHtml(backcolor);
                    dataGridView_result.DefaultCellStyle.BackColor = backcolor_change;
                    dataGridView_result.DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    dataGridView_result.Rows.Insert(0, player_list[current_player], main_wallet, gp_wallet, total);

                    string backcolor = "#EFCA58";
                    Color backcolor_change = ColorTranslator.FromHtml(backcolor);
                    dataGridView_result.DefaultCellStyle.BackColor = backcolor_change;
                    dataGridView_result.DefaultCellStyle.ForeColor = Color.Black;

                }
            }


            dataGridView_result.ClearSelection();
            current_player++;
            if (current_player <= player_list.Length-1)
            {
                webBrowser.Navigate("http://cs.tianfa86.org/player/list");
                count_dataGridView++;
            }
            else
            {
                pictureBox_loader.Visible = false;
                pictureBox_loader.Enabled = false;
                MessageBox.Show("wait for next refresh");
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
