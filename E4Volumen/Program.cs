// Programa que calcula el volumen total de agua en un tanque (m³)

int longitud, ancho, altura;
bool esValido = false;

// Pedir longitud
Console.WriteLine("Ingrese la longitud del tanque en metros:");
do
{
    string entrada = Console.ReadLine();
    esValido = int.TryParse(entrada, out longitud);
    if (!esValido || longitud <= 0)
    {
        Console.WriteLine("Entrada inválida. Ingrese un número mayor que 0 para la longitud.");
        esValido = false;
    }
} while (!esValido);

// Pedir ancho
Console.WriteLine("Ingrese el ancho del tanque en metros:");
do
{
    string entrada = Console.ReadLine();
    esValido = int.TryParse(entrada, out ancho);
    if (!esValido || ancho <= 0)
    {
        Console.WriteLine("Entrada inválida. Ingrese un número mayor que 0 para el ancho.");
        esValido = false;
    }
} while (!esValido);

// Pedir altura
Console.WriteLine("Ingrese la altura del tanque en metros:");
do
{
    string entrada = Console.ReadLine();
    esValido = int.TryParse(entrada, out altura);
    if (!esValido || altura <= 0)
    {
        Console.WriteLine("Entrada inválida. Ingrese un número mayor que 0 para la altura.");
        esValido = false;
    }
} while (!esValido);

// Calcular volumen
int volumen = longitud * ancho * altura;

// Mostrar resultado
Console.WriteLine($"El volumen total de agua en el tanque es: {volumen} m³.");
