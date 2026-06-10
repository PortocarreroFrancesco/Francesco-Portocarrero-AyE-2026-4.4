char[,] Tablero =
{
    { '-', '-', '-' },
    { '-', '-', '-' },
    { '-', '-', '-' }
};

char Jugador = 'X';
bool Ganador = false;
int Jugadas = 0;

static void MostrarTablero(char[,] Tablero)
{
    Console.WriteLine();

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(Tablero[i, j] + " ");
        }

        Console.WriteLine();
    }

    Console.WriteLine();
}

static bool VerificarGanador(char[,] T, char J)
{
    for (int i = 0; i < 3; i++)
    {
        if (T[i, 0] == J &&
            T[i, 1] == J &&
            T[i, 2] == J)
        {
            return true;
        }

        if (T[0, i] == J &&
            T[1, i] == J &&
            T[2, i] == J)
        {
            return true;
        }
    }

    if (T[0, 0] == J &&
        T[1, 1] == J &&
        T[2, 2] == J)
    {
        return true;
    }

    if (T[0, 2] == J &&
        T[1, 1] == J &&
        T[2, 0] == J)
    {
        return true;
    }

    return false;
}

while (!Ganador && Jugadas < 9)
{
    MostrarTablero(Tablero);

    Console.WriteLine($"Turno del jugador {Jugador}");

    Console.WriteLine("Fila (1-3):");
    int Fila = int.Parse(Console.ReadLine() ?? "0") - 1;

    Console.WriteLine("Columna (1-3):");
    int Columna = int.Parse(Console.ReadLine() ?? "0") - 1;

    if (Fila < 0 || Fila > 2 ||
        Columna < 0 || Columna > 2)
    {
        Console.WriteLine("Posición inválida.");
        continue;
    }

    if (Tablero[Fila, Columna] != '-')
    {
        Console.WriteLine("Casillero ocupado.");
        continue;
    }

    Tablero[Fila, Columna] = Jugador;

    Jugadas++;

    if (VerificarGanador(Tablero, Jugador))
    {
        Ganador = true;
        MostrarTablero(Tablero);
        Console.WriteLine($"Ganó el jugador {Jugador}");
    }
    else
    {
        if (Jugador == 'X')
        {
            Jugador = 'O';
        }
        else
        {
            Jugador = 'X';
        }
    }
}

if (!Ganador)
{
    MostrarTablero(Tablero);
    Console.WriteLine("Empate.");
}