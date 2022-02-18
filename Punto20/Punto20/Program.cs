using System;
/// <summary>
/// Oscar David Ramos Calzada
///Miércoles 16 - febrero / 2022
/// Punto#20
/// </summary>

namespace punto20
{
    class Program
    {
        static void Main(string[] args)
        {
            Double sueldoTotal, sueldo, quincena, diaTrabajo, bonoProfesional, deducion, bonoTransporte=120000;
            

            int opcion = 0;
            do
            {
                Console.WriteLine("Bienvenido al calculador de sueldo");
                Console.WriteLine("");
                Console.WriteLine("Si tienes titulo universitario ingresa 1, de lo contrario ingresa 2");
                Console.WriteLine("");
                Console.WriteLine("Ingrese 0 para salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Por favor ingrese su sueldo quincenal");
                        quincena = double.Parse(Console.ReadLine());
                        bonoProfesional = (quincena * 10) / 100;
                        Console.WriteLine("");
                        Console.WriteLine("Por favor ingrese número de días trabajados");
                        diaTrabajo = double.Parse(Console.ReadLine());
                        //Procesos matemáticos 
                        diaTrabajo = diaTrabajo * 25000;
                        sueldo = quincena + bonoProfesional + diaTrabajo + bonoTransporte;
                        deducion = (sueldo * 7) / 100;
                        sueldoTotal = sueldo - deducion;

                        Console.WriteLine("");
                        Console.WriteLine("Su sueldo quincenal es: ${0}", sueldoTotal, Console.BackgroundColor = ConsoleColor.Green);
                        Console.WriteLine("");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine("Por favor ingrese su sueldo quincenal");
                        quincena = double.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Por favor ingrese número de días trabajados");
                        diaTrabajo = double.Parse(Console.ReadLine());
                        //Procesos matemáticos 
                        diaTrabajo = diaTrabajo * 25000;
                        sueldo = quincena + diaTrabajo + bonoTransporte;
                        deducion = (sueldo * 7) / 100;
                        sueldoTotal = sueldo - deducion;

                        Console.WriteLine("");
                        Console.WriteLine("Su sueldo quincenal es: ${0}", sueldoTotal, Console.ForegroundColor = ConsoleColor.Green);
                        Console.WriteLine("");
                        Console.ReadKey();
                        break;

                    case 0:
                        break;

                    default:
                        Console.WriteLine("Ingrese una opción validad", Console.ForegroundColor = ConsoleColor.Red);
                        Console.WriteLine("");
                        Console.ReadKey();
                        break;
                }

            } while (opcion != 0);
        }
    }
}
