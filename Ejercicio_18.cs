Console.WriteLine("Ingrese el valor.");
double Valor = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Unidad de origen:");
Console.WriteLine("1-Metros");
Console.WriteLine("2-Pies");
Console.WriteLine("3-Centímetros");
Console.WriteLine("4-Pulgadas");

int Origen = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Unidad de destino:");
Console.WriteLine("1-Metros");
Console.WriteLine("2-Pies");
Console.WriteLine("3-Centímetros");
Console.WriteLine("4-Pulgadas");

int Destino = int.Parse(Console.ReadLine() ?? "0");

double Metros = 0;

switch (Origen)
{
    case 1: Metros = Valor; break;
    case 2: Metros = Valor * 0.3048; break;
    case 3: Metros = Valor / 100; break;
    case 4: Metros = Valor * 0.0254; break;
}

double Resultado = 0;

switch (Destino)
{
    case 1: Resultado = Metros; break;
    case 2: Resultado = Metros / 0.3048; break;
    case 3: Resultado = Metros * 100; break;
    case 4: Resultado = Metros / 0.0254; break;
}

Console.WriteLine($"Resultado: {Resultado}");