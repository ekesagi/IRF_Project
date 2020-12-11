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
    public partial class JaratLetrehozas : Form
    {
        public JaratLetrehozas()
        {
            InitializeComponent();
            dtpInduasiIdo.Value = DateTime.Now.Date;
            dtpErkezesiIdo.Value = DateTime.Now.Date;
            foreach (var varos in Form1.Varosok)
            {
                cbKiinduloVaros.Items.Add(varos);
                cbErkezoVaros.Items.Add(varos);
            }
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            if (cbJarmu.SelectedItem.ToString() == "Busz")
            {
                Buszjarat bj = new Buszjarat();
                bj.ErkezesiIdo = dtpErkezesiIdo.Value;
                bj.IndulasiIdo = dtpInduasiIdo.Value;
                bj.ErkezesiHely = cbErkezoVaros.SelectedItem.ToString();
                bj.IndulasiHely = cbKiinduloVaros.SelectedItem.ToString();
                bj.UtHossz = Convert.ToInt32(tbUthossz.Text);
                bj.Idotartam = (int)Math.Floor((bj.ErkezesiIdo - bj.IndulasiIdo).TotalMinutes);
                Form1.Jaratok.Add(bj);
            }
            else if (cbJarmu.SelectedItem.ToString() == "Repülő")
            {
                Repulojarat rj = new Repulojarat();
                rj.ErkezesiIdo = dtpErkezesiIdo.Value;
                rj.IndulasiIdo = dtpInduasiIdo.Value;
                rj.ErkezesiHely = cbErkezoVaros.SelectedItem.ToString();
                rj.IndulasiHely = cbKiinduloVaros.SelectedItem.ToString();
                rj.UtHossz = Convert.ToInt32(tbUthossz.Text);
                rj.Idotartam = (int)Math.Floor((rj.ErkezesiIdo - rj.IndulasiIdo).TotalMinutes);
                Form1.Jaratok.Add(rj);
            }
            else
            {
                Vonatjarat vj = new Vonatjarat();
                vj.ErkezesiIdo = dtpErkezesiIdo.Value;
                vj.IndulasiIdo = dtpInduasiIdo.Value;
                vj.ErkezesiHely = cbErkezoVaros.SelectedItem.ToString();
                vj.IndulasiHely = cbKiinduloVaros.SelectedItem.ToString();
                vj.UtHossz = Convert.ToInt32(tbUthossz.Text);
                vj.Idotartam = (int)Math.Floor((vj.ErkezesiIdo - vj.IndulasiIdo).TotalMinutes);
                Form1.Jaratok.Add(vj);
            }


        }
    }
}
