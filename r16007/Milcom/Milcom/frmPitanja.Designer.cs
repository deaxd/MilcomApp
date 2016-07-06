namespace Milcom
{
    partial class frmPitanja
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
            this.dgvPitanja = new System.Windows.Forms.DataGridView();
            this.pitanjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.milcomDataSet = new Milcom.MilcomDataSet();
            this.btnIzbrisiP = new System.Windows.Forms.Button();
            this.btnUrediP = new System.Windows.Forms.Button();
            this.btnDodajP = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.dgvOdgovori = new System.Windows.Forms.DataGridView();
            this.fkodgovorpitanje1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIzbrisiO = new System.Windows.Forms.Button();
            this.btnUrediO = new System.Windows.Forms.Button();
            this.btnDodajO = new System.Windows.Forms.Button();
            this.pitanjeTableAdapter = new Milcom.MilcomDataSetTableAdapters.pitanjeTableAdapter();
            this.odgovorTableAdapter = new Milcom.MilcomDataSetTableAdapters.odgovorTableAdapter();
            this.tippolaganjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tip_polaganjaTableAdapter = new Milcom.MilcomDataSetTableAdapters.tip_polaganjaTableAdapter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tekstDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tocnoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pitanjeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tippolaganjaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tekstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPitanja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitanjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milcomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdgovori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkodgovorpitanje1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tippolaganjaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPitanja
            // 
            this.dgvPitanja.AutoGenerateColumns = false;
            this.dgvPitanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPitanja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tippolaganjaidDataGridViewTextBoxColumn,
            this.tekstDataGridViewTextBoxColumn});
            this.dgvPitanja.DataSource = this.pitanjeBindingSource;
            this.dgvPitanja.Location = new System.Drawing.Point(12, 64);
            this.dgvPitanja.Name = "dgvPitanja";
            this.dgvPitanja.Size = new System.Drawing.Size(644, 261);
            this.dgvPitanja.TabIndex = 0;
            // 
            // pitanjeBindingSource
            // 
            this.pitanjeBindingSource.DataMember = "pitanje";
            this.pitanjeBindingSource.DataSource = this.milcomDataSet;
            // 
            // milcomDataSet
            // 
            this.milcomDataSet.DataSetName = "MilcomDataSet";
            this.milcomDataSet.EnforceConstraints = false;
            this.milcomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnIzbrisiP
            // 
            this.btnIzbrisiP.BackgroundImage = global::Milcom.Properties.Resources.iconDelete;
            this.btnIzbrisiP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIzbrisiP.Location = new System.Drawing.Point(626, 27);
            this.btnIzbrisiP.Name = "btnIzbrisiP";
            this.btnIzbrisiP.Size = new System.Drawing.Size(35, 35);
            this.btnIzbrisiP.TabIndex = 3;
            this.btnIzbrisiP.UseVisualStyleBackColor = true;
            this.btnIzbrisiP.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnUrediP
            // 
            this.btnUrediP.BackgroundImage = global::Milcom.Properties.Resources.iconUpdate;
            this.btnUrediP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUrediP.Location = new System.Drawing.Point(585, 27);
            this.btnUrediP.Name = "btnUrediP";
            this.btnUrediP.Size = new System.Drawing.Size(35, 35);
            this.btnUrediP.TabIndex = 2;
            this.btnUrediP.UseVisualStyleBackColor = true;
            this.btnUrediP.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnDodajP
            // 
            this.btnDodajP.BackgroundImage = global::Milcom.Properties.Resources.iconCreate;
            this.btnDodajP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDodajP.Location = new System.Drawing.Point(544, 27);
            this.btnDodajP.Name = "btnDodajP";
            this.btnDodajP.Size = new System.Drawing.Size(35, 35);
            this.btnDodajP.TabIndex = 1;
            this.btnDodajP.UseVisualStyleBackColor = true;
            this.btnDodajP.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(581, 545);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 9;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // dgvOdgovori
            // 
            this.dgvOdgovori.AutoGenerateColumns = false;
            this.dgvOdgovori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdgovori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.tekstDataGridViewTextBoxColumn1,
            this.tocnoDataGridViewCheckBoxColumn,
            this.pitanjeidDataGridViewTextBoxColumn});
            this.dgvOdgovori.DataSource = this.fkodgovorpitanje1BindingSource;
            this.dgvOdgovori.Location = new System.Drawing.Point(16, 367);
            this.dgvOdgovori.Name = "dgvOdgovori";
            this.dgvOdgovori.Size = new System.Drawing.Size(640, 172);
            this.dgvOdgovori.TabIndex = 10;
            // 
            // fkodgovorpitanje1BindingSource
            // 
            this.fkodgovorpitanje1BindingSource.DataMember = "fk_odgovor_pitanje1";
            this.fkodgovorpitanje1BindingSource.DataSource = this.pitanjeBindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Popis pitanja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Odgovori za odabrano pitanje:";
            // 
            // btnIzbrisiO
            // 
            this.btnIzbrisiO.BackgroundImage = global::Milcom.Properties.Resources.iconDelete;
            this.btnIzbrisiO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIzbrisiO.Location = new System.Drawing.Point(627, 331);
            this.btnIzbrisiO.Name = "btnIzbrisiO";
            this.btnIzbrisiO.Size = new System.Drawing.Size(30, 30);
            this.btnIzbrisiO.TabIndex = 15;
            this.btnIzbrisiO.UseVisualStyleBackColor = true;
            this.btnIzbrisiO.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnUrediO
            // 
            this.btnUrediO.BackgroundImage = global::Milcom.Properties.Resources.iconUpdate;
            this.btnUrediO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUrediO.Location = new System.Drawing.Point(591, 331);
            this.btnUrediO.Name = "btnUrediO";
            this.btnUrediO.Size = new System.Drawing.Size(30, 30);
            this.btnUrediO.TabIndex = 14;
            this.btnUrediO.UseVisualStyleBackColor = true;
            this.btnUrediO.Click += new System.EventHandler(this.btnUrediO_Click);
            // 
            // btnDodajO
            // 
            this.btnDodajO.BackgroundImage = global::Milcom.Properties.Resources.iconCreate;
            this.btnDodajO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDodajO.Location = new System.Drawing.Point(555, 331);
            this.btnDodajO.Name = "btnDodajO";
            this.btnDodajO.Size = new System.Drawing.Size(30, 30);
            this.btnDodajO.TabIndex = 13;
            this.btnDodajO.UseVisualStyleBackColor = true;
            this.btnDodajO.Click += new System.EventHandler(this.btnDodajO_Click);
            // 
            // pitanjeTableAdapter
            // 
            this.pitanjeTableAdapter.ClearBeforeFill = true;
            // 
            // odgovorTableAdapter
            // 
            this.odgovorTableAdapter.ClearBeforeFill = true;
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
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // tekstDataGridViewTextBoxColumn1
            // 
            this.tekstDataGridViewTextBoxColumn1.DataPropertyName = "tekst";
            this.tekstDataGridViewTextBoxColumn1.HeaderText = "tekst";
            this.tekstDataGridViewTextBoxColumn1.Name = "tekstDataGridViewTextBoxColumn1";
            this.tekstDataGridViewTextBoxColumn1.Width = 400;
            // 
            // tocnoDataGridViewCheckBoxColumn
            // 
            this.tocnoDataGridViewCheckBoxColumn.DataPropertyName = "tocno";
            this.tocnoDataGridViewCheckBoxColumn.HeaderText = "tocno";
            this.tocnoDataGridViewCheckBoxColumn.Name = "tocnoDataGridViewCheckBoxColumn";
            // 
            // pitanjeidDataGridViewTextBoxColumn
            // 
            this.pitanjeidDataGridViewTextBoxColumn.DataPropertyName = "pitanje_id";
            this.pitanjeidDataGridViewTextBoxColumn.HeaderText = "pitanje_id";
            this.pitanjeidDataGridViewTextBoxColumn.Name = "pitanjeidDataGridViewTextBoxColumn";
            this.pitanjeidDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
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
            // tekstDataGridViewTextBoxColumn
            // 
            this.tekstDataGridViewTextBoxColumn.DataPropertyName = "tekst";
            this.tekstDataGridViewTextBoxColumn.HeaderText = "tekst";
            this.tekstDataGridViewTextBoxColumn.Name = "tekstDataGridViewTextBoxColumn";
            this.tekstDataGridViewTextBoxColumn.Width = 400;
            // 
            // frmPitanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 580);
            this.Controls.Add(this.btnIzbrisiO);
            this.Controls.Add(this.btnUrediO);
            this.Controls.Add(this.btnDodajO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOdgovori);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnIzbrisiP);
            this.Controls.Add(this.btnUrediP);
            this.Controls.Add(this.btnDodajP);
            this.Controls.Add(this.dgvPitanja);
            this.Name = "frmPitanja";
            this.Text = "Pitanja";
            this.Load += new System.EventHandler(this.frmPitanja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPitanja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitanjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milcomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdgovori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkodgovorpitanje1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tippolaganjaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPitanja;
        private System.Windows.Forms.Button btnDodajP;
        private System.Windows.Forms.Button btnUrediP;
        private System.Windows.Forms.Button btnIzbrisiP;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.DataGridView dgvOdgovori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIzbrisiO;
        private System.Windows.Forms.Button btnUrediO;
        private System.Windows.Forms.Button btnDodajO;
        private System.Windows.Forms.BindingSource pitanjeBindingSource;
        private MilcomDataSet milcomDataSet;
        private System.Windows.Forms.BindingSource fkodgovorpitanje1BindingSource;
        private MilcomDataSetTableAdapters.pitanjeTableAdapter pitanjeTableAdapter;
        private MilcomDataSetTableAdapters.odgovorTableAdapter odgovorTableAdapter;
        private System.Windows.Forms.BindingSource tippolaganjaBindingSource;
        private MilcomDataSetTableAdapters.tip_polaganjaTableAdapter tip_polaganjaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tekstDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tocnoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pitanjeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tippolaganjaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tekstDataGridViewTextBoxColumn;
    }
}