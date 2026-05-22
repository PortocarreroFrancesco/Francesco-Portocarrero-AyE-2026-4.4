double Envio = 300.00;
Console.WriteLine("Ingrese el tipo de envio.");
string Tipo = Console.ReadLine() ?? "";
Tipo = Tipo.ToLower();
Console.WriteLine("Ingrese el tipo de destino.");
string Destino = Console.ReadLine() ?? "";
Destino = Destino.ToLower();
static double tipo(string Tipo, double Envio)
{
    double RecargosTipo = 0;
    switch (Tipo)
    {
        case "s": return 0;
        case "x":
            RecargosTipo = Envio * (20.0/100.0);
            return RecargosTipo;
        case "e":
            RecargosTipo = Envio * (40.0/100.0);
            return RecargosTipo;
        default: return RecargosTipo;
    }
}
static double destino(string Destino, double Envio)
{
    double RecargosDestino = 0;
    switch (Destino)
    {
        case "l":
            RecargosDestino = Envio * (5.0/100.0);
            return RecargosDestino;
        case "n":
            RecargosDestino = Envio * (20.0/100.0);
            return RecargosDestino;
        default: return RecargosDestino;
    }
}
if ((Tipo == "s" || Tipo == "x" || Tipo == "e") &&
    (Destino == "l" || Destino == "n"))
{
    double EnvioFinal = Envio + tipo(Tipo, Envio) + destino(Destino, Envio);
    Console.WriteLine($"Costo final: ${EnvioFinal}");
} else Console.WriteLine("Caracteres no válidos");