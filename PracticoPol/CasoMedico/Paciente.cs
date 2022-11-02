using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PracticoPol.CasoMedico;
namespace PracticoPol.CasoMedico
{
    public class Paciente :Persona
    {
        public string NroObraSocial { get; set; }

        public Paciente(string nombre, string apellido, string nroObraSocial):base(nombre, apellido)
        {
            this.NroObraSocial = nroObraSocial;
        }

        public override string ToString()
        {
            return base.ToString() + " con numero de socio de Obra Social: " + NroObraSocial;
        }
    }
}
