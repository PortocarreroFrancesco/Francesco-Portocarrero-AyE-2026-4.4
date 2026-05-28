int[] VectorNumeros = new int[5];
int Indice = 0;
Console.WriteLine("Ingresá 5 números");
Console.WriteLine("Primer número:");
string N1 = Console.ReadLine() ?? "";
if (int.TryParse(N1, out int PrimerNumero))
{
    VectorNumeros[Indice] = PrimerNumero;
    Indice++;
}
else Console.WriteLine("Caracter no válido.");

Console.WriteLine("Segundo número:");
string N2 = Console.ReadLine() ?? "";
if (int.TryParse(N2, out int SegundoNumero))
{
    VectorNumeros[Indice] = SegundoNumero;
    Indice++;
}
else Console.WriteLine("Caracter no válido.");

Console.WriteLine("Tercer número:");
string N3 = Console.ReadLine() ?? "";
if (int.TryParse(N3, out int TercerNumero))
{
    VectorNumeros[Indice] = TercerNumero;
    Indice++;
}
else Console.WriteLine("Caracter no válido.");

Console.WriteLine("Cuarto número:");
string N4 = Console.ReadLine() ?? "";
if (int.TryParse(N4, out int CuartoNumero))
{
    VectorNumeros[Indice] = CuartoNumero;
    Indice++;
}
else Console.WriteLine("Caracter no válido.");

Console.WriteLine("Primer número:");
string N5 = Console.ReadLine() ?? "";
if (int.TryParse(N5, out int QuintoNumero))
{
    VectorNumeros[Indice] = QuintoNumero;
    Indice++;
}
else Console.WriteLine("Caracter no válido.");
for (int i = 0; i < VectorNumeros.Length; i++) Console.WriteLine(VectorNumeros[i]);