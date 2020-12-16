using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_beadando
{
    public partial class Utvonaltervezes : Form
    {
        List<List<Jarat>> Utvonalak = new List<List<Jarat>>();

        public List<Jarat> JaratokAdottVarosbol(string varos, DateTime mikortol)
        {
            List<Jarat> Eredmenyek = new List<Jarat>();
            foreach (var jarat in Form1.Jaratok)
            {
                if (varos == jarat.IndulasiHely && mikortol<jarat.IndulasiIdo)
                {
                    Eredmenyek.Add(jarat);
                }
            }
            return Eredmenyek;
        }

        public Utvonaltervezes()
        {
            InitializeComponent();
            foreach (var varos in Form1.Varosok)
            {
                cbHonnan.Items.Add(varos);
                cbHova.Items.Add(varos);
            }
        }

        private void btnBetolt_Click(object sender, EventArgs e)
        {
            if (cbHonnan.SelectedItem==null||cbHova.SelectedItem==null)
            {
                MessageBox.Show("Kérem adjon meg kiindulási és érkezési várost!");
            }
            else
            {
                Utvonalak.Clear();
                tbUtvonalak.Clear();

                string indulovaros = cbHonnan.SelectedItem.ToString();
                string erkezovaros = cbHova.SelectedItem.ToString();

                List<Jarat> Indulojaratok = JaratokAdottVarosbol(indulovaros, dtpMikor.Value.Date);

                foreach (var jarat1 in Indulojaratok)
                {
                    if (jarat1.ErkezesiHely==erkezovaros)
                    {
                        List<Jarat> UjUtvonal = new List<Jarat>();
                        UjUtvonal.Add(jarat1);
                        Utvonalak.Add(UjUtvonal);
                    }
                    else
                    {
                        List<Jarat> MasodikJaratok = JaratokAdottVarosbol(jarat1.ErkezesiHely, jarat1.ErkezesiIdo);
                        foreach (var jarat2 in MasodikJaratok)
                        {
                            if (jarat2.ErkezesiHely == erkezovaros)
                            {
                                List<Jarat> UjUtvonal = new List<Jarat>();
                                UjUtvonal.Add(jarat1);
                                UjUtvonal.Add(jarat2);
                                Utvonalak.Add(UjUtvonal);
                            }
                            else
                            {
                                List<Jarat> HarmadikJaratok = JaratokAdottVarosbol(jarat2.ErkezesiHely, jarat2.ErkezesiIdo);
                                foreach (var jarat3 in HarmadikJaratok)
                                {
                                    if (jarat1.ErkezesiHely == erkezovaros)
                                    {
                                        List<Jarat> UjUtvonal = new List<Jarat>();
                                        UjUtvonal.Add(jarat1);
                                        UjUtvonal.Add(jarat2);
                                        UjUtvonal.Add(jarat3);
                                        Utvonalak.Add(UjUtvonal);
                                    }
                                    else
                                    {
                                        List<Jarat> NegyedikJaratok = JaratokAdottVarosbol(jarat3.ErkezesiHely, jarat3.ErkezesiIdo);
                                        foreach (var jarat4 in NegyedikJaratok)
                                        {
                                            if (jarat1.ErkezesiHely == erkezovaros)
                                            {
                                                List<Jarat> UjUtvonal = new List<Jarat>();
                                                UjUtvonal.Add(jarat1);
                                                UjUtvonal.Add(jarat2);
                                                UjUtvonal.Add(jarat3);
                                                UjUtvonal.Add(jarat4);
                                                Utvonalak.Add(UjUtvonal);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                /*Útvonalak kiírása*/
                
                foreach (var utvonal in Utvonalak)
                {
                    tbUtvonalak.Text += "OPCIÓ:";
                    tbUtvonalak.Text += Environment.NewLine;

                    foreach (var jarat in utvonal)
                    {
                        tbUtvonalak.Text += jarat.ToString();
                        tbUtvonalak.Text += Environment.NewLine;
                    }
                    tbUtvonalak.Text += Environment.NewLine;
                }
            }
        }

        private void btnKivalaszt_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(new FileStream(saveFileDialog1.FileName,FileMode.CreateNew) ,Encoding.UTF8) ;
                sw.WriteLine("Opció sorszáma; Közlekedési eszköz; Indulási hely; Indulási idő; Érkezési hely; Érkezési idő; Időtartam(perc);Úthossz(km);Vonat típus;Kapunk-e ebédet;Autópályán megy-e;");

                for (int i = 0; i < Utvonalak.Count; i++)
                {
                    foreach (var Jarat in Utvonalak[i])
                    {
                        if (Jarat is Buszjarat)
                        {
                            sw.WriteLine(i.ToString() + ";" + Jarat.MiVagyokEn + ";" + Jarat.IndulasiHely + ";"+Jarat.IndulasiIdo+";"+Jarat.ErkezesiHely + ";" +Jarat.ErkezesiIdo + ";" +Jarat.Idotartam + ";" +Jarat.UtHossz + ";;;" +((Buszjarat)Jarat).AutoPalyanMegyE+";");
                        }
                        else if (Jarat is Vonatjarat)
                        {
                            sw.WriteLine(i.ToString() + ";" + Jarat.MiVagyokEn + ";" + Jarat.IndulasiHely + ";" + Jarat.IndulasiIdo + ";" + Jarat.ErkezesiHely + ";" + Jarat.ErkezesiIdo + ";" + Jarat.Idotartam + ";" + Jarat.UtHossz + ";" + ((Vonatjarat)Jarat).Tipus+";;;");
                        }
                        else
                        {
                            sw.WriteLine(i.ToString() + ";" + Jarat.MiVagyokEn + ";" + Jarat.IndulasiHely + ";" + Jarat.IndulasiIdo + ";" + Jarat.ErkezesiHely + ";" + Jarat.ErkezesiIdo + ";" + Jarat.Idotartam + ";" + Jarat.UtHossz + ";;" + ((Repulojarat)Jarat).KapunkEEbedet+";;");
                        }
                    }
                }
                sw.Close();
                MessageBox.Show("Útvonalak sikeresen exportálva.");
            }

        }
    }
}
