Console.WriteLine("Ingrese una frase");
string texto = Console.ReadLine()??"";

int contador = 0;
string vocales = "aeiouAEIOU";

foreach(char t in texto)
{
    foreach (char v in vocales)
    {
        if (t == v)
        {
            contador++;
            break;
        }
    }
}

Console.WriteLine($"La frase tiene {contador} vocales");