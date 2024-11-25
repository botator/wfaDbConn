using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ca20241125
{
    internal class Auto
    {
        public string Modell { get; set; }
        public string Rendszem { get; set; }
        public int HengerSzam { get; set; }
        public int HengerTerfogat { get; set; }
        public int Teljesitmeny { get; set; }
        public int LegnagyobbSeb { get; set; }
        public (int Min,int Max) Fogyasztás { get; set; }

        public List<Ember> Tulajdonos { get; set; }
        public Auto(string modell, string rendszem, int hengerSzam, int hengerTerfogat, int teljesitmeny, int legnagyobbSeb, (int Min, int Max) fogyasztás,params string[] tulajdonos) : this(tulajdonos)
        {
            Modell = modell;
            Rendszem = rendszem;
            HengerSzam = hengerSzam;
            HengerTerfogat = hengerTerfogat;
            Teljesitmeny = teljesitmeny;
            LegnagyobbSeb = legnagyobbSeb;
            Fogyasztás = fogyasztás;
        }
        public Auto(string rendszem) : this("Ford T-model",rendszem,4,2878,20,68,(11,18))
        {
                  
        }
        private Auto(params string[] tulajdonos)
        {
            Tulajdonos = [];
            foreach (var tulcsi in tulajdonos)
            {
                Tulajdonos.Add(new Ember(tulcsi));
            }
        }
    }
}
