using System.Xml.Linq;

Console.WriteLine("Ingresá una fecha expresada en un número de 6 dígitos, donde los dos primeros dígitos expresan el día, el tercero y el cuarto expresan el mes y los dos últimos expresan el año,");
int fecha = Convert.ToInt32(Console.ReadLine()??"");

int mes = (fecha / 100) % 100;

switch (mes)
{
    case 1:
        Console.WriteLine("El mes es enero");
        break;
    case 2:
        Console.WriteLine("El mes es febrero");
        break;
    case 3:
        Console.WriteLine("El mes es marzo");
        break;
    case 4:
        Console.WriteLine("El mes es abril");
        break;
    case 5:
        Console.WriteLine("El mes es mayo");
        break;
    case 6:
        Console.WriteLine("El mes es junio");
        break;
    case 7:
        Console.WriteLine("El mes es julio");
        break;
    case 8:
        Console.WriteLine("El mes es agosto");
        break;
    case 9:
        Console.WriteLine("El mes es septiembre");
        break;
    case 10:
        Console.WriteLine("El mes es octubre");
        break;
    case 11:
        Console.WriteLine("El mes es noviembre");
        break;
    case 12:
        Console.WriteLine("El mes es diciembre");
        break;
    default:
        Console.WriteLine("El número ingresado no corresponde a ningún mes");
        break;

}
