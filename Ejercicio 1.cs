Console.WriteLine("Ingresá un número entero y te digo si es primo o no.");
int numero = Convert.ToInt32(Console.ReadLine());
static bool es_primo(int numero)
{
    if (numero == 2)
    {
        bool resultado = true;
        return resultado;
    }
    else if (numero < 2)
    {
        bool resultado = false;
        return resultado;
    }
    else if (numero % 2 == 0 && numero > 2)
    {
        bool resultado = false;
        return resultado;
    }
    else
    {
        bool resultado = true;
        return resultado;
    }
}

bool resultado = es_primo(numero);

if (resultado == true)
{
    Console.WriteLine("Es un número primo");

}
else
{
    Console.WriteLine("Es un número NO primo");
}