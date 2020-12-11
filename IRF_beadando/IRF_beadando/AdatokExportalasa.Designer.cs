namespace IRF_beadando
{
    partial class AdatokExportalasa
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
            this.btnExportalas = new System.Windows.Forms.Button();
            this.dtgAdatokkiirasa = new System.Windows.Forms.DataGridView();
            this.jaratBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAdatokkiirasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jaratBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExportalas
            // 
            this.btnExportalas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExportalas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExportalas.Location = new System.Drawing.Point(299, 398);
            this.btnExportalas.Name = "btnExportalas";
            this.btnExportalas.Size = new System.Drawing.Size(200, 40);
            this.btnExportalas.TabIndex = 0;
            this.btnExportalas.Text = "Adatok exportálása";
            this.btnExportalas.UseVisualStyleBackColor = false;
            this.btnExportalas.Click += new System.EventHandler(this.btnExportalas_Click);
            // 
            // dtgAdatokkiirasa
            // 
            this.dtgAdatokkiirasa.AutoGenerateColumns = false;
            this.dtgAdatokkiirasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAdatokkiirasa.DataSource = this.jaratBindingSource;
            this.dtgAdatokkiirasa.Location = new System.Drawing.Point(48, 21);
            this.dtgAdatokkiirasa.Name = "dtgAdatokkiirasa";
            this.dtgAdatokkiirasa.RowHeadersWidth = 51;
            this.dtgAdatokkiirasa.RowTemplate.Height = 24;
            this.dtgAdatokkiirasa.Size = new System.Drawing.Size(704, 326);
            this.dtgAdatokkiirasa.TabIndex = 1;
            // 
            // jaratBindingSource
            // 
            this.jaratBindingSource.DataSource = typeof(IRF_beadando.Jarat);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(148, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Az adatok exportálásához, kérem kattintson az exportálás gombra!";
            // 
            // AdatokExportalasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgAdatokkiirasa);
            this.Controls.Add(this.btnExportalas);
            this.Name = "AdatokExportalasa";
            this.Text = "Adatok Exportálása";
            this.Load += new System.EventHandler(this.AdatokExportalasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAdatokkiirasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jaratBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExportalas;
        private System.Windows.Forms.DataGridView dtgAdatokkiirasa;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.BindingSource jaratBindingSource;
        private System.Windows.Forms.Label label1;
    }
}