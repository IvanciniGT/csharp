using System;

namespace Lenguaje_C_Sharp
{
    class Program
    {
        private const string mensajeInicial = "Hola mundo!";

        public static string MensajeInicial
        {
            get
            {
                return mensajeInicial;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MensajeInicial);
        }
    }
}
