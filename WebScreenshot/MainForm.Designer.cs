namespace WebScreenshot
{
	partial class MainForm
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
			this.panelBottom = new System.Windows.Forms.Panel();
			this.buttonGo = new System.Windows.Forms.Button();
			this.textBoxUrl = new System.Windows.Forms.TextBox();
			this.buttonTakeScreenshot = new System.Windows.Forms.Button();
			this.panelFill = new System.Windows.Forms.Panel();
			this.webBrowser = new System.Windows.Forms.WebBrowser();
			this.timerScreenshot = new System.Windows.Forms.Timer(this.components);
			this.buttonHelp = new System.Windows.Forms.Button();
			this.panelBottom.SuspendLayout();
			this.panelFill.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelBottom
			// 
			this.panelBottom.Controls.Add(this.buttonHelp);
			this.panelBottom.Controls.Add(this.buttonGo);
			this.panelBottom.Controls.Add(this.textBoxUrl);
			this.panelBottom.Controls.Add(this.buttonTakeScreenshot);
			this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelBottom.Location = new System.Drawing.Point(0, 436);
			this.panelBottom.Name = "panelBottom";
			this.panelBottom.Size = new System.Drawing.Size(684, 26);
			this.panelBottom.TabIndex = 0;
			// 
			// buttonGo
			// 
			this.buttonGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonGo.Location = new System.Drawing.Point(510, 3);
			this.buttonGo.Name = "buttonGo";
			this.buttonGo.Size = new System.Drawing.Size(42, 21);
			this.buttonGo.TabIndex = 1;
			this.buttonGo.Text = "Go";
			this.buttonGo.UseVisualStyleBackColor = true;
			this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
			// 
			// textBoxUrl
			// 
			this.textBoxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxUrl.Location = new System.Drawing.Point(3, 3);
			this.textBoxUrl.Name = "textBoxUrl";
			this.textBoxUrl.Size = new System.Drawing.Size(501, 20);
			this.textBoxUrl.TabIndex = 0;
			// 
			// buttonTakeScreenshot
			// 
			this.buttonTakeScreenshot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonTakeScreenshot.Location = new System.Drawing.Point(556, 3);
			this.buttonTakeScreenshot.Name = "buttonTakeScreenshot";
			this.buttonTakeScreenshot.Size = new System.Drawing.Size(107, 21);
			this.buttonTakeScreenshot.TabIndex = 2;
			this.buttonTakeScreenshot.Text = "Take screenshot";
			this.buttonTakeScreenshot.UseVisualStyleBackColor = true;
			this.buttonTakeScreenshot.Click += new System.EventHandler(this.buttonTakeScreenshot_Click);
			// 
			// panelFill
			// 
			this.panelFill.Controls.Add(this.webBrowser);
			this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelFill.Location = new System.Drawing.Point(0, 0);
			this.panelFill.Name = "panelFill";
			this.panelFill.Size = new System.Drawing.Size(684, 436);
			this.panelFill.TabIndex = 1;
			// 
			// webBrowser
			// 
			this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser.Location = new System.Drawing.Point(0, 0);
			this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser.Name = "webBrowser";
			this.webBrowser.Size = new System.Drawing.Size(684, 436);
			this.webBrowser.TabIndex = 0;
			this.webBrowser.Url = new System.Uri("http://google.com", System.UriKind.Absolute);
			// 
			// timerScreenshot
			// 
			this.timerScreenshot.Tick += new System.EventHandler(this.timerScreenshot_Tick);
			// 
			// buttonHelp
			// 
			this.buttonHelp.Location = new System.Drawing.Point(667, 3);
			this.buttonHelp.Name = "buttonHelp";
			this.buttonHelp.Size = new System.Drawing.Size(14, 21);
			this.buttonHelp.TabIndex = 3;
			this.buttonHelp.Text = "?";
			this.buttonHelp.UseVisualStyleBackColor = true;
			this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
			// 
			// MainForm
			// 
			this.AcceptButton = this.buttonGo;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 462);
			this.Controls.Add(this.panelFill);
			this.Controls.Add(this.panelBottom);
			this.MinimumSize = new System.Drawing.Size(700, 500);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WebScreenshot";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.panelBottom.ResumeLayout(false);
			this.panelBottom.PerformLayout();
			this.panelFill.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelBottom;
		private System.Windows.Forms.Button buttonTakeScreenshot;
		private System.Windows.Forms.Panel panelFill;
		private System.Windows.Forms.WebBrowser webBrowser;
		private System.Windows.Forms.TextBox textBoxUrl;
		private System.Windows.Forms.Button buttonGo;
		private System.Windows.Forms.Timer timerScreenshot;
		private System.Windows.Forms.Button buttonHelp;



	}
}

