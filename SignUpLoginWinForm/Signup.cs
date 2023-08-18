using System.Data.SqlClient;

namespace SignUpLoginWinForm
{
    public partial class Signup : Form
    {
        DbAccess objDbAccess = new DbAccess();

        public Signup()
        {
            InitializeComponent();
        }

        public void buttonSignUp_Click(object sender, EventArgs e)
        {
            string username = textBoxName.Text;
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;
            string confirmPassword = textBoxConfirmPassword.Text;
            string country = comboBoxCountry.Text;

            if (username == string.Empty) MessageBox.Show("Enter the name.");
            else if (email == string.Empty) MessageBox.Show("Enter the email.");
            else if (password == string.Empty) MessageBox.Show("Enter the password.");
            else if (confirmPassword == string.Empty) MessageBox.Show("Enter the confirm password.");
            else if (country == string.Empty) MessageBox.Show("Select the country.");
            else if (password != confirmPassword) MessageBox.Show("Passwords dont match");
            else
            {
                string hash = Security.Hash(password);
                SqlCommand insertCommand = new SqlCommand("insert into Users_Table (Name, Email, Country, Hash) values(@username, @email, @country, @hash)");

                insertCommand.Parameters.AddWithValue("@username", username);
                insertCommand.Parameters.AddWithValue("@email", email);
                insertCommand.Parameters.AddWithValue("@country", country);
                insertCommand.Parameters.AddWithValue("@hash", hash);

                int row = objDbAccess.executeQuery(insertCommand);
                if (row == 1)
                {
                    MessageBox.Show("Account created successfully");

                    HomeForm home = new HomeForm();
                    home.Show();
                    this.Hide();
                }
                else MessageBox.Show("Something went wrong.");
            }
        }
    }
}