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
            foreach (var varos in Form1.Varosok)
            {
                cbKiinduloVaros.Items.Add(varos.Nev);
                cbErkezoVaros.Items.Add(varos.Nev);
            }
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {

        }
    }
}
