using System;

class Program
{
    static void Main()
    {
        int opcion = 0;

        while (opcion != 4)
        {
            Console.WriteLine("MENÚ PRINCIPAL");
            Console.WriteLine("1) Primer bloque");
            Console.WriteLine("2) Segundo bloque");
            Console.WriteLine("3) Tercer bloque");
            Console.WriteLine("4) Salir");

            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                PrimerBloque();
            }
            else if (opcion == 2)
            {
                SegundoBloque();
            }
            else if (opcion == 3)
            {
                TercerBloque();
            }
            else if (opcion == 4)
            {
                Console.WriteLine("Saliendo del programa...");
            }
            else
            {
                Console.WriteLine("Opción incorrecta");
            }

            Console.WriteLine();
        }
    }

    // ===================== PRIMER BLOQUE =====================

    static void PrimerBloque()
    {
        int opcion = 0;

        while (opcion != 4)
        {
            Console.WriteLine("PRIMER BLOQUE");
            Console.WriteLine("1) Múltiplos de 3 del 1 al 100");
            Console.WriteLine("2) Verificar edad");
            Console.WriteLine("3) Cantidad de letras de una palabra");
            Console.WriteLine("4) Volver");

            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                MultiplosDeTres();
            }
            else if (opcion == 2)
            {
                VerificarEdad();
            }
            else if (opcion == 3)
            {
                CantidadLetras();
            }
        }
    }

    static void MultiplosDeTres()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    static void VerificarEdad()
    {
        int edad;

        Console.WriteLine("Ingrese su edad:");
        edad = Convert.ToInt32(Console.ReadLine());

        if (edad < 18)
        {
            Console.WriteLine("Menor de edad");
        }
        else if (edad == 18)
        {
            Console.WriteLine("Tiene justo 18 años");
        }
        else
        {
            Console.WriteLine("Mayor de edad");
        }
    }

    static void CantidadLetras()
    {
        string palabra;

        Console.WriteLine("Ingrese una palabra:");
        palabra = Console.ReadLine();

        Console.WriteLine("Tiene " + palabra.Length + " letras");
    }

    // ===================== SEGUNDO BLOQUE =====================

    static void SegundoBloque()
    {
        int opcion = 0;

        while (opcion != 4)
        {
            Console.WriteLine("SEGUNDO BLOQUE");
            Console.WriteLine("1) Adivinar número del 1 al 10");
            Console.WriteLine("2) Mostrar divisores de un número");
            Console.WriteLine("3) Serie de Fibonacci (20 números)");
            Console.WriteLine("4) Volver");

            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                AdivinarNumero();
            }
            else if (opcion == 2)
            {
                MostrarDivisores();
            }
            else if (opcion == 3)
            {
                Fibonacci();
            }
        }
    }

    static void AdivinarNumero()
    {
        Random rnd = new Random();
        int numeroSecreto = rnd.Next(1, 11);
        int intento = 0;

        while (intento != numeroSecreto)
        {
            Console.WriteLine("Adiviná el número del 1 al 10:");
            intento = Convert.ToInt32(Console.ReadLine());

            if (intento < numeroSecreto)
            {
                Console.WriteLine("Es mayor");
            }
            else if (intento > numeroSecreto)
            {
                Console.WriteLine("Es menor");
            }
        }

        Console.WriteLine("¡Correcto!");
    }

    static void MostrarDivisores()
    {
        int numero;

        Console.WriteLine("Ingrese un número:");
        numero = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    static void Fibonacci()
    {
        int a = 0;
        int b = 1;
        int c;

        Console.WriteLine(a);
        Console.WriteLine(b);

        for (int i = 3; i <= 20; i++)
        {
            c = a + b;
            Console.WriteLine(c);
            a = b;
            b = c;
        }
    }

    // ===================== TERCER BLOQUE =====================

    static void TercerBloque()
    {
        int opcion = 0;

        while (opcion != 4)
        {
            Console.WriteLine("TERCER BLOQUE");
            Console.WriteLine("1) Contar cuántas veces aparece una letra");
            Console.WriteLine("2) Mostrar números impares hasta un número");
            Console.WriteLine("3) Rango de número (0-100)");
            Console.WriteLine("4) Volver");

            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                ContarLetra();
            }
            else if (opcion == 2)
            {
                NumerosImpares();
            }
            else if (opcion == 3)
            {
                RangoNumero();
            }
        }
    }

    static void ContarLetra()
    {
        string palabra;
        char letra;
        int contador = 0;

        Console.WriteLine("Ingrese una palabra:");
        palabra = Console.ReadLine();

        Console.WriteLine("Ingrese una letra:");
        letra = Convert.ToChar(Console.ReadLine());

        for (int i = 0; i < palabra.Length; i++)
        {
            if (palabra[i] == letra)
            {
                contador++;
            }
        }

        Console.WriteLine("Aparece " + contador + " veces");
    }

    static void NumerosImpares()
    {
        int numero;

        Console.WriteLine("Ingrese un número:");
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero < 1)
        {
            Console.WriteLine("No se puede");
        }
        else
        {
            for (int i = 1; i <= numero; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    static void RangoNumero()
    {
        int numero;

        Console.WriteLine("Ingrese un número:");
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero >= 0 && numero <= 25)
        {
            Console.WriteLine("Rango 0-25");
        }
        else if (numero >= 26 && numero <= 50)
        {
            Console.WriteLine("Rango 26-50");
        }
        else if (numero >= 51 && numero <= 75)
        {
            Console.WriteLine("Rango 51-75");
        }
        else if (numero >= 76 && numero <= 100)
        {
            Console.WriteLine("Rango 76-100");
        }
        else
        {
            Console.WriteLine("Fuera de rango");
        }
    }
}
