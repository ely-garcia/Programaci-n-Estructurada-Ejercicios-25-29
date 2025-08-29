// Programa que determina si un año es bisiesto

Console.WriteLine("Ingrese un año:");
int anio;
bool esValido = false;

// Validación
do
{
    string entrada = Console.ReadLine();
    esValido = int.TryParse(entrada, out anio);
    if (!esValido || anio <= 0)
    {
        Console.WriteLine("Entrada inválida. Ingrese un año válido (mayor a 0).");
        esValido = false;
    }
} while (!esValido);

// Evaluar si es bisiesto usando operadores lógicos
if ((anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0))
{
    Console.WriteLine($"{anio} es un año bisiesto ");
}
else
{
    Console.WriteLine($"{anio} no es un año bisiesto ");
}

