Console.WriteLine("Ingrese el valor de uno de los lados del cuadrado en centímetros");
int lado = Convert.ToInt32(Console.ReadLine());

int perimetro = lado * 4;
int superficie = lado * lado;

Console.WriteLine($"Perímetro:{perimetro} Cm");
Console.WriteLine($"Superficie:{superficie} Cm");


