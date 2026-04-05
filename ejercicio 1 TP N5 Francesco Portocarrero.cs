int acceso = 0;

while (acceso == 0)
{
    Console.WriteLine("Ingrese su contraseña:");
    string password = Console.ReadLine();

    if (password == "12345")
    {
        Console.WriteLine("¡Acceso concedido!");
        acceso = 1;
    }
    else
    {
        Console.WriteLine("¡Acceso denegado! Inténtalo de nuevo.");
    }
}