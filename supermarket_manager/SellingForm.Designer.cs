namespace supermarket_manager
{
    partial class SellingForm
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
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_order = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_qty = new System.Windows.Forms.TextBox();
            this.button_lg = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_date = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label_seller = new System.Windows.Forms.Label();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView_sellList = new System.Windows.Forms.DataGridView();
            this.dataGridView_products = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sellList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).BeginInit();
            this.SuspendLayout();
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.Location = new System.Drawing.Point(12, 10);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(35, 38);
            this.label_exit.TabIndex = 27;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(151, 85);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.ReadOnly = true;
            this.textBox_price.Size = new System.Drawing.Size(194, 30);
            this.textBox_price.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(151, 46);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.ReadOnly = true;
            this.textBox_name.Size = new System.Drawing.Size(194, 30);
            this.textBox_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // dataGridView_order
            // 
            this.dataGridView_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ProdName,
            this.ProdPrice,
            this.ProdQty,
            this.TotalPrice});
            this.dataGridView_order.Location = new System.Drawing.Point(382, 48);
            this.dataGridView_order.Name = "dataGridView_order";
            this.dataGridView_order.RowHeadersWidth = 51;
            this.dataGridView_order.RowTemplate.Height = 24;
            this.dataGridView_order.Size = new System.Drawing.Size(581, 166);
            this.dataGridView_order.TabIndex = 13;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 80;
            // 
            // ProdName
            // 
            this.ProdName.HeaderText = "ProdName";
            this.ProdName.MinimumWidth = 6;
            this.ProdName.Name = "ProdName";
            this.ProdName.Width = 110;
            // 
            // ProdPrice
            // 
            this.ProdPrice.HeaderText = "ProdPrice";
            this.ProdPrice.MinimumWidth = 6;
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Width = 110;
            // 
            // ProdQty
            // 
            this.ProdQty.HeaderText = "ProdQty";
            this.ProdQty.MinimumWidth = 6;
            this.ProdQty.Name = "ProdQty";
            this.ProdQty.Width = 110;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Total";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Width = 110;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(222, 168);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(123, 46);
            this.button_add.TabIndex = 10;
            this.button_add.Text = "Add Order";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_qty
            // 
            this.textBox_qty.Location = new System.Drawing.Point(151, 124);
            this.textBox_qty.Name = "textBox_qty";
            this.textBox_qty.Size = new System.Drawing.Size(194, 30);
            this.textBox_qty.TabIndex = 7;
            // 
            // button_lg
            // 
            this.button_lg.Location = new System.Drawing.Point(31, 592);
            this.button_lg.Name = "button_lg";
            this.button_lg.Size = new System.Drawing.Size(120, 46);
            this.button_lg.TabIndex = 26;
            this.button_lg.Text = "Logout";
            this.button_lg.UseVisualStyleBackColor = true;
            this.button_lg.Click += new System.EventHandler(this.button_lg_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label_date);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox_id);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label_seller);
            this.panel1.Controls.Add(this.comboBox_category);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dataGridView_sellList);
            this.panel1.Controls.Add(this.dataGridView_products);
            this.panel1.Controls.Add(this.dataGridView_order);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.textBox_qty);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_price);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(196, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 625);
            this.panel1.TabIndex = 22;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(711, 10);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(59, 25);
            this.label_date.TabIndex = 22;
            this.label_date.Text = "Date:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(885, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 33);
            this.button1.TabIndex = 21;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(761, 284);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 30);
            this.textBox_id.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(690, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "BillId";
            // 
            // label_seller
            // 
            this.label_seller.AutoSize = true;
            this.label_seller.Location = new System.Drawing.Point(31, 7);
            this.label_seller.Name = "label_seller";
            this.label_seller.Size = new System.Drawing.Size(114, 25);
            this.label_seller.TabIndex = 18;
            this.label_seller.Text = "SellerName";
            // 
            // comboBox_category
            // 
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(36, 281);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(194, 33);
            this.comboBox_category.TabIndex = 17;
            this.comboBox_category.Text = "Select Category";
            this.comboBox_category.SelectionChangeCommitted += new System.EventHandler(this.comboBox_category_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Selling List";
            // 
            // dataGridView_sellList
            // 
            this.dataGridView_sellList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_sellList.Location = new System.Drawing.Point(382, 323);
            this.dataGridView_sellList.Name = "dataGridView_sellList";
            this.dataGridView_sellList.RowHeadersWidth = 51;
            this.dataGridView_sellList.RowTemplate.Height = 24;
            this.dataGridView_sellList.Size = new System.Drawing.Size(581, 288);
            this.dataGridView_sellList.TabIndex = 15;
            // 
            // dataGridView_products
            // 
            this.dataGridView_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_products.Location = new System.Drawing.Point(36, 323);
            this.dataGridView_products.Name = "dataGridView_products";
            this.dataGridView_products.RowHeadersWidth = 51;
            this.dataGridView_products.RowTemplate.Height = 24;
            this.dataGridView_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_products.Size = new System.Drawing.Size(309, 288);
            this.dataGridView_products.TabIndex = 14;
            this.dataGridView_products.Click += new System.EventHandler(this.dataGridView_products_Click);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 649);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.button_lg);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sellList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_order;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_qty;
        private System.Windows.Forms.Button button_lg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_products;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView_sellList;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.Label label_seller;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_date;
    }
}