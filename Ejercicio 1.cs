static string ejercicio1(int n)
{
    if (n > 0)
    {
        return "Es positivo";
    }
    else if (n < 0)
    {
        return "Es negativo";
    }
    else
    {
        return "Es 0";
    }
}

Console.WriteLine("Ingresá un número:");

if (int.TryParse(Console.ReadLine(), out int numero))
{
    Console.WriteLine(ejercicio1(numero));
}
else
{
    Console.WriteLine("Error: Debes ingresar un número válido.");
}
