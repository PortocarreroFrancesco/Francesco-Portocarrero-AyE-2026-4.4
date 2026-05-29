float SueldoNeto;
float Remuneraciones;
float SueldoBasico;
int Antiguedad;
int Presentismo;

float Descuentos;
float Jubilacion;
float ObraSocial;

static float CalcularAntiguedad()
{

}
Console.WriteLine("Ingrese su sueldo básico.");
SueldoBasico = Console.ReadLine() ?? "";

Descuentos = Jubilacion + ObraSocial;
Remuneraciones = SueldoBasico + Antiguedad + Presentismo;
SueldoNeto = Remuneraciones - Descuentos;
