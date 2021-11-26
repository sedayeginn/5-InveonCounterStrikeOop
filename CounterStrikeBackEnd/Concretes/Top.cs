using CounterStrikeBackEnd.Abstracts;
using CounterStrikeBackEnd.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrikeBackEnd.Concretes
{
    class Top : AtesliSilah
    {
        public Top(double kalibre, string marka, string model, MenzilTipi menzilTipi, double agirlik) : base(kalibre, marka, model, menzilTipi, agirlik)
        {
            this.MermiTipi = MermiTipi.Top;
            this.MermiKapasitesi = 1;
            this.AtesSesi = "Top Ateş Sesi";
            this.SarjorSesi = "Top Şarjör Sesi";
        }

    }
}
