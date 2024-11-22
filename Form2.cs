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
 
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=COMPUTER;Initial Catalog=detail;Integrated Security=True");
      
        private void button1_Click(object sender, EventArgs e)
        {


            SqlCommand cmd = new SqlCommand("insert into category(category_name) values( @category_name)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@category_name" , textBox1.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("category Successfully inserted");
            con.Close();
        }
    }
}
