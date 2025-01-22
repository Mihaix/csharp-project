namespace supermarket_manager
{
    partial class SellerForm
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
            this.label_exit = new System.Windows.Forms.Label();
            this.dataGridView_seller = new System.Windows.Forms.DataGridView();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_pas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_category = new System.Windows.Forms.Button();
            this.button_seller = new System.Windows.Forms.Button();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_lg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_seller)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.Location = new System.Drawing.Point(12, 10);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(35, 38);
            this.label_exit.TabIndex = 21;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // dataGridView_seller
            // 
            this.dataGridView_seller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_seller.Location = new System.Drawing.Point(384, 60);
            this.dataGridView_seller.Name = "dataGridView_seller";
            this.dataGridView_seller.RowHeadersWidth = 51;
            this.dataGridView_seller.RowTemplate.Height = 24;
            this.dataGridView_seller.Size = new System.Drawing.Size(581, 547);
            this.dataGridView_seller.TabIndex = 13;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(261, 261);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(94, 46);
            this.button_delete.TabIndex = 12;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(150, 261);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(94, 46);
            this.button_update.TabIndex = 11;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(36, 261);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(94, 46);
            this.button_add.TabIndex = 10;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_pas
            // 
            this.textBox_pas.Location = new System.Drawing.Point(161, 188);
            this.textBox_pas.Name = "textBox_pas";
            this.textBox_pas.Size = new System.Drawing.Size(194, 30);
            this.textBox_pas.TabIndex = 7;
            this.textBox_pas.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // button_category
            // 
            this.button_category.Location = new System.Drawing.Point(31, 158);
            this.button_category.Name = "button_category";
            this.button_category.Size = new System.Drawing.Size(120, 46);
            this.button_category.TabIndex = 18;
            this.button_category.Text = "Category";
            this.button_category.UseVisualStyleBackColor = true;
            this.button_category.Click += new System.EventHandler(this.button_category_Click);
            // 
            // button_seller
            // 
            this.button_seller.Location = new System.Drawing.Point(31, 73);
            this.button_seller.Name = "button_seller";
            this.button_seller.Size = new System.Drawing.Size(120, 46);
            this.button_seller.TabIndex = 17;
            this.button_seller.Text = "Product";
            this.button_seller.UseVisualStyleBackColor = true;
            this.button_seller.Click += new System.EventHandler(this.button_seller_Click);
            // 
            // textBox_age
            // 
            this.textBox_age.Location = new System.Drawing.Point(161, 149);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(194, 30);
            this.textBox_age.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Age";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(161, 110);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(194, 30);
            this.textBox_name.TabIndex = 3;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(162, 71);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(194, 30);
            this.textBox_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // button_lg
            // 
            this.button_lg.Location = new System.Drawing.Point(31, 592);
            this.button_lg.Name = "button_lg";
            this.button_lg.Size = new System.Drawing.Size(120, 46);
            this.button_lg.TabIndex = 20;
            this.button_lg.Text = "Logout";
            this.button_lg.UseVisualStyleBackColor = true;
            this.button_lg.Click += new System.EventHandler(this.button_lg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.dataGridView_seller);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.button_update);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.textBox_pas);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_age);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(196, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 625);
            this.panel1.TabIndex = 16;
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 649);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.button_category);
            this.Controls.Add(this.button_seller);
            this.Controls.Add(this.button_lg);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerForm";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_seller)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.DataGridView dataGridView_seller;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_pas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_category;
        private System.Windows.Forms.Button button_seller;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_lg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}