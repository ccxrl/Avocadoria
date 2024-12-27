namespace avocadoria_project_2
{
    partial class Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.prod_save_btn = new System.Windows.Forms.Button();
            this.prod_edit_btn = new System.Windows.Forms.Button();
            this.prod_delete_btn = new System.Windows.Forms.Button();
            this.prod_price_field = new System.Windows.Forms.TextBox();
            this.prod_price_label = new System.Windows.Forms.Label();
            this.flavor_name_field = new System.Windows.Forms.TextBox();
            this.flavor_name_label = new System.Windows.Forms.Label();
            this.prod_name_label = new System.Windows.Forms.Label();
            this.prod_name_field = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label8 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.ProductsDGV = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.size_label = new System.Windows.Forms.Label();
            this.size_name_field = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.customers_order = new System.Windows.Forms.Label();
            this.loggedInEmployeeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDGV)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // prod_save_btn
            // 
            this.prod_save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(227)))), ((int)(((byte)(115)))));
            this.prod_save_btn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prod_save_btn.Location = new System.Drawing.Point(212, 460);
            this.prod_save_btn.Name = "prod_save_btn";
            this.prod_save_btn.Size = new System.Drawing.Size(87, 38);
            this.prod_save_btn.TabIndex = 20;
            this.prod_save_btn.Text = "Save";
            this.prod_save_btn.UseVisualStyleBackColor = false;
            this.prod_save_btn.Click += new System.EventHandler(this.prod_save_btn_Click);
            // 
            // prod_edit_btn
            // 
            this.prod_edit_btn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prod_edit_btn.Location = new System.Drawing.Point(119, 460);
            this.prod_edit_btn.Name = "prod_edit_btn";
            this.prod_edit_btn.Size = new System.Drawing.Size(87, 38);
            this.prod_edit_btn.TabIndex = 19;
            this.prod_edit_btn.Text = "Edit";
            this.prod_edit_btn.UseVisualStyleBackColor = true;
            this.prod_edit_btn.Click += new System.EventHandler(this.prod_edit_btn_Click);
            // 
            // prod_delete_btn
            // 
            this.prod_delete_btn.BackColor = System.Drawing.Color.IndianRed;
            this.prod_delete_btn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prod_delete_btn.Location = new System.Drawing.Point(17, 458);
            this.prod_delete_btn.Name = "prod_delete_btn";
            this.prod_delete_btn.Size = new System.Drawing.Size(87, 40);
            this.prod_delete_btn.TabIndex = 18;
            this.prod_delete_btn.Text = "Delete";
            this.prod_delete_btn.UseVisualStyleBackColor = false;
            this.prod_delete_btn.Click += new System.EventHandler(this.prod_delete_btn_Click);
            // 
            // prod_price_field
            // 
            this.prod_price_field.Location = new System.Drawing.Point(17, 346);
            this.prod_price_field.Name = "prod_price_field";
            this.prod_price_field.Size = new System.Drawing.Size(165, 27);
            this.prod_price_field.TabIndex = 17;
            // 
            // prod_price_label
            // 
            this.prod_price_label.AutoSize = true;
            this.prod_price_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prod_price_label.Location = new System.Drawing.Point(16, 308);
            this.prod_price_label.Name = "prod_price_label";
            this.prod_price_label.Size = new System.Drawing.Size(47, 23);
            this.prod_price_label.TabIndex = 16;
            this.prod_price_label.Text = "Price";
            this.prod_price_label.Click += new System.EventHandler(this.emp_role_label_Click);
            // 
            // flavor_name_field
            // 
            this.flavor_name_field.Location = new System.Drawing.Point(16, 145);
            this.flavor_name_field.Name = "flavor_name_field";
            this.flavor_name_field.Size = new System.Drawing.Size(165, 27);
            this.flavor_name_field.TabIndex = 13;
            // 
            // flavor_name_label
            // 
            this.flavor_name_label.AutoSize = true;
            this.flavor_name_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flavor_name_label.Location = new System.Drawing.Point(17, 108);
            this.flavor_name_label.Name = "flavor_name_label";
            this.flavor_name_label.Size = new System.Drawing.Size(55, 23);
            this.flavor_name_label.TabIndex = 10;
            this.flavor_name_label.Text = "Flavor";
            this.flavor_name_label.Click += new System.EventHandler(this.emp_address_label_Click);
            // 
            // prod_name_label
            // 
            this.prod_name_label.AutoSize = true;
            this.prod_name_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prod_name_label.Location = new System.Drawing.Point(17, 22);
            this.prod_name_label.Name = "prod_name_label";
            this.prod_name_label.Size = new System.Drawing.Size(56, 23);
            this.prod_name_label.TabIndex = 9;
            this.prod_name_label.Text = "Name";
            this.prod_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prod_name_field
            // 
            this.prod_name_field.Location = new System.Drawing.Point(17, 57);
            this.prod_name_field.Name = "prod_name_field";
            this.prod_name_field.Size = new System.Drawing.Size(165, 27);
            this.prod_name_field.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(17, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 30);
            this.label8.TabIndex = 7;
            this.label8.Text = "List of Products";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Controls.Add(this.ProductsDGV);
            this.panel10.Controls.Add(this.label8);
            this.panel10.Location = new System.Drawing.Point(553, 82);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(684, 511);
            this.panel10.TabIndex = 19;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            // 
            // ProductsDGV
            // 
            this.ProductsDGV.AllowUserToDeleteRows = false;
            this.ProductsDGV.AllowUserToOrderColumns = true;
            this.ProductsDGV.BackgroundColor = System.Drawing.Color.White;
            this.ProductsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDGV.Location = new System.Drawing.Point(2, 68);
            this.ProductsDGV.Name = "ProductsDGV";
            this.ProductsDGV.ReadOnly = true;
            this.ProductsDGV.RowHeadersWidth = 51;
            this.ProductsDGV.RowTemplate.Height = 29;
            this.ProductsDGV.Size = new System.Drawing.Size(684, 416);
            this.ProductsDGV.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.pictureBox2);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(9, 272);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(187, 55);
            this.panel7.TabIndex = 24;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Orders";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(227)))), ((int)(((byte)(115)))));
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(9, 150);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(187, 55);
            this.panel3.TabIndex = 23;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(4, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Products";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Employees";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.pictureBox3);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(9, 333);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(187, 55);
            this.panel6.TabIndex = 26;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(4, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(227)))), ((int)(((byte)(115)))));
            this.panel9.Controls.Add(this.pictureBox7);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Location = new System.Drawing.Point(205, 11);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1032, 72);
            this.panel9.TabIndex = 20;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(17, 15);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(34, 40);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 8;
            this.pictureBox7.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(63, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "Products";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(9, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 55);
            this.panel2.TabIndex = 22;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(4, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Home";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.size_label);
            this.panel1.Controls.Add(this.size_name_field);
            this.panel1.Controls.Add(this.prod_save_btn);
            this.panel1.Controls.Add(this.prod_edit_btn);
            this.panel1.Controls.Add(this.prod_delete_btn);
            this.panel1.Controls.Add(this.prod_price_field);
            this.panel1.Controls.Add(this.prod_price_label);
            this.panel1.Controls.Add(this.flavor_name_field);
            this.panel1.Controls.Add(this.flavor_name_label);
            this.panel1.Controls.Add(this.prod_name_label);
            this.panel1.Controls.Add(this.prod_name_field);
            this.panel1.Location = new System.Drawing.Point(205, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 510);
            this.panel1.TabIndex = 18;
            // 
            // size_label
            // 
            this.size_label.AutoSize = true;
            this.size_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.size_label.Location = new System.Drawing.Point(16, 206);
            this.size_label.Name = "size_label";
            this.size_label.Size = new System.Drawing.Size(40, 23);
            this.size_label.TabIndex = 22;
            this.size_label.Text = "Size";
            // 
            // size_name_field
            // 
            this.size_name_field.Location = new System.Drawing.Point(17, 241);
            this.size_name_field.Name = "size_name_field";
            this.size_name_field.Size = new System.Drawing.Size(165, 27);
            this.size_name_field.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.pictureBox8);
            this.panel4.Controls.Add(this.customers_order);
            this.panel4.Location = new System.Drawing.Point(9, 211);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(187, 55);
            this.panel4.TabIndex = 37;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(4, 2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(50, 50);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 6;
            this.pictureBox8.TabStop = false;
            // 
            // customers_order
            // 
            this.customers_order.AutoSize = true;
            this.customers_order.Location = new System.Drawing.Point(62, 19);
            this.customers_order.Name = "customers_order";
            this.customers_order.Size = new System.Drawing.Size(123, 20);
            this.customers_order.TabIndex = 0;
            this.customers_order.Text = "Customer\'s Order";
            this.customers_order.Click += new System.EventHandler(this.customers_order_Click);
            // 
            // loggedInEmployeeLabel
            // 
            this.loggedInEmployeeLabel.AutoSize = true;
            this.loggedInEmployeeLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loggedInEmployeeLabel.Location = new System.Drawing.Point(9, 562);
            this.loggedInEmployeeLabel.Name = "loggedInEmployeeLabel";
            this.loggedInEmployeeLabel.Size = new System.Drawing.Size(180, 30);
            this.loggedInEmployeeLabel.TabIndex = 38;
            this.loggedInEmployeeLabel.Text = "employee_name";
            this.loggedInEmployeeLabel.Click += new System.EventHandler(this.loggedInEmployeeLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 528);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 39;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(13, 503);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(53, 56);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 40;
            this.pictureBox9.TabStop = false;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1243, 604);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loggedInEmployeeLabel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDGV)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button prod_save_btn;
        private Button prod_edit_btn;
        private Button prod_delete_btn;
        private TextBox prod_price_field;
        private Label prod_price_label;
        private TextBox flavor_name_field;
        private Label flavor_name_label;
        private Label prod_name_label;
        private TextBox prod_name_field;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label8;
        private Panel panel10;
        private Panel panel7;
        private Label label5;
        private Panel panel3;
        private Label label1;
        private Label label4;
        private Panel panel6;
        private Panel panel9;
        private PictureBox pictureBox7;
        private Label label7;
        private Panel panel2;
        private Label label9;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label size_label;
        private TextBox size_name_field;
        private DataGridView ProductsDGV;
        private Panel panel4;
        private Label customers_order;
        private Label loggedInEmployeeLabel;
        private Label label2;
        private PictureBox pictureBox9;
        private PictureBox pictureBox6;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox8;
        private PictureBox pictureBox3;
    }
}