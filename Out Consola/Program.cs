using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalcents, pesos, centavos;
            Console.WriteLine("Ingrese la cantidad de Centavos que quiere convertir a pesos: ");
            totalcents = int.Parse(Console.ReadLine());
            Convert(totalcents, out pesos, out centavos);
            Console.WriteLine("La conversión resulta en {0} pesos con {1} centavos, presione cualquier tecla para salir",pesos,centavos);
            Console.ReadKey();
        }
        static void Convert (int totalcents, out int pesos, out int centavos)
        {
            pesos = totalcents / 100;
            centavos = totalcents % 100;
        }
    }
}
