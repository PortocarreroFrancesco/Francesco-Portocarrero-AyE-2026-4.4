Console.WriteLine("Interruptor 1 (0 o 1):");
int I1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Interruptor 2 (0 o 1):");
int I2 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Interruptor 3 (0 o 1):");
int I3 = int.Parse(Console.ReadLine() ?? "0");

int Cerrados = I1 + I2 + I3;

if (Cerrados >= 2)
{
    Console.WriteLine("El equipo funciona.");
}
else
{
    Console.WriteLine("El equipo NO funciona.");
}