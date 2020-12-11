namespace IRF_beadando
{
    partial class AdatokImportalasa
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnImportalas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnImportalas
            // 
            this.btnImportalas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnImportalas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnImportalas.Location = new System.Drawing.Point(306, 398);
            this.btnImportalas.Name = "btnImportalas";
            this.btnImportalas.Size = new System.Drawing.Size(200, 40);
            this.btnImportalas.TabIndex = 0;
            this.btnImportalas.Text = "Importálás";
            this.btnImportalas.UseVisualStyleBackColor = false;
            this.btnImportalas.Click += new System.EventHandler(this.btnImportalas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(131, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Az adatok xml-be történő importálásához, kérem nyomja meg a gombot!";
            // 
            // AdatokImportalasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(848, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImportalas);
            this.Name = "AdatokImportalasa";
            this.Text = "Adatok importálása";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnImportalas;
        private System.Windows.Forms.Label label1;
    }
}