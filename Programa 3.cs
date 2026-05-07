Console.WriteLine("Seleccione una palabra para jugar:");
Console.WriteLine("1) Palabra 1.");
Console.WriteLine("2) Palabra 2.");
Console.WriteLine("3) Palabra 3.");

string P1 = "tecnologia";
string P2 = "algoritmo";
string P3 = "programacion";
string palabra = "";
string oculta = "";
char letra;
bool gano = false;
int intentos = 7;
int eleccion = Convert.ToInt16(Console.ReadLine());

switch (eleccion)
{
    case 1:
        palabra = P1;
        break;
    case 2:
        palabra = P2;
        break;
    case 3:
        palabra = P3;
        break;
    default:
        Console.WriteLine("Caracter no válido, intente con uno de la lista.");
        break;
}

for (int i = 0; i < palabra.Length; i++)
{
    oculta += "_";
}

while (intentos > 0 && !gano)
{
    Console.WriteLine($"Palabra: {oculta}");
    Console.WriteLine($"Intentos restantes: {intentos}");
    Console.WriteLine("Ingrese una letra:");
    letra = Convert.ToChar(Console.ReadLine()??"");
    string nueva = "";

    for (int i=0; i < palabra.Length; i++)
    {
        if (palabra[i] == letra)
        {
            nueva += letra;
        }
        else
        {
            nueva += oculta[i];
        }
        
    }
    if (nueva == oculta)
    {
        intentos--;
    }

    oculta = nueva;

    if (palabra == nueva)
    {
        gano = true;
    }
    if (intentos == 0)
    {
        break;
    }
}

if (gano)
{
    Console.WriteLine();
    Console.WriteLine("Ganaste");
}
else if (intentos == 0)
{
    Console.WriteLine();
    Console.WriteLine("Perdiste");
}
