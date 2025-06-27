using System;
using System.Threading;
using System.Threading.Tasks;

class Tarea
{
    public string Nombre { get; set; }
    public int Duracion { get; set; }
    //Constructor
    public Tarea(string nombre, int duracion)
    {
        this.Nombre = nombre;
        this.Duracion = duracion;
    }
    //Method
    public void Ejecutar()
    {
        Console.WriteLine($"Iniciando proceso, {Nombre}");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("...en proceso...");
        Console.ForegroundColor = ConsoleColor.Black;
        Thread.Sleep(Duracion * 1000);
        Console.WriteLine($"Hemos concluido el proceso {Nombre}");
    }
}

class Monoprocesador
{
    private Queue<Tarea> colaTarea;
    public Monoprocesador()
    {
        colaTarea = new Queue<Tarea>();
    }
    //Methods
    public void agregarTareas(Tarea tarea)
    {
        colaTarea.Enqueue(tarea);
        Console.WriteLine($"\nLa tarea {tarea.Nombre} ha sido agregada con éxito");
    }
    public bool AvailableTareas()
    {
        return colaTarea.Count > 0;
    }
    public void EjecutarTodasTareas()
    {
        if (colaTarea.Count == 0)
        {
            Console.WriteLine("\nTodas las tareas han sido realizadas\n");
            return;
        }

        Console.WriteLine("\nEjecución secuencial\n");

        while (colaTarea.Count > 0)
        {
            Tarea TareaActual = colaTarea.Dequeue();
            TareaActual.Ejecutar();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nTareas ejecutadas");
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Monoprocesador monoprocesador = new Monoprocesador();

        while (true)
        {
            Console.WriteLine("\nBienvenid@...");
            Console.WriteLine("1. Desea agregar una tarea manual?");
            Console.WriteLine("2. Desea agregar una tarea predeterminada?");
            Console.WriteLine("3. Ejecutar tareas");
            Console.WriteLine("4. Salir");

            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Nombre de la tarea: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Cual es la duracion de dicha tarea? (en segundos): ");
                    if (int.TryParse(Console.ReadLine(), out int duracion))
                    {
                        Tarea nuevaTareaManual = new Tarea(nombre, duracion);
                        monoprocesador.agregarTareas(nuevaTareaManual);
                    }
                    else
                    {
                        Console.WriteLine("Debe ingresar un numero valido... ");
                    }
                    break;
                case "2":
                    // Agregar tareas predeterminadas
                    Tarea tarea1 = new Tarea("Predeterminada 1", 2);
                    Tarea tarea2 = new Tarea("Predeterminada 2", 3);
                    monoprocesador.agregarTareas(tarea1);
                    monoprocesador.agregarTareas(tarea2);
                    break;
                case "3":
                    monoprocesador.EjecutarTodasTareas();
                    break;
                case "4":
                    Console.WriteLine("Saliendo del programa...");
                    return;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }

        }
    }
}
