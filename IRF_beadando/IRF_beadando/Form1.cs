using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            AdatokImportalasa i = new AdatokImportalasa();
            i.Show();
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
    }
}
