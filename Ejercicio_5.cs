Console.WriteLine("1-Círculo");
Console.WriteLine("2-Cuadrado");
Console.WriteLine("3-Rectángulo");
Console.WriteLine("4-Triángulo");
Console.WriteLine("5-Pentágono");

int Opcion = int.Parse(Console.ReadLine() ?? "0");

switch (Opcion)
{
    case 1:
        Console.WriteLine("Radio:");
        double Radio = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine($"Perímetro: {2 * Math.PI * Radio}");
        Console.WriteLine($"Superficie: {Math.PI * Radio * Radio}");
        break;

    case 2:
        Console.WriteLine("Lado:");
        double Lado = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine($"Perímetro: {Lado * 4}");
        Console.WriteLine($"Superficie: {Lado * Lado}");
        break;

    case 3:
        Console.WriteLine("Base:");
        double Base = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Altura:");
        double Altura = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine($"Perímetro: {(Base * 2) + (Altura * 2)}");
        Console.WriteLine($"Superficie: {Base * Altura}");
        break;

    case 4:
        Console.WriteLine("Base:");
        double BaseT = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Altura:");
        double AlturaT = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine($"Superficie: {(BaseT * AlturaT) / 2}");
        break;

    case 5:
        Console.WriteLine("Lado:");
        double LadoP = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine($"Perímetro: {LadoP * 5}");
        break;

    default:
        Console.WriteLine("Opción inválida");
        break;
}