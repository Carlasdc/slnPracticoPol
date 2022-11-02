using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PracticoPol.CasoAnimales;
namespace PracticoPol.CasoAnimales
{
    public class Leon:Animal
    {
        public string dientes { get; set; }

        public Leon(string edad, string altura, string peso, string dientes): base(edad, altura, peso)
        {
            this.dientes = dientes;
        }

        public override string Imprimir()
        {
            return base.Imprimir() + " y tiene " + dientes + " dientes";
        }

        public override string ImprimirComida(string comida)
        {
            return "El leon come " + comida ;
        }
    }
}
