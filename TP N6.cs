static string ejercicio1(int n)
{
    if (n > 0)
    {
        return "es positivo";
    }
    else if (n < 0)
    {
        return "es negativo";
    }
    else
    {
        return "es 0";
    }
}

static string calc_edad(int edad)
{
    if (edad < 18)
    {
        return "Lo siento, eres muy joven.";
    }
    else
    {
        return "¡Bienvenido a la fiesta!";
    }
}

static string comprov(string inten)
{
    if (inten == "python123")
    {
        return "¡Contraseña correcta! Acceso concedido.";
    }
    else
    {
        return "¡Contraseña incorrecta, Autodestrucción en 5 minutos!";
    }
}

static string parImpar(int numero)
{
    if (numero % 2 == 0)
    {
        return "El numero es par.";
    }
    else
    {
        return "El numero es impar.";
    }
}

static string entradaGratis(int edad, int palomitas)
{
    if (edad > 65 && palomitas == 1)
    {
        return "¡Felicidades! Tienes entrada gratuita al cine.";
    }
    else
    {
        return "Compra la entrada o raja de acá";
    }
}

int opcion;

do
{
    Console.WriteLine("Ingrese el ejercicio que quiere realizar");
    Console.WriteLine("1) Ejercicio 1 ");
    Console.WriteLine("2) Ejercicio 2 ");
    Console.WriteLine("3) Ejercicio 3 ");
    Console.WriteLine("4) Ejercicio 4 ");
    Console.WriteLine("5) Ejercicio 5 ");
    Console.WriteLine("0) Salir");

    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingresa un número para verificar si es positivo o negativo");
            Console.WriteLine(ejercicio1(Convert.ToInt32(Console.ReadLine())));
            break;

        case 2:
            Console.WriteLine("Ingresa tu edad para verificar si podes entrar a la fiesta");
            Console.WriteLine(calc_edad(Convert.ToInt32(Console.ReadLine())));
            break;

        case 3:
            Console.WriteLine("Ingresa la contraseña secreta");
            Console.WriteLine(comprov(Console.ReadLine() ?? ""));
            break;

        case 4:
            Console.WriteLine("Ingresa un numero para comprobar si es par o impar");
            Console.WriteLine(parImpar(Convert.ToInt32(Console.ReadLine())));
            break;

        case 5:
            Console.WriteLine("Ingresa tu edad:");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("¿Compraste palomitas de maíz?");
            Console.WriteLine("1) Si");
            Console.WriteLine("2) No");

            int palomitas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(entradaGratis(edad, palomitas));
            break;

        case 0:
            Console.WriteLine("Programa finalizado.");
            break;

        default:
            Console.WriteLine("No ingresaste una opción válida");
            break;
    }

    Console.WriteLine();

} while (opcion != 0);