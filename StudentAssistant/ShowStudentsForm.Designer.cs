namespace StudentAssistant
{
    partial class ShowStudentsForm
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
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.chooseuniversitydeantextBox = new System.Windows.Forms.TextBox();
            this.choosefacultydeantextBox = new System.Windows.Forms.TextBox();
            this.showstudentsbutton = new System.Windows.Forms.Button();
            this.DeleteStudentButton = new System.Windows.Forms.Button();
            this.SaveStudentsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(12, 93);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.Size = new System.Drawing.Size(776, 345);
            this.dataGridViewStudents.TabIndex = 0;
            // 
            // chooseuniversitydeantextBox
            // 
            this.chooseuniversitydeantextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseuniversitydeantextBox.ForeColor = System.Drawing.Color.DimGray;
            this.chooseuniversitydeantextBox.Location = new System.Drawing.Point(54, 31);
            this.chooseuniversitydeantextBox.Name = "chooseuniversitydeantextBox";
            this.chooseuniversitydeantextBox.Size = new System.Drawing.Size(158, 29);
            this.chooseuniversitydeantextBox.TabIndex = 1;
            this.chooseuniversitydeantextBox.Text = "University";
            // 
            // choosefacultydeantextBox
            // 
            this.choosefacultydeantextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choosefacultydeantextBox.ForeColor = System.Drawing.Color.DimGray;
            this.choosefacultydeantextBox.Location = new System.Drawing.Point(322, 31);
            this.choosefacultydeantextBox.Name = "choosefacultydeantextBox";
            this.choosefacultydeantextBox.Size = new System.Drawing.Size(158, 29);
            this.choosefacultydeantextBox.TabIndex = 2;
            this.choosefacultydeantextBox.Text = "Faculty";
            // 
            // showstudentsbutton
            // 
            this.showstudentsbutton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showstudentsbutton.Location = new System.Drawing.Point(571, 31);
            this.showstudentsbutton.Name = "showstudentsbutton";
            this.showstudentsbutton.Size = new System.Drawing.Size(158, 29);
            this.showstudentsbutton.TabIndex = 3;
            this.showstudentsbutton.Text = "Show students";
            this.showstudentsbutton.UseVisualStyleBackColor = true;
            this.showstudentsbutton.Click += new System.EventHandler(this.showstudentsbutton_Click);
            // 
            // DeleteStudentButton
            // 
            this.DeleteStudentButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteStudentButton.Location = new System.Drawing.Point(178, 462);
            this.DeleteStudentButton.Name = "DeleteStudentButton";
            this.DeleteStudentButton.Size = new System.Drawing.Size(158, 29);
            this.DeleteStudentButton.TabIndex = 4;
            this.DeleteStudentButton.Text = "Delete a Student";
            this.DeleteStudentButton.UseVisualStyleBackColor = true;
            // 
            // SaveStudentsButton
            // 
            this.SaveStudentsButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveStudentsButton.Location = new System.Drawing.Point(464, 462);
            this.SaveStudentsButton.Name = "SaveStudentsButton";
            this.SaveStudentsButton.Size = new System.Drawing.Size(158, 29);
            this.SaveStudentsButton.TabIndex = 5;
            this.SaveStudentsButton.Text = "Save";
            this.SaveStudentsButton.UseVisualStyleBackColor = true;
            // 
            // ShowStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.SaveStudentsButton);
            this.Controls.Add(this.DeleteStudentButton);
            this.Controls.Add(this.showstudentsbutton);
            this.Controls.Add(this.choosefacultydeantextBox);
            this.Controls.Add(this.chooseuniversitydeantextBox);
            this.Controls.Add(this.dataGridViewStudents);
            this.Name = "ShowStudentsForm";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.ShowStudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.TextBox chooseuniversitydeantextBox;
        private System.Windows.Forms.TextBox choosefacultydeantextBox;
        private System.Windows.Forms.Button showstudentsbutton;
        private System.Windows.Forms.Button DeleteStudentButton;
        private System.Windows.Forms.Button SaveStudentsButton;
    }
}