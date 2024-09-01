namespace ProjectTracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.loginPanel = new System.Windows.Forms.Panel();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.swapPicturesLoginButtonTimer = new System.Windows.Forms.Timer(this.components);
            this.aboutButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.loginButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.swapPicturesAboutButton = new System.Windows.Forms.Timer(this.components);
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboutButtonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginButtonPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.passwordTextBox);
            this.loginPanel.Controls.Add(this.passwordLabel);
            this.loginPanel.Controls.Add(this.usernameTextBox);
            this.loginPanel.Controls.Add(this.usernameLabel);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Location = new System.Drawing.Point(258, 151);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(484, 250);
            this.loginPanel.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(182, 128);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(238, 27);
            this.passwordTextBox.TabIndex = 4;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(65, 131);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(90, 21);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password :";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(182, 95);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(238, 27);
            this.usernameTextBox.TabIndex = 2;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(65, 98);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(96, 21);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username :";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(197, 193);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(91, 35);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // swapPicturesLoginButtonTimer
            // 
            this.swapPicturesLoginButtonTimer.Interval = 17;
            this.swapPicturesLoginButtonTimer.Tick += new System.EventHandler(this.swapPicturesLoginButton_Tick);
            // 
            // aboutButtonPictureBox
            // 
            this.aboutButtonPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("aboutButtonPictureBox.Image")));
            this.aboutButtonPictureBox.Location = new System.Drawing.Point(879, 12);
            this.aboutButtonPictureBox.Name = "aboutButtonPictureBox";
            this.aboutButtonPictureBox.Size = new System.Drawing.Size(110, 40);
            this.aboutButtonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aboutButtonPictureBox.TabIndex = 2;
            this.aboutButtonPictureBox.TabStop = false;
            this.aboutButtonPictureBox.MouseLeave += new System.EventHandler(this.aboutButtonPictureBox_MouseLeave);
            this.aboutButtonPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.aboutButtonPictureBox_MouseMove);
            // 
            // loginButtonPictureBox
            // 
            this.loginButtonPictureBox.Image = global::ProjectTracker.Properties.Resources.LoginButtonSimple;
            this.loginButtonPictureBox.Location = new System.Drawing.Point(12, 12);
            this.loginButtonPictureBox.Name = "loginButtonPictureBox";
            this.loginButtonPictureBox.Size = new System.Drawing.Size(110, 40);
            this.loginButtonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginButtonPictureBox.TabIndex = 1;
            this.loginButtonPictureBox.TabStop = false;
            this.loginButtonPictureBox.Click += new System.EventHandler(this.loginButtonPictureBox_Click);
            this.loginButtonPictureBox.MouseLeave += new System.EventHandler(this.loginButtonPictureBox_MouseLeave);
            this.loginButtonPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginButtonPictureBox_MouseMove);
            // 
            // swapPicturesAboutButton
            // 
            this.swapPicturesAboutButton.Interval = 17;
            this.swapPicturesAboutButton.Tick += new System.EventHandler(this.swapPicturesAboutButton_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 553);
            this.Controls.Add(this.aboutButtonPictureBox);
            this.Controls.Add(this.loginButtonPictureBox);
            this.Controls.Add(this.loginPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboutButtonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginButtonPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.PictureBox loginButtonPictureBox;
        private System.Windows.Forms.Timer swapPicturesLoginButtonTimer;
        private System.Windows.Forms.PictureBox aboutButtonPictureBox;
        private System.Windows.Forms.Timer swapPicturesAboutButton;
    }
}