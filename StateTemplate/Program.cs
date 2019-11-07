using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 0;
            string tipo = "";
            IPrimitiva calidad = null;
            double total = 0;

            Console.WriteLine("1-Barato, 2-Normal");
            tipo = Console.ReadLine();

            if (tipo == "1")
                calidad = new Barato();
            if (tipo == "2")
                calidad = new Normal();

            Console.WriteLine("Cuantos decia Producir: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            Algoritmo produccion = new Algoritmo();
            total = produccion.metodoTemplate(calidad, cantidad);

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("El total es {0}", total);

        }
    }
}
