Console.WriteLine("Ingresa una frase para invertirla");
string texto = Console.ReadLine()??"";

string invertido = "";

for(int i=texto.Length-1;i>=0;i--)
{
    invertido = invertido + texto[i];
}

Console.WriteLine(invertido);