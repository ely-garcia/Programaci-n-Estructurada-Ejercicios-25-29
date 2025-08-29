// Programa que calcula la cantidad total de baldes de leche producida en un día

int volumenPorVaca, numeroVacas;
bool esValido = false;

// Pedir volumen promedio por vaca
Console.WriteLine("Ingrese el volumen promedio de leche por vaca (en litros):");
do
{
    string entrada = Console.ReadLine();
    esValido = int.TryParse(entrada, out volumenPorVaca);
    if (!esValido || volumenPorVaca <= 0)
    {
        Console.WriteLine("Entrada inválida. Ingrese un número mayor que 0 para el volumen.");
        esValido = false;
    }
} while (!esValido);

// Pedir número de vacas
Console.WriteLine("Ingrese el número total de vacas ordeñadas:");
do
{
    string entrada = Console.ReadLine();
    esValido = int.TryParse(entrada, out numeroVacas);
    if (!esValido || numeroVacas <= 0)
    {
        Console.WriteLine("Entrada inválida. Ingrese un número mayor que 0 para el número de vacas.");
        esValido = false;
    }
} while (!esValido);

// Calcular litros totales
int totalLitros = volumenPorVaca * numeroVacas;

// Convertir a baldes (1 balde = 20 litros)
int totalBaldes = totalLitros / 20;

// Mostrar resultado
Console.WriteLine($"La producción total es de {totalLitros} litros, equivalentes a {totalBaldes} baldes.");
