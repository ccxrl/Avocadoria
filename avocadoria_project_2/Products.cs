using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            ProductsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductsDGV.SelectionChanged += ProductsDGV_SelectionChanged;
            ApplyAccessControl();
            UpdateLoggedInEmployeeLabel();
            DisplayProducts();
        }

        SqlConnection Con = new SqlConnection("Data Source=Carljurie\\SQLEXPRESS05;Initial Catalog=avocadoria_db;Integrated Security=True;");


        private void DisplayProducts()
        {
            Con.Open();
            string Query = "SELECT * from Products";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProductsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Clear()
        {
            prod_name_field.Text = "";
            flavor_name_field.Text = "";
            size_name_field.Text = "";
            prod_price_field.Text = "";
        }

        int Key = 0;

        private void prod_save_btn_Click(object sender, EventArgs e)
        {
            if (prod_name_field.Text == "" || flavor_name_field.Text == "" || size_name_field.Text == "" || prod_price_field.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Products (Name, Flavor, Size, Price) VALUES (@PN, @PF, @PS, @PP)", Con);
                    cmd.Parameters.AddWithValue("@PN", prod_name_field.Text);
                    cmd.Parameters.AddWithValue("@PF", flavor_name_field.Text);
                    cmd.Parameters.AddWithValue("@PS", size_name_field.Text);
                    cmd.Parameters.AddWithValue("@PP", prod_price_field.Text);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Product Added");

                    DisplayProducts();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void ProductsDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (ProductsDGV.SelectedRows.Count > 0)
            {
                int selectedIndex = ProductsDGV.SelectedRows[0].Index;

                prod_name_field.Text = ProductsDGV.Rows[selectedIndex].Cells[1].Value.ToString();
                flavor_name_field.Text = ProductsDGV.Rows[selectedIndex].Cells[2].Value.ToString();
                size_name_field.Text = ProductsDGV.Rows[selectedIndex].Cells[3].Value.ToString();
                prod_price_field.Text = ProductsDGV.Rows[selectedIndex].Cells[4].Value.ToString();

                if (prod_name_field.Text != "")
                {
                    Key = Convert.ToInt32(ProductsDGV.Rows[selectedIndex].Cells[0].Value.ToString());
                }
            }
        }

        private void prod_edit_btn_Click(object sender, EventArgs e)
        {
            if (prod_name_field.Text == "" || flavor_name_field.Text == "" || size_name_field.Text == "" || prod_price_field.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Products SET Name = @PN, Flavor = @PF, Size = @PS, Price = @PP WHERE Product_id = @PKey", Con);
                    cmd.Parameters.AddWithValue("@PN", prod_name_field.Text);
                    cmd.Parameters.AddWithValue("@PF", flavor_name_field.Text);
                    cmd.Parameters.AddWithValue("@PS", size_name_field.Text);
                    cmd.Parameters.AddWithValue("@PP", prod_price_field.Text);
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Product Information Updated");

                    DisplayProducts();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void prod_delete_btn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select Product");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Products WHERE Product_id = @PKey", Con);
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Product Deleted");

                    DisplayProducts();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
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

        private void UpdateLoggedInEmployeeLabel()
        {
            loggedInEmployeeLabel.Text = LoggedInEmployee.EmployeeName;
        }

        private void loggedInEmployeeLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void emp_role_label_Click(object sender, EventArgs e)
        {

        }

        private void emp_address_label_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
