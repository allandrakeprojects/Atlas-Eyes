using ChoETL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atlas_Eyes
{
    public partial class Main_Form : Form
    {
        List<string> player_list = new List<string>();
        //private string[] player_list;
        private bool isMaintenance = false;
        private int count_dataGridView = 0;
        private int current_player = 0;
        private string player_id;
        private string player_name;
        private string gpn;
        private decimal _total;
        private decimal _main_wallet;
        private decimal _gp_wallet;
        private int threshold = 1000;
        private int refresh_rate = 30;
        string path_gp = Path.GetTempPath() + "/ae_gameprovider.txt";
        string path_mainbalance = Path.GetTempPath() + "/ae_mainbalance.txt";
        string path_gpbalance = Path.GetTempPath() + "/ae_gpbalance.txt";
        string path_gpbalancetemp = Path.GetTempPath() + "/ae_gpbalancetemp.txt";
        string path_player = Path.GetTempPath() + "/ae_player.txt";
        string path_gpname = Path.GetTempPath() + "/ae_gameprovidername.txt";
        private string start_time;
        private string seconds_parse;
        private bool isNoPlayerList = false;
        private bool isOpened = true;
        private bool isMaintenanceInserted = false;

        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            textBox_threshold.Text = Properties.Settings.Default.threshold;
            textBox_seconds.Text = Properties.Settings.Default.refresh_rate;
            threshold = int.Parse(Properties.Settings.Default.threshold);
            refresh_rate = int.Parse(Properties.Settings.Default.refresh_rate);

            if (!File.Exists(path_player))
            {
                isNoPlayerList = true;
            }
            else
            {
                if (new FileInfo(path_player).Length == 0)
                {
                    isNoPlayerList = true;
                }
                else
                {
                    richTextBox_player.Text = File.ReadAllText(path_player);

                    player_list.Clear();

                    string line;
                    StreamReader streamReader = new StreamReader(path_player);
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        if (line.Length > 0)
                        {
                            player_list.Add(line.Trim());
                        }
                    }
                    streamReader.Close();
                }
            }

            DeleteFile();
            webBrowser.Navigate("http://cs.ying168.bet/account/login");
        }

        private void DeleteFile()
        {
            try
            {
                if (File.Exists(path_gp))
                {
                    File.Delete(path_gp);
                }

                if (File.Exists(path_mainbalance))
                {
                    File.Delete(path_mainbalance);
                }

                if (File.Exists(path_gpbalance))
                {
                    File.Delete(path_gpbalance);
                }

                if (File.Exists(path_gpbalancetemp))
                {
                    File.Delete(path_gpbalancetemp);
                }

                if (File.Exists(path_gpname))
                {
                    File.Delete(path_gpname);
                }
            }
            catch (Exception e)
            {
                // Leave blank
            }
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser.ReadyState == WebBrowserReadyState.Complete)
            {
                if (e.Url == webBrowser.Url)
                {
                    if (webBrowser.Url.ToString().Equals("http://cs.ying168.bet/account/login"))
                    {
                        //webBrowser.Document.GetElementById("csname").SetAttribute("value", "fyrain");
                        //webBrowser.Document.GetElementById("cspwd").SetAttribute("value", "djrain123@@@");
                        webBrowser.Document.Window.ScrollTo(0, webBrowser.Document.Window.Size.Height);
                    }

                    if (webBrowser.Url.ToString().Equals("http://cs.ying168.bet/player/list"))
                    {
                        if (!isNoPlayerList)
                        {
                            webBrowser.Visible = false;
                            panel_settings.Visible = true;
                            timer_detect.Start();

                            try
                            {
                                webBrowser.Document.GetElementById("s_keyword").SetAttribute("value", player_list[current_player]);
                                webBrowser.Document.GetElementById("s_submit").InvokeMember("Click");
                                timer_search_preview.Start();
                            }
                            catch (Exception ex)
                            {
                                //MessageBox.Show(ex.ToString());
                            }

                            pictureBox_loader.Visible = true;
                        }
                        else
                        {
                            if (isOpened)
                            {
                                isOpened = false;
                                webBrowser.Visible = false;
                                panel_settings.Visible = true;
                                groupBox_settings.Enabled = false;
                                groupBox_maintenance.Enabled = false;
                                groupBox_result.Enabled = false;
                                label_fetchedtime_1.Enabled = false;
                                label_fetchedtime.Enabled = false;
                                webBrowser.Navigate("http://cs.ying168.bet/player/list");
                                MessageBox.Show("Please provide player username.");
                            }
                            else
                            {
                                timer_reload.Start();
                            }
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

            try
            {
                HtmlElementCollection spans = webBrowser.Document.GetElementsByTagName("span");

                foreach (HtmlElement span in spans)
                {
                    if (span.InnerHtml.ToString().Equals(player_list[current_player]))
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
                            }
                            else if (count == 2)
                            {
                                player_name = result.Replace(" ", "");
                            }
                        }

                        break;
                    }
                }

                HtmlElement table = webBrowser.Document.GetElementById("data");
                var rows = table.GetElementsByTagName("tr");
                foreach (HtmlElement row in rows)
                {
                    int i = 0;
                    foreach (HtmlElement cell in row.GetElementsByTagName("td"))
                    {
                        i++;
                        string value = cell.InnerText;
                        if (i == 2)
                        {
                            using (StringReader sr = new StringReader(value))
                            {
                                int count = 0;
                                string line;
                                while ((line = sr.ReadLine()) != null)
                                {
                                    count++;

                                    if (count == 2)
                                    {
                                        gpn = line;

                                        timer_get_data.Start();

                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception err)
            {
                label_result.Visible = false;

                dataGridView_result.Rows.Insert(0, player_list[current_player], "-", "-", "-");

                string backcolor = "#EE3A59";
                Color backcolor_change = ColorTranslator.FromHtml(backcolor);
                dataGridView_result.Rows[0].DefaultCellStyle.BackColor = backcolor_change;
                dataGridView_result.Rows[0].DefaultCellStyle.ForeColor = Color.Black;

                dataGridView_result.Sort(dataGridView_result.Columns["total"], ListSortDirection.Descending);
                dataGridView_result.ClearSelection();

                current_player++;
                if (current_player <= player_list.Count - 1)
                {
                    _main_wallet = 0;
                    _gp_wallet = 0;
                    _total = 0;
                    DeleteFile();
                    webBrowser.Navigate("http://cs.ying168.bet/player/list");
                }
                else
                {
                    timer_refreshrate.Start();
                    start_time = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    seconds_parse = DateTime.Now.AddSeconds(refresh_rate + 2).ToString("dd/MM/yyyy HH:mm:ss");
                    string time = DateTime.Now.ToString("HH:mm");
                    label_fetchedtime.Text = time;
                }
            }
        }

        private async void timer_get_data_TickAsync(object sender, EventArgs e)
        {
            timer_detect.Stop();

            timer_get_data.Stop();

            // Get Game Provider ID
            await GetGPIDAsync(player_id);

            // Get Player Main Balance
            await GetPlayerBalanceAsync(player_id);

            try
            {
                // Get Player Game Provider Balance
                await GetGameProviderBalanceAsync(player_id, player_name, gpn);
            }
            catch (Exception err)
            {
                webBrowser.Navigate("http://cs.ying168.bet/player/list");
            }

            // Display in Table
            DisplayInTable();
        }

        private async Task GetGPIDAsync(String player_id)
        {
            var cookies = FullWebBrowserCookie.GetCookieInternal(webBrowser.Url, false);
            WebClient wc = new WebClient();
            wc.Headers.Add("Cookie: " + cookies);
            wc.Encoding = Encoding.UTF8;
            wc.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            string result = await wc.DownloadStringTaskAsync("http://cs.ying168.bet/kzb/gp/v1/gps?playerid=" + player_id);

            string reversestring = "";
            int length = result.Length - 1;
            while (length >= 0)
            {
                reversestring = reversestring + result[length];
                length--;
            }

            int count_remove_start = 0;
            int count_remove_end = 0;

            foreach (char c in reversestring)
            {
                count_remove_end++;

                if (c == ',')
                {
                    break;
                }
            }

            foreach (char c in result)
            {
                count_remove_start++;

                if (c == '[')

                {
                    break;
                }
            }

            result = result.Remove(count_remove_start, 1);
            string final_result = result.Remove(result.Length - count_remove_end) + "}";

            try
            {
                using (var csv = new ChoCSVWriter(path_gp).WithFirstLineHeader())
                {
                    using (var p = ChoJSONReader.LoadText(final_result).WithJSONPath("$...data"))
                    {
                        csv.Write(p.Select(i => new {
                            Header_Test_Header = i.id + i.flag + i.nb
                        }));
                    }
                }

                using (var csv = new ChoCSVWriter(path_gpname).WithFirstLineHeader())
                {
                    using (var p = ChoJSONReader.LoadText(final_result).WithJSONPath("$...data"))
                    {
                        csv.Write(p.Select(i => new {
                            Header_Test_Header = i.id + "*|*" + i.name
                        }));
                    }
                }
            }
            catch (Exception err)
            {
                //MessageBox.Show(err.ToString());
            }
        }

        private async Task GetPlayerBalanceAsync(String player_id)
        {
            var cookies = FullWebBrowserCookie.GetCookieInternal(webBrowser.Url, false);
            WebClient wc = new WebClient();
            wc.Headers.Add("Cookie: " + cookies);
            wc.Encoding = Encoding.UTF8;
            wc.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            string result = await wc.DownloadStringTaskAsync("http://cs.ying168.bet/kzb/player/mcbalance?playerid=" + player_id);

            try
            {
                using (var csv = new ChoCSVWriter(path_mainbalance).WithFirstLineHeader())
                {
                    using (var p = ChoJSONReader.LoadText(result).WithJSONPath("$...val"))
                    {
                        csv.Write(p.Select(i => new {
                            Header_Test_Header = i.main
                        }));
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

        }

        private async Task GetGameProviderBalanceAsync(String player_id, String player_name, String gpn)
        {
            using (StreamReader sr = File.OpenText(path_gp))
            {
                string result = String.Empty;
                while ((result = sr.ReadLine()) != null)
                {
                    if (result != "Header_Test_Header")
                    {
                        char last = result[result.Length - 1];
                        char second_last = result[result.Length - 2];
                        if (last == '0')
                        {
                            if (second_last == '1')
                            {
                                string final_result = result.Remove(result.Length - 2);

                                if (final_result != "10000")
                                {
                                    var cookies = FullWebBrowserCookie.GetCookieInternal(webBrowser.Url, false);
                                    WebClient wc = new WebClient();
                                    wc.Headers.Add("Cookie: " + cookies);
                                    wc.Encoding = Encoding.UTF8;
                                    wc.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                                    string result_download = await wc.DownloadStringTaskAsync("http://cs.ying168.bet/kzb/gp/v1/balance?gpid=" + final_result + "&playerid=" + player_id + "&playername=" + player_name + "&gpn=3425819" + gpn);
                                    //MessageBox.Show(final_result + " ------ " + result_download);
                                    try
                                    {
                                        using (var csv = new ChoCSVWriter(path_gpbalancetemp).WithFirstLineHeader())
                                        {
                                            using (var p = ChoJSONReader.LoadText(result_download).WithJSONPath("$...data"))
                                            {
                                                csv.Write(p.Select(i => new
                                                {
                                                    Header_Test_Header = i.val
                                                }));
                                            }
                                        }

                                        string line;
                                        StreamReader streamReader = new StreamReader(path_gpbalancetemp);
                                        while ((line = streamReader.ReadLine()) != null)
                                        {
                                            if (!line.Contains("Header_Test_Header"))
                                            {
                                                //MessageBox.Show(line);
                                                StreamWriter sw = new StreamWriter(path_gpbalance, true, Encoding.UTF8);
                                                sw.WriteLine(line);
                                                sw.Close();
                                            }
                                        }
                                        streamReader.Close();
                                    }
                                    catch (Exception err)
                                    {
                                        //MessageBox.Show(err.ToString());
                                    }
                                }
                            }
                            else
                            {
                                isMaintenance = true;
                                string final_result = result.Remove(result.Length - 2);
                                bool isGet = false;
                                string line;
                                StreamReader streamReader = new StreamReader(path_gpname);
                                while ((line = streamReader.ReadLine()) != null)
                                {
                                    if (line != "Header_Test_Header")
                                    {
                                        int count = 0;
                                        string[] words = line.Split("*|*");
                                        foreach (string word in words)
                                        {
                                            count++;

                                            if (count == 1)
                                            {
                                                if (final_result == word)
                                                {
                                                    isGet = true;
                                                }
                                            }
                                            else if (count == 2)
                                            {
                                                if (isGet)
                                                {
                                                    isGet = false;

                                                    foreach (DataGridViewRow row in dataGridView_maintenance.Rows)
                                                    {
                                                        foreach (DataGridViewCell cell in row.Cells)
                                                        {
                                                            string value = cell.Value.ToString();

                                                            if (word != value)
                                                            {
                                                                isMaintenanceInserted = true;
                                                                dataGridView_maintenance.Rows.Add(word);
                                                            }
                                                            else
                                                            {
                                                                isMaintenanceInserted = true;
                                                            }
                                                        }
                                                    }

                                                    if (!isMaintenanceInserted)
                                                    {
                                                        dataGridView_maintenance.Rows.Add(word);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                streamReader.Close();

                                dataGridView_maintenance.ClearSelection();
                                label_maintenance.Visible = false;
                            }
                        }
                        else
                        {
                            if (second_last == '2')
                            {
                                isMaintenance = true;
                                string final_result = result.Remove(result.Length - 2);
                                bool isGet = false;
                                string line;
                                StreamReader streamReader = new StreamReader(path_gpname);
                                while ((line = streamReader.ReadLine()) != null)
                                {
                                    if (line != "Header_Test_Header")
                                    {
                                        int count = 0;
                                        string[] words = line.Split("*|*");
                                        foreach (string word in words)
                                        {
                                            count++;

                                            if (count == 1)
                                            {
                                                if (final_result == word)
                                                {
                                                    isGet = true;
                                                }
                                            }
                                            else if (count == 2)
                                            {
                                                if (isGet)
                                                {
                                                    isGet = false;

                                                    foreach (DataGridViewRow row in dataGridView_maintenance.Rows)
                                                    {
                                                        foreach (DataGridViewCell cell in row.Cells)
                                                        {
                                                            string value = cell.Value.ToString();

                                                            if (word != value)
                                                            {
                                                                isMaintenanceInserted = true;
                                                                dataGridView_maintenance.Rows.Add(word);
                                                            }
                                                            else
                                                            {
                                                                isMaintenanceInserted = true;
                                                            }
                                                        }
                                                    }

                                                    if (!isMaintenanceInserted)
                                                    {
                                                        dataGridView_maintenance.Rows.Add(word);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                streamReader.Close();

                                dataGridView_maintenance.ClearSelection();
                                label_maintenance.Visible = false;
                            }
                        }
                    }
                }
                sr.Close();
            }
        }

        private void DisplayInTable()
        {
            if (File.Exists(path_mainbalance))
            {
                string line;
                StreamReader streamReader = new StreamReader(path_mainbalance);
                while ((line = streamReader.ReadLine()) != null)
                {
                    if (line != "Header_Test_Header")
                    {
                        _main_wallet = Decimal.Parse(line);
                        _total += Decimal.Parse(line);
                    }
                }
                streamReader.Close();
            }

            if (File.Exists(path_gpbalance))
            {
                string line_total;
                StreamReader streamReader_total = new StreamReader(path_gpbalance);
                while ((line_total = streamReader_total.ReadLine()) != null)
                {
                    if (line_total != "Header_Test_Header")
                    {
                        _gp_wallet += Decimal.Parse(line_total);
                        _total += Decimal.Parse(line_total);
                    }
                }
                streamReader_total.Close();
            }
            
            label_result.Visible = false;

            if (threshold <= _total)
            {
                if (!isMaintenance)
                {
                    isMaintenance = false;

                    dataGridView_result.Rows.Insert(0, player_name, String.Format("{0:n}", _main_wallet), String.Format("{0:n}", _gp_wallet), String.Format("{0:n}", _total));

                    string backcolor = "#22967C";
                    Color backcolor_change = ColorTranslator.FromHtml(backcolor);
                    dataGridView_result.Rows[0].DefaultCellStyle.BackColor = backcolor_change;
                    dataGridView_result.Rows[0].DefaultCellStyle.ForeColor = Color.Black;

                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.altas_eyes);
                    player.Play();
                }
                else
                {
                    dataGridView_result.Rows.Insert(0, player_name, String.Format("{0:n}", _main_wallet), String.Format("{0:n}", _gp_wallet), String.Format("{0:n}", _total));

                    string backcolor = "#EFCA58";
                    Color backcolor_change = ColorTranslator.FromHtml(backcolor);
                    dataGridView_result.Rows[0].DefaultCellStyle.BackColor = backcolor_change;
                    dataGridView_result.Rows[0].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
            else
            {
                if (!isMaintenance)
                {
                    isMaintenance = false;

                    dataGridView_result.Rows.Insert(0, player_name, String.Format("{0:n}", _main_wallet), String.Format("{0:n}", _gp_wallet), String.Format("{0:n}", _total));

                    string backcolor = "#EE3A59";
                    Color backcolor_change = ColorTranslator.FromHtml(backcolor);
                    dataGridView_result.Rows[0].DefaultCellStyle.BackColor = backcolor_change;
                    dataGridView_result.Rows[0].DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    dataGridView_result.Rows.Insert(0, player_name, String.Format("{0:n}", _main_wallet), String.Format("{0:n}", _gp_wallet), String.Format("{0:n}", _total));

                    string backcolor = "#EFCA58";
                    Color backcolor_change = ColorTranslator.FromHtml(backcolor);
                    dataGridView_result.Rows[0].DefaultCellStyle.BackColor = backcolor_change;
                    dataGridView_result.Rows[0].DefaultCellStyle.ForeColor = Color.Black;
                }
            }

            dataGridView_result.Sort(dataGridView_result.Columns["total"], ListSortDirection.Descending);
            dataGridView_result.ClearSelection();

            current_player++;
            if (current_player <= player_list.Count - 1)
            {
                _main_wallet = 0;
                _gp_wallet = 0;
                _total = 0;
                DeleteFile(); 
                webBrowser.Navigate("http://cs.ying168.bet/player/list");
            }
            else
            {
                timer_refreshrate.Start();
                start_time = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                seconds_parse = DateTime.Now.AddSeconds(refresh_rate + 2).ToString("dd/MM/yyyy HH:mm:ss");
                string time = DateTime.Now.ToString("HH:mm");
                label_fetchedtime.Text = time;
            }
        }


        private void timer_refreshrate_Tick(object sender, EventArgs e)
        {
            DateTime seconds = DateTime.ParseExact(seconds_parse, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            string start_time_parse = start_time;
            DateTime start = DateTime.ParseExact(start_time_parse, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            TimeSpan difference = seconds - start;
            int hrs = difference.Hours;
            int mins = difference.Minutes;
            int secs = difference.Seconds;

            TimeSpan spinTime = new TimeSpan(hrs, mins, secs);

            TimeSpan delta = DateTime.Now - start;
            TimeSpan timeRemaining = spinTime - delta;

            if (timeRemaining.Minutes != 0)
            {
                if (timeRemaining.Seconds == 0)
                {
                    label_timer.Text = timeRemaining.Minutes + ":" + timeRemaining.Seconds + "0";
                }
                else
                {
                    if (timeRemaining.Seconds.ToString().Length == 1)
                    {
                        label_timer.Text = timeRemaining.Minutes + ":0" + timeRemaining.Seconds;
                    }
                    else
                    {
                        label_timer.Text = timeRemaining.Minutes + ":" + timeRemaining.Seconds;
                    }
                }
                
                pictureBox_loader.Visible = false;
                label_timer.Visible = true;
            }
            else
            {                
                if (label_timer.Text == "1")
                {
                    _main_wallet = 0;
                    _gp_wallet = 0;
                    _total = 0;
                    label_timer.Visible = false;
                    label_timer.Text = "";
                    isMaintenanceInserted = false;
                    pictureBox_loader.Visible = true;
                    timer_refreshrate.Stop();
                    current_player = 0;

                    dataGridView_result.Rows.Clear();
                    dataGridView_result.Refresh();

                    dataGridView_maintenance.Rows.Clear();
                    dataGridView_maintenance.Refresh();

                    player_list.Clear();

                    string line;
                    StreamReader streamReader = new StreamReader(path_player);
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        if (line.Length > 0)
                        {
                            player_list.Add(line.Trim());
                        }
                    }
                    streamReader.Close();

                    DeleteFile();
                    webBrowser.Navigate("http://cs.ying168.bet/player/list");
                }
                else
                {
                    label_timer.Text = timeRemaining.Seconds.ToString();
                    pictureBox_loader.Visible = false;
                    label_timer.Visible = true;
                }
            }
        }

        private void dataGridView_result_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView_result.Rows[0].Selected = false;
        }

        private void dataGridView_result_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            int limit_thredshold = 1;
            int limit_refreshrate = 10;

            int n;
            bool isNumeric_threshold = int.TryParse(textBox_threshold.Text, out n);
            bool isNumeric_refreshrate = int.TryParse(textBox_seconds.Text, out n);

            if (isNumeric_threshold && isNumeric_refreshrate)
            {
                if (threshold != int.Parse(textBox_threshold.Text) || refresh_rate != int.Parse(textBox_seconds.Text))
                {
                    if (limit_thredshold <= int.Parse(textBox_threshold.Text) && limit_refreshrate <= int.Parse(textBox_seconds.Text))
                    {
                        Properties.Settings.Default.threshold = textBox_threshold.Text;
                        Properties.Settings.Default.refresh_rate = textBox_seconds.Text;
                        Properties.Settings.Default.Save();
                        threshold = int.Parse(textBox_threshold.Text);
                        refresh_rate = int.Parse(textBox_seconds.Text);
                        MessageBox.Show("Changes applied.");
                    }
                    else
                    {
                        textBox_threshold.Text = threshold.ToString();
                        textBox_seconds.Text = refresh_rate.ToString();
                        MessageBox.Show("Limit exceed.");
                    }
                }
                else
                {
                    MessageBox.Show("No changes applied.");
                }
            }
            else
            {
                textBox_threshold.Text = threshold.ToString();
                textBox_seconds.Text = refresh_rate.ToString();
                MessageBox.Show("Enter numeric only.");
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (richTextBox_player.Text != "")
            {
                richTextBox_player.Text = Regex.Replace(richTextBox_player.Text, @"^\s*$(\n|\r|\r\n)", "", RegexOptions.Multiline);
                richTextBox_player.SaveFile(path_player, RichTextBoxStreamType.PlainText);

                var contents = File.ReadAllLines(path_player);
                Array.Sort(contents);
                File.WriteAllLines(path_player, contents);

                richTextBox_player.Text = "";
                richTextBox_player.Text = File.ReadAllText(path_player).Trim();

                if (isNoPlayerList)
                {
                    pictureBox_loader.Visible = true;
                    isNoPlayerList = false;
                    webBrowser.Visible = false;
                    panel_settings.Visible = true;
                    groupBox_settings.Enabled = true;
                    groupBox_maintenance.Enabled = true;
                    groupBox_result.Enabled = true;
                    label_fetchedtime_1.Enabled = true;
                    label_fetchedtime.Enabled = true;

                    string line;
                    StreamReader streamReader = new StreamReader(path_player);
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        if (line.Length > 0)
                        {
                            player_list.Add(line.Trim());
                        }
                    }
                    streamReader.Close();
                    
                    timer_reload.Stop();
                    webBrowser.Navigate("http://cs.ying168.bet/player/list");
                }

                MessageBox.Show("Changes applied.");
            }
            else
            {
                MessageBox.Show("Required to have player username.");
            }
        }

        private void timer_reload_Tick(object sender, EventArgs e)
        {
            timer_reload.Stop();
            webBrowser.Navigate("http://cs.ying168.bet/player/list");
        }

        private void pictureBox_loader_Click(object sender, EventArgs e)
        {

        }

        private void timer_detect_Tick(object sender, EventArgs e)
        {
            timer_detect.Stop();
            webBrowser.Navigate("http://cs.ying168.bet/player/list");
        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Exit the program?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void dataGridView_result_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            try
            {
                e.SortResult = Compare(e.CellValue1.ToString(), e.CellValue2.ToString());
            }
            catch (Exception err)
            {
                //MessageBox.Show(err.ToString());
            }
        }

        private int Compare(string a, string b)
        {
            return decimal.Parse(a).CompareTo(decimal.Parse(b));
        }
    }
}
