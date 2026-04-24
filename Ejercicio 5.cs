Console.WriteLine("Ingresá tu edad:");
int edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("¿Compraste palomitas de maíz?");
Console.WriteLine("1) Si");
Console.WriteLine("2) No");

int palomitas = Convert.ToInt32(Console.ReadLine());

if (edad > 65 && palomitas == 1)
{
    Console.WriteLine("¡Felicidades! Tienes entrada gratuita al cine.");
}
else
{
    Console.WriteLine("Compra la entrada o raja de acá");
}
