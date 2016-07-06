namespace Milcom
{
    partial class frmKorisniciDetalji
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
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUredu = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.milcomDataSet = new Milcom.MilcomDataSet();
            this.tipkorisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tip_korisnikTableAdapter = new Milcom.MilcomDataSetTableAdapters.tip_korisnikTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.milcomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipkorisnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTip
            // 
            this.cbTip.DataSource = this.tipkorisnikBindingSource;
            this.cbTip.DisplayMember = "tip";
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Location = new System.Drawing.Point(160, 45);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(121, 21);
            this.cbTip.TabIndex = 0;
            this.cbTip.ValueMember = "id";
            this.cbTip.SelectedIndexChanged += new System.EventHandler(this.cbTip_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(160, 95);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(160, 121);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDatum);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtAdresa);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtOIB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(11, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 243);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci polaznika:";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(149, 114);
            this.dtpDatum.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpDatum.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(137, 20);
            this.dtpDatum.TabIndex = 34;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(149, 192);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Email:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(149, 166);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Telefon:";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(149, 140);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(100, 20);
            this.txtAdresa.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Adresa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Datum rođenja:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(149, 88);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Prezime:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(149, 62);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ime:";
            // 
            // txtOIB
            // 
            this.txtOIB.Location = new System.Drawing.Point(149, 36);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(100, 20);
            this.txtOIB.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "OIB:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Tip korisnika:";
            // 
            // btnUredu
            // 
            this.btnUredu.Location = new System.Drawing.Point(171, 465);
            this.btnUredu.Name = "btnUredu";
            this.btnUredu.Size = new System.Drawing.Size(75, 23);
            this.btnUredu.TabIndex = 20;
            this.btnUredu.Text = "U redu";
            this.btnUredu.UseVisualStyleBackColor = true;
            this.btnUredu.Click += new System.EventHandler(this.btnUredu_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(272, 465);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 21;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // milcomDataSet
            // 
            this.milcomDataSet.DataSetName = "MilcomDataSet";
            this.milcomDataSet.EnforceConstraints = false;
            this.milcomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipkorisnikBindingSource
            // 
            this.tipkorisnikBindingSource.DataMember = "tip_korisnik";
            this.tipkorisnikBindingSource.DataSource = this.milcomDataSet;
            // 
            // tip_korisnikTableAdapter
            // 
            this.tip_korisnikTableAdapter.ClearBeforeFill = true;
            // 
            // frmKorisniciDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 508);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnUredu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTip);
            this.Name = "frmKorisniciDetalji";
            this.Text = "Korisnici - Detalji";
            this.Load += new System.EventHandler(this.frmKorisniciDetalji_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.milcomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipkorisnikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUredu;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private MilcomDataSet milcomDataSet;
        private System.Windows.Forms.BindingSource tipkorisnikBindingSource;
        private MilcomDataSetTableAdapters.tip_korisnikTableAdapter tip_korisnikTableAdapter;
    }
}