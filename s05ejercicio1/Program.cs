using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s05ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n , suma;
            Console.WriteLine("ingrese numero del elemanto: ");
            n = int.Parse(Console.ReadLine());
           suma = 0;
            for (int i = 1; i <= n; i++) 
                { Console.WriteLine("interaccion " + n );
                suma = suma + i;
                Console.WriteLine("en esta interaccion la suma es " + suma);
                Console.ReadKey(); }


        }
    }
}
