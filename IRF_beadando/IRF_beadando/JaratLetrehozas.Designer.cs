namespace IRF_beadando
{
    partial class JaratLetrehozas
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
            this.btnMentes = new System.Windows.Forms.Button();
            this.cbKiinduloVaros = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbErkezoVaros = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpInduasiIdo = new System.Windows.Forms.DateTimePicker();
            this.dtpErkezesiIdo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbJarmu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUthossz = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMentes
            // 
            this.btnMentes.Location = new System.Drawing.Point(331, 370);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(75, 23);
            this.btnMentes.TabIndex = 0;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // cbKiinduloVaros
            // 
            this.cbKiinduloVaros.FormattingEnabled = true;
            this.cbKiinduloVaros.Location = new System.Drawing.Point(348, 97);
            this.cbKiinduloVaros.Name = "cbKiinduloVaros";
            this.cbKiinduloVaros.Size = new System.Drawing.Size(121, 24);
            this.cbKiinduloVaros.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kiinduló város:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Érkező város:";
            // 
            // cbErkezoVaros
            // 
            this.cbErkezoVaros.FormattingEnabled = true;
            this.cbErkezoVaros.Location = new System.Drawing.Point(348, 152);
            this.cbErkezoVaros.Name = "cbErkezoVaros";
            this.cbErkezoVaros.Size = new System.Drawing.Size(121, 24);
            this.cbErkezoVaros.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Indulási idő:";
            // 
            // dtpInduasiIdo
            // 
            this.dtpInduasiIdo.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dtpInduasiIdo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInduasiIdo.Location = new System.Drawing.Point(348, 253);
            this.dtpInduasiIdo.Name = "dtpInduasiIdo";
            this.dtpInduasiIdo.Size = new System.Drawing.Size(229, 22);
            this.dtpInduasiIdo.TabIndex = 7;
            // 
            // dtpErkezesiIdo
            // 
            this.dtpErkezesiIdo.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dtpErkezesiIdo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpErkezesiIdo.Location = new System.Drawing.Point(348, 304);
            this.dtpErkezesiIdo.Name = "dtpErkezesiIdo";
            this.dtpErkezesiIdo.Size = new System.Drawing.Size(229, 22);
            this.dtpErkezesiIdo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Érkezési idő:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Közlekedési jármű:";
            // 
            // cbJarmu
            // 
            this.cbJarmu.FormattingEnabled = true;
            this.cbJarmu.Items.AddRange(new object[] {
            "Busz",
            "Repülő",
            "Vonat"});
            this.cbJarmu.Location = new System.Drawing.Point(348, 42);
            this.cbJarmu.Name = "cbJarmu";
            this.cbJarmu.Size = new System.Drawing.Size(121, 24);
            this.cbJarmu.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Úthossz:";
            // 
            // tbUthossz
            // 
            this.tbUthossz.Location = new System.Drawing.Point(348, 205);
            this.tbUthossz.Name = "tbUthossz";
            this.tbUthossz.Size = new System.Drawing.Size(121, 22);
            this.tbUthossz.TabIndex = 15;
            // 
            // JaratLetrehozas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 470);
            this.Controls.Add(this.tbUthossz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbJarmu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpErkezesiIdo);
            this.Controls.Add(this.dtpInduasiIdo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbErkezoVaros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKiinduloVaros);
            this.Controls.Add(this.btnMentes);
            this.Name = "JaratLetrehozas";
            this.Text = "JaratLetrehozas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.ComboBox cbKiinduloVaros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbErkezoVaros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpInduasiIdo;
        private System.Windows.Forms.DateTimePicker dtpErkezesiIdo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbJarmu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbUthossz;
    }
}