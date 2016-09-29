namespace AwkTurtleCounter
{
    partial class AwkTurtUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listenButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hideBrowserButton = new System.Windows.Forms.Button();
            this.showBrowserButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(29, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 432);
            this.panel1.TabIndex = 0;
            // 
            // listenButton
            // 
            this.listenButton.Location = new System.Drawing.Point(846, 132);
            this.listenButton.Name = "listenButton";
            this.listenButton.Size = new System.Drawing.Size(106, 23);
            this.listenButton.TabIndex = 1;
            this.listenButton.Text = "Start Listening";
            this.listenButton.UseVisualStyleBackColor = true;
            this.listenButton.Click += new System.EventHandler(this.ListenButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(814, 486);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "whatsAppBrowser";
            // 
            // hideBrowserButton
            // 
            this.hideBrowserButton.Location = new System.Drawing.Point(846, 161);
            this.hideBrowserButton.Name = "hideBrowserButton";
            this.hideBrowserButton.Size = new System.Drawing.Size(106, 23);
            this.hideBrowserButton.TabIndex = 1;
            this.hideBrowserButton.Text = "Hide Browser";
            this.hideBrowserButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hideBrowserButton.UseVisualStyleBackColor = true;
            this.hideBrowserButton.Click += new System.EventHandler(this.hideBrowserButton_Click);
            // 
            // showBrowserButton
            // 
            this.showBrowserButton.Location = new System.Drawing.Point(846, 244);
            this.showBrowserButton.Name = "showBrowserButton";
            this.showBrowserButton.Size = new System.Drawing.Size(106, 23);
            this.showBrowserButton.TabIndex = 1;
            this.showBrowserButton.Text = "Show Browser";
            this.showBrowserButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.showBrowserButton.UseVisualStyleBackColor = true;
            this.showBrowserButton.Click += new System.EventHandler(this.showBrowserButton_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(846, 218);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(106, 20);
            this.passwordBox.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 530);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.showBrowserButton);
            this.Controls.Add(this.hideBrowserButton);
            this.Controls.Add(this.listenButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button listenButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button hideBrowserButton;
        private System.Windows.Forms.Button showBrowserButton;
        private System.Windows.Forms.TextBox passwordBox;
    }
}