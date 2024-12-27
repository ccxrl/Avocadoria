using System.Data;
using System.Data.SqlClient;

namespace avocadoria_project_2
{
    public partial class Login : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=Carljurie\\SQLEXPRESS05;Initial Catalog=avocadoria_db;Integrated Security=True;");

        public Login()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = username_box.Text;
            string password = password_box.Text;

            if (IsValidLogin(username, password, out string role))
            {
                MessageBox.Show("Login successful!");

                LoggedInEmployee.SetLoggedInEmployee(username, role);

                Home homeForm = new Home();
                homeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private bool IsValidLogin(string username, string password, out string role)
        {
            role = string.Empty;

            try
            {
                Con.Open();

                string query = "SELECT Role FROM Employee WHERE Name = @Username AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, Con))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        role = result.ToString();
                        return true;
                    }

                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                Con.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}