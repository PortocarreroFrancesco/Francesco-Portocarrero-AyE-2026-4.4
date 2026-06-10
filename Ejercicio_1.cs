int Continuar = 0;

string[] Cartas = new string[8];

static void MostrarCartas(string[] Cartas)
{
    Console.WriteLine("Tus cartas:");

    for (int i = 0; i < 8; i++)
    {
        Console.WriteLine($"{i + 1}) {Cartas[i]}");
    }
}

static void DarCartas(string[] Cartas)
{
    string[] Palos = { "Picas", "Corazón", "Trébol", "Diamante" };
    string[] Numeros = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

    Random Aleatorio = new Random();

    for (int i = 0; i < 8; i++)
    {
        int NumeroAleatorio = Aleatorio.Next(0, 13);
        int PaloAleatorio = Aleatorio.Next(0, 4);

        Cartas[i] = $"{Numeros[NumeroAleatorio]} de {Palos[PaloAleatorio]}";
    }

    MostrarCartas(Cartas);
}

static void DescartarCartas(string[] Cartas)
{
    string[] Palos = { "Picas", "Corazón", "Trébol", "Diamante" };
    string[] Numeros = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

    Random Aleatorio = new Random();

    Console.WriteLine("¿Cuántas cartas querés descartar?");
    int Cantidad = int.Parse(Console.ReadLine() ?? "0");

    if (Cantidad < 1 || Cantidad > 8)
    {
        Console.WriteLine("Cantidad inválida.");
        return;
    }

    for (int i = 0; i < Cantidad; i++)
    {
        Console.WriteLine($"Ingresá la posición de la carta a descartar ({i + 1}/{Cantidad})");
        int Posicion = int.Parse(Console.ReadLine() ?? "0");

        if (Posicion < 1 || Posicion > 8)
        {
            Console.WriteLine("Posición inválida.");
            i--;
        }
        else
        {
            int NumeroAleatorio = Aleatorio.Next(0, 13);
            int PaloAleatorio = Aleatorio.Next(0, 4);

            Cartas[Posicion - 1] = $"{Numeros[NumeroAleatorio]} de {Palos[PaloAleatorio]}";
        }
    }

    Console.WriteLine();
    Console.WriteLine("Cartas luego del descarte:");
    MostrarCartas(Cartas);
}

while (Continuar == 0)
{
    Console.WriteLine();
    Console.WriteLine("1) Pedir cartas");
    Console.WriteLine("2) Descartar cartas");
    Console.WriteLine("0) Dejar de jugar");

    string Respuesta = Console.ReadLine() ?? "";

    switch (Respuesta)
    {
        case "1":
            DarCartas(Cartas);
            break;

        case "2":

            bool HayCartas = true;

            for (int i = 0; i < 8; i++)
            {
                if (Cartas[i] == null)
                {
                    HayCartas = false;
                }
            }

            if (HayCartas)
            {
                DescartarCartas(Cartas);
            }
            else
            {
                Console.WriteLine("Primero tenés que pedir cartas.");
            }

            break;

        case "0":
            Continuar = 1;
            Console.WriteLine("Gracias por jugar.");
            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;
    }
}