using System.ComponentModel.Design;

Console.WriteLine("Para determinar si es apto para recibir la beca económica, porfavor ingrese sus datos");

Console.WriteLine("1) Ingrese su nombre.");
string nombre = Console.ReadLine();

Console.WriteLine("2) Ingrese su promedio actual.");
double promedio = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("3) Ingrese la distancia en KM desde su casa a la universidad");
int distancia = Convert.ToInt32(Console.ReadLine());

static Boolean DeterminarBeca (double promedio, int distancia)
{
    if (promedio >= 8.5)
    {
        Boolean Resultado = true;
        return Resultado;
    }
    else if (distancia >= 50)
    {
        Boolean Resultado = true;
        return Resultado;
    }
    else
    {
        Boolean Resultado = false;
        return Resultado;
    }
}

bool Resultado = DeterminarBeca(promedio, distancia);

if (Resultado == true)
{
    Console.WriteLine($"Felicidades {nombre}, tu beca ha sido aprobada.");
}
else if (Resultado == false)
{
    Console.WriteLine($"Lo sentimos {nombre}, no cumples con los requisitos mínimos.");
}
