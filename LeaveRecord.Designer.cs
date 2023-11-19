namespace HR_Management_System
{
    partial class LeaveRecord
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
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.leaveType = new System.Windows.Forms.TextBox();
            this.leaveId = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.leaveGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.leaveGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(172, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "LeaveType";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(548, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 49);
            this.button1.TabIndex = 29;
            this.button1.Text = "Populate Leave";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(697, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "End Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(697, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Start Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(172, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Employee ID";
            // 
            // leaveType
            // 
            this.leaveType.Location = new System.Drawing.Point(289, 166);
            this.leaveType.Multiline = true;
            this.leaveType.Name = "leaveType";
            this.leaveType.Size = new System.Drawing.Size(280, 35);
            this.leaveType.TabIndex = 20;
            // 
            // leaveId
            // 
            this.leaveId.Location = new System.Drawing.Point(289, 77);
            this.leaveId.Multiline = true;
            this.leaveId.Name = "leaveId";
            this.leaveId.Size = new System.Drawing.Size(280, 35);
            this.leaveId.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(74, 594);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 44);
            this.button4.TabIndex = 32;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(807, 77);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(300, 26);
            this.startDate.TabIndex = 33;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(807, 157);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(300, 26);
            this.endDate.TabIndex = 34;
            // 
            // leaveGrid
            // 
            this.leaveGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.leaveGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leaveGrid.Location = new System.Drawing.Point(74, 332);
            this.leaveGrid.Name = "leaveGrid";
            this.leaveGrid.RowHeadersWidth = 62;
            this.leaveGrid.RowTemplate.Height = 28;
            this.leaveGrid.Size = new System.Drawing.Size(1140, 236);
            this.leaveGrid.TabIndex = 35;
            this.leaveGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.leaveGrid_CellContentClick);
            // 
            // LeaveRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::HR_Management_System.Properties.Resources.container;
            this.ClientSize = new System.Drawing.Size(1252, 658);
            this.Controls.Add(this.leaveGrid);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leaveType);
            this.Controls.Add(this.leaveId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LeaveRecord";
            this.Text = "LeaveRecord";
            this.Load += new System.EventHandler(this.LeaveRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leaveGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox leaveType;
        private System.Windows.Forms.TextBox leaveId;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.DataGridView leaveGrid;
    }
}