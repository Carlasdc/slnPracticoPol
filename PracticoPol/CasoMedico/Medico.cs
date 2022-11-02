using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PracticoPol.CasoMedico;
namespace PracticoPol.CasoMedico
{
    public class Medico : Persona
    {
        public string Especialidad { get; set; }
        public Medico(string nombre, string apellido, string especialidad):base(nombre, apellido)
        {
            this.Especialidad = especialidad;
        }
        public override string ToString()
        {
            return base.ToString() + " especialidad " + Especialidad;
        }
    }
}
