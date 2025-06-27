// Sort and display the first array
mostrar_Pares.Sort();
Console.WriteLine("Los numeros pares ordenados son: " + string.Join(", ", mostrar_Pares));

// Combine both arrays/lists
List<int> listaCombinadaOrdenada = new List<int>();
listaCombinadaOrdenada.AddRange(mostrar_Pares);
listaCombinadaOrdenada.AddRange(otraLista); // Replace 'otraLista' with your second array/list variable

// Sort the combined list
listaCombinadaOrdenada.Sort();

// Print the combined and sorted list
Console.WriteLine("Ambas listas combinadas y ordenadas: " + string.Join(", ", listaCombinadaOrdenada));

// Elevar al cuadrado el segundo número de cada arreglo
int cuadradoSegundoPrimo = numPrimos[1] * numPrimos[1];
int cuadradoSegundoPar = numPares[1] * numPares[1];

Console.WriteLine("El segundo número de numPrimos elevado al cuadrado es: " + cuadradoSegundoPrimo);
Console.WriteLine("El segundo número de numPares elevado al cuadrado es: " + cuadradoSegundoPar);