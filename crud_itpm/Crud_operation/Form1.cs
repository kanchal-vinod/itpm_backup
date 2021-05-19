using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace Crud_operation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-R9GQG21K\SQLEXPRESS;Initial Catalog=itpmCRUD;Integrated Security=True");


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbProgramme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAcademicYear_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            clearfields();

        }

        private void clearfields()
        {
            txtAcademicYear.Clear();
            cmbProgramme.ResetText();
            numGroupNum.ResetText();
            numSubGroupNum.ResetText();
            txtGroupID.Clear();
            txtSubGroupID.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                if (isValid())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO studentinformation VALUES (' " + txtAcademicYear.Text + " ',' " + cmbProgramme.Text + " ',' " + numGroupNum.Text + " ',' " + numSubGroupNum.Text + " ',' " + txtGroupID.Text + " ',' " + txtSubGroupID.Text + " ')", con);
                   

                  


                  
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("student data successfully added.", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                  
            }

        }

        //validation for academic yaer field
        private bool isValid()
        {
            if (txtAcademicYear.Text == string.Empty)
            {
                MessageBox.Show("acadmic year is required", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    } 
}
