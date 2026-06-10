Console.WriteLine("Ingrese un número entre 1 y 10.");
int Numero = int.Parse(Console.ReadLine() ?? "0");

switch (Numero)
{
    case 2:
    case 3:
    case 5:
    case 7:
        Console.WriteLine("Es primo.");
        break;

    case 1:
        Console.WriteLine("No es primo porque solamente tiene un divisor.");
        break;

    case 4:
    case 6:
    case 8:
    case 9:
    case 10:
        Console.WriteLine("No es primo porque tiene más de dos divisores.");
        break;

    default:
        Console.WriteLine("Número fuera de rango.");
        break;
}