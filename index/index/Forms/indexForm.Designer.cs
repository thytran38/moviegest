namespace index
{
    partial class indexForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(indexForm));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grdMovies = new System.Windows.Forms.DataGridView();
            this.lblMoviedb = new System.Windows.Forms.Label();
            this.logoBox01 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grdMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox01)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1233, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1497, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // grdMovies
            // 
            this.grdMovies.AllowUserToAddRows = false;
            this.grdMovies.AllowUserToDeleteRows = false;
            this.grdMovies.BackgroundColor = System.Drawing.Color.Gray;
            this.grdMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMovies.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grdMovies.Location = new System.Drawing.Point(171, 120);
            this.grdMovies.Name = "grdMovies";
            this.grdMovies.ReadOnly = true;
            this.grdMovies.Size = new System.Drawing.Size(1401, 319);
            this.grdMovies.TabIndex = 4;
            // 
            // lblMoviedb
            // 
            this.lblMoviedb.AutoSize = true;
            this.lblMoviedb.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoviedb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblMoviedb.Location = new System.Drawing.Point(169, 97);
            this.lblMoviedb.Name = "lblMoviedb";
            this.lblMoviedb.Size = new System.Drawing.Size(122, 15);
            this.lblMoviedb.TabIndex = 5;
            this.lblMoviedb.Text = "Your movie database ";
            // 
            // logoBox01
            // 
            this.logoBox01.BackColor = System.Drawing.Color.Transparent;
            this.logoBox01.Image = ((System.Drawing.Image)(resources.GetObject("logoBox01.Image")));
            this.logoBox01.Location = new System.Drawing.Point(17, 3);
            this.logoBox01.Name = "logoBox01";
            this.logoBox01.Size = new System.Drawing.Size(160, 94);
            this.logoBox01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoBox01.TabIndex = 0;
            this.logoBox01.TabStop = false;
            this.logoBox01.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(630, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your favorite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Recommendation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Exit";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.logoBox01);
            this.panel1.Location = new System.Drawing.Point(-14, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 1059);
            this.panel1.TabIndex = 1;
            // 
            // indexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.lblMoviedb);
            this.Controls.Add(this.grdMovies);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel1);
            this.Name = "indexForm";
            this.Text = "moviegestForm";
            ((System.ComponentModel.ISupportInitialize)(this.grdMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox01)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView grdMovies;
        private System.Windows.Forms.Label lblMoviedb;
        private System.Windows.Forms.PictureBox logoBox01;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}

