Console.WriteLine("Ingresá un número NO negativo para calcular su factorial");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 0)
{
    Console.WriteLine("Tenes que ingresar un número NO negativo");
    return;
}

static int factorial(int n)
{
    int resultado = 1;
    for (int i = 1; i <= n; i++)
    {
        resultado *= i;
    }
    return resultado;
}

int resultado = factorial(n);

Console.WriteLine($"El factorial de {n} es {resultado}");