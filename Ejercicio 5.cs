Console.WriteLine("Ingresá tu edad:");

if (int.TryParse(Console.ReadLine(), out int edad))
{
    Console.WriteLine("¿Compraste palomitas de maíz?");
    Console.WriteLine("1) Sí");
    Console.WriteLine("2) No");

    if (int.TryParse(Console.ReadLine(), out int palomitas))
    {
        if (edad > 65 && palomitas == 1)
        {
            Console.WriteLine("¡Felicidades! Tienes entrada gratuita al cine.");
        }
        else
        {
            Console.WriteLine("Compra la entrada o raja de acá.");
        }
    }
    else
    {
        Console.WriteLine("Error: Debes ingresar 1 o 2.");
    }
}
else
{
    Console.WriteLine("Error: Debes ingresar una edad válida.");
}
