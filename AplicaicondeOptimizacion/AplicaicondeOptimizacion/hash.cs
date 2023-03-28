using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicaicondeOptimizacion
{
    public class hash
    {
        public void optimizacion_hash()
        {
            int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int suma = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        suma += matriz[i, j];
                    }
                }
            }
            Console.WriteLine("La suma de la diagonal principal es: " + suma);
            Console.ReadLine();
        }
    }
}
