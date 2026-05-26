int x = 1;
string N;
string[] NombresContactos = new string[50];
string[] NumerosContactos = new string[50];
int CantidadContactos = 0;

while (x == 1)
{

    Console.WriteLine("Ingresá que acción queres realizar:");
    Console.WriteLine("1) Añadir un nuevo contacto.");
    Console.WriteLine("2) Mostrar todos los contactos.");
    Console.WriteLine("3) Buscar un contacto por nombre.");
    Console.WriteLine("0) Terminar el programa.");
    N = Console.ReadLine() ?? "";

    bool EsunNumero = int.TryParse(N, out int Respuesta);

    if (EsunNumero)
    {
        switch (Respuesta)
        {
            case 1:
                Console.WriteLine("Ingrese el nombre del contacto.");
                string Nombre = Console.ReadLine() ?? "";
                Console.WriteLine("Ingrese el número de teléfono del contacto.");
                string Numero = Console.ReadLine() ?? "";
                NombresContactos[CantidadContactos] = Nombre;
                NumerosContactos[CantidadContactos] = Numero;
                CantidadContactos++;
                break;
            case 2:
                for (int i = 0; i < CantidadContactos; i++) Console.WriteLine($"Contacto: {NombresContactos[i]}, número: {NumerosContactos[i]}");
                break;
            case 3:
                Console.WriteLine("Ingresá el nombre del contacto que queres buscar");
                string Buscado = Console.ReadLine() ?? "";
                bool Encontrado = false;
                for (int i = 0; i < CantidadContactos; i++)
                {
                    if (NombresContactos[i].ToLower() == Buscado.ToLower())
                    {
                        Console.WriteLine($"Contacto: {NombresContactos[i]}, número: {NumerosContactos[i]}");
                        Encontrado = true;
                        break;
                    }
                }
                if (!Encontrado) Console.WriteLine("Nombre de contacto no encontrado.");
                break;
            case 0:
                x = 0;
                break;
        }
    }
    else Console.WriteLine("Caracter no válido.");
}