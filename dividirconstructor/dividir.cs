using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dividirconstructor
{
    class dividir
    {
        public double V1;
        public double V2;

        public dividir()
        {
        }

        public dividir(double v1, double v2)
        {
            V1 = v1;
            V2 = v2;
        }
        public double divide()
        {
            return V1 / V2;
        }
    }
}
