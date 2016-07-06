namespace Milcom
{
    partial class frmGlavnaAdmin
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
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnRezultati = new System.Windows.Forms.Button();
            this.btnTestovi = new System.Windows.Forms.Button();
            this.btnCertifikati = new System.Windows.Forms.Button();
            this.btnKorisnici = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.milcomDataSet = new Milcom.MilcomDataSet();
            this.tippolaganjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tip_polaganjaTableAdapter = new Milcom.MilcomDataSetTableAdapters.tip_polaganjaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.milcomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tippolaganjaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackgroundImage = global::Milcom.Properties.Resources.iconLogout;
            this.btnOdjava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOdjava.Location = new System.Drawing.Point(350, 302);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(41, 35);
            this.btnOdjava.TabIndex = 4;
            this.btnOdjava.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnRezultati
            // 
            this.btnRezultati.BackgroundImage = global::Milcom.Properties.Resources.iconResult;
            this.btnRezultati.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRezultati.Location = new System.Drawing.Point(218, 196);
            this.btnRezultati.Name = "btnRezultati";
            this.btnRezultati.Size = new System.Drawing.Size(125, 75);
            this.btnRezultati.TabIndex = 3;
            this.btnRezultati.UseVisualStyleBackColor = true;
            this.btnRezultati.Click += new System.EventHandler(this.btnRezultati_Click);
            // 
            // btnTestovi
            // 
            this.btnTestovi.BackgroundImage = global::Milcom.Properties.Resources.iconTest;
            this.btnTestovi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTestovi.Location = new System.Drawing.Point(54, 196);
            this.btnTestovi.Name = "btnTestovi";
            this.btnTestovi.Size = new System.Drawing.Size(125, 75);
            this.btnTestovi.TabIndex = 2;
            this.btnTestovi.UseVisualStyleBackColor = true;
            this.btnTestovi.Click += new System.EventHandler(this.btnTestovi_Click);
            // 
            // btnCertifikati
            // 
            this.btnCertifikati.BackgroundImage = global::Milcom.Properties.Resources.iconCertificate;
            this.btnCertifikati.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCertifikati.Location = new System.Drawing.Point(218, 69);
            this.btnCertifikati.Name = "btnCertifikati";
            this.btnCertifikati.Size = new System.Drawing.Size(125, 75);
            this.btnCertifikati.TabIndex = 1;
            this.btnCertifikati.UseVisualStyleBackColor = true;
            this.btnCertifikati.Click += new System.EventHandler(this.btnCertifikati_Click);
            // 
            // btnKorisnici
            // 
            this.btnKorisnici.BackgroundImage = global::Milcom.Properties.Resources.iconUsers;
            this.btnKorisnici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKorisnici.Location = new System.Drawing.Point(54, 69);
            this.btnKorisnici.Name = "btnKorisnici";
            this.btnKorisnici.Size = new System.Drawing.Size(125, 75);
            this.btnKorisnici.TabIndex = 0;
            this.btnKorisnici.UseVisualStyleBackColor = true;
            this.btnKorisnici.Click += new System.EventHandler(this.btnKorisnici_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Korisnici:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Certifikati:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Testovi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rezultati:";
            // 
            // milcomDataSet
            // 
            this.milcomDataSet.DataSetName = "MilcomDataSet";
            this.milcomDataSet.EnforceConstraints = false;
            this.milcomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // frmGlavnaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 347);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnRezultati);
            this.Controls.Add(this.btnTestovi);
            this.Controls.Add(this.btnCertifikati);
            this.Controls.Add(this.btnKorisnici);
            this.Name = "frmGlavnaAdmin";
            this.Text = "Milcom - A D M I N";
            this.Load += new System.EventHandler(this.frmGlavnaAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.milcomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tippolaganjaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKorisnici;
        private System.Windows.Forms.Button btnCertifikati;
        private System.Windows.Forms.Button btnTestovi;
        private System.Windows.Forms.Button btnRezultati;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MilcomDataSet milcomDataSet;
        private System.Windows.Forms.BindingSource tippolaganjaBindingSource;
        private MilcomDataSetTableAdapters.tip_polaganjaTableAdapter tip_polaganjaTableAdapter;
    }
}