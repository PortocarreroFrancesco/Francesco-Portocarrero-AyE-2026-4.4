int intentos = 3;

static int factorial(int numero)
{
    int resultado = 1;
    for (int i = 1; i <= numero; i++)
    {
        resultado *= i;
    }
    return resultado;
}

while (intentos > 0)
{
    Console.WriteLine("Ingresá un número no negativo.");
    Console.WriteLine($"Intentos restantes: {intentos}");

    string texto = Console.ReadLine();

    if (int.TryParse(texto, out int numero))
    {
        if (numero >= 0)
        {
            int resultado = factorial(numero);
            Console.WriteLine($"El factorial de {numero} es {resultado}");

            intentos = 3;
        }
        else
        {
            intentos--;
            Console.WriteLine("Número inválido (negativo).");
        }
    }
    else
    {
        intentos--;
        Console.WriteLine("No es un número válido.");
    }
}

Console.WriteLine("Se te acabaron los intentos.");
