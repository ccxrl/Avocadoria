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
    public partial class OrderItemsArchive : Form
    {
        public OrderItemsArchive()
        {
            InitializeComponent();
            DisplayEmployees();
        }

        SqlConnection Con = new SqlConnection("Data Source=Carljurie\\SQLEXPRESS05;Initial Catalog=avocadoria_db;Integrated Security=True;");

        private void DisplayEmployees()
        {
            Con.Open();
            string Query = "SELECT * from OrderItemArchive";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            OrderItemsArchiveDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Orders Obj = new Orders();
            Obj.Show();
            this.Hide();
        }
    }
}
