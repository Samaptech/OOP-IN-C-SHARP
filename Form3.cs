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

namespace task
{

    public partial class Form3 : Form
    {

        SqlConnection con = new SqlConnection("Data Source=COMPUTER;Initial Catalog=detail;Integrated Security=True");

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            SqlCommand cmd = new SqlCommand("insert into products(product_name, product_formula , product_mrp , product_rate) values( @product_name , @product_formula , @product_mrp , @product_rate )", con);
            con.Open();
            cmd.Parameters.AddWithValue("@product_name", textBox1.Text);
            cmd.Parameters.AddWithValue("@product_formula", textBox2.Text);
            cmd.Parameters.AddWithValue("@product_mrp", textBox3.Text);
            cmd.Parameters.AddWithValue("@product_rate", textBox4.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Product Successfully inserted");
            con.Close();

        }

      /*  private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("select category_name from category", con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read()) { comboBox1.Items.Add(sdr["category_name"].ToString()); }
            con.Close();

        }*/
    }
}
