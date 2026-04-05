Console.WriteLine("El sistema tiene un numero secreto, adivinalo");
int acceso = 0;
while (acceso == 0) 
{
    string numero = Console.ReadLine();
    if (numero == "7")
    {
        Console.WriteLine("Acceso concedido");
        acceso = 1;
    } 
    else 
    {
        Console.WriteLine("Acceso denegado, intentalo de nuevo");
    }
}
