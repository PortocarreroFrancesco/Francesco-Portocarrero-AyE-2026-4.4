Console.WriteLine("Ingrese un número de 3 dígitos");
int numero = Convert.ToInt32(Console.ReadLine());

int unidad = numero / 100;
int decena = (numero / 10) % 10;
int centena = numero % 10;

Console.WriteLine($"Valor ingresado:{numero}");
Console.WriteLine($"Unidades:{unidad}");
Console.WriteLine($"Decenas:{decena}");
Console.WriteLine($"Centenas:{centena}");
