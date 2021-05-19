
namespace Crud_operation
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StudentDataGridView = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAcademicYear = new System.Windows.Forms.TextBox();
            this.txtSubGID = new System.Windows.Forms.TextBox();
            this.txtGID = new System.Windows.Forms.TextBox();
            this.comprogramme = new System.Windows.Forms.ComboBox();
            this.numGrNUm = new System.Windows.Forms.NumericUpDown();
            this.numSubGruNum = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGrNUm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSubGruNum)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentDataGridView
            // 
            this.StudentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDataGridView.Location = new System.Drawing.Point(40, 62);
            this.StudentDataGridView.Name = "StudentDataGridView";
            this.StudentDataGridView.RowHeadersWidth = 51;
            this.StudentDataGridView.RowTemplate.Height = 24;
            this.StudentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentDataGridView.Size = new System.Drawing.Size(581, 150);
            this.StudentDataGridView.TabIndex = 0;
            this.StudentDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDataGridView_CellContentClick);
            this.StudentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDataGridView_CellContentClick_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(712, 62);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 33);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(712, 121);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 33);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(712, 179);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 33);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Academic Year And Semester ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Programme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Group Nmber";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sub Group Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Group ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sub Group ID";
            // 
            // txtAcademicYear
            // 
            this.txtAcademicYear.Location = new System.Drawing.Point(286, 260);
            this.txtAcademicYear.Name = "txtAcademicYear";
            this.txtAcademicYear.Size = new System.Drawing.Size(100, 22);
            this.txtAcademicYear.TabIndex = 10;
            // 
            // txtSubGID
            // 
            this.txtSubGID.Location = new System.Drawing.Point(564, 372);
            this.txtSubGID.Name = "txtSubGID";
            this.txtSubGID.Size = new System.Drawing.Size(174, 22);
            this.txtSubGID.TabIndex = 11;
            this.txtSubGID.Text = "  ";
            // 
            // txtGID
            // 
            this.txtGID.Location = new System.Drawing.Point(574, 310);
            this.txtGID.Name = "txtGID";
            this.txtGID.Size = new System.Drawing.Size(144, 22);
            this.txtGID.TabIndex = 12;
            // 
            // comprogramme
            // 
            this.comprogramme.FormattingEnabled = true;
            this.comprogramme.Items.AddRange(new object[] {
            "cyber security",
            "information technology"});
            this.comprogramme.Location = new System.Drawing.Point(184, 313);
            this.comprogramme.Name = "comprogramme";
            this.comprogramme.Size = new System.Drawing.Size(121, 24);
            this.comprogramme.TabIndex = 13;
            // 
            // numGrNUm
            // 
            this.numGrNUm.Location = new System.Drawing.Point(185, 373);
            this.numGrNUm.Name = "numGrNUm";
            this.numGrNUm.Size = new System.Drawing.Size(120, 22);
            this.numGrNUm.TabIndex = 14;
            // 
            // numSubGruNum
            // 
            this.numSubGruNum.Location = new System.Drawing.Point(611, 261);
            this.numSubGruNum.Name = "numSubGruNum";
            this.numSubGruNum.Size = new System.Drawing.Size(143, 22);
            this.numSubGruNum.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(294, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "Manage Student Groups";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 484);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numSubGruNum);
            this.Controls.Add(this.numGrNUm);
            this.Controls.Add(this.comprogramme);
            this.Controls.Add(this.txtGID);
            this.Controls.Add(this.txtSubGID);
            this.Controls.Add(this.txtAcademicYear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.StudentDataGridView);
            this.Name = "Form2";
            this.Text = "manage student groups";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGrNUm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSubGruNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentDataGridView;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAcademicYear;
        private System.Windows.Forms.TextBox txtSubGID;
        private System.Windows.Forms.TextBox txtGID;
        private System.Windows.Forms.ComboBox comprogramme;
        private System.Windows.Forms.NumericUpDown numGrNUm;
        private System.Windows.Forms.NumericUpDown numSubGruNum;
        private System.Windows.Forms.Label label7;
    }
}