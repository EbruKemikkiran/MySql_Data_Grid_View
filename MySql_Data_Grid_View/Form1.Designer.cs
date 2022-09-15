namespace MySql_Data_Grid_View
{
    partial class Form1
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnActiveUsers = new System.Windows.Forms.Button();
            this.btnPassiveUsers = new System.Windows.Forms.Button();
            this.lblActiveUsers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToOrderColumns = true;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(12, 84);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(589, 343);
            this.dgvUsers.TabIndex = 0;
            // 
            // btnActiveUsers
            // 
            this.btnActiveUsers.Location = new System.Drawing.Point(28, 38);
            this.btnActiveUsers.Name = "btnActiveUsers";
            this.btnActiveUsers.Size = new System.Drawing.Size(143, 23);
            this.btnActiveUsers.TabIndex = 1;
            this.btnActiveUsers.Text = "Active Users";
            this.btnActiveUsers.UseVisualStyleBackColor = true;
            this.btnActiveUsers.Click += new System.EventHandler(this.btnActiveUsers_Click);
            // 
            // btnPassiveUsers
            // 
            this.btnPassiveUsers.Location = new System.Drawing.Point(447, 38);
            this.btnPassiveUsers.Name = "btnPassiveUsers";
            this.btnPassiveUsers.Size = new System.Drawing.Size(144, 23);
            this.btnPassiveUsers.TabIndex = 1;
            this.btnPassiveUsers.Text = "Passive Users";
            this.btnPassiveUsers.UseVisualStyleBackColor = true;
            this.btnPassiveUsers.Click += new System.EventHandler(this.btnPassiveUsers_Click);
            // 
            // lblActiveUsers
            // 
            this.lblActiveUsers.AutoSize = true;
            this.lblActiveUsers.Location = new System.Drawing.Point(248, 38);
            this.lblActiveUsers.Name = "lblActiveUsers";
            this.lblActiveUsers.Size = new System.Drawing.Size(93, 16);
            this.lblActiveUsers.TabIndex = 2;
            this.lblActiveUsers.Text = "Active 0 Users";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblActiveUsers);
            this.Controls.Add(this.btnPassiveUsers);
            this.Controls.Add(this.btnActiveUsers);
            this.Controls.Add(this.dgvUsers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnActiveUsers;
        private System.Windows.Forms.Button btnPassiveUsers;
        private System.Windows.Forms.Label lblActiveUsers;
    }
}

