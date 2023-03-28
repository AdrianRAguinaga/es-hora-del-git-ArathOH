using AplicaicondeOptimizacion;
using System;
using System.Buffers;
using System.Diagnostics;
using System.Threading.Tasks;


// Utiliza 'Parallel.For' y 'System.Buffers.ArrayPool' para reducir la sobrecarga de la memoria:
class Program
{
    static void Main(string[] args)
    {
        const int dataSize = 1000000;
        double[] data = ArrayPool<double>.Shared.Rent(dataSize);

        // Llenamos el arreglo con valores aleatorios
        Random r = new Random();
        for (int i = 0; i < dataSize; i++)
            data[i] = r.NextDouble();

        // Medimos el tiempo de ejecución de la sección paralela
        Stopwatch stopwatch = Stopwatch.StartNew();

        // Realizamos operaciones matemáticas en paralelo
        Parallel.For(0, dataSize, i =>
        {
            data[i] = Math.Sin(data[i]) * Math.Cos(data[i]) / Math.Tan(data[i]);
        });

        // Detenemos el temporizador y calculamos el tiempo de ejecución
        stopwatch.Stop();
        TimeSpan timeSpan = stopwatch.Elapsed;

        // Imprimimos algunos resultados y el tiempo de ejecución
        Console.WriteLine("Resultado: " + data[100] + ", " + data[1000] + ", " + data[10000]);
        Console.WriteLine("Tiempo de ejecución: " + timeSpan.TotalMilliseconds + " milisegundos");

        // Devolvemos el arreglo al ArrayPool
        ArrayPool<double>.Shared.Return(data);

        // Creamos una instancia de la clase Paralelizacion
        paralelización p = new paralelización();
        p.paralelizaci();
        Console.WriteLine("-------------------------------------------------------------------------");
        // Creamos una instancia de la clase Paralelizacion
        hash  h= new hash();
        h.optimizacion_hash();

        Console.ReadLine();
    }
}