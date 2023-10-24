using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1Suma.Servicios
{
    internal class OperacionImplementacion : OperacionInterfaz
    {
        public int suma(int numero)
        {
            int sumaAlmacenado;
            sumaAlmacenado = 0;

            for (int i = 1;  i <= numero; i++)
            {
                sumaAlmacenado += i;

            }
            return sumaAlmacenado;
        }
    }
}
