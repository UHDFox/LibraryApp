namespace LibraryApp
{
    partial class LoginWindow
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
            panel1 = new Panel();
            UserLogin = new TextBox();
            UserPassword = new TextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GrayText;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(UserPassword);
            panel1.Controls.Add(UserLogin);
            panel1.ForeColor = Color.Coral;
            panel1.Location = new Point(188, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(430, 229);
            panel1.TabIndex = 0;
            // 
            // UserLogin
            // 
            UserLogin.Location = new Point(119, 56);
            UserLogin.Name = "UserLogin";
            UserLogin.Size = new Size(198, 25);
            UserLogin.TabIndex = 1;
            // 
            // UserPassword
            // 
            UserPassword.Location = new Point(119, 101);
            UserPassword.Name = "UserPassword";
            UserPassword.Size = new Size(198, 25);
            UserPassword.TabIndex = 2;
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(119, 141);
            button1.Name = "button1";
            button1.Size = new Size(198, 59);
            button1.TabIndex = 3;
            button1.Text = "LoginButton";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LoginWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "LoginWindow";
            Text = "LoginWindow";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private TextBox UserPassword;
        private TextBox UserLogin;
    }
}