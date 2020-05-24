namespace StudentAssistant
{
    partial class StudentForm
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
            this.PrepareTimeButton = new System.Windows.Forms.Button();
            this.SortDifficultButton = new System.Windows.Forms.Button();
            this.SortDateButton = new System.Windows.Forms.Button();
            this.ExamDatetextBox = new System.Windows.Forms.TextBox();
            this.AddMaterialTextBox = new System.Windows.Forms.TextBox();
            this.MaterialTextBox = new System.Windows.Forms.TextBox();
            this.PreparetimetextBox = new System.Windows.Forms.TextBox();
            this.DifficulttextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewExam = new System.Windows.Forms.DataGridView();
            this.SubjectIDtextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewSubjectsStudent = new System.Windows.Forms.DataGridView();
            this.ShowSubjectsStudentButoon = new System.Windows.Forms.Button();
            this.AddExamButton = new System.Windows.Forms.Button();
            this.DeleteExamButton = new System.Windows.Forms.Button();
            this.ExamIDtextBox = new System.Windows.Forms.TextBox();
            this.ShowExamsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjectsStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // PrepareTimeButton
            // 
            this.PrepareTimeButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrepareTimeButton.Location = new System.Drawing.Point(441, 501);
            this.PrepareTimeButton.Name = "PrepareTimeButton";
            this.PrepareTimeButton.Size = new System.Drawing.Size(156, 37);
            this.PrepareTimeButton.TabIndex = 41;
            this.PrepareTimeButton.Text = "Prepare time only";
            this.PrepareTimeButton.UseVisualStyleBackColor = true;
            this.PrepareTimeButton.Click += new System.EventHandler(this.PrepareTimeButton_Click);
            // 
            // SortDifficultButton
            // 
            this.SortDifficultButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortDifficultButton.Location = new System.Drawing.Point(625, 501);
            this.SortDifficultButton.Name = "SortDifficultButton";
            this.SortDifficultButton.Size = new System.Drawing.Size(156, 37);
            this.SortDifficultButton.TabIndex = 40;
            this.SortDifficultButton.Text = "Sort by Difficult";
            this.SortDifficultButton.UseVisualStyleBackColor = true;
            this.SortDifficultButton.Click += new System.EventHandler(this.SortDifficultButton_Click);
            // 
            // SortDateButton
            // 
            this.SortDateButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortDateButton.Location = new System.Drawing.Point(253, 501);
            this.SortDateButton.Name = "SortDateButton";
            this.SortDateButton.Size = new System.Drawing.Size(156, 37);
            this.SortDateButton.TabIndex = 39;
            this.SortDateButton.Text = "Sort by Date";
            this.SortDateButton.UseVisualStyleBackColor = true;
            this.SortDateButton.Click += new System.EventHandler(this.SortDateButton_Click);
            // 
            // ExamDatetextBox
            // 
            this.ExamDatetextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExamDatetextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ExamDatetextBox.Location = new System.Drawing.Point(838, 379);
            this.ExamDatetextBox.Name = "ExamDatetextBox";
            this.ExamDatetextBox.Size = new System.Drawing.Size(149, 25);
            this.ExamDatetextBox.TabIndex = 38;
            this.ExamDatetextBox.Text = "Date";
            // 
            // AddMaterialTextBox
            // 
            this.AddMaterialTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddMaterialTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.AddMaterialTextBox.Location = new System.Drawing.Point(838, 317);
            this.AddMaterialTextBox.Name = "AddMaterialTextBox";
            this.AddMaterialTextBox.Size = new System.Drawing.Size(149, 25);
            this.AddMaterialTextBox.TabIndex = 37;
            this.AddMaterialTextBox.Text = "Additional material";
            // 
            // MaterialTextBox
            // 
            this.MaterialTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaterialTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.MaterialTextBox.Location = new System.Drawing.Point(838, 286);
            this.MaterialTextBox.Name = "MaterialTextBox";
            this.MaterialTextBox.Size = new System.Drawing.Size(149, 25);
            this.MaterialTextBox.TabIndex = 36;
            this.MaterialTextBox.Text = "Material";
            // 
            // PreparetimetextBox
            // 
            this.PreparetimetextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PreparetimetextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PreparetimetextBox.Location = new System.Drawing.Point(838, 348);
            this.PreparetimetextBox.Name = "PreparetimetextBox";
            this.PreparetimetextBox.Size = new System.Drawing.Size(149, 25);
            this.PreparetimetextBox.TabIndex = 35;
            this.PreparetimetextBox.Text = "Prepare time";
            // 
            // DifficulttextBox
            // 
            this.DifficulttextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DifficulttextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.DifficulttextBox.Location = new System.Drawing.Point(838, 255);
            this.DifficulttextBox.Name = "DifficulttextBox";
            this.DifficulttextBox.Size = new System.Drawing.Size(149, 25);
            this.DifficulttextBox.TabIndex = 34;
            this.DifficulttextBox.Text = "Difficult";
            // 
            // dataGridViewExam
            // 
            this.dataGridViewExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExam.Location = new System.Drawing.Point(46, 273);
            this.dataGridViewExam.Name = "dataGridViewExam";
            this.dataGridViewExam.Size = new System.Drawing.Size(753, 207);
            this.dataGridViewExam.TabIndex = 33;
            // 
            // SubjectIDtextBox
            // 
            this.SubjectIDtextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubjectIDtextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SubjectIDtextBox.Location = new System.Drawing.Point(838, 224);
            this.SubjectIDtextBox.Name = "SubjectIDtextBox";
            this.SubjectIDtextBox.Size = new System.Drawing.Size(149, 25);
            this.SubjectIDtextBox.TabIndex = 29;
            this.SubjectIDtextBox.Text = "Subject ID";
            this.SubjectIDtextBox.TextChanged += new System.EventHandler(this.SubjectIDtextBox_TextChanged);
            // 
            // dataGridViewSubjectsStudent
            // 
            this.dataGridViewSubjectsStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubjectsStudent.Location = new System.Drawing.Point(46, 29);
            this.dataGridViewSubjectsStudent.Name = "dataGridViewSubjectsStudent";
            this.dataGridViewSubjectsStudent.Size = new System.Drawing.Size(753, 221);
            this.dataGridViewSubjectsStudent.TabIndex = 28;
            // 
            // ShowSubjectsStudentButoon
            // 
            this.ShowSubjectsStudentButoon.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowSubjectsStudentButoon.Location = new System.Drawing.Point(838, 29);
            this.ShowSubjectsStudentButoon.Name = "ShowSubjectsStudentButoon";
            this.ShowSubjectsStudentButoon.Size = new System.Drawing.Size(156, 37);
            this.ShowSubjectsStudentButoon.TabIndex = 27;
            this.ShowSubjectsStudentButoon.Text = "Show subjects";
            this.ShowSubjectsStudentButoon.UseVisualStyleBackColor = true;
            this.ShowSubjectsStudentButoon.Click += new System.EventHandler(this.ShowSubjectsStudentButoon_Click);
            // 
            // AddExamButton
            // 
            this.AddExamButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddExamButton.Location = new System.Drawing.Point(838, 410);
            this.AddExamButton.Name = "AddExamButton";
            this.AddExamButton.Size = new System.Drawing.Size(156, 37);
            this.AddExamButton.TabIndex = 42;
            this.AddExamButton.Text = "Add exam";
            this.AddExamButton.UseVisualStyleBackColor = true;
            this.AddExamButton.Click += new System.EventHandler(this.AddExamButton_Click);
            // 
            // DeleteExamButton
            // 
            this.DeleteExamButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteExamButton.Location = new System.Drawing.Point(838, 501);
            this.DeleteExamButton.Name = "DeleteExamButton";
            this.DeleteExamButton.Size = new System.Drawing.Size(156, 37);
            this.DeleteExamButton.TabIndex = 43;
            this.DeleteExamButton.Text = "Delete exam";
            this.DeleteExamButton.UseVisualStyleBackColor = true;
            this.DeleteExamButton.Click += new System.EventHandler(this.DeleteExamButton_Click);
            // 
            // ExamIDtextBox
            // 
            this.ExamIDtextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExamIDtextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ExamIDtextBox.Location = new System.Drawing.Point(838, 470);
            this.ExamIDtextBox.Name = "ExamIDtextBox";
            this.ExamIDtextBox.Size = new System.Drawing.Size(156, 25);
            this.ExamIDtextBox.TabIndex = 44;
            this.ExamIDtextBox.Text = "Exam ID";
            // 
            // ShowExamsButton
            // 
            this.ShowExamsButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowExamsButton.Location = new System.Drawing.Point(65, 501);
            this.ShowExamsButton.Name = "ShowExamsButton";
            this.ShowExamsButton.Size = new System.Drawing.Size(156, 37);
            this.ShowExamsButton.TabIndex = 45;
            this.ShowExamsButton.Text = "Show exams";
            this.ShowExamsButton.UseVisualStyleBackColor = true;
            this.ShowExamsButton.Click += new System.EventHandler(this.ShowExamsButton_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1029, 558);
            this.Controls.Add(this.ShowExamsButton);
            this.Controls.Add(this.ExamIDtextBox);
            this.Controls.Add(this.DeleteExamButton);
            this.Controls.Add(this.AddExamButton);
            this.Controls.Add(this.PrepareTimeButton);
            this.Controls.Add(this.SortDifficultButton);
            this.Controls.Add(this.SortDateButton);
            this.Controls.Add(this.ExamDatetextBox);
            this.Controls.Add(this.AddMaterialTextBox);
            this.Controls.Add(this.MaterialTextBox);
            this.Controls.Add(this.PreparetimetextBox);
            this.Controls.Add(this.DifficulttextBox);
            this.Controls.Add(this.dataGridViewExam);
            this.Controls.Add(this.SubjectIDtextBox);
            this.Controls.Add(this.dataGridViewSubjectsStudent);
            this.Controls.Add(this.ShowSubjectsStudentButoon);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjectsStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PrepareTimeButton;
        private System.Windows.Forms.Button SortDifficultButton;
        private System.Windows.Forms.Button SortDateButton;
        private System.Windows.Forms.Button ShowSubjectsStudentButoon;
        public System.Windows.Forms.DataGridView dataGridViewSubjectsStudent;
        public System.Windows.Forms.DataGridView dataGridViewExam;
        private System.Windows.Forms.Button AddExamButton;
        private System.Windows.Forms.Button DeleteExamButton;
        public System.Windows.Forms.TextBox ExamIDtextBox;
        public System.Windows.Forms.TextBox ExamDatetextBox;
        public System.Windows.Forms.TextBox AddMaterialTextBox;
        public System.Windows.Forms.TextBox MaterialTextBox;
        public System.Windows.Forms.TextBox PreparetimetextBox;
        public System.Windows.Forms.TextBox DifficulttextBox;
        public System.Windows.Forms.TextBox SubjectIDtextBox;
        private System.Windows.Forms.Button ShowExamsButton;
    }
}