int acu = 1;
for (int i = 2; i <= 5; i++)
{
    int nueva = acu + i;
    Console.WriteLine($"{acu} + {i} = {nueva}");
    acu = nueva;
}
