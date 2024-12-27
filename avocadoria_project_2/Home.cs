using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avocadoria_project_2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            UpdateLoggedInEmployeeLabel();
            ApplyAccessControl();
        }
        private void UpdateLoggedInEmployeeLabel()
        {
            loggedInEmployeeLabel.Text = LoggedInEmployee.EmployeeName;
        }

        private void ApplyAccessControl()
        {
            string role = LoggedInEmployee.Role;

            if (role == "Manager" || role == "Supervisor")
            {
                label4.Enabled = true;
                pictureBox6.Enabled = true;
            }
            else
            {
                label4.Enabled = false;
                pictureBox6.Enabled = false;
            }
        }

        // log out button
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log Out Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Login Obj = new Login();
                Obj.Show();
                this.Close();
            }
        }

        private void customers_order_Click(object sender, EventArgs e)
        {
            OrderItems Obj = new OrderItems();
            Obj.Show();
            this.Hide();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            Products Obj = new Products();
            Obj.Show();
            this.Hide();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Employees Obj = new Employees();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Products Obj = new Products();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OrderItems Obj = new OrderItems();
            Obj.Show();
            this.Hide();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            Orders Obj = new Orders();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Orders Obj = new Orders();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Employees Obj = new Employees();
            Obj.Show();
            this.Hide();
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
