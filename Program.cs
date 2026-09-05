// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//int opcion = Convert.ToInt32(Console.ReadLine());
int[] numeros = { 1, 2, 3, 4, 5 };
List<int> list = numeros.ToList();
var pares = numeros.Where(n => n % 2 == 0);
var suma = numeros.Sum();
var max = numeros.Max();
Console.WriteLine($"{suma} - {max} - {pares.ElementAt(1)}");

int precio = 45;
switch (precio)
{
    case 40:
        Console.WriteLine("40");
        break;
    case 45:
        Console.WriteLine("45");
        break;
    default:
        Console.WriteLine("Otro valor");
        break;
}

switch (precio)
{
    case < 40:
        Console.WriteLine("40");
        break;
    case > 45 && :
        Console.WriteLine("45");
        break;
    default:
        Console.WriteLine("Otro valor");
        break;
}
//modif