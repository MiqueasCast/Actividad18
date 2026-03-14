void Menu()
{
    Console.WriteLine("Menú: \n1. Registrar venta \n2. Mostrar total vendido \n3. Mostrar promedio de ventas\n4. Mostrar venta mayor registrada\n5. Salir");
}
double TotalVendido(int cantidad, double precio)
{
    double total = cantidad * precio;
    return total;
}

int cantidadVentas = 0;
double TotalVentas = 0;
double ventaMayor = 0;
int opcion = 0;
double resultado = 0;
string nombreVenta ="";
do
{
    Menu();
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Clear();

            int opcionMenu2 = 0;

            while (opcionMenu2 != 2)
            {

                Console.Write($"Ingrese nombre del producto {cantidadVentas + 1}: ");
                string nombreProducto = Console.ReadLine();
                nombreVenta = nombreProducto;

                Console.Write("Ingrese cantidad vendida: ");
                int cantidadVendida = int.Parse(Console.ReadLine());

                Console.Write("Ingrese precio por unidad: ");
                double precioUnidad = double.Parse(Console.ReadLine());

                Console.WriteLine("");

                resultado = TotalVendido(cantidadVendida, precioUnidad);

                TotalVentas += resultado;
                cantidadVentas++;

                if (resultado > ventaMayor)
                {
                    ventaMayor = resultado;
                    nombreVenta = nombreProducto;
                }

                Console.Write("¿Desea ingresar otra venta? \n1. Continuar\n2. Finalizar\nRespuesta: ");
                opcionMenu2 = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            break;
        case 2:
            Console.Clear();
            Console.WriteLine($"Total vendido: Q.{TotalVentas}");
            break;
        case 3:
            Console.Clear();
            Console.WriteLine($"Promedio de ventas: Q{TotalVentas/cantidadVentas}");
            break;
        case 4:
            Console.Clear();
            Console.WriteLine($"Venta mayor:\nNombre:{nombreVenta}\nMonto total:Q{ventaMayor} ");
            break;
        case 5:
            Console.Clear();
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.Clear();
            Console.WriteLine("Opción no válida. Por favor, ingrese una opción del menú.");
            break;
    }

}while (opcion != 5);