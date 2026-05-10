Console.WriteLine("Ingresá un número entero:");

if (int.TryParse(Console.ReadLine(), out int numero))
{
    if (numero % 2 == 0)
    {
        Console.WriteLine("El número es par.");
    }
    else
    {
        Console.WriteLine("El número es impar.");
    }
}
else
{
    Console.WriteLine("Error: Debes ingresar un número entero.");
}
