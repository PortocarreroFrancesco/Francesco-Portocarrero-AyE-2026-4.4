Console.WriteLine("b) Relacionales");

        if (25 > 30)
            Console.WriteLine("11) Es verdadera");
        else
            Console.WriteLine("11) Es falsa");

        if (14 <= 14)
            Console.WriteLine("12) Es verdadera");
        else
            Console.WriteLine("12) Es falsa");

        if (0 == 0)
            Console.WriteLine("13) Es verdadera");
        else
            Console.WriteLine("13) Es falsa");

        if (10 != 10)
            Console.WriteLine("14) Es verdadera");
        else
            Console.WriteLine("14) Es falsa");

        if (8 >= 3)
            Console.WriteLine("15) Es verdadera");
        else
            Console.WriteLine("15) Es falsa");

        if (15 < 15)
            Console.WriteLine("16) Es verdadera");
        else
            Console.WriteLine("16) Es falsa");

        if (100 != 50)
            Console.WriteLine("17) Es verdadera");
        else
            Console.WriteLine("17) Es falsa");

        if (7 == 7.0)
            Console.WriteLine("18) Es verdadera");
        else
            Console.WriteLine("18) Es falsa");

        if (0.5 > 0)
            Console.WriteLine("19) Es verdadera");
        else
            Console.WriteLine("19) Es falsa");

        if (-5 < -2)
            Console.WriteLine("20) Es verdadera");
        else
            Console.WriteLine("20) Es falsa");


        Console.WriteLine("\nc) Lógica combinada");

        if ((5 > 3) && (10 < 20))
            Console.WriteLine("21) Es verdadera");
        else
            Console.WriteLine("21) Es falsa");

        if ((8 == 10) || (5 != 2))
            Console.WriteLine("22) Es verdadera");
        else
            Console.WriteLine("22) Es falsa");

        if (!(10 == 10))
            Console.WriteLine("23) Es verdadera");
        else
            Console.WriteLine("23) Es falsa");

        if ((15 > 10) && !(5 > 10))
            Console.WriteLine("24) Es verdadera");
        else
            Console.WriteLine("24) Es falsa");

        if ((10 + 2 > 10) || (5 * 2 < 8))
            Console.WriteLine("25) Es verdadera");
        else
            Console.WriteLine("25) Es falsa");

        int temperatura = 35;
        bool humedad = false;

        if ((temperatura > 30) && (humedad == true))
            Console.WriteLine("26) Es verdadera");
        else
            Console.WriteLine("26) Es falsa");

        int edad = 16;

        if (!(edad >= 18))
            Console.WriteLine("27) Es verdadera");
        else
            Console.WriteLine("27) Es falsa");

        if ((10 / 3 == 3) && (10 % 3 == 1))
            Console.WriteLine("28) Es verdadera");
        else
            Console.WriteLine("28) Es falsa");

        string nombre = "Ana";

        if ((nombre == "Juan") || (nombre == "Ana"))
            Console.WriteLine("29) Es verdadera");
        else
            Console.WriteLine("29) Es falsa");

        if (((5 * 2) + 10 > 15) && (20 / 4 == 5))
            Console.WriteLine("30) Es verdadera");
        else
            Console.WriteLine("30) Es falsa");
