using System.Data;
using System.Runtime.CompilerServices;

void Menu()
{
    Console.Write("Menú: \n1. Calcular el área de un círuclo\n2. Calcular el área de un triángulo\n3. Calcular el factorial de un número\n" +
                  "4. Determinar si un número es par o impar\n5. Salir");
}

double AreaCirculo(double radio)
{
    double area = Math.PI * Math.Pow(radio, 2);
    return area;
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
            Console.Write("Ingrese radio del circulo: ");
            Console.WriteLine("Área:"+AreaCirculo(double.Parse(Console.ReadLine())));
            break;
        case 2:

            break;
        case 3:
            break;
        case 4:
            break;
        case 5:
            break;
        default:
            break;
    }



}while( opcion != 5);
