static string comprov(string inten)
{
    if (inten == "python123")
    {
        return "¡Contraseña correcta! Acceso concedido.";
    }
    else
    {
        return "¡Contraseña incorrecta! Autodestrucción en 5 minutos.";
    }
}

Console.WriteLine("Ingrese la contraseña:");

string password = Console.ReadLine() ?? "";

Console.WriteLine(comprov(password));
