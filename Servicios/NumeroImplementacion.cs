using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1Suma.Servicios
{
    
    internal class NumeroImplementacion : NumeroInterfaz
    {
        public int numero()
        {
            int numero;
            Console.WriteLine("Di numero");
            numero = int.Parse(Console.ReadLine());
            return numero;
        }
    }
}
