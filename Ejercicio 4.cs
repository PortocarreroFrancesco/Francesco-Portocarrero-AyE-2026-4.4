Console.WriteLine("Lee el texto:");
Console.WriteLine();
string texto = "El hotel del centro es el más antiguo del pueblo y también es aquel que tiene más comodidades. Este hotel fue construido en 1911, pero primero se utilizó como casa de familia. En 1975 un inversionista compró esta propiedad y la reformó para transformarla en el hotel que hoy conocemos. Es un hotel pequeño, pero cuenta con servicio a la habitación, con pileta climatizada, con un restaurante de categoría, entre otras cosas.";
Console.WriteLine(texto);
Console.WriteLine();
Console.WriteLine("Ahora ingresá una palabra del texto que quieras cambiar");
string borrar_palabra = Console.ReadLine() ?? "";
Console.WriteLine("Ahora ingresá la palabra por la que queres cambiarla");
string nueva_palabra = Console.ReadLine() ?? "";

texto = texto.Replace(borrar_palabra, nueva_palabra);

Console.WriteLine(texto);