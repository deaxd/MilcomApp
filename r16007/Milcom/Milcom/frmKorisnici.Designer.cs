namespace Milcom
{
    partial class frmKorisnici
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
            this.lblPretrazi = new System.Windows.Forms.Label();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.korisniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.milcomDataSet = new Milcom.MilcomDataSet();
            this.korisniciTableAdapter = new Milcom.MilcomDataSetTableAdapters.korisniciTableAdapter();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumrodjenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polaznikoibDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milcomDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPretrazi
            // 
            this.lblPretrazi.AutoSize = true;
            this.lblPretrazi.Location = new System.Drawing.Point(13, 13);
            this.lblPretrazi.Name = "lblPretrazi";
            this.lblPretrazi.Size = new System.Drawing.Size(45, 13);
            this.lblPretrazi.TabIndex = 0;
            this.lblPretrazi.Text = "Pretraži:";
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Location = new System.Drawing.Point(76, 10);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(100, 20);
            this.txtPretrazi.TabIndex = 1;
            this.txtPretrazi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPretrazi_KeyUp);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.BackgroundImage = global::Milcom.Properties.Resources.iconUserDelete;
            this.btnIzbrisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIzbrisi.Location = new System.Drawing.Point(942, 13);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(50, 40);
            this.btnIzbrisi.TabIndex = 5;
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.BackgroundImage = global::Milcom.Properties.Resources.iconUserUpdate;
            this.btnUredi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUredi.Location = new System.Drawing.Point(886, 14);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(50, 40);
            this.btnUredi.TabIndex = 4;
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackgroundImage = global::Milcom.Properties.Resources.iconUserCreate;
            this.btnDodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDodaj.Location = new System.Drawing.Point(830, 14);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(50, 40);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AutoGenerateColumns = false;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.tipDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.datumrodjenjaDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.polaznikoibDataGridViewTextBoxColumn});
            this.dgvKorisnici.DataSource = this.korisniciBindingSource;
            this.dgvKorisnici.Location = new System.Drawing.Point(12, 59);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.Size = new System.Drawing.Size(980, 435);
            this.dgvKorisnici.TabIndex = 6;
            // 
            // korisniciBindingSource
            // 
            this.korisniciBindingSource.DataMember = "korisnici";
            this.korisniciBindingSource.DataSource = this.milcomDataSet;
            // 
            // milcomDataSet
            // 
            this.milcomDataSet.DataSetName = "MilcomDataSet";
            this.milcomDataSet.EnforceConstraints = false;
            this.milcomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // korisniciTableAdapter
            // 
            this.korisniciTableAdapter.ClearBeforeFill = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // tipDataGridViewTextBoxColumn
            // 
            this.tipDataGridViewTextBoxColumn.DataPropertyName = "tip";
            this.tipDataGridViewTextBoxColumn.HeaderText = "tip";
            this.tipDataGridViewTextBoxColumn.Name = "tipDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // datumrodjenjaDataGridViewTextBoxColumn
            // 
            this.datumrodjenjaDataGridViewTextBoxColumn.DataPropertyName = "datum_rodjenja";
            this.datumrodjenjaDataGridViewTextBoxColumn.HeaderText = "datum_rodjenja";
            this.datumrodjenjaDataGridViewTextBoxColumn.Name = "datumrodjenjaDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // polaznikoibDataGridViewTextBoxColumn
            // 
            this.polaznikoibDataGridViewTextBoxColumn.DataPropertyName = "polaznik_oib";
            this.polaznikoibDataGridViewTextBoxColumn.HeaderText = "polaznik_oib";
            this.polaznikoibDataGridViewTextBoxColumn.Name = "polaznikoibDataGridViewTextBoxColumn";
            this.polaznikoibDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 508);
            this.Controls.Add(this.dgvKorisnici);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.lblPretrazi);
            this.Name = "frmKorisnici";
            this.Text = "Korisnici";
            this.Load += new System.EventHandler(this.frmKorisnici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milcomDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPretrazi;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.DataGridView dgvKorisnici;
        private MilcomDataSet milcomDataSet;
        private System.Windows.Forms.BindingSource korisniciBindingSource;
        private MilcomDataSetTableAdapters.korisniciTableAdapter korisniciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumrodjenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn polaznikoibDataGridViewTextBoxColumn;
    }
}