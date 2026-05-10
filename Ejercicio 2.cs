static string calc_edad(int edad)
{
    if (edad < 18)
    {
        return "Lo siento, eres muy joven.";
    }
    else
    {
        return "¡Bienvenido a la fiesta!";
    }
}

Console.WriteLine("Por favor, ingrese su edad:");

if (int.TryParse(Console.ReadLine(), out int edad))
{
    Console.WriteLine(calc_edad(edad));
}
else
{
    Console.WriteLine("Error: Debes ingresar una edad válida.");
}
