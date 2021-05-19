using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Crud_operation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //sid variable declare
        public int studentID;

        //connection with database
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-R9GQG21K\SQLEXPRESS;Initial Catalog=itpmCRUD;Integrated Security=True");
      
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        //this function for retrive details from database to the interface
        private void DataShow()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM studentinformation",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            StudentDataGridView.DataSource = dt;
            con.Close();
        
        }
         

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (studentID > 0 )
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE studentinformation set academic_year = ' " + txtAcademicYear.Text + " ', programme = ' " + comprogramme.Text + " ',groupNumber = ' " + numGrNUm.Text + " ' ,subGroupNmber = ' " + numSubGruNum.Text + " ',groupid = ' " + txtGID.Text + " ',subGroupID = ' " + txtSubGID.Text + " ' WHERE sid= ' " + studentID + " '", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("upadate the record?", "updated", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                DataShow();
            }
            else 
            {
                MessageBox.Show("click on the raw and update the filled fields ","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            
            }



        }

        //this method helps to show details on fields when we click on table raw
        private void StudentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            studentID = Convert.ToInt32(this.StudentDataGridView.CurrentRow.Cells[0].Value);
            txtAcademicYear.Text = this.StudentDataGridView.CurrentRow.Cells[1].Value.ToString();
            comprogramme.Text = this.StudentDataGridView.CurrentRow.Cells[2].Value.ToString();
            numGrNUm.Text = this.StudentDataGridView.CurrentRow.Cells[3].Value.ToString();
            numSubGruNum.Text = this.StudentDataGridView.CurrentRow.Cells[4].Value.ToString();
            txtGID.Text = this.StudentDataGridView.CurrentRow.Cells[5].Value.ToString();
            txtSubGID.Text = this.StudentDataGridView.CurrentRow.Cells[6].Value.ToString();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataShow();
        }

        //clear button implementation
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearkaramu();
        }

        //clear function
        private void clearkaramu()
        {
            txtAcademicYear.Clear();
            comprogramme.ResetText();
            numGrNUm.ResetText();
            numSubGruNum.ResetText();
            txtGID.Clear();
            txtSubGID.Clear();
        }

        private void StudentDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (studentID > 0)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE from studentinformation  where sid= ' " + studentID + " ' ", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("are you sure to delete this record?", "DELETE", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                DataShow();
            }

            else
            {
                MessageBox.Show("first you should select raw from the table", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
