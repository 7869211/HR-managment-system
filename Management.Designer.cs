namespace HR_Management_System
{
    partial class Management
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
            this.ermButton = new System.Windows.Forms.Button();
            this.lmButton = new System.Windows.Forms.Button();
            this.pmButton = new System.Windows.Forms.Button();
            this.managementBackButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // ermButton
            // 
            this.ermButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ermButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ermButton.Location = new System.Drawing.Point(715, 98);
            this.ermButton.Name = "ermButton";
            this.ermButton.Size = new System.Drawing.Size(320, 68);
            this.ermButton.TabIndex = 0;
            this.ermButton.Text = "Employee Records Management";
            this.ermButton.UseVisualStyleBackColor = false;
            this.ermButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // lmButton
            // 
            this.lmButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lmButton.Location = new System.Drawing.Point(715, 342);
            this.lmButton.Name = "lmButton";
            this.lmButton.Size = new System.Drawing.Size(320, 69);
            this.lmButton.TabIndex = 1;
            this.lmButton.Text = "Leave Management";
            this.lmButton.UseVisualStyleBackColor = false;
            this.lmButton.Click += new System.EventHandler(this.lmButton_Click);
            // 
            // pmButton
            // 
            this.pmButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pmButton.Location = new System.Drawing.Point(715, 214);
            this.pmButton.Name = "pmButton";
            this.pmButton.Size = new System.Drawing.Size(320, 74);
            this.pmButton.TabIndex = 2;
            this.pmButton.Text = "Payroll Management";
            this.pmButton.UseVisualStyleBackColor = false;
            this.pmButton.Click += new System.EventHandler(this.pmButton_Click);
            // 
            // managementBackButton
            // 
            this.managementBackButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.managementBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managementBackButton.Location = new System.Drawing.Point(70, 527);
            this.managementBackButton.Name = "managementBackButton";
            this.managementBackButton.Size = new System.Drawing.Size(118, 52);
            this.managementBackButton.TabIndex = 3;
            this.managementBackButton.Text = "Back";
            this.managementBackButton.UseVisualStyleBackColor = false;
            this.managementBackButton.Click += new System.EventHandler(this.managementBackButton_Click);
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.BackgroundImage = global::HR_Management_System.Properties.Resources.hr3;
            this.ClientSize = new System.Drawing.Size(1253, 625);
            this.Controls.Add(this.managementBackButton);
            this.Controls.Add(this.pmButton);
            this.Controls.Add(this.lmButton);
            this.Controls.Add(this.ermButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Management";
            this.Text = "Management";
            this.Load += new System.EventHandler(this.Management_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ermButton;
        private System.Windows.Forms.Button lmButton;
        private System.Windows.Forms.Button pmButton;
        private System.Windows.Forms.Button managementBackButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}