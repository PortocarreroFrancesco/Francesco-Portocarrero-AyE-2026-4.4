Console.WriteLine("Ingrese la temperatura en grados Fahrenheit");
double tempFahr = Convert.ToDouble(Console.ReadLine()??"");

double tempCels = (tempFahr - 32) * 5 / 9;
Console.WriteLine($"La temperatura en Celsius es: {tempCels}°C");