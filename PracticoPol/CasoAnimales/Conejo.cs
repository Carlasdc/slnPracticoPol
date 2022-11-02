using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticoPol.CasoAnimales;

namespace PracticoPol.CasoAnimales
{
    public class Conejo:Animal
    {
        public string Color { get; }
        public Conejo(string edad, string altura, string peso, string color) : base(edad, altura, peso)
        {
            this.Color = color;
        }
        public override string Imprimir()
        {
            return base.Imprimir() + " y es de color " + Color;
        }

        public override string ImprimirComida(string comida)
        {
            return "El conejo come " + comida;
        }

    }
}
