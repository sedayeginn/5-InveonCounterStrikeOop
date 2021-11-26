using CounterStrikeBackEnd.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrikeBackEnd.Abstracts
{
   abstract class Silah  //new'lenemesin
    {
        public Silah(string marka, string model, MenzilTipi menziTipi, double agirlik)
        {
            this.Marka = marka;
            this.Model = model;
            this.MenzilTipi = menziTipi;
            this.Agirlik = agirlik;
        }
        public string Marka { get; private set; }
        public string Model { get; private set; }
        public MenzilTipi MenzilTipi { get; private set; }
        public double Agirlik { get; private set; }

        protected string Oldur()
        {
            return "Öldürüldü";
        }
        protected string Yarala()
        {
            return "Yaralandı";
        }
    }
}
