Console.WriteLine("Hora:");
int Hora = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Minutos:");
int Minutos = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Segundos:");
int Segundos = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("am o pm:");
string Periodo = Console.ReadLine() ?? "";
Periodo = Periodo.ToLower();

Segundos += 10;

if (Segundos >= 60)
{
    Minutos += Segundos / 60;
    Segundos %= 60;
}

if (Minutos >= 60)
{
    Hora += Minutos / 60;
    Minutos %= 60;
}

if (Hora >= 12)
{
    Hora %= 12;

    if (Periodo == "am")
        Periodo = "pm";
    else
        Periodo = "am";
}

Console.WriteLine($"{Hora} {Periodo}: {Minutos} min: {Segundos} seg.");