namespace HR_Management_System
{
    partial class SaveEmployee
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
            this.empId = new System.Windows.Forms.TextBox();
            this.empCnic = new System.Windows.Forms.TextBox();
            this.empContact = new System.Windows.Forms.TextBox();
            this.empName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.empEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.empDesignation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.empSaveButton = new System.Windows.Forms.Button();
            this.empAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.empSalary = new System.Windows.Forms.TextBox();
            this.backSaveEmployeeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // empId
            // 
            this.empId.Location = new System.Drawing.Point(304, 132);
            this.empId.Multiline = true;
            this.empId.Name = "empId";
            this.empId.Size = new System.Drawing.Size(275, 32);
            this.empId.TabIndex = 0;
            this.empId.TextChanged += new System.EventHandler(this.empId_TextChanged);
            // 
            // empCnic
            // 
            this.empCnic.Location = new System.Drawing.Point(304, 291);
            this.empCnic.Multiline = true;
            this.empCnic.Name = "empCnic";
            this.empCnic.Size = new System.Drawing.Size(275, 36);
            this.empCnic.TabIndex = 1;
            // 
            // empContact
            // 
            this.empContact.Location = new System.Drawing.Point(881, 132);
            this.empContact.Multiline = true;
            this.empContact.Name = "empContact";
            this.empContact.Size = new System.Drawing.Size(263, 32);
            this.empContact.TabIndex = 2;
            // 
            // empName
            // 
            this.empName.Location = new System.Drawing.Point(304, 209);
            this.empName.Multiline = true;
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(275, 35);
            this.empName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "CNIC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(727, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contact #";
            // 
            // empEmail
            // 
            this.empEmail.Location = new System.Drawing.Point(881, 209);
            this.empEmail.Multiline = true;
            this.empEmail.Name = "empEmail";
            this.empEmail.Size = new System.Drawing.Size(263, 35);
            this.empEmail.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(730, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Designation";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // empDesignation
            // 
            this.empDesignation.Location = new System.Drawing.Point(881, 291);
            this.empDesignation.Multiline = true;
            this.empDesignation.Name = "empDesignation";
            this.empDesignation.Size = new System.Drawing.Size(263, 36);
            this.empDesignation.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(727, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email Address";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // empSaveButton
            // 
            this.empSaveButton.Location = new System.Drawing.Point(586, 461);
            this.empSaveButton.Name = "empSaveButton";
            this.empSaveButton.Size = new System.Drawing.Size(131, 51);
            this.empSaveButton.TabIndex = 12;
            this.empSaveButton.Text = "Save";
            this.empSaveButton.UseVisualStyleBackColor = true;
            this.empSaveButton.Click += new System.EventHandler(this.empSaveButton_Click);
            // 
            // empAddress
            // 
            this.empAddress.Location = new System.Drawing.Point(304, 368);
            this.empAddress.Multiline = true;
            this.empAddress.Name = "empAddress";
            this.empAddress.Size = new System.Drawing.Size(275, 36);
            this.empAddress.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(727, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Basic Salary";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // empSalary
            // 
            this.empSalary.Location = new System.Drawing.Point(881, 368);
            this.empSalary.Multiline = true;
            this.empSalary.Name = "empSalary";
            this.empSalary.Size = new System.Drawing.Size(263, 36);
            this.empSalary.TabIndex = 16;
            // 
            // backSaveEmployeeButton
            // 
            this.backSaveEmployeeButton.Location = new System.Drawing.Point(69, 587);
            this.backSaveEmployeeButton.Name = "backSaveEmployeeButton";
            this.backSaveEmployeeButton.Size = new System.Drawing.Size(111, 44);
            this.backSaveEmployeeButton.TabIndex = 17;
            this.backSaveEmployeeButton.Text = "Back";
            this.backSaveEmployeeButton.UseVisualStyleBackColor = true;
            this.backSaveEmployeeButton.Click += new System.EventHandler(this.backSaveEmployeeButton_Click);
            // 
            // SaveEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::HR_Management_System.Properties.Resources.container;
            this.ClientSize = new System.Drawing.Size(1256, 666);
            this.Controls.Add(this.backSaveEmployeeButton);
            this.Controls.Add(this.empSalary);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.empAddress);
            this.Controls.Add(this.empSaveButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.empDesignation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.empEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.empName);
            this.Controls.Add(this.empContact);
            this.Controls.Add(this.empCnic);
            this.Controls.Add(this.empId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SaveEmployee";
            this.Text = "Save Employee";
            this.Load += new System.EventHandler(this.SaveEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox empId;
        private System.Windows.Forms.TextBox empCnic;
        private System.Windows.Forms.TextBox empContact;
        private System.Windows.Forms.TextBox empName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox empEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox empDesignation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button empSaveButton;
        private System.Windows.Forms.TextBox empAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox empSalary;
        private System.Windows.Forms.Button backSaveEmployeeButton;
    }
}