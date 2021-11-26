using CounterStrikeBackEnd.Abstracts;
using CounterStrikeBackEnd.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrikeBackEnd.Concretes
{
    class RoketAtar : AtesliSilah, IYakinlastirUzaklastir
    {
        public RoketAtar(double kalibre, string marka, string model, MenzilTipi menziTipi, double agirlik) : base(kalibre, marka, model, menziTipi, agirlik)
        {
            this.MermiTipi = MermiTipi.Roket;
            this.MermiKapasitesi = 1;
            this.AtesSesi = "Roket Atar Ateş Sesi";
            this.SarjorSesi = "Roket Atar Sarjor Sesi";

        }

        public string Uzaklastir()
        {
            return "Uzaklaştırıldı";
        }

        public string Yakinlastir()
        {
            return "Yakinlaştirildi";
        }
    }
}
