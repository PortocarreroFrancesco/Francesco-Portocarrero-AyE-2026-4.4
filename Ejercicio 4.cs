Console.WriteLine("Ingrese un número de dos cifras");
int numero = Convert.ToInt16(Console.ReadLine());

int digito1 = numero / 10;
int digito2 = numero % 10;

Console.WriteLine($"Valor:{numero}");
Console.WriteLine($"Valor permutado:{digito2}{digito1}");