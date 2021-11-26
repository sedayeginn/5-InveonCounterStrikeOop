using CounterStrikeBackEnd.Abstracts;
using CounterStrikeBackEnd.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrikeBackEnd.Concretes
{
    class Bicak : Silah
    {
        private int _kesmeSayisi;
        public Bicak(string marka, string model, MenzilTipi menziTipi, double agirlik) : base(marka, model, menziTipi, agirlik)
        {
            this._kesmeSayisi = 5;
        }
        public string Bileyle()
        {
            return "Bıçak bileylendi";
        }
        public string Kes()
        {
            if(this._kesmeSayisi>0)
            {
                this._kesmeSayisi--;
                return "Adam" + this.Yarala();
            }
            else
            {
                this._kesmeSayisi = 5;
                return "Adam" + this.Oldur();
            }
        }
    }
}
