
namespace AttendanceSystem
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtClasses = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.addstudentBt = new System.Windows.Forms.Button();
            this.EditstudentBt = new System.Windows.Forms.Button();
            this.delstudentBt = new System.Windows.Forms.Button();
            this.LogoutBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(70, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Information";
            // 
            // dtClasses
            // 
            this.dtClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtClasses.Location = new System.Drawing.Point(70, 85);
            this.dtClasses.Name = "dtClasses";
            this.dtClasses.RowHeadersWidth = 51;
            this.dtClasses.RowTemplate.Height = 29;
            this.dtClasses.Size = new System.Drawing.Size(494, 394);
            this.dtClasses.TabIndex = 2;
            this.dtClasses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtClasses_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(570, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addstudentBt
            // 
            this.addstudentBt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addstudentBt.Location = new System.Drawing.Point(570, 85);
            this.addstudentBt.Name = "addstudentBt";
            this.addstudentBt.Size = new System.Drawing.Size(141, 57);
            this.addstudentBt.TabIndex = 7;
            this.addstudentBt.Text = "Add Student";
            this.addstudentBt.UseVisualStyleBackColor = true;
            this.addstudentBt.Click += new System.EventHandler(this.addstudentBt_Click);
            // 
            // EditstudentBt
            // 
            this.EditstudentBt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditstudentBt.Location = new System.Drawing.Point(570, 170);
            this.EditstudentBt.Name = "EditstudentBt";
            this.EditstudentBt.Size = new System.Drawing.Size(141, 57);
            this.EditstudentBt.TabIndex = 8;
            this.EditstudentBt.Text = "Edit Student";
            this.EditstudentBt.UseVisualStyleBackColor = true;
            this.EditstudentBt.Click += new System.EventHandler(this.EditstudentBt_Click);
            // 
            // delstudentBt
            // 
            this.delstudentBt.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delstudentBt.Location = new System.Drawing.Point(570, 260);
            this.delstudentBt.Name = "delstudentBt";
            this.delstudentBt.Size = new System.Drawing.Size(141, 57);
            this.delstudentBt.TabIndex = 9;
            this.delstudentBt.Text = "Delete Student";
            this.delstudentBt.UseVisualStyleBackColor = true;
            this.delstudentBt.Click += new System.EventHandler(this.delstudentBt_Click);
            // 
            // LogoutBt
            // 
            this.LogoutBt.Location = new System.Drawing.Point(943, 450);
            this.LogoutBt.Name = "LogoutBt";
            this.LogoutBt.Size = new System.Drawing.Size(94, 29);
            this.LogoutBt.TabIndex = 10;
            this.LogoutBt.Text = "Logout";
            this.LogoutBt.UseVisualStyleBackColor = true;
            this.LogoutBt.Click += new System.EventHandler(this.LogoutBt_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 535);
            this.Controls.Add(this.LogoutBt);
            this.Controls.Add(this.delstudentBt);
            this.Controls.Add(this.EditstudentBt);
            this.Controls.Add(this.addstudentBt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtClasses);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance System";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtClasses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtClasses;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addstudentBt;
        private System.Windows.Forms.Button EditstudentBt;
        private System.Windows.Forms.Button delstudentBt;
        private System.Windows.Forms.Button LogoutBt;
    }
}