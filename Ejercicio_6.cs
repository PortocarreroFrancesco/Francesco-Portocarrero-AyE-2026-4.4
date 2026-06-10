int[] Numeros = new int[15];

int Pares = 0;
int Impares = 0;

for (int i = 0; i < 15; i++)
{
    Console.WriteLine($"Ingrese el número {i + 1}:");
    Numeros[i] = int.Parse(Console.ReadLine() ?? "0");
}

for (int i = 0; i < 15; i++)
{
    if (Numeros[i] % 2 == 0)
    {
        Pares++;
    }
    else
    {
        Impares++;
    }
}

Console.WriteLine($"Cantidad de pares: {Pares}");
Console.WriteLine($"Cantidad de impares: {Impares}");