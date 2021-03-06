﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace IRF_beadando
{
    public partial class Form1 : Form
    {
        public static List<string> Varosok = new List<string>();
        public static List<Jarat> Jaratok = new List<Jarat>(); 

        public Form1()
        {
            InitializeComponent();
            Varosok.Add("Veszprém");
            Varosok.Add("Pécs");
            Varosok.Add("Budapest");
            Varosok.Add("Győr");
            Varosok.Add("Eger");
            Varosok.Add("London");
            Varosok.Add("Párizs");
            Varosok.Add("Esztergom");
            Varosok.Add("Balatonfüred");
            Varosok.Add("Szeged");
            Varosok.Add("Amszterdam");
            Varosok.Add("Békéscsaba");
            Varosok.Add("Pápa");
        }

        private void btnLetrehozas_Click(object sender, EventArgs e)
        {
            JaratLetrehozas j = new JaratLetrehozas();
            j.Show();
        }

        private void btnImportalas_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (var stream = System.IO.File.OpenRead(openFileDialog1.FileName))
                {
                    var serializer = new XmlSerializer(typeof(List<Jarat>));
                    Form1.Jaratok = serializer.Deserialize(stream) as List<Jarat>;
                }
            }
        }

        private void btnExportalas_Click(object sender, EventArgs e)
        {
            AdatokExportalasa x = new AdatokExportalasa();
            x.Show();
        }

        private void btnUtvonal_Click(object sender, EventArgs e)
        {
            Utvonaltervezes u = new Utvonaltervezes();
            u.Show();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(new Pen(Color.Green, 2), 20, 280, 80, 80);
            e.Graphics.DrawLine(new Pen(Color.Red, 2), 40, 270, 40, 370);
            e.Graphics.DrawLine(new Pen(Color.Red, 2), 80, 270, 80, 370);
            e.Graphics.DrawLine(new Pen(Color.White, 2), 20, 320, 100, 320);
        }
    }
}
