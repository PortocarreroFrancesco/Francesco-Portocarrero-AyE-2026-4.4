Console.WriteLine("¿Colón descubrió América?");
string R1 = Console.ReadLine() ?? "";
R1 = R1.ToLower();

if (R1 == "si")
{
    Console.WriteLine("¿La independencia de México fue en 1810?");
    string R2 = Console.ReadLine() ?? "";
    R2 = R2.ToLower();

    if (R2 == "si")
    {
        Console.WriteLine("¿The Doors fue un grupo de rock americano?");
        string R3 = Console.ReadLine() ?? "";
        R3 = R3.ToLower();

        if (R3 == "si")
        {
            Console.WriteLine("Ganaste.");
        }
        else
        {
            Console.WriteLine("Perdiste.");
        }
    }
    else
    {
        Console.WriteLine("Perdiste.");
    }
}
else Console.WriteLine("Perdiste.");