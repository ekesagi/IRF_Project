using System;
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
    public partial class AdatokImportalasa : Form
    {
        public AdatokImportalasa()
        {
            InitializeComponent();
        }

        private void btnImportalas_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                using (var stream = System.IO.File.OpenRead(openFileDialog1.FileName))
                {
                    var serializer = new XmlSerializer(typeof(List<Jarat>));
                    Form1.Jaratok = serializer.Deserialize(stream) as List<Jarat>;
                }
            }
        }
    }
}
