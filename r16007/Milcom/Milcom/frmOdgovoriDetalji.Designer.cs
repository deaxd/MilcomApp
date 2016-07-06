namespace Milcom
{
    partial class frmOdgovoriDetalji
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
            this.txtOdgovor = new System.Windows.Forms.TextBox();
            this.cbTocno = new System.Windows.Forms.CheckBox();
            this.btnUredu = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.milcomDataSet = new Milcom.MilcomDataSet();
            this.odgovorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odgovorTableAdapter = new Milcom.MilcomDataSetTableAdapters.odgovorTableAdapter();
            this.tableAdapterManager = new Milcom.MilcomDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.milcomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odgovorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odgovor:";
            // 
            // txtOdgovor
            // 
            this.txtOdgovor.Location = new System.Drawing.Point(72, 12);
            this.txtOdgovor.Multiline = true;
            this.txtOdgovor.Name = "txtOdgovor";
            this.txtOdgovor.Size = new System.Drawing.Size(200, 161);
            this.txtOdgovor.TabIndex = 1;
            // 
            // cbTocno
            // 
            this.cbTocno.AutoSize = true;
            this.cbTocno.Location = new System.Drawing.Point(72, 179);
            this.cbTocno.Name = "cbTocno";
            this.cbTocno.Size = new System.Drawing.Size(57, 17);
            this.cbTocno.TabIndex = 3;
            this.cbTocno.Text = "Točno";
            this.cbTocno.UseVisualStyleBackColor = true;
            // 
            // btnUredu
            // 
            this.btnUredu.Location = new System.Drawing.Point(116, 226);
            this.btnUredu.Name = "btnUredu";
            this.btnUredu.Size = new System.Drawing.Size(75, 23);
            this.btnUredu.TabIndex = 4;
            this.btnUredu.Text = "U redu";
            this.btnUredu.UseVisualStyleBackColor = true;
            this.btnUredu.Click += new System.EventHandler(this.btnUredu_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(197, 226);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 5;
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
            // odgovorBindingSource
            // 
            this.odgovorBindingSource.DataMember = "odgovor";
            this.odgovorBindingSource.DataSource = this.milcomDataSet;
            // 
            // odgovorTableAdapter
            // 
            this.odgovorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.certifikatTableAdapter = null;
            this.tableAdapterManager.korisnikTableAdapter = null;
            this.tableAdapterManager.odgovorTableAdapter = this.odgovorTableAdapter;
            this.tableAdapterManager.pitanjeTableAdapter = null;
            this.tableAdapterManager.polaznikTableAdapter = null;
            this.tableAdapterManager.rezultatTableAdapter = null;
            this.tableAdapterManager.testTableAdapter = null;
            this.tableAdapterManager.tip_korisnikTableAdapter = null;
            this.tableAdapterManager.tip_polaganjaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Milcom.MilcomDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmOdgovoriDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 269);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnUredu);
            this.Controls.Add(this.cbTocno);
            this.Controls.Add(this.txtOdgovor);
            this.Controls.Add(this.label1);
            this.Name = "frmOdgovoriDetalji";
            this.Text = "Odgovor Detalji";
            this.Load += new System.EventHandler(this.frmOdgovoriDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.milcomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odgovorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOdgovor;
        private System.Windows.Forms.CheckBox cbTocno;
        private System.Windows.Forms.Button btnUredu;
        private System.Windows.Forms.Button btnOdustani;
        private MilcomDataSet milcomDataSet;
        private System.Windows.Forms.BindingSource odgovorBindingSource;
        private MilcomDataSetTableAdapters.odgovorTableAdapter odgovorTableAdapter;
        private MilcomDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}