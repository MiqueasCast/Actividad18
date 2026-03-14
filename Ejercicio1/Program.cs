void Menu()
{
    Console.WriteLine("Menú: \n1. Registrar el estudiante \n2. Mostrar promedio general\n3. Mostrar cantidad aprobados y reprobados\n4. Salir");

}

double Promedio(int nota1, int nota2, int nota3)
{
    double calculo = (nota1 + nota2 + nota3) / 3;
    return calculo;
}


int estudiante = 0;
int opcion = 0;
string nombre = "";
double promedio = 0;
do
{
    Menu();
    Console.WriteLine("");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Write("Ingrese nombre del estudiante: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese primera nota: ");
            int nota1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese segunda nota: ");
            int nota2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese tercera nota: ");
            int nota3 = int.Parse(Console.ReadLine());

            double calculoPromedio = Promedio(nota1, nota2, nota3);

            promedio += calculoPromedio;

            estudiante++;
            break;
        case 2:
            if (promedio < 61)
            {
                Console.WriteLine($"Estudiante: {nombre} \nPromedio: {promedio} \nEstado: Reprobado");
            }
            else
            {
                Console.WriteLine($"Estudiante: {nombre} \nPromedio: {promedio} \nEstado: Aprobado");
            }

            break;
        case 3:
            Console.WriteLine("Aprobados: " + estudiante);
            break;
        case 4:
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opcion no valida");
            break;
    }
} while (opcion != 4);