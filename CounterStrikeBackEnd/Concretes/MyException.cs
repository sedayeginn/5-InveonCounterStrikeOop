using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrikeBackEnd.Concretes
{
    class MermiYokHatasi :Exception
    {
        public MermiYokHatasi():base("Mermi Yok")
        {

        }
        
    }
    class SajorDoluHatasi:Exception
    {
        public SajorDoluHatasi():base("Şarjor Zaten Dolu")
        {

        }
    }
}
