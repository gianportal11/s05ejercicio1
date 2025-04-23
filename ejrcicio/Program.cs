using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejrcicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sumaCubos = 0;
            Console.Write("Ingrese la cantidad de números: ");
               

                for (int i = 1; i <= n; i++)
                {
                    Console.Write("Ingrese el número i: ");
                    double numero = double.Parse(Console.ReadLine());
                    sumaCubos += Math.Pow(numero, 3);
                }

                Console.WriteLine("La suma de los cubos es" + sumaCubos);
            }
        }

    }

