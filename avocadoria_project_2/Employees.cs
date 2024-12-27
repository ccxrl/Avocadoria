using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avocadoria_project_2
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
            EmployeesDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UpdateLoggedInEmployeeLabel();
            DisplayEmployees();
        }

        SqlConnection Con = new SqlConnection("Data Source=Carljurie\\SQLEXPRESS05;Initial Catalog=avocadoria_db;Integrated Security=True;");


        private void DisplayEmployees ()
        {
            Con.Open ();
            string Query = "SELECT * from Employee";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmployeesDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Clear()
        {
            emp_text_field.Text = "";
            contact_number_field.Text = "";
            pass_field.Text = "";
            birthday_field.Text = "";
            address_field.Text = "";
            role_field.Text = "";
        }

        int Key = 0;

        private void save_flavor_Click(object sender, EventArgs e)
        {
            if (emp_text_field.Text == "" || contact_number_field.Text == "" || pass_field.Text == "" || birthday_field.Text == "" || role_field.Text == "" || address_field.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Employee (Name, Role, ContactNumber, Password, Birthday, EmployeeAddress) VALUES (@EN, @ER, @EC, @EP, @EB, @EA)", Con);
                    cmd.Parameters.AddWithValue("@EN", emp_text_field.Text);
                    cmd.Parameters.AddWithValue("@ER", role_field.Text);
                    cmd.Parameters.AddWithValue("@EC", contact_number_field.Text);
                    cmd.Parameters.AddWithValue("@EP", pass_field.Text);
                    cmd.Parameters.AddWithValue("@EB", birthday_field.Value);
                    cmd.Parameters.AddWithValue("@EA", address_field.Text);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Employee Added");

                    DisplayEmployees();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void EmployeesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < EmployeesDGV.Rows.Count)
            {
                emp_text_field.Text = EmployeesDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                contact_number_field.Text = EmployeesDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                address_field.Text = EmployeesDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                birthday_field.Text = EmployeesDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
                role_field.Text = EmployeesDGV.Rows[e.RowIndex].Cells[5].Value.ToString();
                pass_field.Text = EmployeesDGV.Rows[e.RowIndex].Cells[6].Value.ToString();

                if (emp_text_field.Text != "")
                {
                    Key = Convert.ToInt32(EmployeesDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
        }

        private void edit_flavor_Click(object sender, EventArgs e)
        {
            if (emp_text_field.Text == "" || contact_number_field.Text == "" || pass_field.Text == "" || birthday_field.Text == "" || role_field.Text == "" || address_field.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update Employee set Name= @EN, Role = @ER, ContactNumber= @EC, Password= @EP, birthday= @EB, EmployeeAddress=@EA where EmployeeID = @EKey", Con); //ADD "where EmpNum = @EKey here before con
                    cmd.Parameters.AddWithValue("@EN", emp_text_field.Text);
                    cmd.Parameters.AddWithValue("@ER", role_field.Text);
                    cmd.Parameters.AddWithValue("@EC", contact_number_field.Text);
                    cmd.Parameters.AddWithValue("@EA", address_field.Text);
                    cmd.Parameters.AddWithValue("@EB", birthday_field.Value);
                    cmd.Parameters.AddWithValue("@EP", pass_field.Text);
                    cmd.Parameters.AddWithValue("@EKey", Key);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Employee Updated!");

                    DisplayEmployees();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void delete_flavor_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select an Employee");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Employee WHERE EmployeeID = @EKey", Con);
                    cmd.Parameters.AddWithValue("@EKey", Key);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Employee Deleted");

                    DisplayEmployees();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Products Obj = new Products();
            Obj.Show();
            this.Hide();
        }

        private void customers_order_Click(object sender, EventArgs e)
        {
            OrderItems Obj = new OrderItems();
            Obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Orders Obj = new Orders();
            Obj.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Home Obj = new Home();
            Obj.Show();
            this.Hide();
        }
        private void UpdateLoggedInEmployeeLabel()
        {
            loggedInEmployeeLabel.Text = LoggedInEmployee.EmployeeName;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void role_field_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void flavor_id_label_Click(object sender, EventArgs e)
        {

        }

        private void Employees_Load(object sender, EventArgs e)
        {

        }

        private void emp_text_field_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
