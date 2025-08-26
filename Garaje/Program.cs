using System;
using Garaje.Clases;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaje
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Garaje g1 = new Garaje(1, "Garaje Central", 50, 10);
            Garaje g1;

            Console.WriteLine("Espacios disponibles: " + g1.getEspaciosDisponibles());

            g1.actualizarEspaciosOcupados(5);

            Console.WriteLine("Espacios ocupados: " + g1.getespaciosOcupados());
            Console.WriteLine("Espacios disponibles: " + g1.getEspaciosDisponibles());
        }
    }
}
