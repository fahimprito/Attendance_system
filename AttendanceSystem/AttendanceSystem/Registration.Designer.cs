
namespace AttendanceSystem
{
    partial class Registration
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
            this.textBoxpass = new System.Windows.Forms.TextBox();
            this.textBoxuser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCpass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Registrationbt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.backbt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxpass
            // 
            this.textBoxpass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxpass.Location = new System.Drawing.Point(269, 154);
            this.textBoxpass.Name = "textBoxpass";
            this.textBoxpass.PasswordChar = '*';
            this.textBoxpass.Size = new System.Drawing.Size(258, 30);
            this.textBoxpass.TabIndex = 10;
            // 
            // textBoxuser
            // 
            this.textBoxuser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxuser.Location = new System.Drawing.Point(269, 105);
            this.textBoxuser.Name = "textBoxuser";
            this.textBoxuser.Size = new System.Drawing.Size(258, 30);
            this.textBoxuser.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(169, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(153, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "User Name";
            // 
            // textBoxCpass
            // 
            this.textBoxCpass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCpass.Location = new System.Drawing.Point(269, 201);
            this.textBoxCpass.Name = "textBoxCpass";
            this.textBoxCpass.PasswordChar = '*';
            this.textBoxCpass.Size = new System.Drawing.Size(258, 30);
            this.textBoxCpass.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(93, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "Confirm Password";
            // 
            // Registrationbt
            // 
            this.Registrationbt.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Registrationbt.Location = new System.Drawing.Point(357, 256);
            this.Registrationbt.Name = "Registrationbt";
            this.Registrationbt.Size = new System.Drawing.Size(108, 38);
            this.Registrationbt.TabIndex = 17;
            this.Registrationbt.Text = "Registration";
            this.Registrationbt.UseVisualStyleBackColor = true;
            this.Registrationbt.Click += new System.EventHandler(this.Registrationbt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(207, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 27);
            this.label3.TabIndex = 18;
            this.label3.Text = "Registration Form";
            // 
            // backbt
            // 
            this.backbt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backbt.Location = new System.Drawing.Point(269, 256);
            this.backbt.Name = "backbt";
            this.backbt.Size = new System.Drawing.Size(71, 38);
            this.backbt.TabIndex = 19;
            this.backbt.Text = "Back";
            this.backbt.UseVisualStyleBackColor = true;
            this.backbt.Click += new System.EventHandler(this.backbt_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 350);
            this.Controls.Add(this.backbt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Registrationbt);
            this.Controls.Add(this.textBoxCpass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxpass);
            this.Controls.Add(this.textBoxuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxpass;
        private System.Windows.Forms.TextBox textBoxuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Registrationbt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button backbt;
    }
}