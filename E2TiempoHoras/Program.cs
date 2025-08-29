// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese la velocidad promedio en km/h:");
int velocidad;
int distancia = 40;

// Validar
bool esValido = false; // Variable de control de validación
do
{
    string entrada = Console.ReadLine();
    esValido = int.TryParse(entrada, out velocidad);
    if (!esValido || velocidad <= 0)
    {
        Console.WriteLine("Entrada inválida. Intenta de nuevo con un número mayor que 0.");
        esValido = false;
    }
} while (!esValido);

// Calculo
double tiempo = (double)distancia / velocidad;

// Mostrar
Console.WriteLine($"El tiempo transcurrido al recorrer una distancia de {distancia} km a {velocidad} km/h es: {tiempo} horas.");
