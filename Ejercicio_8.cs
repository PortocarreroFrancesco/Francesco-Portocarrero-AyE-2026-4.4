Console.WriteLine("Ingrese total de la compra.");
double Compra = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Ingrese número sorteado.");
int Numero = int.Parse(Console.ReadLine() ?? "0");

double Descuento;

if (Numero < 74)
{
    Descuento = Compra * 15 / 100;
}
else
{
    Descuento = Compra * 20 / 100;
}

Console.WriteLine($"Descuento: ${Descuento}");
Console.WriteLine($"Total a pagar: ${Compra - Descuento}");