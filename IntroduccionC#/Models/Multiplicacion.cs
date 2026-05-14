using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntroduccionC_.Models
{
    public class Multiplicacion
    {
        public int num1 {  get; set; }
        public int num2 { get; set; }
        public int res { get; set; }
        public string mulsum { get; set; }

        public void CalcularMultiplicacion()
        {
            int suma = 0;
            string cadena = "";

            for (int i = 0; i < this.num2; i++)
            {
                suma += this.num1;
                cadena += this.num1;

                if (i < this.num2 - 1)
                {
                    cadena += "+";
                }
            }

            this.res= suma;
            this.mulsum = cadena + "=" + suma;
        }
    }
}