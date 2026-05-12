static string suma()
{
    Console.WriteLine("Ingresá números para sumarlos, cuando quieras terminar escribí 0");
    string numeros = Console.ReadLine() ?? "";
    int acum = 0;

    if (int.TryParse(numeros, out int numero))
    {
        acum = acum + numero;
        if (numero == 0)
        {
            string respuesta = $"Resultado: {acum}";
            return respuesta;
        }
        suma();
    }
    else
    {
        string respuesta = "Carácter no válido.";
        return respuesta;
    }
    string respuesta1 = "error";
    return respuesta1;
}

Console.WriteLine(suma());