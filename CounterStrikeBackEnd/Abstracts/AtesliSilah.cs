using CounterStrikeBackEnd.Concretes;
using CounterStrikeBackEnd.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrikeBackEnd.Abstracts
{
   abstract class AtesliSilah : Silah
    {
        public AtesliSilah(double kalibre, string marka, string model, MenzilTipi menziTipi, double agirlik) : base(marka, model, menziTipi, agirlik)
        {
            this.Kalibre = kalibre;
        }
        public MermiTipi MermiTipi { get; protected set; }
        public int MermiKapasitesi { get; protected set; }
        public double Kalibre { get; private set; }
        public int MermiSayisi { get; protected set; }
        public string SarjorSesi { get; protected set; }
        public string AtesSesi { get; protected set; }

        public string AtesEt()
        {
            Random rnd = new Random();
            if(this.MermiSayisi>0)
            {
                this.MermiSayisi--;
                int rastgeleSayi = rnd.Next(1, 7);
                if(rastgeleSayi==1)
                {
                    return this.AtesSesi + "Ateş Edildi" + Oldur();
                }
                else
                {
                    return this.AtesSesi + "Ateş Edildi" + Yarala();
                }
            }
            else
            {
                throw new MermiYokHatasi();
            }
        }
        public virtual string SarjoruDoldur()
        {
            if(this.MermiSayisi<this.MermiKapasitesi)
            {
                this.MermiSayisi = this.MermiKapasitesi;
                return this.SarjorSesi+ "Şarjor Dolduruldu";
            }
            else
            {
                throw new SajorDoluHatasi();
            }
        }
    }
}
