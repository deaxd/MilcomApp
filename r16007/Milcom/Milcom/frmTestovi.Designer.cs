namespace Milcom
{
    partial class frmTestovi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInformatika = new System.Windows.Forms.Button();
            this.btnNjemacki = new System.Windows.Forms.Button();
            this.btnEngleski = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnInformatika);
            this.groupBox1.Controls.Add(this.btnNjemacki);
            this.groupBox1.Controls.Add(this.btnEngleski);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 365);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izaberite kategoriju:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Informatika:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Njemački jezik:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Engleski jezik:";
            // 
            // btnInformatika
            // 
            this.btnInformatika.BackgroundImage = global::Milcom.Properties.Resources.iconComp;
            this.btnInformatika.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInformatika.Location = new System.Drawing.Point(59, 264);
            this.btnInformatika.Name = "btnInformatika";
            this.btnInformatika.Size = new System.Drawing.Size(150, 75);
            this.btnInformatika.TabIndex = 5;
            this.btnInformatika.UseVisualStyleBackColor = true;
            this.btnInformatika.Click += new System.EventHandler(this.btnInformatika_Click);
            // 
            // btnNjemacki
            // 
            this.btnNjemacki.BackgroundImage = global::Milcom.Properties.Resources.iconGer;
            this.btnNjemacki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNjemacki.Location = new System.Drawing.Point(59, 161);
            this.btnNjemacki.Name = "btnNjemacki";
            this.btnNjemacki.Size = new System.Drawing.Size(150, 75);
            this.btnNjemacki.TabIndex = 4;
            this.btnNjemacki.UseVisualStyleBackColor = true;
            this.btnNjemacki.Click += new System.EventHandler(this.btnNjemacki_Click);
            // 
            // btnEngleski
            // 
            this.btnEngleski.BackgroundImage = global::Milcom.Properties.Resources.iconEng;
            this.btnEngleski.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEngleski.Location = new System.Drawing.Point(59, 59);
            this.btnEngleski.Name = "btnEngleski";
            this.btnEngleski.Size = new System.Drawing.Size(150, 75);
            this.btnEngleski.TabIndex = 3;
            this.btnEngleski.UseVisualStyleBackColor = true;
            this.btnEngleski.Click += new System.EventHandler(this.btnEngleski_Click);
            // 
            // frmTestovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 389);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTestovi";
            this.Text = "Testovi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEngleski;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInformatika;
        private System.Windows.Forms.Button btnNjemacki;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}