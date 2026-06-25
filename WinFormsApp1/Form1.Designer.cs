namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWelcome = new Label();
            lblLogin = new Label();
            lblPassword = new Label();
            btnLogin = new Button();
            btnGuest = new Button();
            tbPassword = new TextBox();
            tbLogin = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblWelcome.Location = new Point(314, 51);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(155, 20);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Добро пожаловать!";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(362, 132);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(52, 20);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Логин";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(359, 236);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(62, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Пароль";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(197, 357);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Вход";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnGuest
            // 
            btnGuest.Location = new Point(485, 357);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(94, 29);
            btnGuest.TabIndex = 4;
            btnGuest.Text = "Гость";
            btnGuest.UseVisualStyleBackColor = true;
            btnGuest.Click += btnGuest_Click;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(307, 287);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(167, 27);
            tbPassword.TabIndex = 5;
            // 
            // tbLogin
            // 
            tbLogin.Location = new Point(307, 182);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(167, 27);
            tbLogin.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(68, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(tbLogin);
            Controls.Add(tbPassword);
            Controls.Add(btnGuest);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblLogin);
            Controls.Add(lblWelcome);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Label lblLogin;
        private Label lblPassword;
        private Button btnLogin;
        private Button btnGuest;
        private TextBox tbPassword;
        private TextBox tbLogin;
        private PictureBox pictureBox1;
    }
}
