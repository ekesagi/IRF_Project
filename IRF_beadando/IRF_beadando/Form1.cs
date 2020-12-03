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
        public static List<Varos> Varosok = new List<Varos>();

        public Form1()
        {
            InitializeComponent();
            Varosok.Add(new Varos { Nev = "Veszprém" });
            Varosok.Add(new Varos { Nev = "Pécs" });
            Varosok.Add(new Varos { Nev = "Budapest" });
            Varosok.Add(new Varos { Nev = "Győr" });
            Varosok.Add(new Varos { Nev = "Eger" });
            Varosok.Add(new Varos { Nev = "London" });
            Varosok.Add(new Varos { Nev = "Párizs" });
            Varosok.Add(new Varos { Nev = "Bécs" });
            Varosok.Add(new Varos { Nev = "Esztergom" });
            Varosok.Add(new Varos { Nev = "Balatonfüred" });
            Varosok.Add(new Varos { Nev = "Szeged" });
            Varosok.Add(new Varos { Nev = "Amszterdam" });
            Varosok.Add(new Varos { Nev = "Békéscsaba" });
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
