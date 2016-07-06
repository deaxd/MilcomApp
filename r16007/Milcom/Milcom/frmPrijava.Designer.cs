namespace Milcom
{
    partial class frmPrijava
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
            this.btnPrijava = new System.Windows.Forms.Button();
            this.lblKorIme = new System.Windows.Forms.Label();
            this.txtKorIme = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.prijavaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.milcomDataSet = new Milcom.MilcomDataSet();
            this.prijavaTableAdapter = new Milcom.MilcomDataSetTableAdapters.prijavaTableAdapter();
            this.korisnik1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnik1TableAdapter = new Milcom.MilcomDataSetTableAdapters.korisnik1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prijavaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milcomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnik1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrijava
            // 
            this.btnPrijava.Location = new System.Drawing.Point(106, 211);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(75, 23);
            this.btnPrijava.TabIndex = 0;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // lblKorIme
            // 
            this.lblKorIme.AutoSize = true;
            this.lblKorIme.Location = new System.Drawing.Point(53, 118);
            this.lblKorIme.Name = "lblKorIme";
            this.lblKorIme.Size = new System.Drawing.Size(78, 13);
            this.lblKorIme.TabIndex = 1;
            this.lblKorIme.Text = "Korisničko ime:";
            // 
            // txtKorIme
            // 
            this.txtKorIme.Location = new System.Drawing.Point(137, 118);
            this.txtKorIme.Name = "txtKorIme";
            this.txtKorIme.Size = new System.Drawing.Size(100, 20);
            this.txtKorIme.TabIndex = 2;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(137, 158);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(100, 20);
            this.txtLozinka.TabIndex = 4;
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(53, 158);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(47, 13);
            this.lblLozinka.TabIndex = 3;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(187, 211);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 6;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Milcom.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // prijavaBindingSource
            // 
            this.prijavaBindingSource.DataMember = "prijava";
            this.prijavaBindingSource.DataSource = this.milcomDataSet;
            // 
            // milcomDataSet
            // 
            this.milcomDataSet.DataSetName = "MilcomDataSet";
            this.milcomDataSet.EnforceConstraints = false;
            this.milcomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prijavaTableAdapter
            // 
            this.prijavaTableAdapter.ClearBeforeFill = true;
            // 
            // korisnik1BindingSource
            // 
            this.korisnik1BindingSource.DataMember = "korisnik1";
            this.korisnik1BindingSource.DataSource = this.milcomDataSet;
            // 
            // korisnik1TableAdapter
            // 
            this.korisnik1TableAdapter.ClearBeforeFill = true;
            // 
            // frmPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.txtKorIme);
            this.Controls.Add(this.lblKorIme);
            this.Controls.Add(this.btnPrijava);
            this.Name = "frmPrijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.frmPrijava_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prijavaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milcomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnik1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Label lblKorIme;
        private System.Windows.Forms.TextBox txtKorIme;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.BindingSource prijavaBindingSource;
        private MilcomDataSet milcomDataSet;
        private MilcomDataSetTableAdapters.prijavaTableAdapter prijavaTableAdapter;
        private System.Windows.Forms.BindingSource korisnik1BindingSource;
        private MilcomDataSetTableAdapters.korisnik1TableAdapter korisnik1TableAdapter;
    }
}

