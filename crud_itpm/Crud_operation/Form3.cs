using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Crud_operation
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-R9GQG21K\SQLEXPRESS;Initial Catalog=itpmCRUD;Integrated Security=True");
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO tagtable VALUES(' " +txttagname.Text+ " ',' " + txttagcode.Text + " ',' " + cmbrelatedtag.Text + " ') ",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("inserted successfully");
        
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearkaramukollo();
        }
       
        private void clearkaramukollo()
        {
            //clear function

            txttagname.Clear();
            txttagcode.Clear();
            cmbrelatedtag.ResetText();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void txttagname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
