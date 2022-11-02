using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PracticoPol.CasoAjedrez;

namespace PracticoPol.CasoAjedrez
{
    public class Torre:PiezaAjedrez
    {
        public string MovimientoTorre = " horizontal o vertical";
       
        public Torre()
        {
            this.Nombre = "Torre";
        }

        public override string Mover()
        {
            return base.Mover() + MovimientoTorre;
        }
    }
}
