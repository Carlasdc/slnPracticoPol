using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticoPol.CasoAjedrez
{
    public abstract class PiezaAjedrez
    {
        public string Nombre = "";
        public virtual string Mover()
        {
            return "La pieza " + Nombre+ " se mueve: ";
        }
    }
}
