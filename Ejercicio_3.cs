float SueldoNeto;
float Remuneraciones;
float SueldoBasico;
float Antiguedad;
float Presentismo;

float Descuentos;
float Jubilacion;
float ObraSocial;

Console.WriteLine("Ingrese su sueldo básico.");
SueldoBasico = float.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Ingrese el código de antigüedad (1 a 4).");
int CodigoAntiguedad = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("¿Tiene presentismo? (v/f)");
string TienePresentismo = Console.ReadLine() ?? "";
TienePresentismo = TienePresentismo.ToLower();

static float CalcularAntiguedad(int CodigoAntiguedad, float SueldoBasico)
{
    switch (CodigoAntiguedad)
    {
        case 1:
            return 0;
        case 2:
            return SueldoBasico * 10 / 100;
        case 3:
            return SueldoBasico * 15 / 100;
        case 4:
            return SueldoBasico * 20 / 100;
        default:
            return 0;
    }
}

Antiguedad = CalcularAntiguedad(CodigoAntiguedad, SueldoBasico);

if (TienePresentismo == "v")
    Presentismo = SueldoBasico * 10 / 100;
else
    Presentismo = 0;

Remuneraciones = SueldoBasico + Antiguedad + Presentismo;

Jubilacion = Remuneraciones * 13 / 100;
ObraSocial = Remuneraciones * 3 / 100;

Descuentos = Jubilacion + ObraSocial;

SueldoNeto = Remuneraciones - Descuentos;

Console.WriteLine($"Remuneraciones: ${Remuneraciones}");
Console.WriteLine($"Descuentos: ${Descuentos}");
Console.WriteLine($"Sueldo Neto: ${SueldoNeto}");
