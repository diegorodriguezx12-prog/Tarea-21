Console.Write("Ingrese la cantidad de números que desea ingresar: ");
int n = int.Parse(Console.ReadLine());

int[] numeros = new int[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Ingrese el valor para cada posición [{i}]");
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.Write("Ingrese el número que desea buscar en el arreglo: ");
int valorBuscar = int.Parse(Console.ReadLine());

int contador = 0;
Console.WriteLine($"Buscando el valor {valorBuscar}...");

for (int i = 0;i < n;i++)
{
if (numeros[i] == valorBuscar)
    {
        Console.WriteLine($"Coincidencia encontrada en el índice: {i}");
        contador++;
    }
}

if (contador > 0)
{
    Console.WriteLine($"El número {valorBuscar} aparece {contador} veces en el arreglo.");
}
else
{
    Console.WriteLine($"El número {valorBuscar} no se encuentra en el arreglo.");
}