using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica23
{
    class Determinar
    {
        public string numayor (int a, int b, int c, int d, int e)
        {
            string resultado = "";
            if ((a > b ) && (a > c) && (a > d) && (a > e))
            {
                resultado = "El" + a + "es el mayor";
            }
            if ((b > a) && (b > c) && (b> d) && (b > e))
            {
                resultado = "El" + b + "es el mayor";
            }
            if ((c > a) && (c > b) && (c > d) && (c > e))
            {
                resultado = "El" + c + "es el mayor";
            }
            if ((d > a) && (d > b) && (d > c) && (a > e))
            {
                resultado = "El" + d + "es el mayor";
            }
            if ((e > a) && (e > b) && (e > c) && (e > d))
            {
                resultado = "El" + e + "es el mayor";
            }
            return resultado;
        }
    }
}
