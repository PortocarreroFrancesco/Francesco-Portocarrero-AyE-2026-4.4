Console.WriteLine("Ingrese el total de la compra.");
double Compra = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Ingrese color de bolita.");
string Color = Console.ReadLine() ?? "";
Color = Color.ToLower();

double Descuento = 0;

switch (Color)
{
    case "blanco":
        Descuento = 0;
        break;

    case "verde":
        Descuento = Compra * 10 / 100;
        break;

    case "amarillo":
        Descuento = Compra * 25 / 100;
        break;

    case "azul":
        Descuento = Compra * 50 / 100;
        break;

    case "rojo":
        Descuento = Compra;
        break;

    default:
        Console.WriteLine("Color inválido");
        return;
}

Console.WriteLine($"Debe pagar: ${Compra - Descuento}");