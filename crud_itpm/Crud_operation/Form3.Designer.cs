
namespace Crud_operation
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tagsaveBTN = new System.Windows.Forms.Button();
            this.txttagname = new System.Windows.Forms.TextBox();
            this.txttagcode = new System.Windows.Forms.TextBox();
            this.cmbrelatedtag = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tag Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tag Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Related Tag";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tagsaveBTN
            // 
            this.tagsaveBTN.Location = new System.Drawing.Point(408, 376);
            this.tagsaveBTN.Name = "tagsaveBTN";
            this.tagsaveBTN.Size = new System.Drawing.Size(83, 31);
            this.tagsaveBTN.TabIndex = 4;
            this.tagsaveBTN.Text = "Save";
            this.tagsaveBTN.UseVisualStyleBackColor = true;
            this.tagsaveBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // txttagname
            // 
            this.txttagname.Location = new System.Drawing.Point(244, 100);
            this.txttagname.Name = "txttagname";
            this.txttagname.Size = new System.Drawing.Size(175, 22);
            this.txttagname.TabIndex = 5;
            this.txttagname.TextChanged += new System.EventHandler(this.txttagname_TextChanged);
            // 
            // txttagcode
            // 
            this.txttagcode.Location = new System.Drawing.Point(244, 167);
            this.txttagcode.Name = "txttagcode";
            this.txttagcode.Size = new System.Drawing.Size(175, 22);
            this.txttagcode.TabIndex = 6;
            // 
            // cmbrelatedtag
            // 
            this.cmbrelatedtag.FormattingEnabled = true;
            this.cmbrelatedtag.Location = new System.Drawing.Point(244, 245);
            this.cmbrelatedtag.Name = "cmbrelatedtag";
            this.cmbrelatedtag.Size = new System.Drawing.Size(175, 24);
            this.cmbrelatedtag.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Add Tag";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbrelatedtag);
            this.Controls.Add(this.txttagcode);
            this.Controls.Add(this.txttagname);
            this.Controls.Add(this.tagsaveBTN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "add tag";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button tagsaveBTN;
        private System.Windows.Forms.TextBox txttagname;
        private System.Windows.Forms.TextBox txttagcode;
        private System.Windows.Forms.ComboBox cmbrelatedtag;
        private System.Windows.Forms.Label label4;
    }
}