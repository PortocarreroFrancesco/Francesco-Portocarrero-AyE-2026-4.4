Console.WriteLine("Ingresa la cantidad de terminos de la secuencia Fibonacci que queres ver");
int n = Convert.ToInt32(Console.ReadLine());
int a = 0;
int b = 1;

if (n < 1)
{
    Console.WriteLine("Ingrese un número mayor a 0");
    return;
}

Console.WriteLine(a);

 for (int i = 1; i < n; i++ )
    {
    Console.WriteLine(b);
    int fibonacci = a + b;
    a = b;
    b = fibonacci;
    }

