namespace StudentAssistant
{
    partial class DeanForm
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
            this.components = new System.ComponentModel.Container();
            this.ShowStudentsButton = new System.Windows.Forms.Button();
            this.ShowSubjetcButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timeManagerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeManagerDataSet = new StudentAssistant.TimeManagerDataSet();
            this.DeleteStudentButton = new System.Windows.Forms.Button();
            this.AddSubjectButton = new System.Windows.Forms.Button();
            this.DeleteSubjectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SubjectNameTextBox = new System.Windows.Forms.TextBox();
            this.CourseTextBox = new System.Windows.Forms.TextBox();
            this.SubjectIDtextBox = new System.Windows.Forms.TextBox();
            this.StudentIDtextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeManagerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeManagerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowStudentsButton
            // 
            this.ShowStudentsButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowStudentsButton.Location = new System.Drawing.Point(786, 188);
            this.ShowStudentsButton.Name = "ShowStudentsButton";
            this.ShowStudentsButton.Size = new System.Drawing.Size(136, 40);
            this.ShowStudentsButton.TabIndex = 1;
            this.ShowStudentsButton.Text = "Show students";
            this.ShowStudentsButton.UseVisualStyleBackColor = true;
            this.ShowStudentsButton.Click += new System.EventHandler(this.ShowStudentsButton_Click);
            // 
            // ShowSubjetcButton
            // 
            this.ShowSubjetcButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowSubjetcButton.Location = new System.Drawing.Point(786, 94);
            this.ShowSubjetcButton.Name = "ShowSubjetcButton";
            this.ShowSubjetcButton.Size = new System.Drawing.Size(136, 40);
            this.ShowSubjetcButton.TabIndex = 4;
            this.ShowSubjetcButton.Text = "Show subjects";
            this.ShowSubjetcButton.UseVisualStyleBackColor = true;
            this.ShowSubjetcButton.Click += new System.EventHandler(this.ShowSubjetcButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(738, 339);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // timeManagerDataSetBindingSource
            // 
            this.timeManagerDataSetBindingSource.DataSource = this.timeManagerDataSet;
            this.timeManagerDataSetBindingSource.Position = 0;
            // 
            // timeManagerDataSet
            // 
            this.timeManagerDataSet.DataSetName = "TimeManagerDataSet";
            this.timeManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DeleteStudentButton
            // 
            this.DeleteStudentButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteStudentButton.Location = new System.Drawing.Point(786, 408);
            this.DeleteStudentButton.Name = "DeleteStudentButton";
            this.DeleteStudentButton.Size = new System.Drawing.Size(136, 40);
            this.DeleteStudentButton.TabIndex = 6;
            this.DeleteStudentButton.Text = "Delete a Student";
            this.DeleteStudentButton.UseVisualStyleBackColor = true;
            this.DeleteStudentButton.Click += new System.EventHandler(this.DeleteStudentButton_Click);
            // 
            // AddSubjectButton
            // 
            this.AddSubjectButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddSubjectButton.Location = new System.Drawing.Point(165, 408);
            this.AddSubjectButton.Name = "AddSubjectButton";
            this.AddSubjectButton.Size = new System.Drawing.Size(136, 40);
            this.AddSubjectButton.TabIndex = 7;
            this.AddSubjectButton.Text = "Add a Subject";
            this.AddSubjectButton.UseVisualStyleBackColor = true;
            this.AddSubjectButton.Click += new System.EventHandler(this.AddSubjectButton_Click);
            // 
            // DeleteSubjectButton
            // 
            this.DeleteSubjectButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteSubjectButton.Location = new System.Drawing.Point(478, 408);
            this.DeleteSubjectButton.Name = "DeleteSubjectButton";
            this.DeleteSubjectButton.Size = new System.Drawing.Size(136, 40);
            this.DeleteSubjectButton.TabIndex = 8;
            this.DeleteSubjectButton.Text = "Delete a Subject";
            this.DeleteSubjectButton.UseVisualStyleBackColor = true;
            this.DeleteSubjectButton.Click += new System.EventHandler(this.DeleteSubjectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(662, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            // 
            // SubjectNameTextBox
            // 
            this.SubjectNameTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubjectNameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SubjectNameTextBox.Location = new System.Drawing.Point(13, 387);
            this.SubjectNameTextBox.Name = "SubjectNameTextBox";
            this.SubjectNameTextBox.Size = new System.Drawing.Size(136, 25);
            this.SubjectNameTextBox.TabIndex = 10;
            this.SubjectNameTextBox.Text = "Subject name";
            this.SubjectNameTextBox.TextChanged += new System.EventHandler(this.SignInlogindeantextBox_TextChanged);
            // 
            // CourseTextBox
            // 
            this.CourseTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CourseTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CourseTextBox.Location = new System.Drawing.Point(13, 435);
            this.CourseTextBox.Name = "CourseTextBox";
            this.CourseTextBox.Size = new System.Drawing.Size(136, 25);
            this.CourseTextBox.TabIndex = 11;
            this.CourseTextBox.Text = "Course";
            // 
            // SubjectIDtextBox
            // 
            this.SubjectIDtextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubjectIDtextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SubjectIDtextBox.Location = new System.Drawing.Point(326, 416);
            this.SubjectIDtextBox.Name = "SubjectIDtextBox";
            this.SubjectIDtextBox.Size = new System.Drawing.Size(136, 25);
            this.SubjectIDtextBox.TabIndex = 12;
            this.SubjectIDtextBox.Text = "Subject ID";
            // 
            // StudentIDtextBox
            // 
            this.StudentIDtextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentIDtextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.StudentIDtextBox.Location = new System.Drawing.Point(634, 416);
            this.StudentIDtextBox.Name = "StudentIDtextBox";
            this.StudentIDtextBox.Size = new System.Drawing.Size(136, 25);
            this.StudentIDtextBox.TabIndex = 13;
            this.StudentIDtextBox.Text = "Student ID";
            // 
            // DeanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(946, 486);
            this.Controls.Add(this.StudentIDtextBox);
            this.Controls.Add(this.SubjectIDtextBox);
            this.Controls.Add(this.CourseTextBox);
            this.Controls.Add(this.SubjectNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteSubjectButton);
            this.Controls.Add(this.AddSubjectButton);
            this.Controls.Add(this.DeleteStudentButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ShowSubjetcButton);
            this.Controls.Add(this.ShowStudentsButton);
            this.Name = "DeanForm";
            this.Text = "Student Assistant";
            this.Load += new System.EventHandler(this.DeanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeManagerDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeManagerDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ShowStudentsButton;
        private System.Windows.Forms.Button ShowSubjetcButton;
        private System.Windows.Forms.BindingSource timeManagerDataSetBindingSource;
        private TimeManagerDataSet timeManagerDataSet;
        private System.Windows.Forms.Button DeleteStudentButton;
        private System.Windows.Forms.Button AddSubjectButton;
        private System.Windows.Forms.Button DeleteSubjectButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox SubjectNameTextBox;
        public System.Windows.Forms.TextBox CourseTextBox;
        public System.Windows.Forms.TextBox SubjectIDtextBox;
        public System.Windows.Forms.TextBox StudentIDtextBox;
    }
}