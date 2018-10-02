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
            this.timer_search_preview = new System.Windows.Forms.Timer(this.components);
            this.timer_view_player = new System.Windows.Forms.Timer(this.components);
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.panel_settings = new System.Windows.Forms.Panel();
            this.groupBox_maintenance = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox_loader = new System.Windows.Forms.PictureBox();
            this.groupBox_result = new System.Windows.Forms.GroupBox();
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
            this.timer_get_value = new System.Windows.Forms.Timer(this.components);
            this.panel_settings.SuspendLayout();
            this.groupBox_maintenance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loader)).BeginInit();
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
            // timer_view_player
            // 
            this.timer_view_player.Interval = 3000;
            this.timer_view_player.Tick += new System.EventHandler(this.timer_view_player_Tick);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(792, 368);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // panel_settings
            // 
            this.panel_settings.Controls.Add(this.groupBox_maintenance);
            this.panel_settings.Controls.Add(this.pictureBox_loader);
            this.panel_settings.Controls.Add(this.groupBox_result);
            this.panel_settings.Controls.Add(this.groupBox_settings);
            this.panel_settings.Location = new System.Drawing.Point(1, 1);
            this.panel_settings.Name = "panel_settings";
            this.panel_settings.Size = new System.Drawing.Size(791, 368);
            this.panel_settings.TabIndex = 5;
            this.panel_settings.Visible = false;
            // 
            // groupBox_maintenance
            // 
            this.groupBox_maintenance.Controls.Add(this.dataGridView1);
            this.groupBox_maintenance.Location = new System.Drawing.Point(36, 176);
            this.groupBox_maintenance.Name = "groupBox_maintenance";
            this.groupBox_maintenance.Size = new System.Drawing.Size(262, 146);
            this.groupBox_maintenance.TabIndex = 6;
            this.groupBox_maintenance.TabStop = false;
            this.groupBox_maintenance.Text = "Maintenance";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.Location = new System.Drawing.Point(11, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(240, 115);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Game Provider";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // pictureBox_loader
            // 
            this.pictureBox_loader.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_loader.Image")));
            this.pictureBox_loader.Location = new System.Drawing.Point(723, 9);
            this.pictureBox_loader.Name = "pictureBox_loader";
            this.pictureBox_loader.Size = new System.Drawing.Size(59, 37);
            this.pictureBox_loader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_loader.TabIndex = 7;
            this.pictureBox_loader.TabStop = false;
            // 
            // groupBox_result
            // 
            this.groupBox_result.Controls.Add(this.dataGridView_result);
            this.groupBox_result.Location = new System.Drawing.Point(334, 57);
            this.groupBox_result.Name = "groupBox_result";
            this.groupBox_result.Size = new System.Drawing.Size(419, 265);
            this.groupBox_result.TabIndex = 6;
            this.groupBox_result.TabStop = false;
            this.groupBox_result.Text = "Result";
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
            this.dataGridView_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.main_wallet,
            this.gp_wallet,
            this.total});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_result.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_result.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView_result.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_result.Name = "dataGridView_result";
            this.dataGridView_result.ReadOnly = true;
            this.dataGridView_result.RowHeadersVisible = false;
            this.dataGridView_result.Size = new System.Drawing.Size(406, 240);
            this.dataGridView_result.TabIndex = 2;
            this.dataGridView_result.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_result_CellContentClick);
            this.dataGridView_result.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_result_DataBindingComplete);
            // 
            // username
            // 
            this.username.FillWeight = 88.64321F;
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // main_wallet
            // 
            this.main_wallet.FillWeight = 104.0067F;
            this.main_wallet.HeaderText = "Main Wallet";
            this.main_wallet.Name = "main_wallet";
            this.main_wallet.ReadOnly = true;
            // 
            // gp_wallet
            // 
            this.gp_wallet.FillWeight = 107.5971F;
            this.gp_wallet.HeaderText = "GP Wallet";
            this.gp_wallet.Name = "gp_wallet";
            this.gp_wallet.ReadOnly = true;
            // 
            // total
            // 
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
            this.groupBox_settings.Location = new System.Drawing.Point(36, 57);
            this.groupBox_settings.Name = "groupBox_settings";
            this.groupBox_settings.Size = new System.Drawing.Size(262, 113);
            this.groupBox_settings.TabIndex = 5;
            this.groupBox_settings.TabStop = false;
            this.groupBox_settings.Text = "Settings";
            // 
            // button_apply
            // 
            this.button_apply.Location = new System.Drawing.Point(210, 76);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(41, 23);
            this.button_apply.TabIndex = 4;
            this.button_apply.Text = "Apply";
            this.button_apply.UseVisualStyleBackColor = true;
            // 
            // textBox_seconds
            // 
            this.textBox_seconds.Location = new System.Drawing.Point(139, 50);
            this.textBox_seconds.Name = "textBox_seconds";
            this.textBox_seconds.Size = new System.Drawing.Size(112, 20);
            this.textBox_seconds.TabIndex = 3;
            this.textBox_seconds.Text = "30";
            // 
            // label_seconds
            // 
            this.label_seconds.AutoSize = true;
            this.label_seconds.Location = new System.Drawing.Point(8, 53);
            this.label_seconds.Name = "label_seconds";
            this.label_seconds.Size = new System.Drawing.Size(128, 13);
            this.label_seconds.TabIndex = 2;
            this.label_seconds.Text = "Refresh rate (in seconds):";
            // 
            // textBox_threshold
            // 
            this.textBox_threshold.Location = new System.Drawing.Point(139, 24);
            this.textBox_threshold.Name = "textBox_threshold";
            this.textBox_threshold.Size = new System.Drawing.Size(112, 20);
            this.textBox_threshold.TabIndex = 1;
            this.textBox_threshold.Text = "1000";
            // 
            // label_threshold
            // 
            this.label_threshold.AutoSize = true;
            this.label_threshold.Location = new System.Drawing.Point(7, 27);
            this.label_threshold.Name = "label_threshold";
            this.label_threshold.Size = new System.Drawing.Size(57, 13);
            this.label_threshold.TabIndex = 0;
            this.label_threshold.Text = "Threshold:";
            // 
            // timer_get_value
            // 
            this.timer_get_value.Interval = 10000;
            this.timer_get_value.Tick += new System.EventHandler(this.timer_get_value_Tick);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(791, 367);
            this.Controls.Add(this.panel_settings);
            this.Controls.Add(this.webBrowser);
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Altas Eyes";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.panel_settings.ResumeLayout(false);
            this.groupBox_maintenance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loader)).EndInit();
            this.groupBox_result.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_result)).EndInit();
            this.groupBox_settings.ResumeLayout(false);
            this.groupBox_settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer_search_preview;
        private System.Windows.Forms.Timer timer_view_player;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn main_wallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn gp_wallet;
        private System.Windows.Forms.GroupBox groupBox_maintenance;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Timer timer_get_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}

