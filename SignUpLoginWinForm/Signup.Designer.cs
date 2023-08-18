namespace SignUpLoginWinForm
{
    partial class Signup
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
            label1 = new Label();
            label2 = new Label();
            textBoxName = new TextBox();
            textBoxEmail = new TextBox();
            label3 = new Label();
            textBoxConfirmPassword = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxPassword = new TextBox();
            comboBoxCountry = new ComboBox();
            buttonSignUp = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(321, 25);
            label1.Name = "label1";
            label1.Size = new Size(117, 37);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(121, 95);
            label2.Name = "label2";
            label2.Size = new Size(81, 32);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(351, 106);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(217, 23);
            textBoxName.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(351, 159);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(217, 23);
            textBoxEmail.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(121, 148);
            label3.Name = "label3";
            label3.Size = new Size(76, 32);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Location = new Point(351, 266);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.Size = new Size(217, 23);
            textBoxConfirmPassword.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(121, 255);
            label5.Name = "label5";
            label5.Size = new Size(222, 32);
            label5.TabIndex = 3;
            label5.Text = "Confirm Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(121, 310);
            label6.Name = "label6";
            label6.Size = new Size(107, 32);
            label6.TabIndex = 3;
            label6.Text = "Country";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(121, 194);
            label7.Name = "label7";
            label7.Size = new Size(122, 32);
            label7.TabIndex = 3;
            label7.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(351, 205);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(217, 23);
            textBoxPassword.TabIndex = 4;
            // 
            // comboBoxCountry
            // 
            comboBoxCountry.FormattingEnabled = true;
            comboBoxCountry.Items.AddRange(new object[] { "Albania", "Germany", "Poland", "UK", "USA" });
            comboBoxCountry.Location = new Point(351, 321);
            comboBoxCountry.Name = "comboBoxCountry";
            comboBoxCountry.Size = new Size(217, 23);
            comboBoxCountry.TabIndex = 5;
            // 
            // buttonSignUp
            // 
            buttonSignUp.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSignUp.Location = new Point(297, 381);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(122, 46);
            buttonSignUp.TabIndex = 7;
            buttonSignUp.Text = "Sign Up";
            buttonSignUp.UseVisualStyleBackColor = true;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSignUp);
            Controls.Add(comboBoxCountry);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textBoxPassword);
            Controls.Add(label7);
            Controls.Add(textBoxConfirmPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(label3);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Signup";
            Text = "Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxName;
        private TextBox textBoxEmail;
        private Label label3;
        private TextBox textBoxConfirmPassword;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxPassword;
        private ComboBox comboBoxCountry;
        private Button buttonSignUp;
    }
}