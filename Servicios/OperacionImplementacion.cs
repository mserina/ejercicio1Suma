using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1Suma.Servicios
{
    /// <summary>
    /// Clase que contiene toda la logica de los metodos
    /// 251023 - msm
    /// </summary>
    internal class OperacionImplementacion : OperacionInterfaz
    {

        public void suma(int numero)
        {
            int sumaAlmacenado;
            sumaAlmacenado = 0;

            //Se pone for para que a la variable i le meta tantos numeros en funcion del numero que le haya indicado, de esta forma por cada vuelta que de se iran asignando y sumando el valor de i a los valores de las i anteriores   
            for (int i = 1;  i <= numero; i++)
            {
                sumaAlmacenado += i;

            }
            Console.WriteLine("La suma de los numeros del 1 al  " + numero + " es " + sumaAlmacenado);
        }
    }
}
