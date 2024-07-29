namespace MovieApp
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.Button buttonSearchByID;
        private System.Windows.Forms.Button buttonLoadAllUsers;
        private System.Windows.Forms.Button buttonSwitchToForm1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.buttonSearchByID = new System.Windows.Forms.Button();
            this.buttonLoadAllUsers = new System.Windows.Forms.Button();
            this.buttonSwitchToForm1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersWidth = 51;
            this.dataGridViewUsers.RowTemplate.Height = 24;
            this.dataGridViewUsers.Size = new System.Drawing.Size(776, 331);
            this.dataGridViewUsers.TabIndex = 0;
            this.dataGridViewUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellContentClick);
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(12, 363);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(100, 22);
            this.textBoxUserID.TabIndex = 1;
            // 
            // buttonSearchByID
            // 
            this.buttonSearchByID.Location = new System.Drawing.Point(118, 362);
            this.buttonSearchByID.Name = "buttonSearchByID";
            this.buttonSearchByID.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchByID.TabIndex = 4;
            this.buttonSearchByID.Text = "Search";
            this.buttonSearchByID.UseVisualStyleBackColor = true;
            this.buttonSearchByID.Click += new System.EventHandler(this.buttonSearchByID_Click);
            // 
            // buttonLoadAllUsers
            // 
            this.buttonLoadAllUsers.Location = new System.Drawing.Point(199, 362);
            this.buttonLoadAllUsers.Name = "buttonLoadAllUsers";
            this.buttonLoadAllUsers.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadAllUsers.TabIndex = 5;
            this.buttonLoadAllUsers.Text = "Load All";
            this.buttonLoadAllUsers.UseVisualStyleBackColor = true;
            this.buttonLoadAllUsers.Click += new System.EventHandler(this.buttonLoadAllUsers_Click);
            // 
            // buttonSwitchToForm1
            // 
            this.buttonSwitchToForm1.Location = new System.Drawing.Point(713, 362);
            this.buttonSwitchToForm1.Name = "buttonSwitchToForm1";
            this.buttonSwitchToForm1.Size = new System.Drawing.Size(75, 23);
            this.buttonSwitchToForm1.TabIndex = 7;
            this.buttonSwitchToForm1.Text = "Movies";
            this.buttonSwitchToForm1.UseVisualStyleBackColor = true;
            this.buttonSwitchToForm1.Click += new System.EventHandler(this.buttonSwitchToForm1_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSwitchToForm1);
            this.Controls.Add(this.buttonLoadAllUsers);
            this.Controls.Add(this.buttonSearchByID);
            this.Controls.Add(this.textBoxUserID);
            this.Controls.Add(this.dataGridViewUsers);
            this.Name = "Form2";
            this.Text = "User Information";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
