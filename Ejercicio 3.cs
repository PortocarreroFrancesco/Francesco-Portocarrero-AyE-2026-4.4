using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Ingresá un número y vamos a sumar cada uno de sus digitos");
string texto = Console.ReadLine()??"";

int AUX = 0;

foreach (char t in texto)
{
    AUX = AUX + (t - '0');
}

Console.WriteLine(AUX);

