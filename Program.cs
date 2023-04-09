using System;

class EjemploMath
{
    static void Main(string[] args)
    {
        // Obtener el valor absoluto de un número
        int numero = -5;
        int valorAbsoluto = Math.Abs(numero);
        Console.WriteLine("El valor absoluto de {0} es {1}", numero, valorAbsoluto);

        // Redondear un número al entero más cercano
        double numeroDecimal = 3.75;
        int enteroMasCercano = (int)Math.Round(numeroDecimal);
        Console.WriteLine("El entero más cercano a {0} es {1}", numeroDecimal, enteroMasCercano);

        // Obtener el valor máximo y mínimo de un conjunto de números
        int[] numeros = new int[] { 3, 5, 2, 8, 1 };
        int maximo = Math.Max(numeros[0], numeros[1]);
        int minimo = Math.Min(numeros[2], numeros[3]);
        Console.WriteLine("El número máximo es {0} y el número mínimo es {1}", maximo, minimo);

        // Calcular la raíz cuadrada de un número
        double numeroRaiz = 16.0;
        double raizCuadrada = Math.Sqrt(numeroRaiz);
        Console.WriteLine("La raíz cuadrada de {0} es {1}", numeroRaiz, raizCuadrada);

        // Convertir un ángulo en grados a radianes
        double anguloGrados = 45.0;
        double anguloRadianes = Math.PI * anguloGrados / 180.0;
        Console.WriteLine("{0} grados equivale a {1} radianes", anguloGrados, anguloRadianes);
    }
}
