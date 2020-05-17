namespace StudentAssistant
{
    partial class SignInStudent
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
            this.SignInStudentButton = new System.Windows.Forms.Button();
            this.SignInPasswordstudenttextBox = new System.Windows.Forms.TextBox();
            this.SignInloginstudenttextBox = new System.Windows.Forms.TextBox();
            this.SirnInStudentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SignInStudentButton
            // 
            this.SignInStudentButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignInStudentButton.Location = new System.Drawing.Point(202, 319);
            this.SignInStudentButton.Name = "SignInStudentButton";
            this.SignInStudentButton.Size = new System.Drawing.Size(150, 33);
            this.SignInStudentButton.TabIndex = 7;
            this.SignInStudentButton.Text = "Sign In";
            this.SignInStudentButton.UseVisualStyleBackColor = true;
            this.SignInStudentButton.Click += new System.EventHandler(this.SignInStudentButton_Click);
            // 
            // SignInPasswordstudenttextBox
            // 
            this.SignInPasswordstudenttextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignInPasswordstudenttextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SignInPasswordstudenttextBox.Location = new System.Drawing.Point(203, 243);
            this.SignInPasswordstudenttextBox.Name = "SignInPasswordstudenttextBox";
            this.SignInPasswordstudenttextBox.Size = new System.Drawing.Size(149, 25);
            this.SignInPasswordstudenttextBox.TabIndex = 6;
            this.SignInPasswordstudenttextBox.Text = "Password";
            this.SignInPasswordstudenttextBox.UseSystemPasswordChar = true;
            // 
            // SignInloginstudenttextBox
            // 
            this.SignInloginstudenttextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignInloginstudenttextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SignInloginstudenttextBox.Location = new System.Drawing.Point(202, 186);
            this.SignInloginstudenttextBox.Name = "SignInloginstudenttextBox";
            this.SignInloginstudenttextBox.Size = new System.Drawing.Size(149, 25);
            this.SignInloginstudenttextBox.TabIndex = 5;
            this.SignInloginstudenttextBox.Text = "Login";
            // 
            // SirnInStudentLabel
            // 
            this.SirnInStudentLabel.AutoSize = true;
            this.SirnInStudentLabel.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SirnInStudentLabel.Location = new System.Drawing.Point(177, 99);
            this.SirnInStudentLabel.Name = "SirnInStudentLabel";
            this.SirnInStudentLabel.Size = new System.Drawing.Size(209, 36);
            this.SirnInStudentLabel.TabIndex = 4;
            this.SirnInStudentLabel.Text = "Please, sign in";
            // 
            // SignInStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.SignInStudentButton);
            this.Controls.Add(this.SignInPasswordstudenttextBox);
            this.Controls.Add(this.SignInloginstudenttextBox);
            this.Controls.Add(this.SirnInStudentLabel);
            this.Name = "SignInStudent";
            this.Text = "Sign In Student";
            this.Load += new System.EventHandler(this.SignInStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignInStudentButton;
        private System.Windows.Forms.TextBox SignInPasswordstudenttextBox;
        private System.Windows.Forms.TextBox SignInloginstudenttextBox;
        private System.Windows.Forms.Label SirnInStudentLabel;
    }
}