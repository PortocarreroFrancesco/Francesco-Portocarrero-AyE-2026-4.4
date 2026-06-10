Console.WriteLine("Ingrese primer valor lógico (v/f).");
string A = Console.ReadLine() ?? "";
A = A.ToLower();

Console.WriteLine("Ingrese segundo valor lógico (v/f).");
string B = Console.ReadLine() ?? "";
B = B.ToLower();

if ((A != "v" && A != "f") ||
    (B != "v" && B != "f"))
{
    Console.WriteLine("Error en los datos.");
}
else
{
    bool ValorA = A == "v";
    bool ValorB = B == "v";

    bool AND = ValorA && ValorB;
    bool NOR = !(ValorA || ValorB);

    Console.WriteLine($"AND = {(AND ? "V" : "F")}");
    Console.WriteLine($"NOR = {(NOR ? "V" : "F")}");
}