int resp;

Console.WriteLine("Listos para despegar? 1) si 2) no");
resp = Convert.ToInt32(Console.ReadLine());

for (int i = 5; i >= 1; i--)
{
    Console.WriteLine(i);
}

if (resp == 1)
{
    Console.WriteLine("Despegue!");
}
else
{
    Console.WriteLine("Abortando misión...");
}
