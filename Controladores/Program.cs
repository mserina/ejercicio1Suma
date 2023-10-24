using ejercicio1Suma.Servicios;

namespace ejercicio1Suma{
    class program
    {
        static void Main(string[] args)
        {
            //Para pedir numero
            NumeroInterfaz num = new NumeroImplementacion();
            int numero;
            numero = num.numero();

            //Para la suma
            OperacionInterfaz op = new OperacionImplementacion();
            int resultado = op.suma(numero);
            Console.WriteLine("La suma de los numeros del 1 al  " + numero + " es " + resultado);
        }
    }
}