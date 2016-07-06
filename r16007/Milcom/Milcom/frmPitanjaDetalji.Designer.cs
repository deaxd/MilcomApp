namespace Milcom
{
    partial class frmPitanjaDetalji
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPitanje = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnUredu = new System.Windows.Forms.Button();
            this.milcomDataSet = new Milcom.MilcomDataSet();
            this.pitanjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pitanjeTableAdapter = new Milcom.MilcomDataSetTableAdapters.pitanjeTableAdapter();
            this.tableAdapterManager = new Milcom.MilcomDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.milcomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitanjeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pitanje:";
            // 
            // txtPitanje
            // 
            this.txtPitanje.Location = new System.Drawing.Point(76, 12);
            this.txtPitanje.Multiline = true;
            this.txtPitanje.Name = "txtPitanje";
            this.txtPitanje.Size = new System.Drawing.Size(291, 128);
            this.txtPitanje.TabIndex = 1;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(292, 146);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 8;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnUredu
            // 
            this.btnUredu.Location = new System.Drawing.Point(211, 146);
            this.btnUredu.Name = "btnUredu";
            this.btnUredu.Size = new System.Drawing.Size(75, 23);
            this.btnUredu.TabIndex = 7;
            this.btnUredu.Text = "U redu";
            this.btnUredu.UseVisualStyleBackColor = true;
            this.btnUredu.Click += new System.EventHandler(this.btnUredu_Click);
            // 
            // milcomDataSet
            // 
            this.milcomDataSet.DataSetName = "MilcomDataSet";
            this.milcomDataSet.EnforceConstraints = false;
            this.milcomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pitanjeBindingSource
            // 
            this.pitanjeBindingSource.DataMember = "pitanje";
            this.pitanjeBindingSource.DataSource = this.milcomDataSet;
            // 
            // pitanjeTableAdapter
            // 
            this.pitanjeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.certifikatTableAdapter = null;
            this.tableAdapterManager.korisnikTableAdapter = null;
            this.tableAdapterManager.odgovorTableAdapter = null;
            this.tableAdapterManager.pitanjeTableAdapter = this.pitanjeTableAdapter;
            this.tableAdapterManager.polaznikTableAdapter = null;
            this.tableAdapterManager.rezultatTableAdapter = null;
            this.tableAdapterManager.testTableAdapter = null;
            this.tableAdapterManager.tip_korisnikTableAdapter = null;
            this.tableAdapterManager.tip_polaganjaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Milcom.MilcomDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmPitanjaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 185);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnUredu);
            this.Controls.Add(this.txtPitanje);
            this.Controls.Add(this.label1);
            this.Name = "frmPitanjaDetalji";
            this.Text = "Pitanja - Detalji";
            this.Load += new System.EventHandler(this.frmPitanjaDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.milcomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitanjeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPitanje;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnUredu;
        private MilcomDataSet milcomDataSet;
        private System.Windows.Forms.BindingSource pitanjeBindingSource;
        private MilcomDataSetTableAdapters.pitanjeTableAdapter pitanjeTableAdapter;
        private MilcomDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}