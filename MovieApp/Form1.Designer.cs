namespace MovieApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonAllMovies;
        private System.Windows.Forms.Button buttonUnreleased2017;
        private System.Windows.Forms.Button buttonNonEnglishLanguages;
        private System.Windows.Forms.Button buttonToyStoryDirectors;
        private System.Windows.Forms.Button buttonEmployeesByBuilding;
        private System.Windows.Forms.Button buttonMoviesWithMultipleDirectors;
        private System.Windows.Forms.Button buttonTotalSales;
        private System.Windows.Forms.Button buttonEmployeeCountInBuilding2w;
        private System.Windows.Forms.Button buttonExtendExpiration;
        private System.Windows.Forms.Button buttonSwitchToForm2;
        private System.Windows.Forms.Label labelAccountBalance;
        private System.Windows.Forms.Label labelExpirationDate;

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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonAllMovies = new System.Windows.Forms.Button();
            this.buttonUnreleased2017 = new System.Windows.Forms.Button();
            this.buttonNonEnglishLanguages = new System.Windows.Forms.Button();
            this.buttonToyStoryDirectors = new System.Windows.Forms.Button();
            this.buttonEmployeesByBuilding = new System.Windows.Forms.Button();
            this.buttonMoviesWithMultipleDirectors = new System.Windows.Forms.Button();
            this.buttonTotalSales = new System.Windows.Forms.Button();
            this.buttonEmployeeCountInBuilding2w = new System.Windows.Forms.Button();
            this.buttonExtendExpiration = new System.Windows.Forms.Button();
            this.buttonSwitchToForm2 = new System.Windows.Forms.Button();
            this.labelAccountBalance = new System.Windows.Forms.Label();
            this.labelExpirationDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(16, 15);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(1013, 369);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // buttonAllMovies
            // 
            this.buttonAllMovies.Location = new System.Drawing.Point(16, 391);
            this.buttonAllMovies.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAllMovies.Name = "buttonAllMovies";
            this.buttonAllMovies.Size = new System.Drawing.Size(100, 28);
            this.buttonAllMovies.TabIndex = 1;
            this.buttonAllMovies.Text = "All Movies";
            this.buttonAllMovies.UseVisualStyleBackColor = true;
            this.buttonAllMovies.Click += new System.EventHandler(this.buttonAllMovies_Click);
            // 
            // buttonUnreleased2017
            // 
            this.buttonUnreleased2017.Location = new System.Drawing.Point(124, 391);
            this.buttonUnreleased2017.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUnreleased2017.Name = "buttonUnreleased2017";
            this.buttonUnreleased2017.Size = new System.Drawing.Size(173, 28);
            this.buttonUnreleased2017.TabIndex = 2;
            this.buttonUnreleased2017.Text = "Unreleased in 2017";
            this.buttonUnreleased2017.UseVisualStyleBackColor = true;
            this.buttonUnreleased2017.Click += new System.EventHandler(this.buttonUnreleased2017_Click);
            // 
            // buttonNonEnglishLanguages
            // 
            this.buttonNonEnglishLanguages.Location = new System.Drawing.Point(305, 391);
            this.buttonNonEnglishLanguages.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNonEnglishLanguages.Name = "buttonNonEnglishLanguages";
            this.buttonNonEnglishLanguages.Size = new System.Drawing.Size(213, 28);
            this.buttonNonEnglishLanguages.TabIndex = 3;
            this.buttonNonEnglishLanguages.Text = "Non-English Languages";
            this.buttonNonEnglishLanguages.UseVisualStyleBackColor = true;
            this.buttonNonEnglishLanguages.Click += new System.EventHandler(this.buttonNonEnglishLanguages_Click);
            // 
            // buttonToyStoryDirectors
            // 
            this.buttonToyStoryDirectors.Location = new System.Drawing.Point(527, 391);
            this.buttonToyStoryDirectors.Margin = new System.Windows.Forms.Padding(4);
            this.buttonToyStoryDirectors.Name = "buttonToyStoryDirectors";
            this.buttonToyStoryDirectors.Size = new System.Drawing.Size(173, 28);
            this.buttonToyStoryDirectors.TabIndex = 4;
            this.buttonToyStoryDirectors.Text = "Toy Story Directors";
            this.buttonToyStoryDirectors.UseVisualStyleBackColor = true;
            this.buttonToyStoryDirectors.Click += new System.EventHandler(this.buttonToyStoryDirectors_Click);
            // 
            // buttonEmployeesByBuilding
            // 
            this.buttonEmployeesByBuilding.Location = new System.Drawing.Point(708, 391);
            this.buttonEmployeesByBuilding.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEmployeesByBuilding.Name = "buttonEmployeesByBuilding";
            this.buttonEmployeesByBuilding.Size = new System.Drawing.Size(200, 28);
            this.buttonEmployeesByBuilding.TabIndex = 5;
            this.buttonEmployeesByBuilding.Text = "Employees by Building";
            this.buttonEmployeesByBuilding.UseVisualStyleBackColor = true;
            this.buttonEmployeesByBuilding.Click += new System.EventHandler(this.buttonEmployeesByBuilding_Click);
            // 
            // buttonMoviesWithMultipleDirectors
            // 
            this.buttonMoviesWithMultipleDirectors.Location = new System.Drawing.Point(916, 391);
            this.buttonMoviesWithMultipleDirectors.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMoviesWithMultipleDirectors.Name = "buttonMoviesWithMultipleDirectors";
            this.buttonMoviesWithMultipleDirectors.Size = new System.Drawing.Size(113, 28);
            this.buttonMoviesWithMultipleDirectors.TabIndex = 6;
            this.buttonMoviesWithMultipleDirectors.Text = "Multi-Director";
            this.buttonMoviesWithMultipleDirectors.UseVisualStyleBackColor = true;
            this.buttonMoviesWithMultipleDirectors.Click += new System.EventHandler(this.buttonMoviesWithMultipleDirectors_Click);
            // 
            // buttonTotalSales
            // 
            this.buttonTotalSales.Location = new System.Drawing.Point(16, 427);
            this.buttonTotalSales.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTotalSales.Name = "buttonTotalSales";
            this.buttonTotalSales.Size = new System.Drawing.Size(100, 28);
            this.buttonTotalSales.TabIndex = 7;
            this.buttonTotalSales.Text = "Total Sales";
            this.buttonTotalSales.UseVisualStyleBackColor = true;
            this.buttonTotalSales.Click += new System.EventHandler(this.buttonTotalSales_Click);
            // 
            // buttonEmployeeCountInBuilding2w
            // 
            this.buttonEmployeeCountInBuilding2w.Location = new System.Drawing.Point(124, 427);
            this.buttonEmployeeCountInBuilding2w.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEmployeeCountInBuilding2w.Name = "buttonEmployeeCountInBuilding2w";
            this.buttonEmployeeCountInBuilding2w.Size = new System.Drawing.Size(173, 28);
            this.buttonEmployeeCountInBuilding2w.TabIndex = 8;
            this.buttonEmployeeCountInBuilding2w.Text = "Employee Count 2w";
            this.buttonEmployeeCountInBuilding2w.UseVisualStyleBackColor = true;
            this.buttonEmployeeCountInBuilding2w.Click += new System.EventHandler(this.buttonEmployeeCountInBuilding2w_Click);
            // 
            // buttonExtendExpiration
            // 
            this.buttonExtendExpiration.Location = new System.Drawing.Point(897, 427);
            this.buttonExtendExpiration.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExtendExpiration.Name = "buttonExtendExpiration";
            this.buttonExtendExpiration.Size = new System.Drawing.Size(132, 28);
            this.buttonExtendExpiration.TabIndex = 9;
            this.buttonExtendExpiration.Text = "Extend Expiration";
            this.buttonExtendExpiration.UseVisualStyleBackColor = true;
            this.buttonExtendExpiration.Click += new System.EventHandler(this.buttonExtendExpiration_Click);
            // 
            // buttonSwitchToForm2
            // 
            this.buttonSwitchToForm2.Location = new System.Drawing.Point(764, 427);
            this.buttonSwitchToForm2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSwitchToForm2.Name = "buttonSwitchToForm2";
            this.buttonSwitchToForm2.Size = new System.Drawing.Size(125, 28);
            this.buttonSwitchToForm2.TabIndex = 10;
            this.buttonSwitchToForm2.Text = "Switch to Form 2";
            this.buttonSwitchToForm2.UseVisualStyleBackColor = true;
            this.buttonSwitchToForm2.Click += new System.EventHandler(this.buttonSwitchToForm2_Click);
            // 
            // labelAccountBalance
            // 
            this.labelAccountBalance.AutoSize = true;
            this.labelAccountBalance.Location = new System.Drawing.Point(16, 470);
            this.labelAccountBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAccountBalance.Name = "labelAccountBalance";
            this.labelAccountBalance.Size = new System.Drawing.Size(118, 17);
            this.labelAccountBalance.TabIndex = 11;
            this.labelAccountBalance.Text = "Account Balance:";
            // 
            // labelExpirationDate
            // 
            this.labelExpirationDate.AutoSize = true;
            this.labelExpirationDate.Location = new System.Drawing.Point(224, 470);
            this.labelExpirationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExpirationDate.Name = "labelExpirationDate";
            this.labelExpirationDate.Size = new System.Drawing.Size(105, 17);
            this.labelExpirationDate.TabIndex = 12;
            this.labelExpirationDate.Text = "Expiration Date:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 500);
            this.Controls.Add(this.labelExpirationDate);
            this.Controls.Add(this.labelAccountBalance);
            this.Controls.Add(this.buttonSwitchToForm2);
            this.Controls.Add(this.buttonExtendExpiration);
            this.Controls.Add(this.buttonEmployeeCountInBuilding2w);
            this.Controls.Add(this.buttonTotalSales);
            this.Controls.Add(this.buttonMoviesWithMultipleDirectors);
            this.Controls.Add(this.buttonEmployeesByBuilding);
            this.Controls.Add(this.buttonToyStoryDirectors);
            this.Controls.Add(this.buttonNonEnglishLanguages);
            this.Controls.Add(this.buttonUnreleased2017);
            this.Controls.Add(this.buttonAllMovies);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "MovieApp";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
