Console.WriteLine("Para calcular su salario semanal, ingrese la cantidad de horas que trabajó esta semana.");
string horasxtrabajo = Console.ReadLine()??"";
static int salario(int horas)
{
    if (horas < 40)
    {
        int sueldo = horas * 16;
        return sueldo;
    }
    else
    {
        int horasExtra = horas - 40;
        int sueldo = (horas - horasExtra) * 16 + horasExtra * 20;
        return sueldo;
    }
}

if (int.TryParse(horasxtrabajo, out int horas))
{
    Console.WriteLine($"Su salario semanal es de: ${salario(horas)}");
}
else
{
    Console.WriteLine("Caracter inválido");
}