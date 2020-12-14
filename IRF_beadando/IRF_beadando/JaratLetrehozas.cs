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
            try
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
                    bj.AutoPalyanMegyE = cbAutoPalyanMegyE.Checked;
                    Form1.Jaratok.Add(bj);
                    MessageBox.Show("Buszjárat hozzáadva. Új járat megadásához, kérem töltse ki újból a formot!");
                    Urites();
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
                    rj.KapunkEEbedet = cbKapunkEEbedet.Checked;
                    Form1.Jaratok.Add(rj);
                    MessageBox.Show("Repülőjárat hozzáadva. Új járat megadásához, kérem töltse ki újból a formot!");
                    Urites();
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
                    vj.Tipus = cbVonatTipusa.SelectedItem.ToString();
                    Form1.Jaratok.Add(vj);
                    MessageBox.Show("Vonatjárat hozzáadva. Új járat megadásához, kérem töltse ki újból a formot!");
                    Urites();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kérem töltsön ki minden mezőt!");
            }
            
        }

        private void cbJarmu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbJarmu.SelectedItem ==null)
            {
                lblVonatTipusa.Visible = false;
                cbVonatTipusa.Visible = false;
                cbKapunkEEbedet.Visible = false;
                cbAutoPalyanMegyE.Visible = false;
            }
            else if (cbJarmu.SelectedItem.ToString() == "Busz")
            {
                lblVonatTipusa.Visible = false;
                cbVonatTipusa.Visible = false;
                cbKapunkEEbedet.Visible = false;
                cbAutoPalyanMegyE.Visible = true;
            }
            else if (cbJarmu.SelectedItem.ToString() == "Repülő")
            {
                lblVonatTipusa.Visible = false;
                cbVonatTipusa.Visible = false;
                cbKapunkEEbedet.Visible = true;
                cbAutoPalyanMegyE.Visible = false;
            }
            else
            {
                lblVonatTipusa.Visible = true;
                cbVonatTipusa.Visible = true;
                cbKapunkEEbedet.Visible = false;
                cbAutoPalyanMegyE.Visible = false;
            }
        }

        private void Urites()
        {
            cbJarmu.SelectedItem = null;
            cbKiinduloVaros.SelectedItem = null;
            cbErkezoVaros.SelectedItem = null;
            cbVonatTipusa.SelectedItem=null ;
            cbKapunkEEbedet.Checked = false;
            cbAutoPalyanMegyE.Checked = false;
            tbUthossz.Clear();
            dtpInduasiIdo.Value = DateTime.Now.Date;
            dtpErkezesiIdo.Value = DateTime.Now.Date;

        }
    }
}
