using System;

namespace GUIA_3_EJERCICIO_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *PROGRAMACION ESTRUCTURADA G07L
             *REBECA SARAÍ ALVARENGA HERNÁNDEZ
             *
             *EJERCICIO #1 GUIA 3
             */

            double km, m, y, v;
            const double m_factor = 1000;
            const double y_factor = 1093.61;
            const double v_factor = 1196.3;
            Console.WriteLine("Hola y bienvenido :)");
            Console.WriteLine("Por favor ingrese el valor a convertir en kilometros...");
            km = Convert.ToDouble(Console.ReadLine());
            m = km * m_factor;
            y = km * y_factor;
            v = km * v_factor;
            Console.WriteLine("\nEn total, " + km + " km es igual a:");
            Console.WriteLine("\t " + m + " metros,");
            Console.WriteLine("\t " + y + " yardas,");
            Console.WriteLine("\t y " + v + " varas.");
            Console.WriteLine("Presione cualquier tecla para cerrar el programa");
            Console.ReadKey();
        }
    }
}
