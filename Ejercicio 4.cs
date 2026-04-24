int suma = 0;
int numero;

while (true)
{
    Console.WriteLine("Ingresá un número (0 para terminar):");
    numero = Convert.ToInt32(Console.ReadLine());

    if (numero == 0)
    {
        break;
    }

    suma = suma + numero;
}

Console.WriteLine("La suma total es: " + suma);
