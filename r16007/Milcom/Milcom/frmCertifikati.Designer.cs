namespace Milcom
{
    partial class frmCertifikati
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
            this.milcomDataSet = new Milcom.MilcomDataSet();
            this.certifikatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.certifikatTableAdapter = new Milcom.MilcomDataSetTableAdapters.certifikatTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumizdavanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezultatidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnIzdaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milcomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certifikatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.datumizdavanjaDataGridViewTextBoxColumn,
            this.rezultatidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.certifikatBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(525, 286);
            this.dataGridView1.TabIndex = 0;
            // 
            // milcomDataSet
            // 
            this.milcomDataSet.DataSetName = "MilcomDataSet";
            this.milcomDataSet.EnforceConstraints = false;
            this.milcomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // certifikatBindingSource
            // 
            this.certifikatBindingSource.DataMember = "certifikat";
            this.certifikatBindingSource.DataSource = this.milcomDataSet;
            // 
            // certifikatTableAdapter
            // 
            this.certifikatTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // datumizdavanjaDataGridViewTextBoxColumn
            // 
            this.datumizdavanjaDataGridViewTextBoxColumn.DataPropertyName = "datum_izdavanja";
            this.datumizdavanjaDataGridViewTextBoxColumn.HeaderText = "datum_izdavanja";
            this.datumizdavanjaDataGridViewTextBoxColumn.Name = "datumizdavanjaDataGridViewTextBoxColumn";
            // 
            // rezultatidDataGridViewTextBoxColumn
            // 
            this.rezultatidDataGridViewTextBoxColumn.DataPropertyName = "rezultat_id";
            this.rezultatidDataGridViewTextBoxColumn.HeaderText = "rezultat_id";
            this.rezultatidDataGridViewTextBoxColumn.Name = "rezultatidDataGridViewTextBoxColumn";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(463, 339);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 8;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnIzdaj
            // 
            this.btnIzdaj.Location = new System.Drawing.Point(347, 339);
            this.btnIzdaj.Name = "btnIzdaj";
            this.btnIzdaj.Size = new System.Drawing.Size(110, 23);
            this.btnIzdaj.TabIndex = 7;
            this.btnIzdaj.Text = "Izdaj certifikat";
            this.btnIzdaj.UseVisualStyleBackColor = true;
            this.btnIzdaj.Click += new System.EventHandler(this.btnIzdaj_Click);
            // 
            // frmCertifikati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 374);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnIzdaj);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmCertifikati";
            this.Text = "Certifikati";
            this.Load += new System.EventHandler(this.frmCertifikati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milcomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certifikatBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MilcomDataSet milcomDataSet;
        private System.Windows.Forms.BindingSource certifikatBindingSource;
        private MilcomDataSetTableAdapters.certifikatTableAdapter certifikatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumizdavanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezultatidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnIzdaj;
    }
}