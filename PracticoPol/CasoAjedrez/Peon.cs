using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PracticoPol.CasoAjedrez;
namespace PracticoPol.CasoAjedrez
{
    public class Peon:PiezaAjedrez
    {
        public string MovimientoPeon = " uno hacia adelante y come en diagonal";

        public Peon()
        {
            this.Nombre = "Peon";
        }
        public override string Mover()
        {
            return base.Mover() + MovimientoPeon;
        }
    }
}
