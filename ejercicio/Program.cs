// Calcular individualmente la suma de los números pares e impares desde el 1 al 200
Console.WriteLine("Suma de pares e impares");
int i, sumapar = 0, sumaimpar = 0; // Se declara el tipo de datos de las variables una sola vez
for (i = 1; i <= 200; i++) //Primer bucle: Garantiza que se repita hasta que i sea 201
{
    if (i % 2 == 0) // Bucle que detecta si los números son pares y los suma
    {
        sumapar = sumapar + i; // sumapar es la variable donde se guardan solo números pares y los va sumando segun i
    }
    else
    {
        sumaimpar = sumaimpar + i; // sumaimpar es la variable donde se guardan solo números impares y los va sumando segun i
    }
}
Console.WriteLine($"La suma de los números pares es: {sumapar}");
Console.WriteLine($"La suma de los números impares es: {sumaimpar}");
// imprimimos los resultados en consola
