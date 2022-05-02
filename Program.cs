using System;
using System.Diagnostics;

namespace OrdenamientoYBusquedaG2_2022_II
{
    internal class Program
    {
        static void Main()
        {
            Stopwatch stopwatch = new Stopwatch();


            Console.WriteLine("Ingresa el tamaño del vector");


            int N = int.Parse(Console.ReadLine());
            int[] A = GeneraAleatoria(N);
            Console.WriteLine("************Desordenada****************");
            Imprime(A);
            Console.WriteLine("************Ordenada*******************");

            stopwatch.Start();
            Ordenamiento.Burbuja(A);
            stopwatch.Stop();

            Console.WriteLine("Tiempo de ordenamiento es: {0} [ms]", stopwatch.ElapsedMilliseconds);


                /*
            Imprime(A);

            A =new int[] {4,5,7,20,40};

            Imprime(A);
            int indice=Busqueda.Directa(A,100);

            if( indice != -1)
            {
                Console.WriteLine("Número encontrado en la posición: {0}", indice);
            }else
            {
                Console.WriteLine("Número no encontrado");
            }

                */


            Console.ReadLine();


        }

        static int [] GeneraAleatoria( int N)
        {
            Random aleatoria = new Random();
            int [] Aux= new int[N];

            for (int i = 0; i < N; i++)
            {
                Aux[i] =(int)(aleatoria.NextDouble()*10000); //Genera un número entre 0 y 10000
            }
            return Aux;
        }

        static void Imprime(int [] A)
        {
            foreach( int a in A)
            {
                Console.Write("{0} ", a);
            }
            Console.WriteLine();
        }
    }
}
