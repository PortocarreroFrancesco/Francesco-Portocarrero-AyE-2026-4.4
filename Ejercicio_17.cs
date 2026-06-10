Console.WriteLine("Ingrese A:");
double A = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Ingrese B:");
double B = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Ingrese C:");
double C = double.Parse(Console.ReadLine() ?? "0");

if (A == 0)
{
    Console.WriteLine("No es una ecuación de segundo grado.");
}
else
{
    double Delta = (B * B) - (4 * A * C);

    if (Delta < 0)
    {
        Console.WriteLine("No tiene soluciones reales.");
    }
    else
    {
        double X1 = (-B + Math.Sqrt(Delta)) / (2 * A);
        double X2 = (-B - Math.Sqrt(Delta)) / (2 * A);

        Console.WriteLine($"X1 = {X1}");
        Console.WriteLine($"X2 = {X2}");
    }
}