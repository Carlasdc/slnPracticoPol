using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticoPol.CasoInstrumentos
{
    public abstract class InstrumentoMusical
    {
        public virtual string Afinar()
        {
            return "Afinando " + Nombre;
        }
        public string Nombre { get; set; }
    }
}
