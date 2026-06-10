Console.WriteLine("Conjunto A");

int A1 = int.Parse(Console.ReadLine() ?? "0");
int A2 = int.Parse(Console.ReadLine() ?? "0");
int A3 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Conjunto B");

int B1 = int.Parse(Console.ReadLine() ?? "0");
int B2 = int.Parse(Console.ReadLine() ?? "0");
int B3 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Intersección:");

if (A1 == B1 || A1 == B2 || A1 == B3)
    Console.WriteLine(A1);

if (A2 == B1 || A2 == B2 || A2 == B3)
    Console.WriteLine(A2);

if (A3 == B1 || A3 == B2 || A3 == B3)
    Console.WriteLine(A3);