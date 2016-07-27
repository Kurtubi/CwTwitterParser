namespace TwitterParser
{
    partial class frmTwitterParserPanel
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listTopic = new TwitterParser.CwFileListView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UserPageGoGitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showTweetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.textAnahtarKelime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textHashTag = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.wbrowserTweet = new System.Windows.Forms.WebBrowser();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AllowDrop = true;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AllowDrop = true;
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(1018, 561);
            this.splitContainer1.SplitterDistance = 229;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listTopic);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // listTopic
            // 
            this.listTopic.AllowDrop = true;
            this.listTopic.ContextMenuStrip = this.contextMenuStrip;
            this.listTopic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listTopic.FullRowSelect = true;
            this.listTopic.GridLines = true;
            this.listTopic.Location = new System.Drawing.Point(3, 85);
            this.listTopic.Name = "listTopic";
            this.listTopic.Size = new System.Drawing.Size(1012, 141);
            this.listTopic.TabIndex = 8;
            this.listTopic.UseCompatibleStateImageBehavior = false;
            this.listTopic.View = System.Windows.Forms.View.Details;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserPageGoGitToolStripMenuItem,
            this.toolStripSeparator1,
            this.showTweetToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(189, 54);
            // 
            // UserPageGoGitToolStripMenuItem
            // 
            this.UserPageGoGitToolStripMenuItem.Name = "UserPageGoGitToolStripMenuItem";
            this.UserPageGoGitToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.UserPageGoGitToolStripMenuItem.Text = "Kullanıcı Sayfasına git";
            this.UserPageGoGitToolStripMenuItem.Click += new System.EventHandler(this.UserPageGoGitToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // showTweetToolStripMenuItem
            // 
            this.showTweetToolStripMenuItem.Name = "showTweetToolStripMenuItem";
            this.showTweetToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.showTweetToolStripMenuItem.Text = "Tweeti Görüntüle";
            this.showTweetToolStripMenuItem.Click += new System.EventHandler(this.showTweetToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBrowser);
            this.groupBox2.Controls.Add(this.textAnahtarKelime);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textHashTag);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1012, 69);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(362, 12);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(75, 46);
            this.btnBrowser.TabIndex = 4;
            this.btnBrowser.Text = "Ara";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // textAnahtarKelime
            // 
            this.textAnahtarKelime.Location = new System.Drawing.Point(92, 38);
            this.textAnahtarKelime.Name = "textAnahtarKelime";
            this.textAnahtarKelime.Size = new System.Drawing.Size(264, 20);
            this.textAnahtarKelime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aranacak Kelime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hashtag Adı";
            // 
            // textHashTag
            // 
            this.textHashTag.Location = new System.Drawing.Point(92, 12);
            this.textHashTag.Name = "textHashTag";
            this.textHashTag.Size = new System.Drawing.Size(264, 20);
            this.textHashTag.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.wbrowserTweet);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1018, 328);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // wbrowserTweet
            // 
            this.wbrowserTweet.ContextMenuStrip = this.contextMenuStrip;
            this.wbrowserTweet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbrowserTweet.Location = new System.Drawing.Point(3, 16);
            this.wbrowserTweet.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbrowserTweet.Name = "wbrowserTweet";
            this.wbrowserTweet.Size = new System.Drawing.Size(1012, 309);
            this.wbrowserTweet.TabIndex = 0;
            this.wbrowserTweet.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.wbrowserTweet_ProgressChanged);
            // 
            // frmTwitterParserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 561);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmTwitterParserPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTwitterParserPanel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTwitterParserPanel_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.WebBrowser wbrowserTweet;
        private System.Windows.Forms.GroupBox groupBox1;
        private CwFileListView listTopic;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.TextBox textAnahtarKelime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textHashTag;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem UserPageGoGitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showTweetToolStripMenuItem;


    }
}