using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiclosFor_While
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            //for
            //parte 1 valor de la iteracion
            //parte 2 condicion
            //parte 3 aumento o decremento

            int tabla;
           // int i = 1; // parte 1

            Console.WriteLine("Ingrese el numero de la tabla que quiere calcular");
            tabla = int.Parse(Console.ReadLine());

            //parte 2
            // while(i <= 10)
            // {
            // Console.WriteLine("" + tabla * i);
            // i++; //parte 3

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("" + tabla * i);
            }



            Console.ReadKey();
        }

        
        
    }
}
