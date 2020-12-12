using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_beadando
{
    [Serializable]
    public class Repulojarat : Jarat
    {
        public bool KapunkEEbedet { get; set; }
        public Repulojarat()
        {
            this.MiVagyokEn = "Repülő";
        }
        public override string ToString()
        {
            return "REPÜLŐ: " + IndulasiHely + " " + IndulasiIdo + " " + ErkezesiHely + " " + ErkezesiIdo + " " + Idotartam + " perc " + UtHossz + " km , Kapunk-e ebédet a repülőjáraton?:" + KapunkEEbedet ;
        }
    }
}
