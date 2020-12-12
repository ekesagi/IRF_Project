namespace IRF_beadando
{
    partial class Utvonaltervezes
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
            this.cbHonnan = new System.Windows.Forms.ComboBox();
            this.cbHova = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBetolt = new System.Windows.Forms.Button();
            this.btnKivalaszt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpMikor = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbUtvonalak = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(98, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kiinduló város:";
            // 
            // cbHonnan
            // 
            this.cbHonnan.FormattingEnabled = true;
            this.cbHonnan.Location = new System.Drawing.Point(237, 99);
            this.cbHonnan.Name = "cbHonnan";
            this.cbHonnan.Size = new System.Drawing.Size(121, 24);
            this.cbHonnan.TabIndex = 1;
            // 
            // cbHova
            // 
            this.cbHova.FormattingEnabled = true;
            this.cbHova.Location = new System.Drawing.Point(563, 99);
            this.cbHova.Name = "cbHova";
            this.cbHova.Size = new System.Drawing.Size(121, 24);
            this.cbHova.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(416, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Érkezési város:";
            // 
            // btnBetolt
            // 
            this.btnBetolt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBetolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBetolt.Location = new System.Drawing.Point(139, 210);
            this.btnBetolt.Name = "btnBetolt";
            this.btnBetolt.Size = new System.Drawing.Size(559, 40);
            this.btnBetolt.TabIndex = 8;
            this.btnBetolt.Text = "Útvonalak keresése";
            this.btnBetolt.UseVisualStyleBackColor = false;
            this.btnBetolt.Click += new System.EventHandler(this.btnBetolt_Click);
            // 
            // btnKivalaszt
            // 
            this.btnKivalaszt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKivalaszt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKivalaszt.Location = new System.Drawing.Point(139, 420);
            this.btnKivalaszt.Name = "btnKivalaszt";
            this.btnKivalaszt.Size = new System.Drawing.Size(559, 40);
            this.btnKivalaszt.TabIndex = 9;
            this.btnKivalaszt.Text = "Útvonalak exportálása";
            this.btnKivalaszt.UseVisualStyleBackColor = false;
            this.btnKivalaszt.Click += new System.EventHandler(this.btnKivalaszt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(219, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Indulás időpontja:";
            // 
            // dtpMikor
            // 
            this.dtpMikor.Location = new System.Drawing.Point(387, 157);
            this.dtpMikor.Name = "dtpMikor";
            this.dtpMikor.Size = new System.Drawing.Size(215, 22);
            this.dtpMikor.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(67, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(642, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Útvonal kereséséhez kérem adja meg a következő adatokat, majd nyomjon a gombra!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(135, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(563, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Az útvonalak csv-be történő exportálásához, kérem nyomja meg a gombot!";
            // 
            // tbUtvonalak
            // 
            this.tbUtvonalak.Location = new System.Drawing.Point(12, 256);
            this.tbUtvonalak.Multiline = true;
            this.tbUtvonalak.Name = "tbUtvonalak";
            this.tbUtvonalak.Size = new System.Drawing.Size(843, 110);
            this.tbUtvonalak.TabIndex = 14;
            // 
            // Utvonaltervezes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(867, 525);
            this.Controls.Add(this.tbUtvonalak);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpMikor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKivalaszt);
            this.Controls.Add(this.btnBetolt);
            this.Controls.Add(this.cbHova);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbHonnan);
            this.Controls.Add(this.label1);
            this.Name = "Utvonaltervezes";
            this.Text = "Útvonal létrehozása";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbHonnan;
        private System.Windows.Forms.ComboBox cbHova;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBetolt;
        private System.Windows.Forms.Button btnKivalaszt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpMikor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUtvonalak;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}