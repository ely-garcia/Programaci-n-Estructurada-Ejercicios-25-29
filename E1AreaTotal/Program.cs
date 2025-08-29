//Calcular el area total de un terreno
Console.WriteLine("Calcular área total de terreno");
// Declara variables
int ancho = 5;
int longitud;
double area;
double area_manzanas;

// Validar entrada
bool esValido = false; //Variable que controla el bucle - tipo de dato: Boleano
do
{
    Console.Write("Ingresa la longitud del terreno en varas (solo números enteros): ");
    string entrada = Console.ReadLine();
    esValido = int.TryParse(entrada, out longitud);
    if (!esValido)
    {
        Console.WriteLine("Entrada inválida. Intenta de nuevo.");
    }
} while (!esValido);

int v = longitud * ancho;

// Cálculos
area = v;
area_manzanas = area / 1428.8;

Console.WriteLine($"El área total del terreno es: {area_manzanas} manzanas.");
