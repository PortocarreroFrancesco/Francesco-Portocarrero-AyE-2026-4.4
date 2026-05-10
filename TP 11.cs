Console.WriteLine("Elegí que TP querés revisar:");
Console.WriteLine("1) TP N°4.");
Console.WriteLine("2) TP N°5.");

int tp = Convert.ToInt32(Console.ReadLine());
int ejercicio;

switch (tp)
{
    case 1:

        Console.WriteLine("Ingresá qué ejercicio querés revisar:");
        Console.WriteLine("1) Ejercicio 1");
        Console.WriteLine("2) Ejercicio 2");
        Console.WriteLine("3) Ejercicio 3");
        Console.WriteLine("4) Ejercicio 4");

        ejercicio = Convert.ToInt32(Console.ReadLine());

        switch (ejercicio)
        {
            case 1:

                void recursivaE1(int i)
                {
                    if (i > 10)
                    {
                        return;
                    }

                    Console.WriteLine(i);
                    recursivaE1(i + 1);
                }

                recursivaE1(0);

                break;

            case 2:

                void hola(int i)
                {
                    if (i == 5)
                    {
                        return;
                    }

                    Console.WriteLine("Hola mundo");
                    hola(i + 1);
                }

                hola(0);

                break;

            case 3:

                void pares(int i)
                {
                    if (i > 20)
                    {
                        return;
                    }

                    Console.WriteLine(i);
                    pares(i + 2);
                }

                pares(2);

                break;

            case 4:

                void mult7(int i)
                {
                    if (i > 70)
                    {
                        return;
                    }

                    Console.WriteLine(i);
                    mult7(i + 7);
                }

                mult7(7);

                break;

            default:
                Console.WriteLine("Caracter no válido.");
                break;
        }

        break;

    case 2:

        Console.WriteLine("Ingresá qué ejercicio querés revisar:");
        Console.WriteLine("1) Ejercicio 1");
        Console.WriteLine("2) Ejercicio 2");
        Console.WriteLine("3) Ejercicio 3");
        Console.WriteLine("4) Ejercicio 4");

        ejercicio = Convert.ToInt32(Console.ReadLine());

        switch (ejercicio)
        {
            case 1:

                void password()
                {
                    Console.WriteLine("Ingrese su contraseña:");
                    string pass = Console.ReadLine() ?? "";

                    if (pass == "12345")
                    {
                        Console.WriteLine("¡Acceso concedido!");
                        return;
                    }

                    Console.WriteLine("¡Acceso denegado!");
                    password();
                }

                password();

                break;

            case 2:

                void cuentaRegresiva(int i)
                {
                    if (i == 0)
                    {
                        Console.WriteLine("Despegue!");
                        return;
                    }

                    Console.WriteLine(i);
                    cuentaRegresiva(i - 1);
                }

                cuentaRegresiva(5);

                break;

            case 3:

                void secreto()
                {
                    Console.WriteLine("Adiviná el número secreto:");
                    string numero = Console.ReadLine() ?? "";

                    if (numero == "7")
                    {
                        Console.WriteLine("Acceso concedido");
                        return;
                    }

                    Console.WriteLine("Acceso denegado");
                    secreto();
                }

                secreto();

                break;

            case 4:

                int sumaRecursiva(int suma)
                {
                    Console.WriteLine("Ingresá un número (0 para terminar):");
                    int numero = Convert.ToInt32(Console.ReadLine());

                    if (numero == 0)
                    {
                        return suma;
                    }

                    return sumaRecursiva(suma + numero);
                }

                int resultado = sumaRecursiva(0);

                Console.WriteLine($"La suma total es: {resultado}");

                break;

            default:
                Console.WriteLine("Caracter no válido.");
                break;
        }

        break;

    default:
        Console.WriteLine("Caracter no válido.");
        break;
}
