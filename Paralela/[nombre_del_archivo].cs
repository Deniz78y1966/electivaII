var colores = new string[] { "Amarillo", "Azul", "Rojo", "Verde", "Anaranjado" };

            // Agrupar colores que inician con "A"
            var coloresConA = new List<string>();
            for (int m = 0; m < colores.Length; m++)
            {
                if (colores[m].StartsWith("A"))
                {
                    coloresConA.Add(colores[m]);
                }
            }
            if (coloresConA.Count > 0)
            {
                Console.WriteLine("\nLos colores que inician con A son: " + string.Join(", ", coloresConA));
            }
            
            // Combinar algunos números de numPrimos y numPares
var numPrimos = new int[] { 2, 3, 5, 7, 11 };
var numPares = new int[] { 2, 4, 6, 8, 10 };

var combinados = new List<int>();
combinados.Add(numPrimos[0]);
combinados.Add(numPrimos[1]);
combinados.Add(numPares[0]);
combinados.Add(numPares[1]);

Console.WriteLine("Números combinados: " + string.Join(", ", combinados));