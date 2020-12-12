using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_beadando
{
    [Serializable]
    public class Vonatjarat : Jarat
    {
        public string Tipus { get; set; }
        public Vonatjarat()
        {
            this.MiVagyokEn = "Vonat";
        }
        public override string ToString()
        {
            return "VONAT: " + IndulasiHely + " " + IndulasiIdo + " " + ErkezesiHely + " " + ErkezesiIdo + " " + Idotartam + " perc " + UtHossz + " km , Vonat típusa:" + Tipus;
        }
    }
}
