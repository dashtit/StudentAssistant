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
            this.DeanAccForm = new System.Windows.Forms.Label();
            this.ShowStudentsButton = new System.Windows.Forms.Button();
            this.ShowSubjetcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeanAccForm
            // 
            this.DeanAccForm.AutoSize = true;
            this.DeanAccForm.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeanAccForm.Location = new System.Drawing.Point(163, 65);
            this.DeanAccForm.Name = "DeanAccForm";
            this.DeanAccForm.Size = new System.Drawing.Size(214, 36);
            this.DeanAccForm.TabIndex = 0;
            this.DeanAccForm.Text = "Please, choose";
            this.DeanAccForm.Click += new System.EventHandler(this.DeanAccForm_Click);
            // 
            // ShowStudentsButton
            // 
            this.ShowStudentsButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowStudentsButton.Location = new System.Drawing.Point(66, 159);
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
            this.ShowSubjetcButton.Location = new System.Drawing.Point(330, 159);
            this.ShowSubjetcButton.Name = "ShowSubjetcButton";
            this.ShowSubjetcButton.Size = new System.Drawing.Size(136, 40);
            this.ShowSubjetcButton.TabIndex = 4;
            this.ShowSubjetcButton.Text = "Show subjects";
            this.ShowSubjetcButton.UseVisualStyleBackColor = true;
            this.ShowSubjetcButton.Click += new System.EventHandler(this.ShowSubjetcButton_Click);
            // 
            // DeanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(545, 327);
            this.Controls.Add(this.ShowSubjetcButton);
            this.Controls.Add(this.ShowStudentsButton);
            this.Controls.Add(this.DeanAccForm);
            this.Name = "DeanForm";
            this.Text = "Student Assistant";
            this.Load += new System.EventHandler(this.DeanForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DeanAccForm;
        private System.Windows.Forms.Button ShowStudentsButton;
        private System.Windows.Forms.Button ShowSubjetcButton;
    }
}