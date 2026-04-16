bool x = true;

while (x == true)
{
    Console.WriteLine("Ingresá una de las opciones del menú");
    Console.WriteLine("1) Hola   2) Chau   3)Terminar el programa");

    int respuesta = Convert.ToInt16(Console.ReadLine());
    switch (respuesta)
    {
        case 1:
            Console.WriteLine("Hola.");
                break;
        case 2:
            Console.WriteLine("Chau");
            break;
        case 3:
            x = false;
            break;
    }
}
