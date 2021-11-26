using CounterStrikeBackEnd.Abstracts;
using CounterStrikeBackEnd.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrikeBackEnd.Concretes
{
    class Tabanca : AtesliSilah
    {
        public Tabanca(double kalibre, string marka, string model, MenzilTipi menziTipi, double agirlik) : base(kalibre, marka, model, menziTipi, agirlik)
        {
            this.MermiTipi = MermiTipi.Cekirdekli;
            this.MermiKapasitesi = 15;
            this.AtesSesi = "Tabanca Ateş Sesi";
            this.SarjorSesi = "Tabanca Şarjor Sesi";
        }
    }
}
