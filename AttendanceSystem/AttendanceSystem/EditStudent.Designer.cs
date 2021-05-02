
namespace AttendanceSystem
{
    partial class EditStudent
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
            this.SnameTBupdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updateBt = new System.Windows.Forms.Button();
            this.attendanceTbupdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tbidupdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SnameTBupdate
            // 
            this.SnameTBupdate.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SnameTBupdate.Location = new System.Drawing.Point(63, 183);
            this.SnameTBupdate.Name = "SnameTBupdate";
            this.SnameTBupdate.Size = new System.Drawing.Size(233, 29);
            this.SnameTBupdate.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(63, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Student Name";
            // 
            // updateBt
            // 
            this.updateBt.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateBt.Location = new System.Drawing.Point(187, 274);
            this.updateBt.Name = "updateBt";
            this.updateBt.Size = new System.Drawing.Size(109, 43);
            this.updateBt.TabIndex = 12;
            this.updateBt.Text = "Update";
            this.updateBt.UseVisualStyleBackColor = true;
            this.updateBt.Click += new System.EventHandler(this.updateBt_Click);
            // 
            // attendanceTbupdate
            // 
            this.attendanceTbupdate.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.attendanceTbupdate.Location = new System.Drawing.Point(63, 239);
            this.attendanceTbupdate.Name = "attendanceTbupdate";
            this.attendanceTbupdate.Size = new System.Drawing.Size(233, 29);
            this.attendanceTbupdate.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(63, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Attendance";
            // 
            // Tbidupdate
            // 
            this.Tbidupdate.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tbidupdate.Location = new System.Drawing.Point(63, 65);
            this.Tbidupdate.Name = "Tbidupdate";
            this.Tbidupdate.Size = new System.Drawing.Size(233, 29);
            this.Tbidupdate.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(63, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Student ID";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(187, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 43);
            this.button1.TabIndex = 17;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 367);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tbidupdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SnameTBupdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updateBt);
            this.Controls.Add(this.attendanceTbupdate);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SnameTBupdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updateBt;
        private System.Windows.Forms.TextBox attendanceTbupdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tbidupdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}