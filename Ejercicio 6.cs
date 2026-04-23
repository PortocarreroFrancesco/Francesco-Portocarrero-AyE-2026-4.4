Console.WriteLine("Ingresá tu nombre");
string nombre = Console.ReadLine()??"";

static Boolean palindromo(string nombre)
{
    for (int i = 0; i<nombre.Length/2;i++)
    {
        if (nombre[i] == nombre[nombre.Length - 1 - i])
        {

        }
        else
        {
            return false;
        }
        
    }
    return true;
}   

Boolean resultado = palindromo(nombre);
if (resultado == true)
{
    Console.WriteLine("Es palíndromo");
}
else
{
    Console.WriteLine("No es palíndromo");
}