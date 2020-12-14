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
        private DateTime _indulasiido;
        public DateTime IndulasiIdo 
        { 
            get 
            { 
                return _indulasiido;
            } 
            set 
            {
                _indulasiido = value;
                if (_erkezesiido!=null)
                {
                    Idotartam = (int)Math.Floor((_erkezesiido - _indulasiido).TotalMinutes);
                }
            } 
        }
        private DateTime _erkezesiido;
        public DateTime ErkezesiIdo 
        { 
            get 
            {
                return _erkezesiido;
            } 
            set 
            {
                _erkezesiido = value;
                if (_indulasiido!=null)
                {
                    Idotartam= (int)Math.Floor((_erkezesiido - _indulasiido).TotalMinutes);
                }
            } 
        }
        public int Idotartam { get; set; }
        public string IndulasiHely { get; set; }
        public string ErkezesiHely { get; set; }
        public int UtHossz { get; set; }
        public string MiVagyokEn { get; set; }
    }
}
