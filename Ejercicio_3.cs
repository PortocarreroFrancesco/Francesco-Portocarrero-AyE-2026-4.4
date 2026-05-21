int[] Numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int Factor = 67;
int[] Tabla;
Tabla = new int[Numeros.Length];
for (int i = 0; i<Numeros.Length; i++)
{
    int Numero = Numeros[i] * Factor;
    Tabla[i] = Numero;
}
Console.WriteLine("Nueva lista:");
for (int i = 0; i < Tabla.Length; i++) Console.WriteLine(Tabla[i]);