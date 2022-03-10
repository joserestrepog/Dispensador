using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispensador
{
    class Dispensador
    {
        public int saldot;
        public Dispensador()
        {

        }
        public void recargar(int dinero)
        {
            this.saldot = this.saldot + dinero;
        }
    }
}
