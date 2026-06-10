Console.WriteLine("Ingrese edad.");
int Edad = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Ingrese sexo (f/m).");
string Sexo = Console.ReadLine() ?? "";
Sexo = Sexo.ToLower();

double Pulsaciones;

switch (Sexo)
{
    case "f":
        Pulsaciones = (220 - Edad) / 10.0;
        Console.WriteLine($"Pulsaciones: {Pulsaciones}");
        break;

    case "m":
        Pulsaciones = (210 - Edad) / 10.0;
        Console.WriteLine($"Pulsaciones: {Pulsaciones}");
        break;

    default:
        Console.WriteLine("Sexo inválido");
        break;
}