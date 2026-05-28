float[] Temperatura = new float[7];
int IndiceTemperatura = 0;
for (int i = 0; i < Temperatura.Length; i++){
    Console.WriteLine($"Ingresá la temperatura en grados celsius del dia {i + 1}");
    string T = Console.ReadLine() ?? "";
    if (float.TryParse(T, out float Temp)){
        Temperatura[IndiceTemperatura] = Temp;
        IndiceTemperatura++;
    }else{
        Console.WriteLine("Caracter no válido.");
        break;
     }
} float TemperaturaMinima = Temperatura[0]; 
for(int i = 0; i < Temperatura.Length; i++){
    if (TemperaturaMinima > Temperatura[i]){
        TemperaturaMinima = Temperatura[i];
    }
} float TemperaturaMaxima = Temperatura[0];
for (int i = 0; i < Temperatura.Length; i++){
    if (TemperaturaMaxima < Temperatura[i]){
        TemperaturaMaxima = Temperatura[i];
    }
} Console.WriteLine($"Temperatura mínima: {TemperaturaMinima}, temperatura máxima: {TemperaturaMaxima}.");