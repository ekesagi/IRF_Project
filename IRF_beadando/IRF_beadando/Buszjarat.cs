using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_beadando
{
    [Serializable]
    public class Buszjarat : Jarat
    {
        public bool AutoPalyanMegyE { get; set; }
        public Buszjarat()
        {
            this.MiVagyokEn = "Busz";
        }
        public override string ToString()
        {
            return "BUSZ: " + IndulasiHely + " " + IndulasiIdo + " " + ErkezesiHely + " " + ErkezesiIdo + " " + Idotartam + " perc " + UtHossz + " km , Autópályán megy:" + AutoPalyanMegyE;
        }
    }
}
