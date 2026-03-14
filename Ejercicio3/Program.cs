using System.Data;
using System.Runtime.CompilerServices;

void Menu()
{
    Console.Write("Menú: \n1. Calcular el área de un círculo\n2. Calcular el área de un triángulo\n3. Calcular el factorial de un número\n" +
                  "4. Determinar si un número es par o impar\n5. Salir");
}

double AreaCirculo(double radio)
{
    double area = Math.PI * Math.Pow(radio, 2);
    return area;
}

double AreaTriangulo(int baseTriangulo, int alturaTrianulo)
{
    return (baseTriangulo * alturaTrianulo) / 2;
}

long Factorial(int numero)
{
    long fact = 1;

    for (int i = 1; i <= numero; i++)
    {
        fact *= i;
    }

    return fact;
}

void ImparPar(int numeroP)
{
    if (numeroP % 2 == 0)
    {
        Console.WriteLine("El numero es par");
    }
    else
    {
        Console.WriteLine("El número es impar");
    }
}

int opcion = 0;
do
{
    Menu();
    Console.WriteLine();
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Clear();
            Console.Write("Ingrese radio del círculo: ");
            Console.WriteLine("Área:"+AreaCirculo(double.Parse(Console.ReadLine())));
            break;
        case 2:
            Console.Clear();
            Console.Write("Ingrese la base del triángulo: ");
            int baseTria = int.Parse(Console.ReadLine());
            Console.Write("Ingres la altura del triángulo: ");
            int alturaTriangulo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Área: {AreaTriangulo(baseTria,alturaTriangulo )}");
            break;
        case 3:
            Console.Clear();
            Console.Write("Ingrese número: ");
            Console.WriteLine("Factorial:" + Factorial(int.Parse(Console.ReadLine())));
            break;
        case 4:
            Console.Clear();
            Console.WriteLine("Ingrese número: ");
            int numero = int.Parse(Console.ReadLine());
            ImparPar(numero);
            break;
        case 5:
            Console.Clear();
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opción no valida");
            break;
    }



}while( opcion != 5);
