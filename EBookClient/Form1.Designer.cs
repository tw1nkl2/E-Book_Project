namespace EBookClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegistry = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPopular = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnNewRelises = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.btnRegistry);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnRegistry
            // 
            this.btnRegistry.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRegistry.FlatAppearance.BorderSize = 0;
            this.btnRegistry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistry.Location = new System.Drawing.Point(457, 32);
            this.btnRegistry.Name = "btnRegistry";
            this.btnRegistry.Size = new System.Drawing.Size(104, 36);
            this.btnRegistry.TabIndex = 3;
            this.btnRegistry.Text = "Реєстрація";
            this.btnRegistry.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(347, 32);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(104, 35);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Увійти";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-Book Store";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPopular);
            this.panel2.Controls.Add(this.btnCategories);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Controls.Add(this.btnNewRelises);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 45);
            this.panel2.TabIndex = 1;
            // 
            // btnPopular
            // 
            this.btnPopular.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPopular.FlatAppearance.BorderSize = 0;
            this.btnPopular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPopular.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPopular.Location = new System.Drawing.Point(423, 5);
            this.btnPopular.Name = "btnPopular";
            this.btnPopular.Size = new System.Drawing.Size(121, 37);
            this.btnPopular.TabIndex = 3;
            this.btnPopular.Text = "Популярні";
            this.btnPopular.UseVisualStyleBackColor = false;
            this.btnPopular.Click += new System.EventHandler(this.btnPopular_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCategories.FlatAppearance.BorderSize = 0;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCategories.Location = new System.Drawing.Point(169, 5);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(121, 37);
            this.btnCategories.TabIndex = 1;
            this.btnCategories.Text = "Категорії";
            this.btnCategories.UseVisualStyleBackColor = false;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.DarkOrange;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.Location = new System.Drawing.Point(41, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(122, 37);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Домашня";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnNewRelises
            // 
            this.btnNewRelises.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNewRelises.FlatAppearance.BorderSize = 0;
            this.btnNewRelises.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRelises.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewRelises.Location = new System.Drawing.Point(296, 5);
            this.btnNewRelises.Name = "btnNewRelises";
            this.btnNewRelises.Size = new System.Drawing.Size(121, 37);
            this.btnNewRelises.TabIndex = 2;
            this.btnNewRelises.Text = "Нові редізи";
            this.btnNewRelises.UseVisualStyleBackColor = false;
            this.btnNewRelises.Click += new System.EventHandler(this.btnNewRelises_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 145);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(573, 305);
            this.panel3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "E-Book";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegistry;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPopular;
        private System.Windows.Forms.Button btnNewRelises;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel3;
    }
}

