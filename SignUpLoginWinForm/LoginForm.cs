using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUpLoginWinForm
{
    public partial class LoginForm : Form
    {
        DbAccess objDbAccess = new DbAccess();
        DataTable dtUsers = new DataTable();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string password = textBoxPassword.Text;

            if (name == string.Empty || password == string.Empty) MessageBox.Show("Please fill form corectly.");
            else
            {
                string query1 = $"Select Hash from Users_Table Where Name = '{name}'";
                using (var hash = objDbAccess.readDataThroughReader(query1))
                {
                    if (hash == null) MessageBox.Show("Hash jest pusty");
                    
                    string? h = hash.GetValue(0).ToString();
                    bool isPasswordCorrect = Security.Verify(password, h);
                    if (!isPasswordCorrect) MessageBox.Show("Password not correct");
                }
                
                
                

                //string query = $"Select * from Users_Table Where Name = '{name}' AND Hash = '{hash}'";
                //objDbAccess.readDataThroughAdapater(query, dtUsers);

                if (dtUsers.Rows.Count > 0)
                {
                    MessageBox.Show("Login successfully.");
                    objDbAccess.closeConnection();

                    HomeForm home = new HomeForm();
                    home.Show();
                    this.Hide();
                }
                else MessageBox.Show("Login or password incorrect.");
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            Signup signUp = new Signup();
            signUp.Show();
            this.Hide();
        }
    }
}
