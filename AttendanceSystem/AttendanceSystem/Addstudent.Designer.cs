
namespace AttendanceSystem
{
    partial class Addstudent
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
            this.SnameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addclassBt = new System.Windows.Forms.Button();
            this.attendanceTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SnameTB
            // 
            this.SnameTB.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SnameTB.Location = new System.Drawing.Point(53, 56);
            this.SnameTB.Name = "SnameTB";
            this.SnameTB.Size = new System.Drawing.Size(233, 29);
            this.SnameTB.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(53, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Student Name";
            // 
            // addclassBt
            // 
            this.addclassBt.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addclassBt.Location = new System.Drawing.Point(292, 112);
            this.addclassBt.Name = "addclassBt";
            this.addclassBt.Size = new System.Drawing.Size(94, 29);
            this.addclassBt.TabIndex = 7;
            this.addclassBt.Text = "ADD";
            this.addclassBt.UseVisualStyleBackColor = true;
            this.addclassBt.Click += new System.EventHandler(this.addclassBt_Click);
            // 
            // attendanceTb
            // 
            this.attendanceTb.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.attendanceTb.Location = new System.Drawing.Point(53, 112);
            this.attendanceTb.Name = "attendanceTb";
            this.attendanceTb.Size = new System.Drawing.Size(233, 29);
            this.attendanceTb.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Attendance";
            // 
            // Addstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 191);
            this.Controls.Add(this.SnameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addclassBt);
            this.Controls.Add(this.attendanceTb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Addstudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SnameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addclassBt;
        private System.Windows.Forms.TextBox attendanceTb;
        private System.Windows.Forms.Label label1;
    }
}