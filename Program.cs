using System;


namespace OrdenamientoYBusquedaG2_2022_II
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingresa el tamaño del vector");
            int N =int.Parse( Console.ReadLine());
            int[] A = GeneraAleatoria(N);
            Console.WriteLine("************Desordenada****************");
            Imprime(A);
            Console.WriteLine("************Ordenada*******************");
            Ordenamiento.Burbuja(A);
            Imprime(A);

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
