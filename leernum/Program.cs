// See https://aka.ms/new-console-template for more information
﻿Console.WriteLine("Comparador de Números");
Console.WriteLine("Introduce números uno por uno.");
Console.WriteLine("Escribe -99 para finalizar.\n");

int mayor = int.MinValue;
int menor = int.MaxValue;
int numero;
int contador = 0;

while (true)
{
    Console.Write("Número: ");
    string? entrada = Console.ReadLine();

    bool esValido = int.TryParse(entrada, out numero);

    if (!esValido)
    {
        Console.WriteLine("Entrada inválida. Intenta de nuevo.\n");
        continue;
    }

    if (numero == -99)
    {
        break; // Termina la lectura
    }

    // Solo comparamos si no es -99
    if (numero > mayor)
    {
        mayor = numero;
    }

    if (numero < menor)
    {
        menor = numero;
    }

    contador++;
}

if (contador == 0)
{
    Console.WriteLine("\n No se ingresaron números válidos.");
}
else
{
    Console.WriteLine($"\nTotal de números ingresados: {contador}");
    Console.WriteLine($"Número mayor: {mayor}");
    Console.WriteLine($"Número menor: {menor}");
}

