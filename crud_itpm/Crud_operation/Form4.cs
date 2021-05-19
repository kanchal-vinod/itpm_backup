using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Crud_operation
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-R9GQG21K\SQLEXPRESS;Initial Catalog=itpmCRUD;Integrated Security=True");
        public int tagid;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            showtagtable();
        }

        private void showtagtable()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tagtable",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            TagdataGridView1.DataSource=dt;
            con.Close();
        }

        private void TagdataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tagid = Convert.ToInt32(this.TagdataGridView1.CurrentRow.Cells[0].Value) ;
            textBoxtagname.Text = this.TagdataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxtagcode.Text = this.TagdataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBoxrelatedtag.Text = this.TagdataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cleardata();
        }

        private void cleardata()
        {
            textBoxtagname.Clear();
            textBoxtagcode.Clear();
            comboBoxrelatedtag.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tagid > 0)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE  tagtable set tagname=' " + textBoxtagname.Text + " ',tagcode=' " + textBoxtagcode.Text + " ',relatedtag=' " + comboBoxrelatedtag.Text + " ' where tagid= ' " + tagid + " ' ", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("do you want to update record", "update", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                showtagtable();
            }
            else
            {
                MessageBox.Show("you should select a raw","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tagid > 0)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE from tagtable  where tagid= ' " + tagid + " ' ", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("do you want to delete record", "warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                showtagtable();
            }
            else 
            {
                MessageBox.Show("please select a raw before click on the delete button","warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
