// Programa que evalúa la calificación usando switch con rangos

Console.WriteLine("Ingrese la calificación del estudiante (0 - 100):");
int nota;
bool esValido = false;

// Validación de entrada
do
{
    string entrada = Console.ReadLine();
    esValido = int.TryParse(entrada, out nota);
    if (!esValido || nota < 0 || nota > 100)
    {
        Console.WriteLine("Entrada inválida. Ingrese un número entre 0 y 100.");
        esValido = false;
    }
} while (!esValido);

// Evaluación con switch
switch (nota)
{
    case int n when n >= 70:
        Console.WriteLine("El estudiante aprobó ");
        break;

    case int n when n >= 50 && n < 70:
        Console.WriteLine("El estudiante está en recuperación ");
        break;

    case int n when n < 50:
        Console.WriteLine("El estudiante reprobó ");
        break;
}
