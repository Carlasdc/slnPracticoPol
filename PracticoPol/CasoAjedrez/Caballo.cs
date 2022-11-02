using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PracticoPol.CasoAjedrez;

namespace PracticoPol.CasoAjedrez
{
    public class Caballo:PiezaAjedrez
    {
        public string MovimientoCaballo = "una casilla recta y otra en diagonal";

        public Caballo()
        {
            this.Nombre = "Caballo";
        }
        public override string Mover()
        {
            return base.Mover() + MovimientoCaballo;
        }
    }
}
