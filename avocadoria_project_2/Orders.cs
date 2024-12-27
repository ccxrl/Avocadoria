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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
            UpdateLoggedInEmployeeLabel();
            ApplyAccessControl();
            DisplayOrders();
        }

        SqlConnection Con = new SqlConnection("Data Source=Carljurie\\SQLEXPRESS05;Initial Catalog=avocadoria_db;Integrated Security=True;");

        private void DisplayOrders()
        {
            Con.Open();
            string Query = "SELECT * from Orders";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            OrdersDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void ApplyAccessControl()
        {
            string role = LoggedInEmployee.Role;

            if (role == "Manager" || role == "Supervisor")
            {
                label4.Enabled = true;
            }
            else
            {
                label4.Enabled = false;
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

        private void label4_Click(object sender, EventArgs e)
        {
            Employees Obj = new Employees();
            Obj.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Home Obj = new Home();
            Obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderItemsArchive Obj = new OrderItemsArchive();
            Obj.Show();
            this.Hide();
        }

        private void UpdateLoggedInEmployeeLabel()
        {
            loggedInEmployeeLabel.Text = LoggedInEmployee.EmployeeName;
        }

        private void OrderItemsArchive_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
