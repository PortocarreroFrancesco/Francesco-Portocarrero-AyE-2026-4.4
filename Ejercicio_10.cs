Console.WriteLine("Alumno 1");
string Nombre1 = Console.ReadLine() ?? "";
double Prom1 = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Alumno 2");
string Nombre2 = Console.ReadLine() ?? "";
double Prom2 = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Alumno 3");
string Nombre3 = Console.ReadLine() ?? "";
double Prom3 = double.Parse(Console.ReadLine() ?? "0");

if (Prom1 >= Prom2 && Prom1 >= Prom3)
{
    Console.WriteLine($"Abanderado: {Nombre1}");

    if (Prom2 >= Prom3)
    {
        Console.WriteLine($"Primer escolta: {Nombre2}");
        Console.WriteLine($"Segundo escolta: {Nombre3}");
    }
    else
    {
        Console.WriteLine($"Primer escolta: {Nombre3}");
        Console.WriteLine($"Segundo escolta: {Nombre2}");
    }
}
else if (Prom2 >= Prom1 && Prom2 >= Prom3)
{
    Console.WriteLine($"Abanderado: {Nombre2}");

    if (Prom1 >= Prom3)
    {
        Console.WriteLine($"Primer escolta: {Nombre1}");
        Console.WriteLine($"Segundo escolta: {Nombre3}");
    }
    else
    {
        Console.WriteLine($"Primer escolta: {Nombre3}");
        Console.WriteLine($"Segundo escolta: {Nombre1}");
    }
}
else
{
    Console.WriteLine($"Abanderado: {Nombre3}");

    if (Prom1 >= Prom2)
    {
        Console.WriteLine($"Primer escolta: {Nombre1}");
        Console.WriteLine($"Segundo escolta: {Nombre2}");
    }
    else
    {
        Console.WriteLine($"Primer escolta: {Nombre2}");
        Console.WriteLine($"Segundo escolta: {Nombre1}");
    }
}