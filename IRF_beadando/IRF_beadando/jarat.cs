using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IRF_beadando
{
    [Serializable]
    [XmlInclude(typeof(Repulojarat))]
    [XmlInclude(typeof(Vonatjarat))]
    [XmlInclude(typeof(Buszjarat))]
    public abstract class Jarat
    {
        public DateTime IndulasiIdo { get; set; }
        public DateTime ErkezesiIdo { get; set; }
        public int Idotartam { get; set; }
        public string IndulasiHely { get; set; }
        public string ErkezesiHely { get; set; }
        public int UtHossz { get; set; }
    }
}
