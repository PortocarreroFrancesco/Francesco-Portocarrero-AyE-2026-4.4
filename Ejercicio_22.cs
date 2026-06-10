Console.WriteLine("Ingrese lado 1.");
double L1 = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Ingrese lado 2.");
double L2 = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Ingrese lado 3.");
double L3 = double.Parse(Console.ReadLine() ?? "0");

if (L1 == L2 && L2 == L3)
{
    Console.WriteLine("EQUILATERO");
}
else if (L1 == L2 || L1 == L3 || L2 == L3)
{
    Console.WriteLine("ISOSCELES");
}
else
{
    Console.WriteLine("ESCALENO");
}