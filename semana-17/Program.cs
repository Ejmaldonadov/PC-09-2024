class Parcial_II
{
    static void Main(string[] args)
    {
        string[] personas = new string[10];
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Ingrese el nombre del alumno {i + 1}: ");
            personas[i] = Console.ReadLine();
        }

        int[] nota = new int[10];
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Ingrese la nota del alumno {i + 1}: ");
            nota[i] = Int32.Parse(Console.ReadLine());
        }

        int opcion;
        do
        {
            Console.WriteLine("Menú");
            Console.WriteLine("1. Alumnos Aprobados");
            Console.WriteLine("2. Alumnos Reprobados");
            Console.WriteLine("3. Promedio de clase");
            Console.WriteLine("4. Salir");
            opcion = Int32.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Aprobados();
                    break;

                case 2:
                    repro();
                    break;

                case 3:
                    promedio();
                    break;

                case 4:
                    Console.WriteLine("Programa Cerrado");
                    Console.ReadKey();
                    break;
            }
        } while (opcion != 4);

        void Aprobados()
        {
            Console.WriteLine("Nombre de los alumnos aprobados.");

            for (int i = 0; i < 10; i++)
            {
                if (i <= 65)
                {
                    Console.WriteLine($"El alumno" + personas[i]);
                }
                else
                {
                    Console.WriteLine("...");
                }
            }
        }
        void repro()
        {
            Console.WriteLine("Nombre de los alumnos desaprobados.");

            for (int i = 0; i < 10; i++)
            {
                if (i >= 65)
                {
                    Console.WriteLine($"El alumno" + personas[i]);
                }
                else
                {
                    Console.WriteLine("...");
                }
            }
        }
    }
    static void promedio()
    {

    }
}