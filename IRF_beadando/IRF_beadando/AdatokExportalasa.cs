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
using System.Xml;
using System.Xml.Serialization;

namespace IRF_beadando
{
    public partial class AdatokExportalasa : Form
    {
        public AdatokExportalasa()
        {
            InitializeComponent();
            dtgAdatokkiirasa.DataSource = Form1.Jaratok;
            dtgAdatokkiirasa.Refresh();
        }

        private void AdatokExportalasa_Load(object sender, EventArgs e)
        {


        }

        private void btnExportalas_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                using (var writer = new System.IO.StreamWriter(saveFileDialog1.FileName))
                {
                    var serializer = new XmlSerializer(typeof(List<Jarat>));
                    serializer.Serialize(writer, Form1.Jaratok);
                    writer.Flush();
                }
            }
        }
    }
}
