using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PracticoPol.CasoAnimales;
namespace PracticoPol.CasoAnimales
{
    public class Loro:Animal
    {
        public string Plumas { get; set; }

        public Loro (string edad, string altura, string peso, string plumas):base(edad, altura, peso)
        {
            Plumas = plumas;
        }

        public override string Imprimir()
        {
            return base.Imprimir() + " y tiene " + Plumas + " plumas";
        }

        public override string ImprimirComida(string comida)
        {
            return "El loro come "+ comida ;
        }
    }
}
