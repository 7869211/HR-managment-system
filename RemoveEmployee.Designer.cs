namespace HR_Management_System
{
    partial class RemoveEmployee
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
            this.removeGrid = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.removeId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.removeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // removeGrid
            // 
            this.removeGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.removeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.removeGrid.Location = new System.Drawing.Point(15, 100);
            this.removeGrid.Name = "removeGrid";
            this.removeGrid.RowHeadersWidth = 62;
            this.removeGrid.RowTemplate.Height = 28;
            this.removeGrid.Size = new System.Drawing.Size(1536, 790);
            this.removeGrid.TabIndex = 10;
            this.removeGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.removeGrid_CellContentClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(38, 954);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 44);
            this.button4.TabIndex = 9;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(918, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter Employee ID to Remove";
            // 
            // removeId
            // 
            this.removeId.Location = new System.Drawing.Point(1148, 57);
            this.removeId.Multiline = true;
            this.removeId.Name = "removeId";
            this.removeId.Size = new System.Drawing.Size(298, 32);
            this.removeId.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1452, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RemoveEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HR_Management_System.Properties.Resources.container;
            this.ClientSize = new System.Drawing.Size(1563, 1050);
            this.Controls.Add(this.removeGrid);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeId);
            this.Controls.Add(this.button1);
            this.Name = "RemoveEmployee";
            this.Text = "RemoveEmployee";
            this.Load += new System.EventHandler(this.RemoveEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.removeGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView removeGrid;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox removeId;
        private System.Windows.Forms.Button button1;
    }
}