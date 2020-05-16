namespace StudentAssistant
{
    partial class SignInDeanForn
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
            this.SirnInDeanLabel = new System.Windows.Forms.Label();
            this.SignInlogindeantextBox = new System.Windows.Forms.TextBox();
            this.SignInPasswordDeantextBox = new System.Windows.Forms.TextBox();
            this.SignInDeanButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SirnInDeanLabel
            // 
            this.SirnInDeanLabel.AutoSize = true;
            this.SirnInDeanLabel.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SirnInDeanLabel.Location = new System.Drawing.Point(147, 69);
            this.SirnInDeanLabel.Name = "SirnInDeanLabel";
            this.SirnInDeanLabel.Size = new System.Drawing.Size(209, 36);
            this.SirnInDeanLabel.TabIndex = 0;
            this.SirnInDeanLabel.Text = "Please, sign in";
            // 
            // SignInlogindeantextBox
            // 
            this.SignInlogindeantextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignInlogindeantextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SignInlogindeantextBox.Location = new System.Drawing.Point(172, 156);
            this.SignInlogindeantextBox.Name = "SignInlogindeantextBox";
            this.SignInlogindeantextBox.Size = new System.Drawing.Size(149, 25);
            this.SignInlogindeantextBox.TabIndex = 1;
            this.SignInlogindeantextBox.Text = "Login";
            this.SignInlogindeantextBox.TextChanged += new System.EventHandler(this.SignIndeantextBox_TextChanged);
            // 
            // SignInPasswordDeantextBox
            // 
            this.SignInPasswordDeantextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignInPasswordDeantextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SignInPasswordDeantextBox.Location = new System.Drawing.Point(173, 213);
            this.SignInPasswordDeantextBox.Name = "SignInPasswordDeantextBox";
            this.SignInPasswordDeantextBox.Size = new System.Drawing.Size(149, 25);
            this.SignInPasswordDeantextBox.TabIndex = 2;
            this.SignInPasswordDeantextBox.Text = "Password";
            this.SignInPasswordDeantextBox.UseSystemPasswordChar = true;
            // 
            // SignInDeanButton
            // 
            this.SignInDeanButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignInDeanButton.Location = new System.Drawing.Point(172, 289);
            this.SignInDeanButton.Name = "SignInDeanButton";
            this.SignInDeanButton.Size = new System.Drawing.Size(150, 33);
            this.SignInDeanButton.TabIndex = 3;
            this.SignInDeanButton.Text = "Sign In";
            this.SignInDeanButton.UseVisualStyleBackColor = true;
            this.SignInDeanButton.Click += new System.EventHandler(this.SignInDeanButton_Click);
            // 
            // SignInDeanForn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(494, 450);
            this.Controls.Add(this.SignInDeanButton);
            this.Controls.Add(this.SignInPasswordDeantextBox);
            this.Controls.Add(this.SignInlogindeantextBox);
            this.Controls.Add(this.SirnInDeanLabel);
            this.Name = "SignInDeanForn";
            this.Text = "Sign In Dean";
            this.Load += new System.EventHandler(this.SignInDeanForn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SirnInDeanLabel;
        private System.Windows.Forms.TextBox SignInlogindeantextBox;
        private System.Windows.Forms.TextBox SignInPasswordDeantextBox;
        private System.Windows.Forms.Button SignInDeanButton;
    }
}