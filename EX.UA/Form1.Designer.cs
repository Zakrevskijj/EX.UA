namespace EX.UA
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.OKButtn = new System.Windows.Forms.Button();
            this.FilmTxtbox = new System.Windows.Forms.TextBox();
            this.FilmName = new System.Windows.Forms.Label();
            this.Interval = new System.Windows.Forms.Label();
            this.IntervalBox = new System.Windows.Forms.ComboBox();
            this.ActivateBtn = new System.Windows.Forms.Button();
            this.AddingFilm = new System.Windows.Forms.GroupBox();
            this.Hours = new System.Windows.Forms.Label();
            this.FilmsTable = new System.Windows.Forms.DataGridView();
            this.NameFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.repeatSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayBtn = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ResultsTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SucLabel = new System.Windows.Forms.Label();
            this.ErrLabel = new System.Windows.Forms.Label();
            this.SucBox = new System.Windows.Forms.TextBox();
            this.ErrBox = new System.Windows.Forms.TextBox();
            this.GUI = new System.Windows.Forms.Timer(this.components);
            this.Stats = new System.Windows.Forms.GroupBox();
            this.CurFilm = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ClearLogBtn = new System.Windows.Forms.Button();
            this.ViewLogBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddingFilm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FilmsTable)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsTable)).BeginInit();
            this.Stats.SuspendLayout();
            this.CurFilm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OKButtn
            // 
            this.OKButtn.Location = new System.Drawing.Point(403, 16);
            this.OKButtn.Name = "OKButtn";
            this.OKButtn.Size = new System.Drawing.Size(55, 36);
            this.OKButtn.TabIndex = 0;
            this.OKButtn.Text = "OK";
            this.OKButtn.UseVisualStyleBackColor = true;
            this.OKButtn.Click += new System.EventHandler(this.OKButtn_Click);
            // 
            // FilmTxtbox
            // 
            this.FilmTxtbox.Location = new System.Drawing.Point(61, 25);
            this.FilmTxtbox.Name = "FilmTxtbox";
            this.FilmTxtbox.Size = new System.Drawing.Size(159, 20);
            this.FilmTxtbox.TabIndex = 1;
            this.FilmTxtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilmTxtbox_KeyDown);
            // 
            // FilmName
            // 
            this.FilmName.AutoSize = true;
            this.FilmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilmName.Location = new System.Drawing.Point(6, 26);
            this.FilmName.Name = "FilmName";
            this.FilmName.Size = new System.Drawing.Size(49, 17);
            this.FilmName.TabIndex = 2;
            this.FilmName.Text = "Name:";
            // 
            // Interval
            // 
            this.Interval.AutoSize = true;
            this.Interval.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Interval.Location = new System.Drawing.Point(226, 26);
            this.Interval.Name = "Interval";
            this.Interval.Size = new System.Drawing.Size(58, 17);
            this.Interval.TabIndex = 3;
            this.Interval.Text = "Interval:";
            // 
            // IntervalBox
            // 
            this.IntervalBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IntervalBox.FormattingEnabled = true;
            this.IntervalBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.IntervalBox.Location = new System.Drawing.Point(281, 25);
            this.IntervalBox.Name = "IntervalBox";
            this.IntervalBox.Size = new System.Drawing.Size(59, 21);
            this.IntervalBox.TabIndex = 4;
            // 
            // ActivateBtn
            // 
            this.ActivateBtn.FlatAppearance.BorderSize = 0;
            this.ActivateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActivateBtn.Location = new System.Drawing.Point(261, 15);
            this.ActivateBtn.Name = "ActivateBtn";
            this.ActivateBtn.Size = new System.Drawing.Size(76, 40);
            this.ActivateBtn.TabIndex = 5;
            this.ActivateBtn.Text = "Turn off";
            this.ActivateBtn.UseVisualStyleBackColor = true;
            this.ActivateBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddingFilm
            // 
            this.AddingFilm.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.AddingFilm.Controls.Add(this.Hours);
            this.AddingFilm.Controls.Add(this.FilmName);
            this.AddingFilm.Controls.Add(this.OKButtn);
            this.AddingFilm.Controls.Add(this.IntervalBox);
            this.AddingFilm.Controls.Add(this.FilmTxtbox);
            this.AddingFilm.Controls.Add(this.Interval);
            this.AddingFilm.Location = new System.Drawing.Point(334, 0);
            this.AddingFilm.Name = "AddingFilm";
            this.AddingFilm.Size = new System.Drawing.Size(479, 65);
            this.AddingFilm.TabIndex = 6;
            this.AddingFilm.TabStop = false;
            this.AddingFilm.Text = "Adding film";
            // 
            // Hours
            // 
            this.Hours.AutoSize = true;
            this.Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hours.Location = new System.Drawing.Point(346, 26);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(54, 17);
            this.Hours.TabIndex = 5;
            this.Hours.Text = "hour(s)";
            // 
            // FilmsTable
            // 
            this.FilmsTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
            this.FilmsTable.AllowUserToAddRows = false;
            this.FilmsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FilmsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilmsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameFilm,
            this.Interv});
            this.FilmsTable.ContextMenuStrip = this.contextMenuStrip1;
            this.FilmsTable.Location = new System.Drawing.Point(-3, 0);
            this.FilmsTable.Name = "FilmsTable";
            this.FilmsTable.ReadOnly = true;
            this.FilmsTable.Size = new System.Drawing.Size(337, 146);
            this.FilmsTable.TabIndex = 7;
            this.FilmsTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.FilmsTable_CellMouseDoubleClick);
            this.FilmsTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.FilmsTable_RowsAdded);
            this.FilmsTable.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // NameFilm
            // 
            this.NameFilm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameFilm.HeaderText = "Name";
            this.NameFilm.Name = "NameFilm";
            this.NameFilm.ReadOnly = true;
            // 
            // Interv
            // 
            this.Interv.HeaderText = "Interval";
            this.Interv.Name = "Interv";
            this.Interv.ReadOnly = true;
            this.Interv.Width = 45;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repeatSearchToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 26);
            // 
            // repeatSearchToolStripMenuItem
            // 
            this.repeatSearchToolStripMenuItem.Name = "repeatSearchToolStripMenuItem";
            this.repeatSearchToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.repeatSearchToolStripMenuItem.Text = "RepeatSearch";
            this.repeatSearchToolStripMenuItem.Click += new System.EventHandler(this.repeatSearchToolStripMenuItem_Click);
            // 
            // TrayBtn
            // 
            this.TrayBtn.FlatAppearance.BorderSize = 0;
            this.TrayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrayBtn.Location = new System.Drawing.Point(190, 15);
            this.TrayBtn.Name = "TrayBtn";
            this.TrayBtn.Size = new System.Drawing.Size(65, 40);
            this.TrayBtn.TabIndex = 8;
            this.TrayBtn.Text = "Tray";
            this.TrayBtn.UseVisualStyleBackColor = true;
            this.TrayBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Ex.ua Programm";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // ResultsTable
            // 
            this.ResultsTable.AllowUserToAddRows = false;
            this.ResultsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.ResultsTable.Location = new System.Drawing.Point(-2, 146);
            this.ResultsTable.Name = "ResultsTable";
            this.ResultsTable.ReadOnly = true;
            this.ResultsTable.Size = new System.Drawing.Size(473, 256);
            this.ResultsTable.TabIndex = 9;
            this.ResultsTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ResultsTable_CellMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // SucLabel
            // 
            this.SucLabel.AutoSize = true;
            this.SucLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SucLabel.Location = new System.Drawing.Point(6, 16);
            this.SucLabel.Name = "SucLabel";
            this.SucLabel.Size = new System.Drawing.Size(75, 17);
            this.SucLabel.TabIndex = 10;
            this.SucLabel.Text = "Succeded:";
            // 
            // ErrLabel
            // 
            this.ErrLabel.AutoSize = true;
            this.ErrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrLabel.Location = new System.Drawing.Point(6, 42);
            this.ErrLabel.Name = "ErrLabel";
            this.ErrLabel.Size = new System.Drawing.Size(51, 17);
            this.ErrLabel.TabIndex = 11;
            this.ErrLabel.Text = "Errors:";
            // 
            // SucBox
            // 
            this.SucBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.SucBox.Location = new System.Drawing.Point(87, 16);
            this.SucBox.Name = "SucBox";
            this.SucBox.ReadOnly = true;
            this.SucBox.Size = new System.Drawing.Size(43, 20);
            this.SucBox.TabIndex = 12;
            // 
            // ErrBox
            // 
            this.ErrBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ErrBox.Location = new System.Drawing.Point(87, 39);
            this.ErrBox.Name = "ErrBox";
            this.ErrBox.ReadOnly = true;
            this.ErrBox.Size = new System.Drawing.Size(43, 20);
            this.ErrBox.TabIndex = 13;
            // 
            // GUI
            // 
            this.GUI.Enabled = true;
            this.GUI.Interval = 1000;
            this.GUI.Tick += new System.EventHandler(this.GUI_Tick);
            // 
            // Stats
            // 
            this.Stats.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Stats.Controls.Add(this.SucLabel);
            this.Stats.Controls.Add(this.ErrBox);
            this.Stats.Controls.Add(this.ErrLabel);
            this.Stats.Controls.Add(this.SucBox);
            this.Stats.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Stats.Location = new System.Drawing.Point(334, 65);
            this.Stats.Name = "Stats";
            this.Stats.Size = new System.Drawing.Size(137, 81);
            this.Stats.TabIndex = 14;
            this.Stats.TabStop = false;
            this.Stats.Text = "Stats";
            // 
            // CurFilm
            // 
            this.CurFilm.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CurFilm.Controls.Add(this.pictureBox1);
            this.CurFilm.Controls.Add(this.richTextBox1);
            this.CurFilm.Controls.Add(this.label1);
            this.CurFilm.Controls.Add(this.linkLabel1);
            this.CurFilm.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CurFilm.Location = new System.Drawing.Point(470, 65);
            this.CurFilm.Name = "CurFilm";
            this.CurFilm.Size = new System.Drawing.Size(343, 279);
            this.CurFilm.TabIndex = 15;
            this.CurFilm.TabStop = false;
            this.CurFilm.Text = "Current film";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(196, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(6, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(185, 194);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(14, 248);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ClearLogBtn
            // 
            this.ClearLogBtn.FlatAppearance.BorderSize = 0;
            this.ClearLogBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearLogBtn.Location = new System.Drawing.Point(93, 15);
            this.ClearLogBtn.Name = "ClearLogBtn";
            this.ClearLogBtn.Size = new System.Drawing.Size(92, 40);
            this.ClearLogBtn.TabIndex = 16;
            this.ClearLogBtn.Text = "Clear log";
            this.ClearLogBtn.UseVisualStyleBackColor = true;
            this.ClearLogBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // ViewLogBtn
            // 
            this.ViewLogBtn.FlatAppearance.BorderSize = 0;
            this.ViewLogBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewLogBtn.Location = new System.Drawing.Point(6, 15);
            this.ViewLogBtn.Name = "ViewLogBtn";
            this.ViewLogBtn.Size = new System.Drawing.Size(81, 40);
            this.ViewLogBtn.TabIndex = 17;
            this.ViewLogBtn.Text = "View log";
            this.ViewLogBtn.UseVisualStyleBackColor = true;
            this.ViewLogBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.ViewLogBtn);
            this.groupBox1.Controls.Add(this.ActivateBtn);
            this.groupBox1.Controls.Add(this.TrayBtn);
            this.groupBox1.Controls.Add(this.ClearLogBtn);
            this.groupBox1.Location = new System.Drawing.Point(470, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 58);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(810, 402);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CurFilm);
            this.Controls.Add(this.Stats);
            this.Controls.Add(this.FilmsTable);
            this.Controls.Add(this.AddingFilm);
            this.Controls.Add(this.ResultsTable);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EX.UA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AddingFilm.ResumeLayout(false);
            this.AddingFilm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FilmsTable)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResultsTable)).EndInit();
            this.Stats.ResumeLayout(false);
            this.Stats.PerformLayout();
            this.CurFilm.ResumeLayout(false);
            this.CurFilm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OKButtn;
        private System.Windows.Forms.TextBox FilmTxtbox;
        private System.Windows.Forms.Label FilmName;
        private System.Windows.Forms.Label Interval;
        private System.Windows.Forms.ComboBox IntervalBox;
        private System.Windows.Forms.Button ActivateBtn;
        private System.Windows.Forms.GroupBox AddingFilm;
        private System.Windows.Forms.DataGridView FilmsTable;
        private System.Windows.Forms.Button TrayBtn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label Hours;
        private System.Windows.Forms.DataGridView ResultsTable;
        private System.Windows.Forms.Label SucLabel;
        private System.Windows.Forms.Label ErrLabel;
        private System.Windows.Forms.TextBox SucBox;
        private System.Windows.Forms.TextBox ErrBox;
        private System.Windows.Forms.Timer GUI;
        private System.Windows.Forms.GroupBox Stats;
        private System.Windows.Forms.GroupBox CurFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button ClearLogBtn;
        private System.Windows.Forms.Button ViewLogBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem repeatSearchToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

