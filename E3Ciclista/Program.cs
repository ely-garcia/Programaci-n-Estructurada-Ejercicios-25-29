// See https://aka.ms/new-console-template for more information
// Programa que calcula la distancia total recorrida por un ciclista en km
// usando velocidad promedio (km/h) y tiempo (horas)

Console.WriteLine("Ingrese la velocidad promedio en km/h:");
int velocidad;
bool esValido = false;
do
{
    string entrada = Console.ReadLine();
    esValido = int.TryParse(entrada, out velocidad);
    if (!esValido || velocidad <= 0)
    {
        Console.WriteLine("Entrada inválida. Ingrese un número mayor que 0 para la velocidad.");
        esValido = false;
    }
} while (!esValido);

Console.WriteLine("Ingrese el tiempo recorrido en horas:");
int tiempo;
esValido = false;
do
{
    string entrada = Console.ReadLine();
    esValido = int.TryParse(entrada, out tiempo);
    if (!esValido || tiempo <= 0)
    {
        Console.WriteLine("Entrada inválida. Ingrese un número mayor que 0 para el tiempo.");
        esValido = false;
    }
} while (!esValido);

// Calculo de distancia
int distancia = velocidad * tiempo;

// Mostrar resultado
Console.WriteLine($"La distancia total recorrida es de {distancia} km.");

