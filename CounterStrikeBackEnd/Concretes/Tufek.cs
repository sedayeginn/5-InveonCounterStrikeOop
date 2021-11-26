using CounterStrikeBackEnd.Abstracts;
using CounterStrikeBackEnd.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrikeBackEnd.Concretes
{
    class Tufek : AtesliSilah, IYakinlastirUzaklastir
    {
        public Tufek(TufekTipi tufekTipi, double kalibre, string marka, string model, MenzilTipi menziTipi, double agirlik) : base(kalibre, marka, model, menziTipi, agirlik)
        {
            this.TufekTipi = tufekTipi;
            switch (this.TufekTipi)
            {
                case TufekTipi.Taramalı:
                    this.MermiTipi = MermiTipi.Cekirdekli;
                    this.MermiKapasitesi = 50;
                    this.AtesSesi = "Pompalı Tüfek Ateş Sesi";
                    this.SarjorSesi = "Pompalı Tüfek Şarjor Sesi";
                    break;
                case TufekTipi.Pompalı:
                    this.MermiTipi = MermiTipi.Sacma;
                    this.MermiKapasitesi = 1;
                    this.AtesSesi = "Pompalı Tüfek Ateş Sesi";
                    this.SarjorSesi = "Pompalı Tüfek Şarjor Sesi";
                    break;

            }
        }
        public TufekTipi TufekTipi { get; set; }
        public string Uzaklastir()
        {
            return "Tüfek Uzaklaştırıldı.";
        }

        public string Yakinlastir()
        {
            return "Tüfek Yakınlaştırıldı";
        }
        public override string SarjoruDoldur()
        {
            if(this.TufekTipi==TufekTipi.Pompalı && this.MermiSayisi<this.MermiKapasitesi)
            {
                this.MermiSayisi++;
                return this.SarjorSesi + "Şarjor Dolduruldu";
            }
            else if(this.TufekTipi==TufekTipi.Taramalı)
            {
                return base.SarjoruDoldur();
            }
            else
            {
                return "Şarjor Zaten Dolu";
            }
        }
    }
}
