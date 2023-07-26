namespace UsersAdmin.PresentationLayer
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.searchImage = new System.Windows.Forms.PictureBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 117);
            this.panel1.TabIndex = 0;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(800, 60);
            this.title.TabIndex = 0;
            this.title.Text = "Users Administration";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.panel2.Controls.Add(this.btnInsert);
            this.panel2.Controls.Add(this.searchImage);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 57);
            this.panel2.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(12, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(314, 16);
            this.txtSearch.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.panel3.Location = new System.Drawing.Point(12, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 1);
            this.panel3.TabIndex = 1;
            // 
            // searchImage
            // 
            this.searchImage.Image = global::UsersAdmin.Properties.Resources.lupa;
            this.searchImage.Location = new System.Drawing.Point(338, 14);
            this.searchImage.Name = "searchImage";
            this.searchImage.Size = new System.Drawing.Size(33, 28);
            this.searchImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchImage.TabIndex = 2;
            this.searchImage.TabStop = false;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(418, 11);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 35);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Add";
            this.btnInsert.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(268, 301);
            this.dataGridView1.TabIndex = 1;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox searchImage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}