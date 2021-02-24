using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            int n;
            char continuar;
            do
            {
                Console.Write("Unidad a introducir? (h/m/s): ");
                c = Console.ReadLine()[0];
                if (c == 'm')
                {
                    Console.Write("Cantidad(m): ");
                    n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("En segundos: {0}", HadaP1.Minutes2Seconds(n));

                }
                else if (c == 's')
                {
                    Console.Write("Cantidad(s): ");
                    n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("En minutos: {0}", HadaP1.Seconds2Minutes(n));

                }
                else if (c== 'h')
                {
                    Console.Write("Cantidad(h): ");
                    n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("En minutos: {0}", HadaP1.Hours2Minutes(n));
                }
                else
                {
                    Console.WriteLine("ERROR: Unidad incorrecta.");

                }
                Console.Write("Quieres continuar?(s/n): ");
                continuar = Console.ReadLine()[0];
            } while (continuar == 's');
        }
    }
}