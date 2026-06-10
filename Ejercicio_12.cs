Console.WriteLine("1-Triángulo");
Console.WriteLine("2-Círculo");
Console.WriteLine("3-Rectángulo");
Console.WriteLine("4-Hexágono");

int Figura = int.Parse(Console.ReadLine() ?? "0");

switch (Figura)
{
    case 1:
        Console.WriteLine("Base:");
        double Base = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Altura:");
        double Altura = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine($"Área = {(Base * Altura) / 2}");
        break;

    case 2:
        Console.WriteLine("Radio:");
        double Radio = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine($"Área = {Math.PI * Radio * Radio}");
        break;

    case 3:
        Console.WriteLine("Base:");
        double BaseR = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Altura:");
        double AlturaR = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine($"Área = {BaseR * AlturaR}");
        break;

    case 4:
        Console.WriteLine("Lado:");
        double Lado = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine($"Área = {(3 * Math.Sqrt(3) * Lado * Lado) / 2}");
        break;

    default:
        Console.WriteLine("Opción inválida.");
        break;
}