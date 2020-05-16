namespace StudentAssistant
{
    partial class SignUpDean
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
            this.SignUpDeanLabel = new System.Windows.Forms.Label();
            this.NameDeantextBox = new System.Windows.Forms.TextBox();
            this.LoginDeantextBox = new System.Windows.Forms.TextBox();
            this.PasswordDeantextBox = new System.Windows.Forms.TextBox();
            this.UniversityDeantextBox = new System.Windows.Forms.TextBox();
            this.SurnameDeantextBox = new System.Windows.Forms.TextBox();
            this.FacultyDeantextBox = new System.Windows.Forms.TextBox();
            this.OkDeanButoon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SignUpDeanLabel
            // 
            this.SignUpDeanLabel.AutoSize = true;
            this.SignUpDeanLabel.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignUpDeanLabel.Location = new System.Drawing.Point(119, 28);
            this.SignUpDeanLabel.Name = "SignUpDeanLabel";
            this.SignUpDeanLabel.Size = new System.Drawing.Size(198, 36);
            this.SignUpDeanLabel.TabIndex = 0;
            this.SignUpDeanLabel.Text = "Please, enter:";
            // 
            // NameDeantextBox
            // 
            this.NameDeantextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameDeantextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.NameDeantextBox.Location = new System.Drawing.Point(142, 93);
            this.NameDeantextBox.Name = "NameDeantextBox";
            this.NameDeantextBox.Size = new System.Drawing.Size(156, 23);
            this.NameDeantextBox.TabIndex = 2;
            this.NameDeantextBox.Text = "Name";
            this.NameDeantextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LoginDeantextBox
            // 
            this.LoginDeantextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginDeantextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LoginDeantextBox.Location = new System.Drawing.Point(142, 179);
            this.LoginDeantextBox.Name = "LoginDeantextBox";
            this.LoginDeantextBox.Size = new System.Drawing.Size(156, 23);
            this.LoginDeantextBox.TabIndex = 3;
            this.LoginDeantextBox.Text = "Login";
            // 
            // PasswordDeantextBox
            // 
            this.PasswordDeantextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordDeantextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PasswordDeantextBox.Location = new System.Drawing.Point(142, 222);
            this.PasswordDeantextBox.Name = "PasswordDeantextBox";
            this.PasswordDeantextBox.Size = new System.Drawing.Size(156, 23);
            this.PasswordDeantextBox.TabIndex = 4;
            this.PasswordDeantextBox.Text = "Password";
            this.PasswordDeantextBox.UseSystemPasswordChar = true;
            // 
            // UniversityDeantextBox
            // 
            this.UniversityDeantextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UniversityDeantextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.UniversityDeantextBox.Location = new System.Drawing.Point(142, 264);
            this.UniversityDeantextBox.Name = "UniversityDeantextBox";
            this.UniversityDeantextBox.Size = new System.Drawing.Size(156, 23);
            this.UniversityDeantextBox.TabIndex = 5;
            this.UniversityDeantextBox.Text = "University";
            // 
            // SurnameDeantextBox
            // 
            this.SurnameDeantextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameDeantextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SurnameDeantextBox.Location = new System.Drawing.Point(142, 137);
            this.SurnameDeantextBox.Name = "SurnameDeantextBox";
            this.SurnameDeantextBox.Size = new System.Drawing.Size(156, 23);
            this.SurnameDeantextBox.TabIndex = 6;
            this.SurnameDeantextBox.Text = "Surname";
            // 
            // FacultyDeantextBox
            // 
            this.FacultyDeantextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FacultyDeantextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.FacultyDeantextBox.Location = new System.Drawing.Point(142, 305);
            this.FacultyDeantextBox.Name = "FacultyDeantextBox";
            this.FacultyDeantextBox.Size = new System.Drawing.Size(156, 23);
            this.FacultyDeantextBox.TabIndex = 7;
            this.FacultyDeantextBox.Text = "Faculty";
            // 
            // OkDeanButoon
            // 
            this.OkDeanButoon.Location = new System.Drawing.Point(142, 346);
            this.OkDeanButoon.Name = "OkDeanButoon";
            this.OkDeanButoon.Size = new System.Drawing.Size(156, 23);
            this.OkDeanButoon.TabIndex = 8;
            this.OkDeanButoon.Text = "OK";
            this.OkDeanButoon.UseVisualStyleBackColor = true;
            this.OkDeanButoon.Click += new System.EventHandler(this.OkDeanButoon_Click);
            // 
            // SignUpDean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(438, 411);
            this.Controls.Add(this.OkDeanButoon);
            this.Controls.Add(this.FacultyDeantextBox);
            this.Controls.Add(this.SurnameDeantextBox);
            this.Controls.Add(this.UniversityDeantextBox);
            this.Controls.Add(this.PasswordDeantextBox);
            this.Controls.Add(this.LoginDeantextBox);
            this.Controls.Add(this.NameDeantextBox);
            this.Controls.Add(this.SignUpDeanLabel);
            this.Name = "SignUpDean";
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.SignUpDean_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SignUpDeanLabel;
        private System.Windows.Forms.TextBox NameDeantextBox;
        private System.Windows.Forms.TextBox LoginDeantextBox;
        private System.Windows.Forms.TextBox PasswordDeantextBox;
        private System.Windows.Forms.TextBox UniversityDeantextBox;
        private System.Windows.Forms.TextBox SurnameDeantextBox;
        private System.Windows.Forms.TextBox FacultyDeantextBox;
        private System.Windows.Forms.Button OkDeanButoon;
    }
}