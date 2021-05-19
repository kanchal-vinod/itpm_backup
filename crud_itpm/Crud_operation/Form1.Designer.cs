
using System;

namespace Crud_operation
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb6 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.ll = new System.Windows.Forms.Label();
            this.txtSubGroupID = new System.Windows.Forms.TextBox();
            this.txtGroupID = new System.Windows.Forms.TextBox();
            this.txtAcademicYear = new System.Windows.Forms.TextBox();
            this.numSubGroupNum = new System.Windows.Forms.NumericUpDown();
            this.numGroupNum = new System.Windows.Forms.NumericUpDown();
            this.cmbProgramme = new System.Windows.Forms.ComboBox();
            this.btnGenarateID = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSubGroupNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGroupNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Students Groups";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Cursor = System.Windows.Forms.Cursors.PanSW;
            this.lb1.Location = new System.Drawing.Point(39, 116);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(194, 17);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Academic Year And semester";
            this.lb1.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(39, 181);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(81, 17);
            this.lb2.TabIndex = 2;
            this.lb2.Text = "Programme";
            this.lb2.Click += new System.EventHandler(this.label3_Click);
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(39, 250);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(100, 17);
            this.lb4.TabIndex = 3;
            this.lb4.Text = "Group number";
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.Location = new System.Drawing.Point(564, 186);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(94, 17);
            this.lb6.TabIndex = 4;
            this.lb6.Text = "Sub Group ID";
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Location = new System.Drawing.Point(564, 119);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(65, 17);
            this.lb5.TabIndex = 5;
            this.lb5.Text = "Group ID";
            this.lb5.Click += new System.EventHandler(this.label6_Click);
            // 
            // ll
            // 
            this.ll.AutoSize = true;
            this.ll.Location = new System.Drawing.Point(42, 312);
            this.ll.Name = "ll";
            this.ll.Size = new System.Drawing.Size(131, 17);
            this.ll.TabIndex = 6;
            this.ll.Text = "Sub Group Number";
            this.ll.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtSubGroupID
            // 
            this.txtSubGroupID.Location = new System.Drawing.Point(724, 181);
            this.txtSubGroupID.Name = "txtSubGroupID";
            this.txtSubGroupID.Size = new System.Drawing.Size(169, 22);
            this.txtSubGroupID.TabIndex = 7;
            // 
            // txtGroupID
            // 
            this.txtGroupID.Location = new System.Drawing.Point(724, 111);
            this.txtGroupID.Name = "txtGroupID";
            this.txtGroupID.Size = new System.Drawing.Size(169, 22);
            this.txtGroupID.TabIndex = 8;
            // 
            // txtAcademicYear
            // 
            this.txtAcademicYear.Location = new System.Drawing.Point(258, 116);
            this.txtAcademicYear.Name = "txtAcademicYear";
            this.txtAcademicYear.Size = new System.Drawing.Size(194, 22);
            this.txtAcademicYear.TabIndex = 9;
            this.txtAcademicYear.TextChanged += new System.EventHandler(this.txtAcademicYear_TextChanged);
            // 
            // numSubGroupNum
            // 
            this.numSubGroupNum.Location = new System.Drawing.Point(258, 307);
            this.numSubGroupNum.Name = "numSubGroupNum";
            this.numSubGroupNum.Size = new System.Drawing.Size(194, 22);
            this.numSubGroupNum.TabIndex = 10;
            // 
            // numGroupNum
            // 
            this.numGroupNum.Location = new System.Drawing.Point(258, 236);
            this.numGroupNum.Name = "numGroupNum";
            this.numGroupNum.Size = new System.Drawing.Size(194, 22);
            this.numGroupNum.TabIndex = 11;
            this.numGroupNum.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // cmbProgramme
            // 
            this.cmbProgramme.FormattingEnabled = true;
            this.cmbProgramme.Items.AddRange(new object[] {
            "softwear",
            "it"});
            this.cmbProgramme.Location = new System.Drawing.Point(257, 174);
            this.cmbProgramme.Name = "cmbProgramme";
            this.cmbProgramme.Size = new System.Drawing.Size(195, 24);
            this.cmbProgramme.TabIndex = 12;
            this.cmbProgramme.SelectedIndexChanged += new System.EventHandler(this.cmbProgramme_SelectedIndexChanged);
            // 
            // btnGenarateID
            // 
            this.btnGenarateID.Location = new System.Drawing.Point(567, 271);
            this.btnGenarateID.Name = "btnGenarateID";
            this.btnGenarateID.Size = new System.Drawing.Size(141, 38);
            this.btnGenarateID.TabIndex = 13;
            this.btnGenarateID.Text = "Genarate IDs";
            this.btnGenarateID.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(294, 402);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 33);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(511, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 16;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 495);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGenarateID);
            this.Controls.Add(this.cmbProgramme);
            this.Controls.Add(this.numGroupNum);
            this.Controls.Add(this.numSubGroupNum);
            this.Controls.Add(this.txtAcademicYear);
            this.Controls.Add(this.txtGroupID);
            this.Controls.Add(this.txtSubGroupID);
            this.Controls.Add(this.ll);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.lb6);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "add students groups";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSubGroupNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGroupNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

     

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label ll;
        private System.Windows.Forms.TextBox txtSubGroupID;
        private System.Windows.Forms.TextBox txtGroupID;
        private System.Windows.Forms.TextBox txtAcademicYear;
        private System.Windows.Forms.NumericUpDown numSubGroupNum;
        private System.Windows.Forms.NumericUpDown numGroupNum;
        private System.Windows.Forms.ComboBox cmbProgramme;
        private System.Windows.Forms.Button btnGenarateID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button1;
    }
}

