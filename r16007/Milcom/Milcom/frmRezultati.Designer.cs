namespace Milcom
{
    partial class frmRezultati
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
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.lblPretrazi = new System.Windows.Forms.Label();
            this.dgvRezultati = new System.Windows.Forms.DataGridView();
            this.milcomDataSet = new Milcom.MilcomDataSet();
            this.rezultatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezultatTableAdapter = new Milcom.MilcomDataSetTableAdapters.rezultatTableAdapter();
            this.tippolaganjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tip_polaganjaTableAdapter = new Milcom.MilcomDataSetTableAdapters.tip_polaganjaTableAdapter();
            this.polaznikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.polaznikTableAdapter = new Milcom.MilcomDataSetTableAdapters.polaznikTableAdapter();
            this.polaznikoibDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tippolaganjaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.datumpolaganjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pokusajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodoviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAnaliziraj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezultati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milcomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezultatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tippolaganjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polaznikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Location = new System.Drawing.Point(75, 6);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(100, 20);
            this.txtPretrazi.TabIndex = 3;
            this.txtPretrazi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPretrazi_KeyUp);
            // 
            // lblPretrazi
            // 
            this.lblPretrazi.AutoSize = true;
            this.lblPretrazi.Location = new System.Drawing.Point(12, 9);
            this.lblPretrazi.Name = "lblPretrazi";
            this.lblPretrazi.Size = new System.Drawing.Size(45, 13);
            this.lblPretrazi.TabIndex = 2;
            this.lblPretrazi.Text = "Pretraži:";
            // 
            // dgvRezultati
            // 
            this.dgvRezultati.AutoGenerateColumns = false;
            this.dgvRezultati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezultati.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.polaznikoibDataGridViewTextBoxColumn,
            this.tippolaganjaidDataGridViewTextBoxColumn,
            this.datumpolaganjaDataGridViewTextBoxColumn,
            this.pokusajDataGridViewTextBoxColumn,
            this.bodoviDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dgvRezultati.DataSource = this.rezultatBindingSource;
            this.dgvRezultati.Location = new System.Drawing.Point(13, 32);
            this.dgvRezultati.Name = "dgvRezultati";
            this.dgvRezultati.Size = new System.Drawing.Size(648, 309);
            this.dgvRezultati.TabIndex = 4;
            // 
            // milcomDataSet
            // 
            this.milcomDataSet.DataSetName = "MilcomDataSet";
            this.milcomDataSet.EnforceConstraints = false;
            this.milcomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rezultatBindingSource
            // 
            this.rezultatBindingSource.DataMember = "rezultat";
            this.rezultatBindingSource.DataSource = this.milcomDataSet;
            // 
            // rezultatTableAdapter
            // 
            this.rezultatTableAdapter.ClearBeforeFill = true;
            // 
            // tippolaganjaBindingSource
            // 
            this.tippolaganjaBindingSource.DataMember = "tip_polaganja";
            this.tippolaganjaBindingSource.DataSource = this.milcomDataSet;
            // 
            // tip_polaganjaTableAdapter
            // 
            this.tip_polaganjaTableAdapter.ClearBeforeFill = true;
            // 
            // polaznikBindingSource
            // 
            this.polaznikBindingSource.DataMember = "polaznik";
            this.polaznikBindingSource.DataSource = this.milcomDataSet;
            // 
            // polaznikTableAdapter
            // 
            this.polaznikTableAdapter.ClearBeforeFill = true;
            // 
            // polaznikoibDataGridViewTextBoxColumn
            // 
            this.polaznikoibDataGridViewTextBoxColumn.DataPropertyName = "polaznik_oib";
            this.polaznikoibDataGridViewTextBoxColumn.DataSource = this.polaznikBindingSource;
            this.polaznikoibDataGridViewTextBoxColumn.DisplayMember = "oib";
            this.polaznikoibDataGridViewTextBoxColumn.HeaderText = "polaznik_oib";
            this.polaznikoibDataGridViewTextBoxColumn.Name = "polaznikoibDataGridViewTextBoxColumn";
            this.polaznikoibDataGridViewTextBoxColumn.ReadOnly = true;
            this.polaznikoibDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.polaznikoibDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.polaznikoibDataGridViewTextBoxColumn.ValueMember = "oib";
            // 
            // tippolaganjaidDataGridViewTextBoxColumn
            // 
            this.tippolaganjaidDataGridViewTextBoxColumn.DataPropertyName = "tip_polaganja_id";
            this.tippolaganjaidDataGridViewTextBoxColumn.DataSource = this.tippolaganjaBindingSource;
            this.tippolaganjaidDataGridViewTextBoxColumn.DisplayMember = "tip";
            this.tippolaganjaidDataGridViewTextBoxColumn.HeaderText = "tip_polaganja_id";
            this.tippolaganjaidDataGridViewTextBoxColumn.Name = "tippolaganjaidDataGridViewTextBoxColumn";
            this.tippolaganjaidDataGridViewTextBoxColumn.ReadOnly = true;
            this.tippolaganjaidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tippolaganjaidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tippolaganjaidDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // datumpolaganjaDataGridViewTextBoxColumn
            // 
            this.datumpolaganjaDataGridViewTextBoxColumn.DataPropertyName = "datum_polaganja";
            this.datumpolaganjaDataGridViewTextBoxColumn.HeaderText = "datum_polaganja";
            this.datumpolaganjaDataGridViewTextBoxColumn.Name = "datumpolaganjaDataGridViewTextBoxColumn";
            // 
            // pokusajDataGridViewTextBoxColumn
            // 
            this.pokusajDataGridViewTextBoxColumn.DataPropertyName = "pokusaj";
            this.pokusajDataGridViewTextBoxColumn.HeaderText = "pokusaj";
            this.pokusajDataGridViewTextBoxColumn.Name = "pokusajDataGridViewTextBoxColumn";
            // 
            // bodoviDataGridViewTextBoxColumn
            // 
            this.bodoviDataGridViewTextBoxColumn.DataPropertyName = "bodovi";
            this.bodoviDataGridViewTextBoxColumn.HeaderText = "bodovi";
            this.bodoviDataGridViewTextBoxColumn.Name = "bodoviDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // btnAnaliziraj
            // 
            this.btnAnaliziraj.Location = new System.Drawing.Point(470, 354);
            this.btnAnaliziraj.Name = "btnAnaliziraj";
            this.btnAnaliziraj.Size = new System.Drawing.Size(110, 23);
            this.btnAnaliziraj.TabIndex = 5;
            this.btnAnaliziraj.Text = "Analiziraj test";
            this.btnAnaliziraj.UseVisualStyleBackColor = true;
            this.btnAnaliziraj.Click += new System.EventHandler(this.btnIzradi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(586, 354);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 6;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // frmRezultati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 389);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnAnaliziraj);
            this.Controls.Add(this.dgvRezultati);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.lblPretrazi);
            this.Name = "frmRezultati";
            this.Text = "Rezultati";
            this.Load += new System.EventHandler(this.frmRezultati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezultati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milcomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezultatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tippolaganjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polaznikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.Label lblPretrazi;
        private System.Windows.Forms.DataGridView dgvRezultati;
        private MilcomDataSet milcomDataSet;
        private System.Windows.Forms.BindingSource rezultatBindingSource;
        private MilcomDataSetTableAdapters.rezultatTableAdapter rezultatTableAdapter;
        private System.Windows.Forms.BindingSource tippolaganjaBindingSource;
        private MilcomDataSetTableAdapters.tip_polaganjaTableAdapter tip_polaganjaTableAdapter;
        private System.Windows.Forms.BindingSource polaznikBindingSource;
        private MilcomDataSetTableAdapters.polaznikTableAdapter polaznikTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn polaznikoibDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tippolaganjaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumpolaganjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pokusajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodoviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAnaliziraj;
        private System.Windows.Forms.Button btnOdustani;
    }
}