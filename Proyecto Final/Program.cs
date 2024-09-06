using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenidos a Nuestra Licorera La Bendicion");
        Console.WriteLine("Favor Ingrese su nombre");
        string nombre = Console.ReadLine();
        Console.WriteLine($" {nombre}, por favor ingrese su edad");
        int edad = Convert.ToInt32(Console.ReadLine());

        if (edad < 18)
        {
            Console.WriteLine("Lo sentimos, debe ser mayor de edad para comprar.");
            return;
        }

        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("Elija una de nuestras categorías en Licores");
            Console.WriteLine("Menu Principal");
            Console.WriteLine("1. Vinos");
            Console.WriteLine("2. Tequilas");
            Console.WriteLine("3. Cervezas");
            Console.WriteLine("4. Salir");
            Console.WriteLine("=======================");
            Console.Write("Seleccione una opción: ");
            int categoria = Convert.ToInt32(Console.ReadLine());

            switch (categoria)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Vinos disponibles:");
                    Console.WriteLine("1. Don Melchor Cabernet Sauvignon – L 3,500");
                    Console.WriteLine("2. Concha y Toro Casillero del Diablo – L 750");
                    Console.WriteLine("3. Montes Alpha Cabernet Sauvignon – L 1,200");
                    Console.WriteLine("4. Santa Carolina Reserva de Familia – L 1,800");
                    Console.WriteLine("Seleccione el número de producto que desea comprar: ");
                    int vinoSeleccionado = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese la cantidad a comprar: ");
                    int cantidadVino = Convert.ToInt32(Console.ReadLine());
                    CalcularTotal(vinoSeleccionado, cantidadVino, "Vino");
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Tequilas disponibles:");
                    Console.WriteLine("1. Don Julio 70 – L 1,200");
                    Console.WriteLine("2. Patrón Silver – L 1,500");
                    Console.WriteLine("3. José Cuervo Tradicional – L 850");
                    Console.WriteLine("Seleccione el número de producto que desea comprar: ");
                    int tequilaSeleccionado = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese la cantidad a comprar: ");
                    int cantidadTequila = Convert.ToInt32(Console.ReadLine());
                    CalcularTotal(tequilaSeleccionado, cantidadTequila, "Tequila");
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Cervezas disponibles:");
                    Console.WriteLine("1. Corona – L 60");
                    Console.WriteLine("2. Heineken – L 65");
                    Console.WriteLine("3. Budweiser – L 55");
                    Console.WriteLine("Seleccione el número de producto que desea comprar: ");
                    int cervezaSeleccionada = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese la cantidad a comprar: ");
                    int cantidadCerveza = Convert.ToInt32(Console.ReadLine());
                    CalcularTotal(cervezaSeleccionada, cantidadCerveza, "Cerveza");
                    break;

                case 4:
                    continuar = false;
                    Console.WriteLine("Gracias por su compra. ¡Vuelva pronto!");
                    break;

                default:
                    Console.WriteLine("Opción no válida, intente de nuevo.");
                    break;
            }

            if (categoria != 4)
            {
                Console.WriteLine("¿Desea continuar comprando? (s/n): ");
                string respuesta = Console.ReadLine().ToLower();
                continuar = respuesta == "s";
            }
        }
    }

    static void CalcularTotal(int producto, int cantidad, string categoria)
    {
        double precio = 0;
        switch (categoria)
        {
            case "Vino":
                if (producto == 1) precio = 3500;
                else if (producto == 2) precio = 750;
                else if (producto == 3) precio = 1200;
                else if (producto == 4) precio = 1800;
                break;

            case "Tequila":
                if (producto == 1) precio = 1200;
                else if (producto == 2) precio = 1500;
                else if (producto == 3) precio = 850;
                break;

            case "Cerveza":
                if (producto == 1) precio = 60;
                else if (producto == 2) precio = 65;
                else if (producto == 3) precio = 55;
                break;
        }

        double subtotal = precio * cantidad;
        double impuesto = subtotal * 0.15;

        double descuento = cantidad > 10 ? subtotal * 0.05 : 0;
        double total = subtotal + impuesto - descuento;

        Console.WriteLine($"Subtotal: L {subtotal}");
        Console.WriteLine($"Impuesto (15%): L {impuesto}");
        Console.WriteLine($"Descuento: L {descuento}");
        Console.WriteLine($"Total a pagar: L {total}");
    }
}