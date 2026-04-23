Console.WriteLine("Ingresá tu nombre");
string nombre = Console.ReadLine()??"";
Console.WriteLine("Ingresá tu apellido");
string apellido = Console.ReadLine() ?? "";

char caracter1 = nombre[0];
char caracter2 = apellido[0];

Console.WriteLine($"{caracter1}.{caracter2}");
Console.WriteLine(nombre);
Console.WriteLine(apellido);


