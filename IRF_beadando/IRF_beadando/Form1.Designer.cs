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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(61, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(758, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üdvözöljük a Bridge alkalmazásban, kérem válassza ki a kívánt szolgáltatást!";
            // 
            // btnLetrehozas
            // 
            this.btnLetrehozas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLetrehozas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLetrehozas.Location = new System.Drawing.Point(230, 229);
            this.btnLetrehozas.Name = "btnLetrehozas";
            this.btnLetrehozas.Size = new System.Drawing.Size(528, 40);
            this.btnLetrehozas.TabIndex = 1;
            this.btnLetrehozas.Text = "Járat léterhozása";
            this.btnLetrehozas.UseVisualStyleBackColor = false;
            this.btnLetrehozas.Click += new System.EventHandler(this.btnLetrehozas_Click);
            // 
            // btnExportalas
            // 
            this.btnExportalas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExportalas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExportalas.Location = new System.Drawing.Point(230, 285);
            this.btnExportalas.Name = "btnExportalas";
            this.btnExportalas.Size = new System.Drawing.Size(528, 41);
            this.btnExportalas.TabIndex = 2;
            this.btnExportalas.Text = "Adatok megtekintése és exportálása";
            this.btnExportalas.UseVisualStyleBackColor = false;
            this.btnExportalas.Click += new System.EventHandler(this.btnExportalas_Click);
            // 
            // btnImportalas
            // 
            this.btnImportalas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnImportalas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnImportalas.Location = new System.Drawing.Point(230, 170);
            this.btnImportalas.Name = "btnImportalas";
            this.btnImportalas.Size = new System.Drawing.Size(528, 40);
            this.btnImportalas.TabIndex = 3;
            this.btnImportalas.Text = "Adatok importálása";
            this.btnImportalas.UseVisualStyleBackColor = false;
            this.btnImportalas.Click += new System.EventHandler(this.btnImportalas_Click);
            // 
            // btnUtvonal
            // 
            this.btnUtvonal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUtvonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUtvonal.Location = new System.Drawing.Point(230, 345);
            this.btnUtvonal.Name = "btnUtvonal";
            this.btnUtvonal.Size = new System.Drawing.Size(528, 41);
            this.btnUtvonal.TabIndex = 4;
            this.btnUtvonal.Text = "Útvonaltervezés";
            this.btnUtvonal.UseVisualStyleBackColor = false;
            this.btnUtvonal.Click += new System.EventHandler(this.btnUtvonal_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(982, 473);
            this.Controls.Add(this.btnUtvonal);
            this.Controls.Add(this.btnImportalas);
            this.Controls.Add(this.btnExportalas);
            this.Controls.Add(this.btnLetrehozas);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kezdőlap";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLetrehozas;
        private System.Windows.Forms.Button btnExportalas;
        private System.Windows.Forms.Button btnImportalas;
        private System.Windows.Forms.Button btnUtvonal;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

