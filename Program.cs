using System;

class Program
{
    static void Main(string[] args)
    {

        Random aleatorio = new Random();

        int[] lista_aleatorios = new int[20];
        for (int i = 0; i < lista_aleatorios.Length; i++)
        {
            lista_aleatorios[i] = aleatorio.Next(0, 100);
        }

        Console.WriteLine("Ingresa un número entre 0 y 99: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        int contador = 0;
        for (int i = 0; i < lista_aleatorios.Length; i++)
        {
            if (lista_aleatorios[i] == numero)
            {
                contador++;
            }
        }

        Console.WriteLine("El número {0} aparece {1} veces en la lista generada.", numero, contador);
    }
}
