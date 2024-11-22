using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese # filas: ");
            int f= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese # columnas: ");
            int c= int.Parse(Console.ReadLine());

            int[,] matris = new int[f,c];
            Random rnd = new Random();
            for (int i = 0; i < matris.GetLength(0) ; i++)
            {
                for (int j = 0; j < matris.GetLength(1) ; j++)
                {
                    matris[i,j] = rnd.Next(30,51);
                    Console.Write(matris[i,j]+"\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
