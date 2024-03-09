namespace PublicProxyScraper
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.groupGitProxies = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GetGitRandomLink = new System.Windows.Forms.Button();
            this.SaveGitProxies = new System.Windows.Forms.Button();
            this.txtGitHubUrl = new System.Windows.Forms.TextBox();
            this.Helper = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveInternetProxies = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuAuthorBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.groupGitProxies.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupGitProxies
            // 
            this.groupGitProxies.Controls.Add(this.panel1);
            this.groupGitProxies.Controls.Add(this.txtGitHubUrl);
            this.groupGitProxies.ForeColor = System.Drawing.Color.White;
            this.groupGitProxies.Location = new System.Drawing.Point(12, 40);
            this.groupGitProxies.Name = "groupGitProxies";
            this.groupGitProxies.Padding = new System.Windows.Forms.Padding(10);
            this.groupGitProxies.Size = new System.Drawing.Size(437, 129);
            this.groupGitProxies.TabIndex = 0;
            this.groupGitProxies.TabStop = false;
            this.groupGitProxies.Text = "GitHub Proxies";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GetGitRandomLink);
            this.panel1.Controls.Add(this.SaveGitProxies);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 57);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel1.Size = new System.Drawing.Size(417, 62);
            this.panel1.TabIndex = 3;
            // 
            // GetGitRandomLink
            // 
            this.GetGitRandomLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GetGitRandomLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.GetGitRandomLink.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.GetGitRandomLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetGitRandomLink.Location = new System.Drawing.Point(0, 3);
            this.GetGitRandomLink.Name = "GetGitRandomLink";
            this.GetGitRandomLink.Size = new System.Drawing.Size(417, 23);
            this.GetGitRandomLink.TabIndex = 2;
            this.GetGitRandomLink.Text = "Get Random URL";
            this.GetGitRandomLink.UseVisualStyleBackColor = false;
            this.GetGitRandomLink.Click += new System.EventHandler(this.GetGitRandomLink_Click);
            this.GetGitRandomLink.MouseEnter += new System.EventHandler(this.GetGitRandomLink_MouseEnter);
            // 
            // SaveGitProxies
            // 
            this.SaveGitProxies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SaveGitProxies.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaveGitProxies.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet;
            this.SaveGitProxies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveGitProxies.Location = new System.Drawing.Point(0, 33);
            this.SaveGitProxies.Name = "SaveGitProxies";
            this.SaveGitProxies.Size = new System.Drawing.Size(417, 26);
            this.SaveGitProxies.TabIndex = 0;
            this.SaveGitProxies.Text = "Save Proxies";
            this.SaveGitProxies.UseVisualStyleBackColor = false;
            this.SaveGitProxies.Click += new System.EventHandler(this.SaveGitProxies_Click);
            // 
            // txtGitHubUrl
            // 
            this.txtGitHubUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.txtGitHubUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGitHubUrl.ForeColor = System.Drawing.Color.White;
            this.txtGitHubUrl.Location = new System.Drawing.Point(10, 23);
            this.txtGitHubUrl.Name = "txtGitHubUrl";
            this.txtGitHubUrl.Size = new System.Drawing.Size(417, 20);
            this.txtGitHubUrl.TabIndex = 1;
            this.txtGitHubUrl.Text = "GitHub Raw URL";
            this.txtGitHubUrl.TextChanged += new System.EventHandler(this.txtGitHubUrl_TextChanged);
            this.txtGitHubUrl.Enter += new System.EventHandler(this.txtGitHubUrl_Enter);
            this.txtGitHubUrl.Leave += new System.EventHandler(this.txtGitHubUrl_Leave);
            this.txtGitHubUrl.MouseEnter += new System.EventHandler(this.txtGitHubUrl_MouseEnter);
            // 
            // Helper
            // 
            this.Helper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Helper.ForeColor = System.Drawing.Color.White;
            this.Helper.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.StatusLabel);
            this.panel2.Controls.Add(this.VersionLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 476);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 18);
            this.panel2.TabIndex = 1;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.StatusLabel.ForeColor = System.Drawing.Color.LawnGreen;
            this.StatusLabel.Location = new System.Drawing.Point(0, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(150, 18);
            this.StatusLabel.TabIndex = 1;
            this.StatusLabel.Text = "Status:";
            // 
            // VersionLabel
            // 
            this.VersionLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.VersionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.VersionLabel.Location = new System.Drawing.Point(316, 0);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(145, 18);
            this.VersionLabel.TabIndex = 0;
            this.VersionLabel.Text = "ver. GitHub Edition 1.0";
            this.VersionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SaveInternetProxies);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(437, 90);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proxies from the internet";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(10, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Coming soon";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SaveInternetProxies
            // 
            this.SaveInternetProxies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SaveInternetProxies.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaveInternetProxies.Enabled = false;
            this.SaveInternetProxies.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet;
            this.SaveInternetProxies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveInternetProxies.Location = new System.Drawing.Point(10, 23);
            this.SaveInternetProxies.Name = "SaveInternetProxies";
            this.SaveInternetProxies.Size = new System.Drawing.Size(417, 23);
            this.SaveInternetProxies.TabIndex = 1;
            this.SaveInternetProxies.Text = "Get Proxies";
            this.SaveInternetProxies.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAuthorBtn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(461, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuAuthorBtn
            // 
            this.MenuAuthorBtn.ForeColor = System.Drawing.Color.White;
            this.MenuAuthorBtn.Name = "MenuAuthorBtn";
            this.MenuAuthorBtn.Size = new System.Drawing.Size(67, 20);
            this.MenuAuthorBtn.Text = "Telegram";
            this.MenuAuthorBtn.Click += new System.EventHandler(this.MenuAuthorBtn_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(461, 494);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupGitProxies);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.Text = "Public Proxy Scraper by deprussian";
            this.groupGitProxies.ResumeLayout(false);
            this.groupGitProxies.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupGitProxies;
        private System.Windows.Forms.Button SaveGitProxies;
        private System.Windows.Forms.TextBox txtGitHubUrl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button GetGitRandomLink;
        private System.Windows.Forms.ToolTip Helper;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SaveInternetProxies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuAuthorBtn;
    }
}

