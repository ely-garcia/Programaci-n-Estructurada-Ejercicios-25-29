// Programa que muestra el día de la semana según un número del 1 al 7

Console.WriteLine("Ingrese un número entre 1 y 7:");
int numero;
bool esValido = false;

// Validación de entrada 
do
{
    string entrada = Console.ReadLine();
    esValido = int.TryParse(entrada, out numero);
    if (!esValido || numero < 1 || numero > 7)
    {
        Console.WriteLine("Entrada inválida. Ingrese un número entero entre 1 y 7:");
        esValido = false;
    }
} while (!esValido);

// Uso de switch para mostrar el día
switch (numero)
{
    case 1:
        Console.WriteLine("Lunes");
        break;
    case 2:
        Console.WriteLine("Martes");
        break;
    case 3:
        Console.WriteLine("Miércoles");
        break;
    case 4:
        Console.WriteLine("Jueves");
        break;
    case 5:
        Console.WriteLine("Viernes");
        break;
    case 6:
        Console.WriteLine("Sábado");
        break;
    case 7:
        Console.WriteLine("Domingo");
        break;
}
