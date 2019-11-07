using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateTemplate
{
    class Algoritmo
    {
        public double metodoTemplate(IPrimitiva tipo, int cantidad)
        {
            double total = 0;
            //Crear Juguete
            total += crearJuguete(cantidad);

            //lo decoramos
            total += tipo.Decorar(cantidad);

            //Verificamos Calidad
            calidad();

            //Empacamos
            total += tipo.Empacar(cantidad);

            return total;
        }

        private double crearJuguete (int pCantidad)
        {
            Console.WriteLine("Estamos creando {0} juguetes", pCantidad);
            return 16.50 * pCantidad;
        }
        
        private void calidad()
        {
            Console.WriteLine("Pasa Control de Calidad");
        }
    }
}
