namespace IRF_beadando
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLetrehozas = new System.Windows.Forms.Button();
            this.btnExportalas = new System.Windows.Forms.Button();
            this.btnImportalas = new System.Windows.Forms.Button();
            this.btnUtvonal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üdvözöljük az xy alkalmazásban, kérjük válassza ki a kívánt szolgáltatást!";
            // 
            // btnLetrehozas
            // 
            this.btnLetrehozas.Location = new System.Drawing.Point(151, 156);
            this.btnLetrehozas.Name = "btnLetrehozas";
            this.btnLetrehozas.Size = new System.Drawing.Size(172, 23);
            this.btnLetrehozas.TabIndex = 1;
            this.btnLetrehozas.Text = "Járat léterhozása";
            this.btnLetrehozas.UseVisualStyleBackColor = true;
            this.btnLetrehozas.Click += new System.EventHandler(this.btnLetrehozas_Click);
            // 
            // btnExportalas
            // 
            this.btnExportalas.Location = new System.Drawing.Point(151, 218);
            this.btnExportalas.Name = "btnExportalas";
            this.btnExportalas.Size = new System.Drawing.Size(172, 23);
            this.btnExportalas.TabIndex = 2;
            this.btnExportalas.Text = "Adatok exportálása";
            this.btnExportalas.UseVisualStyleBackColor = true;
            this.btnExportalas.Click += new System.EventHandler(this.btnExportalas_Click);
            // 
            // btnImportalas
            // 
            this.btnImportalas.Location = new System.Drawing.Point(151, 94);
            this.btnImportalas.Name = "btnImportalas";
            this.btnImportalas.Size = new System.Drawing.Size(172, 23);
            this.btnImportalas.TabIndex = 3;
            this.btnImportalas.Text = "Adatok importálása";
            this.btnImportalas.UseVisualStyleBackColor = true;
            this.btnImportalas.Click += new System.EventHandler(this.btnImportalas_Click);
            // 
            // btnUtvonal
            // 
            this.btnUtvonal.Location = new System.Drawing.Point(151, 277);
            this.btnUtvonal.Name = "btnUtvonal";
            this.btnUtvonal.Size = new System.Drawing.Size(172, 23);
            this.btnUtvonal.TabIndex = 4;
            this.btnUtvonal.Text = "Útvonaltervezés";
            this.btnUtvonal.UseVisualStyleBackColor = true;
            this.btnUtvonal.Click += new System.EventHandler(this.btnUtvonal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 350);
            this.Controls.Add(this.btnUtvonal);
            this.Controls.Add(this.btnImportalas);
            this.Controls.Add(this.btnExportalas);
            this.Controls.Add(this.btnLetrehozas);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLetrehozas;
        private System.Windows.Forms.Button btnExportalas;
        private System.Windows.Forms.Button btnImportalas;
        private System.Windows.Forms.Button btnUtvonal;
    }
}

