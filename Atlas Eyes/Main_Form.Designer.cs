namespace Atlas_Eyes
{
    partial class Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer_search_preview = new System.Windows.Forms.Timer(this.components);
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.panel_settings = new System.Windows.Forms.Panel();
            this.pictureBox_loader = new System.Windows.Forms.PictureBox();
            this.label_fetchedtime_1 = new System.Windows.Forms.Label();
            this.groupBox_player = new System.Windows.Forms.GroupBox();
            this.button_save = new System.Windows.Forms.Button();
            this.richTextBox_player = new System.Windows.Forms.RichTextBox();
            this.label_timer = new System.Windows.Forms.Label();
            this.label_fetchedtime = new System.Windows.Forms.Label();
            this.groupBox_maintenance = new System.Windows.Forms.GroupBox();
            this.label_maintenance = new System.Windows.Forms.Label();
            this.dataGridView_maintenance = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_result = new System.Windows.Forms.GroupBox();
            this.label_result = new System.Windows.Forms.Label();
            this.dataGridView_result = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.main_wallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gp_wallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_settings = new System.Windows.Forms.GroupBox();
            this.button_apply = new System.Windows.Forms.Button();
            this.textBox_seconds = new System.Windows.Forms.TextBox();
            this.label_seconds = new System.Windows.Forms.Label();
            this.textBox_threshold = new System.Windows.Forms.TextBox();
            this.label_threshold = new System.Windows.Forms.Label();
            this.timer_get_data = new System.Windows.Forms.Timer(this.components);
            this.timer_refreshrate = new System.Windows.Forms.Timer(this.components);
            this.timer_reload = new System.Windows.Forms.Timer(this.components);
            this.timer_detect = new System.Windows.Forms.Timer(this.components);
            this.panel_settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loader)).BeginInit();
            this.groupBox_player.SuspendLayout();
            this.groupBox_maintenance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_maintenance)).BeginInit();
            this.groupBox_result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_result)).BeginInit();
            this.groupBox_settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_search_preview
            // 
            this.timer_search_preview.Interval = 3000;
            this.timer_search_preview.Tick += new System.EventHandler(this.timer_search_preview_Tick);
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(976, 373);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.WebBrowserShortcutsEnabled = false;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // panel_settings
            // 
            this.panel_settings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_settings.Controls.Add(this.pictureBox_loader);
            this.panel_settings.Controls.Add(this.label_fetchedtime_1);
            this.panel_settings.Controls.Add(this.groupBox_player);
            this.panel_settings.Controls.Add(this.label_timer);
            this.panel_settings.Controls.Add(this.label_fetchedtime);
            this.panel_settings.Controls.Add(this.groupBox_maintenance);
            this.panel_settings.Controls.Add(this.groupBox_result);
            this.panel_settings.Controls.Add(this.groupBox_settings);
            this.panel_settings.Location = new System.Drawing.Point(1, 1);
            this.panel_settings.Name = "panel_settings";
            this.panel_settings.Size = new System.Drawing.Size(974, 371);
            this.panel_settings.TabIndex = 5;
            this.panel_settings.Visible = false;
            // 
            // pictureBox_loader
            // 
            this.pictureBox_loader.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_loader.Image")));
            this.pictureBox_loader.Location = new System.Drawing.Point(898, 9);
            this.pictureBox_loader.Name = "pictureBox_loader";
            this.pictureBox_loader.Size = new System.Drawing.Size(59, 37);
            this.pictureBox_loader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_loader.TabIndex = 7;
            this.pictureBox_loader.TabStop = false;
            this.pictureBox_loader.Visible = false;
            this.pictureBox_loader.Click += new System.EventHandler(this.pictureBox_loader_Click);
            // 
            // label_fetchedtime_1
            // 
            this.label_fetchedtime_1.AutoSize = true;
            this.label_fetchedtime_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fetchedtime_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_fetchedtime_1.Location = new System.Drawing.Point(18, 17);
            this.label_fetchedtime_1.Name = "label_fetchedtime_1";
            this.label_fetchedtime_1.Size = new System.Drawing.Size(142, 18);
            this.label_fetchedtime_1.TabIndex = 10;
            this.label_fetchedtime_1.Text = "Last fetched time:";
            // 
            // groupBox_player
            // 
            this.groupBox_player.Controls.Add(this.button_save);
            this.groupBox_player.Controls.Add(this.richTextBox_player);
            this.groupBox_player.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_player.Location = new System.Drawing.Point(311, 52);
            this.groupBox_player.Name = "groupBox_player";
            this.groupBox_player.Size = new System.Drawing.Size(202, 296);
            this.groupBox_player.TabIndex = 6;
            this.groupBox_player.TabStop = false;
            this.groupBox_player.Text = "Player Username List";
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.White;
            this.button_save.Location = new System.Drawing.Point(57, 259);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(90, 25);
            this.button_save.TabIndex = 7;
            this.button_save.Text = "SAVE";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // richTextBox_player
            // 
            this.richTextBox_player.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_player.Location = new System.Drawing.Point(6, 19);
            this.richTextBox_player.Name = "richTextBox_player";
            this.richTextBox_player.Size = new System.Drawing.Size(190, 231);
            this.richTextBox_player.TabIndex = 6;
            this.richTextBox_player.Text = "";
            this.richTextBox_player.WordWrap = false;
            // 
            // label_timer
            // 
            this.label_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_timer.Location = new System.Drawing.Point(880, 10);
            this.label_timer.Name = "label_timer";
            this.label_timer.Size = new System.Drawing.Size(78, 34);
            this.label_timer.TabIndex = 9;
            this.label_timer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_timer.Visible = false;
            // 
            // label_fetchedtime
            // 
            this.label_fetchedtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fetchedtime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_fetchedtime.Location = new System.Drawing.Point(151, 17);
            this.label_fetchedtime.Name = "label_fetchedtime";
            this.label_fetchedtime.Size = new System.Drawing.Size(60, 18);
            this.label_fetchedtime.TabIndex = 8;
            this.label_fetchedtime.Text = "-";
            this.label_fetchedtime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_maintenance
            // 
            this.groupBox_maintenance.Controls.Add(this.label_maintenance);
            this.groupBox_maintenance.Controls.Add(this.dataGridView_maintenance);
            this.groupBox_maintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_maintenance.Location = new System.Drawing.Point(19, 208);
            this.groupBox_maintenance.Name = "groupBox_maintenance";
            this.groupBox_maintenance.Size = new System.Drawing.Size(273, 140);
            this.groupBox_maintenance.TabIndex = 6;
            this.groupBox_maintenance.TabStop = false;
            this.groupBox_maintenance.Text = "Game Provider Under Maintenance";
            // 
            // label_maintenance
            // 
            this.label_maintenance.AutoSize = true;
            this.label_maintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_maintenance.Location = new System.Drawing.Point(8, 21);
            this.label_maintenance.Name = "label_maintenance";
            this.label_maintenance.Size = new System.Drawing.Size(143, 15);
            this.label_maintenance.TabIndex = 4;
            this.label_maintenance.Text = "No current data available";
            // 
            // dataGridView_maintenance
            // 
            this.dataGridView_maintenance.AllowUserToAddRows = false;
            this.dataGridView_maintenance.AllowUserToDeleteRows = false;
            this.dataGridView_maintenance.AllowUserToResizeColumns = false;
            this.dataGridView_maintenance.AllowUserToResizeRows = false;
            this.dataGridView_maintenance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_maintenance.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_maintenance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_maintenance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(30)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_maintenance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_maintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_maintenance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_maintenance.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_maintenance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_maintenance.Location = new System.Drawing.Point(3, 18);
            this.dataGridView_maintenance.Name = "dataGridView_maintenance";
            this.dataGridView_maintenance.ReadOnly = true;
            this.dataGridView_maintenance.RowHeadersVisible = false;
            this.dataGridView_maintenance.Size = new System.Drawing.Size(267, 119);
            this.dataGridView_maintenance.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // groupBox_result
            // 
            this.groupBox_result.Controls.Add(this.label_result);
            this.groupBox_result.Controls.Add(this.dataGridView_result);
            this.groupBox_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_result.Location = new System.Drawing.Point(532, 52);
            this.groupBox_result.Name = "groupBox_result";
            this.groupBox_result.Size = new System.Drawing.Size(419, 296);
            this.groupBox_result.TabIndex = 6;
            this.groupBox_result.TabStop = false;
            this.groupBox_result.Text = "Result";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_result.Location = new System.Drawing.Point(7, 45);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(143, 15);
            this.label_result.TabIndex = 3;
            this.label_result.Text = "No current data available";
            // 
            // dataGridView_result
            // 
            this.dataGridView_result.AllowUserToAddRows = false;
            this.dataGridView_result.AllowUserToDeleteRows = false;
            this.dataGridView_result.AllowUserToOrderColumns = true;
            this.dataGridView_result.AllowUserToResizeRows = false;
            this.dataGridView_result.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_result.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_result.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.main_wallet,
            this.gp_wallet,
            this.total});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_result.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_result.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView_result.Location = new System.Drawing.Point(3, 18);
            this.dataGridView_result.Name = "dataGridView_result";
            this.dataGridView_result.ReadOnly = true;
            this.dataGridView_result.RowHeadersVisible = false;
            this.dataGridView_result.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_result.Size = new System.Drawing.Size(413, 275);
            this.dataGridView_result.TabIndex = 2;
            this.dataGridView_result.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_result_CellContentClick);
            this.dataGridView_result.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_result_DataBindingComplete);
            this.dataGridView_result.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dataGridView_result_SortCompare);
            // 
            // username
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.username.DefaultCellStyle = dataGridViewCellStyle4;
            this.username.FillWeight = 88.64321F;
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // main_wallet
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.main_wallet.DefaultCellStyle = dataGridViewCellStyle5;
            this.main_wallet.FillWeight = 104.0067F;
            this.main_wallet.HeaderText = "Main Wallet";
            this.main_wallet.Name = "main_wallet";
            this.main_wallet.ReadOnly = true;
            // 
            // gp_wallet
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.gp_wallet.DefaultCellStyle = dataGridViewCellStyle6;
            this.gp_wallet.FillWeight = 107.5971F;
            this.gp_wallet.HeaderText = "GP Wallet";
            this.gp_wallet.Name = "gp_wallet";
            this.gp_wallet.ReadOnly = true;
            // 
            // total
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.total.DefaultCellStyle = dataGridViewCellStyle7;
            this.total.FillWeight = 99.75311F;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // groupBox_settings
            // 
            this.groupBox_settings.Controls.Add(this.button_apply);
            this.groupBox_settings.Controls.Add(this.textBox_seconds);
            this.groupBox_settings.Controls.Add(this.label_seconds);
            this.groupBox_settings.Controls.Add(this.textBox_threshold);
            this.groupBox_settings.Controls.Add(this.label_threshold);
            this.groupBox_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_settings.Location = new System.Drawing.Point(19, 52);
            this.groupBox_settings.Name = "groupBox_settings";
            this.groupBox_settings.Size = new System.Drawing.Size(273, 140);
            this.groupBox_settings.TabIndex = 5;
            this.groupBox_settings.TabStop = false;
            this.groupBox_settings.Text = "Settings";
            // 
            // button_apply
            // 
            this.button_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_apply.ForeColor = System.Drawing.Color.White;
            this.button_apply.Location = new System.Drawing.Point(164, 93);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(90, 25);
            this.button_apply.TabIndex = 4;
            this.button_apply.Text = "APPLY";
            this.button_apply.UseVisualStyleBackColor = false;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // textBox_seconds
            // 
            this.textBox_seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_seconds.Location = new System.Drawing.Point(164, 65);
            this.textBox_seconds.Multiline = true;
            this.textBox_seconds.Name = "textBox_seconds";
            this.textBox_seconds.Size = new System.Drawing.Size(90, 22);
            this.textBox_seconds.TabIndex = 3;
            // 
            // label_seconds
            // 
            this.label_seconds.AutoSize = true;
            this.label_seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_seconds.Location = new System.Drawing.Point(13, 68);
            this.label_seconds.Name = "label_seconds";
            this.label_seconds.Size = new System.Drawing.Size(147, 15);
            this.label_seconds.TabIndex = 2;
            this.label_seconds.Text = "Refresh rate (in seconds):";
            // 
            // textBox_threshold
            // 
            this.textBox_threshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_threshold.Location = new System.Drawing.Point(165, 36);
            this.textBox_threshold.Multiline = true;
            this.textBox_threshold.Name = "textBox_threshold";
            this.textBox_threshold.Size = new System.Drawing.Size(89, 23);
            this.textBox_threshold.TabIndex = 1;
            // 
            // label_threshold
            // 
            this.label_threshold.AutoSize = true;
            this.label_threshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_threshold.Location = new System.Drawing.Point(13, 42);
            this.label_threshold.Name = "label_threshold";
            this.label_threshold.Size = new System.Drawing.Size(65, 15);
            this.label_threshold.TabIndex = 0;
            this.label_threshold.Text = "Threshold:";
            // 
            // timer_get_data
            // 
            this.timer_get_data.Interval = 2000;
            this.timer_get_data.Tick += new System.EventHandler(this.timer_get_data_TickAsync);
            // 
            // timer_refreshrate
            // 
            this.timer_refreshrate.Interval = 1000;
            this.timer_refreshrate.Tick += new System.EventHandler(this.timer_refreshrate_Tick);
            // 
            // timer_reload
            // 
            this.timer_reload.Interval = 10000;
            this.timer_reload.Tick += new System.EventHandler(this.timer_reload_Tick);
            // 
            // timer_detect
            // 
            this.timer_detect.Interval = 30000;
            this.timer_detect.Tick += new System.EventHandler(this.timer_detect_Tick);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(976, 373);
            this.Controls.Add(this.panel_settings);
            this.Controls.Add(this.webBrowser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(992, 412);
            this.MinimumSize = new System.Drawing.Size(992, 412);
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TF Atlas Eyes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_FormClosing);
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.panel_settings.ResumeLayout(false);
            this.panel_settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loader)).EndInit();
            this.groupBox_player.ResumeLayout(false);
            this.groupBox_maintenance.ResumeLayout(false);
            this.groupBox_maintenance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_maintenance)).EndInit();
            this.groupBox_result.ResumeLayout(false);
            this.groupBox_result.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_result)).EndInit();
            this.groupBox_settings.ResumeLayout(false);
            this.groupBox_settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer_search_preview;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Panel panel_settings;
        private System.Windows.Forms.GroupBox groupBox_result;
        private System.Windows.Forms.DataGridView dataGridView_result;
        private System.Windows.Forms.GroupBox groupBox_settings;
        private System.Windows.Forms.TextBox textBox_seconds;
        private System.Windows.Forms.Label label_seconds;
        private System.Windows.Forms.TextBox textBox_threshold;
        private System.Windows.Forms.Label label_threshold;
        private System.Windows.Forms.PictureBox pictureBox_loader;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.GroupBox groupBox_maintenance;
        private System.Windows.Forms.DataGridView dataGridView_maintenance;
        private System.Windows.Forms.Timer timer_get_data;
        private System.Windows.Forms.Label label_maintenance;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label_fetchedtime;
        private System.Windows.Forms.Timer timer_refreshrate;
        private System.Windows.Forms.Label label_timer;
        private System.Windows.Forms.RichTextBox richTextBox_player;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.GroupBox groupBox_player;
        private System.Windows.Forms.Timer timer_reload;
        private System.Windows.Forms.Label label_fetchedtime_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn main_wallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn gp_wallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Timer timer_detect;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}

