Console.WriteLine("Ingrese la hora, minutos y segundos de un instante en forma de un número de 6 dígitos, siendo los primeros dos la hora, el tercero y el cuarto los minutos y los últimos dos los segundos");
int intervalo1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ahora, ingrese la hora, minutos y segundos de otro instante diferente en forma de un número de 6 dígitos, siendo los primeros dos la hora, el tercero y el cuarto los minutos y los últimos dos los segundos");
int intervalo2 = Convert.ToInt32(Console.ReadLine());

int hora1 = intervalo1 / 10000;
int minutos1 = (intervalo1 / 100) % 100;
int segundos1 = intervalo1 % 100;

int hora2 = intervalo2 / 10000;
int minutos2 = (intervalo2 / 100) % 100;
int segundos2 = intervalo2 % 100;

int instante1 = hora1 * 3600 + minutos1 * 60 + segundos1;
int instante2 = hora2 * 3600 + minutos2 * 60 + segundos2;

int intervalo = (instante2 - instante1+86400)%86400;

Console.WriteLine($"Hay {intervalo} segundos de diferencia entre los dos intervalos");