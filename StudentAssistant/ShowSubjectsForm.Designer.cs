namespace StudentAssistant
{
    partial class ShowSubjectsForm
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
            this.IDSubjecttextBox = new System.Windows.Forms.TextBox();
            this.DeleteStudentButton = new System.Windows.Forms.Button();
            this.showsubjectsbutton = new System.Windows.Forms.Button();
            this.choosefacultySubjecttextBox = new System.Windows.Forms.TextBox();
            this.chooseuniversitySubjecttextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewSubjects = new System.Windows.Forms.DataGridView();
            this.AddSubjectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // IDSubjecttextBox
            // 
            this.IDSubjecttextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDSubjecttextBox.ForeColor = System.Drawing.Color.DimGray;
            this.IDSubjecttextBox.Location = new System.Drawing.Point(54, 435);
            this.IDSubjecttextBox.Name = "IDSubjecttextBox";
            this.IDSubjecttextBox.Size = new System.Drawing.Size(158, 29);
            this.IDSubjecttextBox.TabIndex = 11;
            this.IDSubjecttextBox.Text = "ID";
            // 
            // DeleteStudentButton
            // 
            this.DeleteStudentButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteStudentButton.Location = new System.Drawing.Point(575, 434);
            this.DeleteStudentButton.Name = "DeleteStudentButton";
            this.DeleteStudentButton.Size = new System.Drawing.Size(158, 29);
            this.DeleteStudentButton.TabIndex = 10;
            this.DeleteStudentButton.Text = "Delete a Subject";
            this.DeleteStudentButton.UseVisualStyleBackColor = true;
            // 
            // showsubjectsbutton
            // 
            this.showsubjectsbutton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showsubjectsbutton.Location = new System.Drawing.Point(575, 12);
            this.showsubjectsbutton.Name = "showsubjectsbutton";
            this.showsubjectsbutton.Size = new System.Drawing.Size(158, 29);
            this.showsubjectsbutton.TabIndex = 9;
            this.showsubjectsbutton.Text = "Show subjects";
            this.showsubjectsbutton.UseVisualStyleBackColor = true;
            // 
            // choosefacultySubjecttextBox
            // 
            this.choosefacultySubjecttextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choosefacultySubjecttextBox.ForeColor = System.Drawing.Color.DimGray;
            this.choosefacultySubjecttextBox.Location = new System.Drawing.Point(322, 12);
            this.choosefacultySubjecttextBox.Name = "choosefacultySubjecttextBox";
            this.choosefacultySubjecttextBox.Size = new System.Drawing.Size(158, 29);
            this.choosefacultySubjecttextBox.TabIndex = 8;
            this.choosefacultySubjecttextBox.Text = "Faculty";
            // 
            // chooseuniversitySubjecttextBox
            // 
            this.chooseuniversitySubjecttextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseuniversitySubjecttextBox.ForeColor = System.Drawing.Color.DimGray;
            this.chooseuniversitySubjecttextBox.Location = new System.Drawing.Point(54, 12);
            this.chooseuniversitySubjecttextBox.Name = "chooseuniversitySubjecttextBox";
            this.chooseuniversitySubjecttextBox.Size = new System.Drawing.Size(158, 29);
            this.chooseuniversitySubjecttextBox.TabIndex = 7;
            this.chooseuniversitySubjecttextBox.Text = "University";
            // 
            // dataGridViewSubjects
            // 
            this.dataGridViewSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubjects.Location = new System.Drawing.Point(12, 59);
            this.dataGridViewSubjects.Name = "dataGridViewSubjects";
            this.dataGridViewSubjects.Size = new System.Drawing.Size(776, 345);
            this.dataGridViewSubjects.TabIndex = 6;
            // 
            // AddSubjectButton
            // 
            this.AddSubjectButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddSubjectButton.Location = new System.Drawing.Point(322, 434);
            this.AddSubjectButton.Name = "AddSubjectButton";
            this.AddSubjectButton.Size = new System.Drawing.Size(158, 29);
            this.AddSubjectButton.TabIndex = 12;
            this.AddSubjectButton.Text = "Add a Subject";
            this.AddSubjectButton.UseVisualStyleBackColor = true;
            // 
            // ShowSubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(803, 490);
            this.Controls.Add(this.AddSubjectButton);
            this.Controls.Add(this.IDSubjecttextBox);
            this.Controls.Add(this.DeleteStudentButton);
            this.Controls.Add(this.showsubjectsbutton);
            this.Controls.Add(this.choosefacultySubjecttextBox);
            this.Controls.Add(this.chooseuniversitySubjecttextBox);
            this.Controls.Add(this.dataGridViewSubjects);
            this.Name = "ShowSubjectsForm";
            this.Text = "Subjects";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDSubjecttextBox;
        private System.Windows.Forms.Button DeleteStudentButton;
        private System.Windows.Forms.Button showsubjectsbutton;
        private System.Windows.Forms.TextBox choosefacultySubjecttextBox;
        private System.Windows.Forms.TextBox chooseuniversitySubjecttextBox;
        private System.Windows.Forms.DataGridView dataGridViewSubjects;
        private System.Windows.Forms.Button AddSubjectButton;
    }
}