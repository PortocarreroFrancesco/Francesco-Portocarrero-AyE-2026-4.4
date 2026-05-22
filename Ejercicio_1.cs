Console.WriteLine("Ingresá el código de tu categoría");
string Codigo = Console.ReadLine() ?? "";
Codigo = Codigo.ToLower();
if (Codigo == "i") Console.WriteLine("Categoría: Infantiles.  Cuota: $800,00.");
else if (Codigo == "c") Console.WriteLine("Categoría: Cadete.  Cuota: $1.000,00.");
else if (Codigo == "j") Console.WriteLine("Categoría: Juvenil.  Cuota: $1.200,00.");
else if (Codigo == "a") Console.WriteLine("Categoría: Adulto.  Cuota: $900,00.");
else Console.WriteLine("Caracter no válido.");