namespace StudentAssistant
{
    partial class LogInForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.StudentAssistantLabel = new System.Windows.Forms.Label();
            this.SignInStudentButton = new System.Windows.Forms.Button();
            this.SignInDeanButton = new System.Windows.Forms.Button();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.isDeancheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // StudentAssistantLabel
            // 
            this.StudentAssistantLabel.AutoSize = true;
            this.StudentAssistantLabel.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentAssistantLabel.Location = new System.Drawing.Point(83, 54);
            this.StudentAssistantLabel.Name = "StudentAssistantLabel";
            this.StudentAssistantLabel.Size = new System.Drawing.Size(274, 39);
            this.StudentAssistantLabel.TabIndex = 0;
            this.StudentAssistantLabel.Text = "Student Assistant";
            // 
            // SignInStudentButton
            // 
            this.SignInStudentButton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignInStudentButton.Location = new System.Drawing.Point(135, 143);
            this.SignInStudentButton.Name = "SignInStudentButton";
            this.SignInStudentButton.Size = new System.Drawing.Size(159, 41);
            this.SignInStudentButton.TabIndex = 1;
            this.SignInStudentButton.Text = "Sign in as Student";
            this.SignInStudentButton.UseVisualStyleBackColor = true;
            this.SignInStudentButton.Click += new System.EventHandler(this.SignInStudentButton_Click);
            // 
            // SignInDeanButton
            // 
            this.SignInDeanButton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignInDeanButton.Location = new System.Drawing.Point(135, 205);
            this.SignInDeanButton.Name = "SignInDeanButton";
            this.SignInDeanButton.Size = new System.Drawing.Size(159, 41);
            this.SignInDeanButton.TabIndex = 2;
            this.SignInDeanButton.Text = "Sign in as Dean";
            this.SignInDeanButton.UseVisualStyleBackColor = true;
            this.SignInDeanButton.Click += new System.EventHandler(this.SignInDeanButton_Click);
            // 
            // SignUpButton
            // 
            this.SignUpButton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignUpButton.Location = new System.Drawing.Point(135, 264);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(159, 41);
            this.SignUpButton.TabIndex = 3;
            this.SignUpButton.Text = "Sign up";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // isDeancheckBox
            // 
            this.isDeancheckBox.AutoSize = true;
            this.isDeancheckBox.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isDeancheckBox.Location = new System.Drawing.Point(135, 311);
            this.isDeancheckBox.Name = "isDeancheckBox";
            this.isDeancheckBox.Size = new System.Drawing.Size(65, 24);
            this.isDeancheckBox.TabIndex = 4;
            this.isDeancheckBox.Text = "Dean";
            this.isDeancheckBox.UseVisualStyleBackColor = true;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.isDeancheckBox);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.SignInDeanButton);
            this.Controls.Add(this.SignInStudentButton);
            this.Controls.Add(this.StudentAssistantLabel);
            this.Name = "LogInForm";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudentAssistantLabel;
        private System.Windows.Forms.Button SignInStudentButton;
        private System.Windows.Forms.Button SignInDeanButton;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.CheckBox isDeancheckBox;
    }
}

