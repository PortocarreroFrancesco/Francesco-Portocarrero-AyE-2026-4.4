Console.WriteLine("Ingrese el monto que genera por hora de trabajo");
int sueldoxhora = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ahora, ingrese la cantidad de horas que trabajó");
int horas = Convert.ToInt32(Console.ReadLine());

int sueldobruto = sueldoxhora * horas;

Console.WriteLine($"Su sueldo bruto es de: ${sueldobruto}");
