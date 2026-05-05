Console.WriteLine("Indicar precio de lista");
double precio = Convert.ToDouble(Console.ReadLine());

static double descuento(double precio)
{
    double descuentoprecio = precio * 0.18;
    double preciofinal = precio - descuentoprecio;
    return preciofinal;
}

double preciofinal = descuento(precio);

Console.WriteLine($"Precio de lista: ${precio}");
Console.WriteLine("Descuento: 18% sobre el precio de lista");
Console.WriteLine($"Precio con descuento: ${preciofinal}");