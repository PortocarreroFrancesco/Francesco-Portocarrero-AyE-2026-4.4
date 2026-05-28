float[] Notas = new float[10];
int IndiceNotas = 0;
for (int i = 0; i < Notas.Length; i++){
    Console.WriteLine($"Ingresá la nota del estudiante {i+1}");
    string N = Console.ReadLine() ?? "";
    if (float.TryParse(N, out float Nota)){
        Notas[IndiceNotas] = Nota;
        IndiceNotas++;
    }else Console.WriteLine("Caracter no válido.");
}float SumaTotal = 0;
for (int i = 0; i < Notas.Length; i++) SumaTotal += Notas[i];
float PromedioNotas = SumaTotal / Notas.Length;
Console.WriteLine($"Suma total de las notas: {SumaTotal}, Promedio de notas: {PromedioNotas}.");