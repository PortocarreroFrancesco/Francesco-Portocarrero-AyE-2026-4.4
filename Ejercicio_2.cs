string[] Frutas = { "manzana", "banana", "naranja", "frutilla", "uva","sandía","ananá", "mango", "limón","pera" };
Console.WriteLine("Ingresá el nombre de una fruta");
string FrutaBuscada = Console.ReadLine() ?? "";
FrutaBuscada = FrutaBuscada.ToLower();
bool Encotrada = false;
for (int i = 0; i< Frutas.Length; i++) {
    if (Frutas[i] == FrutaBuscada){
        Encotrada = true;
        Console.WriteLine($"La fruta {FrutaBuscada} fué encontrada en el índice {i}.");
        break;
    }
}if (!Encotrada) Console.WriteLine($"La fruta {FrutaBuscada} no fué encontrada en la lista.");