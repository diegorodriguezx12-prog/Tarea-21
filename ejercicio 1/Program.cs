Console.Write("Ingrese la cantidad de números que desea ingresar: ");
int n = int.Parse(Console.ReadLine());

int[] numeros = new int[n];
double suma = 0;

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Ingrese el número {i + 1}");
    numeros[i] = int.Parse(Console.ReadLine());
    suma += numeros[i];
}

double promedio = suma / n;

Console.WriteLine($"El promedio general es: {promedio:F2}");

int contador = 0;

Console.WriteLine("Valores que están por encima del promedio");
for (int i = 0; i < n;i++)
{
    if (numeros[i] > promedio)
    {
        Console.WriteLine($"{numeros[i]}");
        contador++;
    }
}
Console.WriteLine($"El total de números por encima del promedio: {contador}");