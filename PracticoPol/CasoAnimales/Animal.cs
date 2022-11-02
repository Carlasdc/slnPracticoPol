using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticoPol.CasoAnimales
{
    public abstract class Animal
    {
        #region propiedades
        public string edad { get; }
        public string altura { get; }
        public string peso { get; }
        #endregion
        #region constructor
        public Animal(string edad, string altura, string peso)
        {
            this.edad = edad;
            this.altura = altura;
            this.peso = peso;
        }
        #endregion

        public virtual string Imprimir()
        {
            return "La edad es de : " + edad + " años, su altura de " + altura + ", y su peso de " + peso;
        }

        public abstract string ImprimirComida(string comida);
        
        
    }
}
