Console.WriteLine("Ingrese un número de dos cifras");
int numero = Convert.ToInt32(Console.ReadLine());

int digito1 = numero / 10;
int digito2 = numero % 10;

Console.WriteLine($"El primer dígito es:{digito1}");
Console.WriteLine($"El segundo dígito es:{digito2}");