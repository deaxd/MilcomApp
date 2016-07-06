namespace Milcom
{
    partial class frmGlavnaUser
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
            this.btnPristupi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.tippolaganjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.milcomDataSet = new Milcom.MilcomDataSet();
            this.milcomDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tip_polaganjaTableAdapter = new Milcom.MilcomDataSetTableAdapters.tip_polaganjaTableAdapter();
            this.korisnikTableAdapter1 = new Milcom.MilcomDataSetTableAdapters.korisnikTableAdapter();
            this.rezultatTableAdapter1 = new Milcom.MilcomDataSetTableAdapters.rezultatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tippolaganjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milcomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milcomDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPristupi
            // 
            this.btnPristupi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPristupi.Location = new System.Drawing.Point(89, 220);
            this.btnPristupi.Name = "btnPristupi";
            this.btnPristupi.Size = new System.Drawing.Size(200, 75);
            this.btnPristupi.TabIndex = 0;
            this.btnPristupi.Text = "Pristupi testu";
            this.btnPristupi.UseVisualStyleBackColor = true;
            this.btnPristupi.Click += new System.EventHandler(this.btnPristupi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Milcom.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(69, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // cbTip
            // 
            this.cbTip.DataSource = this.tippolaganjaBindingSource;
            this.cbTip.DisplayMember = "tip";
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Location = new System.Drawing.Point(126, 179);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(121, 21);
            this.cbTip.TabIndex = 7;
            this.cbTip.ValueMember = "id";
            // 
            // tippolaganjaBindingSource
            // 
            this.tippolaganjaBindingSource.DataMember = "tip_polaganja";
            this.tippolaganjaBindingSource.DataSource = this.milcomDataSet;
            // 
            // milcomDataSet
            // 
            this.milcomDataSet.DataSetName = "MilcomDataSet";
            this.milcomDataSet.EnforceConstraints = false;
            this.milcomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // milcomDataSetBindingSource
            // 
            this.milcomDataSetBindingSource.DataSource = this.milcomDataSet;
            this.milcomDataSetBindingSource.Position = 0;
            // 
            // tip_polaganjaTableAdapter
            // 
            this.tip_polaganjaTableAdapter.ClearBeforeFill = true;
            // 
            // korisnikTableAdapter1
            // 
            this.korisnikTableAdapter1.ClearBeforeFill = true;
            // 
            // rezultatTableAdapter1
            // 
            this.rezultatTableAdapter1.ClearBeforeFill = true;
            // 
            // frmGlavnaUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.cbTip);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPristupi);
            this.Name = "frmGlavnaUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Milcom";
            this.Load += new System.EventHandler(this.frmGlavnaUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tippolaganjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milcomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milcomDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPristupi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.BindingSource milcomDataSetBindingSource;
        private MilcomDataSet milcomDataSet;
        private System.Windows.Forms.BindingSource tippolaganjaBindingSource;
        private MilcomDataSetTableAdapters.tip_polaganjaTableAdapter tip_polaganjaTableAdapter;
        private MilcomDataSetTableAdapters.korisnikTableAdapter korisnikTableAdapter1;
        private MilcomDataSetTableAdapters.rezultatTableAdapter rezultatTableAdapter1;
    }
}