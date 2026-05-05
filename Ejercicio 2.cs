Console.WriteLine("Ingrese un número de 3 dígitos");
int numero = Convert.ToInt32(Console.ReadLine());

int digito = (numero / 10) % 10;

Console.WriteLine($"Valor:{numero}");
Console.WriteLine($"El número central es:{digito}");