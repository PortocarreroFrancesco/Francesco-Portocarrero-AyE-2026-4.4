Console.WriteLine("Ingrese el día.");
string Dia = Console.ReadLine() ?? "";

Console.WriteLine("Ingrese el mes.");
string Mes = Console.ReadLine() ?? "";

Console.WriteLine("Ingrese el año.");
string Anio = Console.ReadLine() ?? "";

string NombreMes;

switch (Mes)
{
    case "1":
    case "01":
        NombreMes = "enero";
        break;

    case "2":
    case "02":
        NombreMes = "febrero";
        break;

    case "3":
    case "03":
        NombreMes = "marzo";
        break;

    case "4":
    case "04":
        NombreMes = "abril";
        break;

    case "5":
    case "05":
        NombreMes = "mayo";
        break;

    case "6":
    case "06":
        NombreMes = "junio";
        break;

    case "7":
    case "07":
        NombreMes = "julio";
        break;

    case "8":
    case "08":
        NombreMes = "agosto";
        break;

    case "9":
    case "09":
        NombreMes = "septiembre";
        break;

    case "10":
        NombreMes = "octubre";
        break;

    case "11":
        NombreMes = "noviembre";
        break;

    case "12":
        NombreMes = "diciembre";
        break;

    default:
        NombreMes = "Mes inválido";
        break;
}

Console.WriteLine($"{Dia} de {NombreMes} de 20{Anio}");