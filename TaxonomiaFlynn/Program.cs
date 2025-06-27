using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        //Ejercicion 1
        Console.WriteLine("Ejercicio 1");
        //Creamos el arreglo/lista string 
        string[] colores = new string[6] { "Azul", "Amarillo", "Rojo", "Naranja", "Negro", "Gris" };

        //Recorriendo al array en orden alfabético
        Array.Sort(colores);
        Console.WriteLine("El orden alfabetico del arreglo es " + string.Join(", ", colores));

        //Loop para llamar a los que inicien con una letra en específico (like N)
        List<string> coloresConN = new List<string>();
        for (int g = 0; g < colores.Length; g++)
        {
            if (colores[g].StartsWith("N"))
            {
                coloresConN.Add(colores[g]);
            }
        }
        if (coloresConN.Count > 0)
        {
            Console.WriteLine("Los colores que inician con N son: " + string.Join(", ", coloresConN));
        }

        //Loop para llamar a los que inicien con una letra en específico (like A)
        List<string> coloresConA = new List<string>();
        for (int m = 0; m < colores.Length; m++)
        {
            if (colores[m].StartsWith("A"))
            {
                coloresConA.Add(colores[m]);
            }
        }
        if (coloresConA.Count > 0)
        {
            Console.WriteLine("Los colores que inician con A son: " + string.Join(", ", coloresConA));
        }

        //Ejercicio 2
        Console.WriteLine("\nEjercicio 2");
        List<string> autosSinVniT = new List<string>();
        List<string> ColoresSinAniN = new List<string>();

        string[] autos = { "Volvo", "Audi", "McClaren", "Ferrari", "Toyota", "Porsche" };
        //instruction for autos
        for (int r = 0; r < autos.Length; r++)
        {
            if (!autos[r].StartsWith("V") && !autos[r].StartsWith("T"))
            {
                autosSinVniT.Add(autos[r]);
            }
        }
        if (autosSinVniT.Count > 0)
        {
            Console.WriteLine("Los autos que NO inician con V ni con T son: " + string.Join(", ", autosSinVniT));
        }
        //instruction for colores
        for (int e = 0; e < colores.Length; e++)
        {
            if (!colores[e].StartsWith("A") && !colores[e].StartsWith("N"))
            {
                ColoresSinAniN.Add(colores[e]);
            }
        }
        if (ColoresSinAniN.Count > 0)
        {
            Console.WriteLine("Los colores que NO inician con A ni con N son: " + string.Join(", ", ColoresSinAniN));
        }

        //Ejercicio 3
        Console.WriteLine("\nEjercicio 3");
        int[] numPrimos = { 3, 5, 7, 9, 11 };
        int[] numPares = { 2, 4, 6, 8, 10 };
        List<int> mostrar_Primos = new List<int>();
        List<int> mostrar_Pares = new List<int>();

        //mostrando numeros primos.
        foreach (int mostrarPrimos in numPrimos)
        {
            mostrar_Primos.Add(mostrarPrimos);
        }
        if (mostrar_Primos.Count > 0)
        {
            Console.WriteLine($"Los numeros primos son " + string.Join(", ", mostrar_Primos));
        }
        //mostrando numeros pares.
        foreach (int mostrarPares in numPares)
        {
            mostrar_Pares.Add(mostrarPares);
        }
        if (mostrar_Pares.Count > 0)
        {
            Console.WriteLine($"Los numeros pares son " + string.Join(", ", mostrar_Pares));
        }

        //Primera instrucción: combinar los primeros números del arreglo.
        int combinacion1 = numPrimos[0] + numPares[0];
        Console.WriteLine("La combinación de " + numPrimos[0] + " y " + numPares[0] + " = " + combinacion1);
        int combinacion2 = numPrimos[4] + numPares[1];
        Console.WriteLine("La combinación de " + numPrimos[4] + " y " + numPares[1] + " = " + combinacion1);

        //Segunda instrucción: combinar y ordenar el contenido de ambos.
        mostrar_Pares.Sort();
        mostrar_Primos.Sort();
        List<int> listaOrdenada = new List<int>();
        listaOrdenada.AddRange(mostrar_Pares);
        listaOrdenada.AddRange(mostrar_Primos);
        listaOrdenada.Sort();
        Console.WriteLine("La lista combinada y ordenada es = " + string.Join(", ", listaOrdenada));

        //Elevando al cuadrado
        int cuadradoPrimo2 = numPrimos[1] * numPrimos[1];
        int cuadradoPar4 = numPares[3] * numPares[3];
        Console.WriteLine("\nEl segundo número primo elevado al cuadrado es: " + cuadradoPrimo2);
        Console.WriteLine("El segundo número par elevado al cuadrado es: " + cuadradoPar4);
    }
}

