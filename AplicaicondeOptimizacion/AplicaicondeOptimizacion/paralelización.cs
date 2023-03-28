using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicaicondeOptimizacion
{
    // optimización llamada "paralelización". La paralelización consiste en dividir una tarea en varias tareas más pequeñas que pueden ser ejecutadas de forma simultánea en diferentes núcleos de procesamiento, lo que permite una mayor utilización de los recursos del sistema y un mejor rendimiento. 
    public class paralelización
    {
        public void paralelizaci()
        {
        double[] data = new double[1000000];
        // Llenamos el arreglo con valores aleatorios
        Random r = new Random();
                for (int i = 0; i<data.Length; i++)
                    data[i] = r.NextDouble();

                // Realizamos operaciones matemáticas en paralelo
                Parallel.For(0, data.Length, i =>
                {
                    data[i] = Math.Sin(data[i])* Math.Cos(data[i]) / Math.Tan(data[i]);
                });

            // Medimos el tiempo de ejecución de la sección paralela
            Stopwatch stopwatch = Stopwatch.StartNew();

            // Realizamos operaciones matemáticas en paralelo
            Parallel.For(0, data.Length, i =>
            {
                data[i] = Math.Sin(data[i]) * Math.Cos(data[i]) / Math.Tan(data[i]);
            });

            // Detenemos el temporizador y calculamos el tiempo de ejecución
            stopwatch.Stop();
            TimeSpan timeSpan = stopwatch.Elapsed;


            // Imprimimos algunos resultados
            Console.WriteLine("Resultado: " + data[100] + ", " + data[1000] + ", " + data[10000]);
            Console.WriteLine("Tiempo de ejecución: " + timeSpan.TotalMilliseconds + " milisegundos");
        }
    }
}
