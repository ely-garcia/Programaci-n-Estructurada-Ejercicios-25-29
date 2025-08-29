// Programa que determina si un número es positivo, negativo o cero

Console.WriteLine("Ingrese un número:");
int numero;
bool esValido = false;

do
{
    string entrada = Console.ReadLine();
    esValido = int.TryParse(entrada, out numero);
    if (!esValido)
    {
        Console.WriteLine("Entrada inválida. Intente de nuevo con un número entero.");
    }
} while (!esValido);

// Uso de if para determinar el tipo de número
if (numero > 0)
{
    Console.WriteLine("El número es positivo.");
}

if (numero < 0)
{
    Console.WriteLine("El número es negativo.");
}

if (numero == 0)
{
    Console.WriteLine("El número es cero.");
}
