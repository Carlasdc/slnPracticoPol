using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticoPol.CasoMedico
{
    public class Persona
    {
        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public override string ToString()
        {
            return Nombre+ ", "+ Apellido;
        }
    }
}
