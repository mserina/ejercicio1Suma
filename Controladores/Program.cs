using ejercicio1Suma.Servicios;

namespace ejercicio1Suma{

    /// <summary>
    /// Clase principal,que contiene el metodo principal
    /// 251023 - msm
    /// </summary>
    class program
    {
        /// <summary>
        /// Metodo donde empieza el programa, el cual contiene el procedimiento en el que debe ir los metodos
        /// 251023 - msm
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Para pedir numero
            NumeroInterfaz num = new NumeroImplementacion();
            int numero;
            numero = num.numero();

            //Para la suma
            OperacionInterfaz op = new OperacionImplementacion();
            op.suma(numero);
        }
    }
}