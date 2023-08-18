namespace SignUpLoginWinForm
{
    partial class LoginForm
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
            buttonLogin = new Button();
            textBoxName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBoxPassword = new TextBox();
            label7 = new Label();
            buttonSignUp = new Button();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogin.Location = new Point(480, 300);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(122, 46);
            buttonLogin.TabIndex = 12;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(385, 155);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(217, 23);
            textBoxName.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(155, 144);
            label2.Name = "label2";
            label2.Size = new Size(81, 32);
            label2.TabIndex = 8;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(320, 31);
            label1.Name = "label1";
            label1.Size = new Size(89, 37);
            label1.TabIndex = 13;
            label1.Text = "Login";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(385, 219);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(217, 23);
            textBoxPassword.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(155, 208);
            label7.Name = "label7";
            label7.Size = new Size(122, 32);
            label7.TabIndex = 14;
            label7.Text = "Password";
            // 
            // buttonSignUp
            // 
            buttonSignUp.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSignUp.Location = new Point(298, 300);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(122, 46);
            buttonSignUp.TabIndex = 16;
            buttonSignUp.Text = "Sign Up";
            buttonSignUp.UseVisualStyleBackColor = true;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSignUp);
            Controls.Add(textBoxPassword);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private TextBox textBoxName;
        private Label label2;
        private Label label1;
        private TextBox textBoxPassword;
        private Label label7;
        private Button buttonSignUp;
    }
}