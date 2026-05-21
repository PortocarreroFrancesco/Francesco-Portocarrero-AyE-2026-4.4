string[] Nombres = { "Alejandro", "Alexander", "Augusto", "Baldomero", "Baraquiel", "Bartolomé", "Benedicto", "Adriano", "Gianluca", "Apolo" };
char[] Vocales = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U', 'á', 'é', 'í', 'ó', 'ú', 'Á', 'É', 'Í', 'Ó', 'Ú' };
int CantidadVocales = 0;
for (int i = 0; i<Nombres.Length;i++)
{
    foreach (char x in Nombres[i])
    {
        foreach (char y in Vocales)
        {
            if (x == y) CantidadVocales++;
        }
    }
}
Console.WriteLine($"Cantidad de vocales: {CantidadVocales}.");