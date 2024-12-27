using Org.BouncyCastle.Crypto.Modes.Gcm;
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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace avocadoria_project_2
{
    public partial class OrderItems : Form
    {
        public OrderItems()
        {
            InitializeComponent();
            OrderItemDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UpdateLoggedInEmployeeLabel();
            ApplyAccessControl();
            DisableButtons();
            DisplayProducts();
            DisplayOrderItems();
        }

        SqlConnection Con = new SqlConnection("Data Source=Carljurie\\SQLEXPRESS05;Initial Catalog=avocadoria_db;Integrated Security=True;");

        private bool orderCreated = false;
        int Key = 0;
        private int currentOrderID;

        private void DisplayOrderItems()
        {
            Con.Open();
            string Query = "SELECT * from OrderItem";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            OrderItemDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void DisplayProducts(string nameFilter = "")
        {
            Con.Open();

            string Query = "SELECT * FROM Products WHERE 1 = 1";

            if (!string.IsNullOrEmpty(nameFilter))
            {
                Query += $" AND Name LIKE @NameFilter";
            }

            using (SqlDataAdapter sda = new SqlDataAdapter(Query, Con))
            {
                if (!string.IsNullOrEmpty(nameFilter))
                {
                    sda.SelectCommand.Parameters.AddWithValue("@NameFilter", $"%{nameFilter}%");
                }

                var ds = new DataSet();
                sda.Fill(ds);
                ProductsDGV.DataSource = ds.Tables[0];
            }

            Con.Close();
        }

        private void Clear()
        {
            product_id_field.Text = "";
            order_item_quantity_field.Text = "";
        }

        private void ApplyAccessControl()
        {
            string role = LoggedInEmployee.Role;

            if (role == "Manager" || role == "Supervisor")
            {
                employees.Enabled = true;
            }
            else
            {
                employees.Enabled = false;
            }

        }


        // add button
        private void prod_save_btn_Click(object sender, EventArgs e)
        {
            if (order_item_quantity_field.Text == "" || product_id_field.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Products WHERE Product_id = @Product_id", Con);
                    checkCmd.Parameters.AddWithValue("@Product_id", product_id_field.Text);
                    int productCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (productCount > 0)
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO OrderItem (OrderID, Product_id, Quantity, OrderDate, Subtotal) " +
                            "VALUES (@OrderID, @Product_id, @Quantity, @OrderDate, (@Quantity * (SELECT Price FROM Products WHERE Product_id = @Product_id)))", Con);

                        cmd.Parameters.AddWithValue("@OrderID", currentOrderID);
                        cmd.Parameters.AddWithValue("@Product_id", product_id_field.Text);
                        cmd.Parameters.AddWithValue("@Quantity", order_item_quantity_field.Text);
                        cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                        cmd.ExecuteNonQuery();

                        Con.Close();

                        DisplayProducts();
                        DisplayOrderItems();
                        Clear();

                        UpdateTotalAmountLabel();
                    }
                    else
                    {
                        MessageBox.Show("Product does not exist.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    Con.Close();
                }
            }
        }


        private void OrderItemDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < OrderItemDGV.Rows.Count)
            {
                product_id_field.Text = OrderItemDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                order_item_quantity_field.Text = OrderItemDGV.Rows[e.RowIndex].Cells[3].Value.ToString();

                if (product_id_field.Text != "")
                {
                    Key = Convert.ToInt32(OrderItemDGV.Rows[e.RowIndex].Cells[1].Value.ToString());
                }

                UpdateTotalAmountLabel();
            }
        }

        // edit button
        private void prod_edit_btn_Click(object sender, EventArgs e)
        {
            if (order_item_quantity_field.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE OrderItem SET Product_id = @Product_id, Quantity = @Quantity, OrderDate = @OrderDate, Subtotal = (@Quantity * (SELECT Price FROM Products WHERE Product_id = @Product_id)) WHERE OrderItemID = @OrderItemID", Con);
                    cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Product_id", product_id_field.Text);
                    cmd.Parameters.AddWithValue("@Quantity", order_item_quantity_field.Text);
                    cmd.Parameters.AddWithValue("@OrderItemID", Key);

                    cmd.ExecuteNonQuery();

                    Con.Close();
                    MessageBox.Show("Order Updated");
                    MessageBox.Show("Order item id" + Key);
                    

                    DisplayProducts();
                    DisplayOrderItems();
                    Clear();

                    UpdateTotalAmountLabel();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // delete button
        private void prod_delete_btn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select Order Item");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM OrderItem WHERE OrderItemID = @OKey", Con);
                    cmd.Parameters.AddWithValue("@OKey", Key);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Order Item Deleted");

                    DisplayOrderItems();
                    Clear();

                    UpdateTotalAmountLabel();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void UpdateTotalAmountLabel()
        {
            int totalAmount = CalculateTotalAmount();
            totalAmountLabel.Text = "₱" + totalAmount.ToString();
        }


        private int CalculateTotalAmount()
        {
            int totalAmount = 0;

            foreach (DataGridViewRow row in OrderItemDGV.Rows)
            {
                if (row.Cells["Subtotal"].Value != null && row.Cells["Subtotal"].Value != DBNull.Value)
                {
                    totalAmount += Convert.ToInt32(row.Cells["Subtotal"].Value);
                }
            }

            return totalAmount;
        }

        private void MoveDataToOrderTable()
        {
            try
            {
                Con.Open();

                int totalAmount = CalculateTotalAmount();

                SqlCommand archiveCmd = new SqlCommand("INSERT INTO OrderItemArchive (OrderItemID, OrderID, Product_id, Quantity, Subtotal, OrderDate) SELECT OrderItemID, @OrderID, Product_id, Quantity, Subtotal, OrderDate FROM OrderItem", Con);
                archiveCmd.Parameters.AddWithValue("@OrderID", currentOrderID);
                archiveCmd.ExecuteNonQuery();

                SqlCommand orderCmd = new SqlCommand("UPDATE Orders SET OrderDate = (SELECT MAX(OrderDate) FROM OrderItemArchive WHERE OrderID = @OrderID), TotalAmount = @TotalAmount, PaymentMethod = @PaymentMethod WHERE OrderID = @OrderID", Con);
                orderCmd.Parameters.AddWithValue("@OrderID", currentOrderID);
                orderCmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                orderCmd.Parameters.AddWithValue("@PaymentMethod", payment_method_field.Text);
                orderCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        // pay button
        private void button1_Click(object sender, EventArgs e)
        {
            if (!orderCreated)
            {
                MessageBox.Show("Please create an order before proceeding with payment.");
                return;
            }

            if (payment_method_field.Text == "")
            {
                MessageBox.Show("Payment method is empty.");
            }
            else
            {
                MessageBox.Show("Payment Done!");

                MoveDataToOrderTable();

                ClearOrderItems();

                DisplayOrderItems();
                UpdateTotalAmountLabel();

                DisableButtons();
                orderCreated = false;
            }
        }

        // CREATE ORDER BUTTON
        private void create_order_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                SqlCommand orderCmd = new SqlCommand("INSERT INTO Orders DEFAULT VALUES; SELECT SCOPE_IDENTITY();", Con);
                currentOrderID = Convert.ToInt32(orderCmd.ExecuteScalar());

                Con.Close();
                MessageBox.Show("Order Created. Order ID: " + currentOrderID);

                order_id_counter.Text = "#" + currentOrderID;

                EnableButtons();
                orderCreated = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClearOrderItems()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM OrderItem", Con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void DisableButtons()
        {
            prod_save_btn.Enabled = false;
            prod_edit_btn.Enabled = false;
            prod_delete_btn.Enabled = false;
            button1.Enabled = false; // Pay button
        }

        private void EnableButtons()
        {
            prod_save_btn.Enabled = true;
            prod_edit_btn.Enabled = true;
            prod_delete_btn.Enabled = true;
            button1.Enabled = true; // Pay button
        }

        private void search_name_TextChanged(object sender, EventArgs e)
        {
            DisplayProducts(search_name.Text);
        }

        private void products_Click(object sender, EventArgs e)
        {
            Products Obj = new Products();
            Obj.Show();
            this.Hide();
        }

        private void orders_Click(object sender, EventArgs e)
        {
            Orders Obj = new Orders();
            Obj.Show();
            this.Hide();
        }

        private void employees_Click(object sender, EventArgs e)
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

        private void pay_btn_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
        private void flavor_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
