namespace Proiect_Baze_de_Date
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelFac = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.labelSum = new System.Windows.Forms.Label();
            this.labelSca = new System.Windows.Forms.Label();
            this.textFac = new System.Windows.Forms.TextBox();
            this.textSum = new System.Windows.Forms.TextBox();
            this.textSca = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scadentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturiDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturiInfoDataSet = new Proiect_Baze_de_Date.FacturiInfoDataSet();
            this.facturiDataTableAdapter = new Proiect_Baze_de_Date.FacturiInfoDataSetTableAdapters.FacturiDataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturiDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturiInfoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.facturiDataGridViewTextBoxColumn,
            this.sumaDataGridViewTextBoxColumn,
            this.scadentaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.facturiDataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(890, 219);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelFac
            // 
            this.labelFac.AutoSize = true;
            this.labelFac.Location = new System.Drawing.Point(32, 36);
            this.labelFac.Name = "labelFac";
            this.labelFac.Size = new System.Drawing.Size(55, 16);
            this.labelFac.TabIndex = 1;
            this.labelFac.Text = "Factura:";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(42, 61);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(45, 16);
            this.labelSum.TabIndex = 2;
            this.labelSum.Text = "Suma:";
            // 
            // labelSca
            // 
            this.labelSca.AutoSize = true;
            this.labelSca.Location = new System.Drawing.Point(19, 87);
            this.labelSca.Name = "labelSca";
            this.labelSca.Size = new System.Drawing.Size(68, 16);
            this.labelSca.TabIndex = 3;
            this.labelSca.Text = "Scadenta:";
            // 
            // textFac
            // 
            this.textFac.Location = new System.Drawing.Point(93, 30);
            this.textFac.Name = "textFac";
            this.textFac.Size = new System.Drawing.Size(100, 22);
            this.textFac.TabIndex = 4;
            // 
            // textSum
            // 
            this.textSum.Location = new System.Drawing.Point(93, 58);
            this.textSum.Name = "textSum";
            this.textSum.Size = new System.Drawing.Size(100, 22);
            this.textSum.TabIndex = 5;
            // 
            // textSca
            // 
            this.textSca.Location = new System.Drawing.Point(93, 84);
            this.textSca.Name = "textSca";
            this.textSca.Size = new System.Drawing.Size(100, 22);
            this.textSca.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAdauga);
            this.groupBox1.Controls.Add(this.labelSum);
            this.groupBox1.Controls.Add(this.textSca);
            this.groupBox1.Controls.Add(this.labelFac);
            this.groupBox1.Controls.Add(this.textSum);
            this.groupBox1.Controls.Add(this.labelSca);
            this.groupBox1.Controls.Add(this.textFac);
            this.groupBox1.Location = new System.Drawing.Point(13, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 144);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adauga Factura";
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.Location = new System.Drawing.Point(93, 113);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(100, 25);
            this.buttonAdauga.TabIndex = 7;
            this.buttonAdauga.Text = "Adauga";
            this.buttonAdauga.UseVisualStyleBackColor = true;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // facturiDataGridViewTextBoxColumn
            // 
            this.facturiDataGridViewTextBoxColumn.DataPropertyName = "Facturi";
            this.facturiDataGridViewTextBoxColumn.HeaderText = "Facturi";
            this.facturiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.facturiDataGridViewTextBoxColumn.Name = "facturiDataGridViewTextBoxColumn";
            this.facturiDataGridViewTextBoxColumn.Width = 125;
            // 
            // sumaDataGridViewTextBoxColumn
            // 
            this.sumaDataGridViewTextBoxColumn.DataPropertyName = "Suma";
            this.sumaDataGridViewTextBoxColumn.HeaderText = "Suma";
            this.sumaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sumaDataGridViewTextBoxColumn.Name = "sumaDataGridViewTextBoxColumn";
            this.sumaDataGridViewTextBoxColumn.Width = 125;
            // 
            // scadentaDataGridViewTextBoxColumn
            // 
            this.scadentaDataGridViewTextBoxColumn.DataPropertyName = "Scadenta";
            this.scadentaDataGridViewTextBoxColumn.HeaderText = "Scadenta";
            this.scadentaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.scadentaDataGridViewTextBoxColumn.Name = "scadentaDataGridViewTextBoxColumn";
            this.scadentaDataGridViewTextBoxColumn.Width = 125;
            // 
            // facturiDataBindingSource
            // 
            this.facturiDataBindingSource.DataMember = "FacturiData";
            this.facturiDataBindingSource.DataSource = this.facturiInfoDataSet;
            // 
            // facturiInfoDataSet
            // 
            this.facturiInfoDataSet.DataSetName = "FacturiInfoDataSet";
            this.facturiInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturiDataTableAdapter
            // 
            this.facturiDataTableAdapter.ClearBeforeFill = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 544);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturiDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturiInfoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FacturiInfoDataSet facturiInfoDataSet;
        private System.Windows.Forms.BindingSource facturiDataBindingSource;
        private FacturiInfoDataSetTableAdapters.FacturiDataTableAdapter facturiDataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scadentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelFac;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelSca;
        private System.Windows.Forms.TextBox textFac;
        private System.Windows.Forms.TextBox textSum;
        private System.Windows.Forms.TextBox textSca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAdauga;
    }
}