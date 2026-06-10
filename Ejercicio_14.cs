Console.WriteLine("Cantidad de camisas:");
int Cantidad = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Precio de cada camisa:");
double Precio = double.Parse(Console.ReadLine() ?? "0");

double Total = Cantidad * Precio;

double Porcentaje;

if (Cantidad >= 1 && Cantidad <= 4)
{
    Porcentaje = 12.5;
}
else if (Cantidad >= 5 && Cantidad <= 8)
{
    Porcentaje = 20;
}
else
{
    Porcentaje = 31.5;
}

double Descuento = Total * Porcentaje / 100;

Console.WriteLine($"Compra sin descuento: ${Total}");
Console.WriteLine($"Descuento: ${Descuento}");
Console.WriteLine($"Total final: ${Total - Descuento}");