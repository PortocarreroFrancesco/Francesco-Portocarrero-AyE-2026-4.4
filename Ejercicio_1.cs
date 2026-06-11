int[,] Mapa = new int[10, 10];

Random Aleatorio = new Random();

int TesorosColocados = 0;

while (TesorosColocados < 3)
{
    int Fila = Aleatorio.Next(0, 10);
    int Columna = Aleatorio.Next(0, 10);

    if (Mapa[Fila, Columna] == 0)
    {
        Mapa[Fila, Columna] = 1;
        TesorosColocados++;
    }
}

int Intentos = 5;
int TesorosEncontrados = 0;

while (Intentos > 0 && TesorosEncontrados < 3)
{
    Console.WriteLine();
    Console.WriteLine($"Intentos restantes: {Intentos}");
    Console.WriteLine($"Tesoros encontrados: {TesorosEncontrados}/3");

    Console.WriteLine("Ingrese fila (1-10):");
    int FilaUsuario = int.Parse(Console.ReadLine() ?? "0") - 1;

    Console.WriteLine("Ingrese columna (1-10):");
    int ColumnaUsuario = int.Parse(Console.ReadLine() ?? "0") - 1;

    if (FilaUsuario < 0 || FilaUsuario > 9 ||
        ColumnaUsuario < 0 || ColumnaUsuario > 9)
    {
        Console.WriteLine("Posición inválida.");
        continue;
    }

    if (Mapa[FilaUsuario, ColumnaUsuario] == 2)
    {
        Console.WriteLine("Ya revisaste esa casilla.");
        continue;
    }

    if (Mapa[FilaUsuario, ColumnaUsuario] == 1)
    {
        Console.WriteLine("¡TESORO ENCONTRADO!");

        TesorosEncontrados++;

        Intentos = 5;

        Mapa[FilaUsuario, ColumnaUsuario] = 2;
    }
    else
    {
        Console.WriteLine("No encontraste nada.");

        Intentos--;

        Mapa[FilaUsuario, ColumnaUsuario] = 2;
    }
}

if (TesorosEncontrados == 3)
{
    Console.WriteLine();
    Console.WriteLine("¡Ganaste! Encontraste todos los tesoros.");
}
else
{
    Console.WriteLine();
    Console.WriteLine("Perdiste. Te quedaste sin intentos.");
}