using System;

namespace OrdenamientoYBusquedaG2_2022_II
{
    internal static class Ordenamiento
    {
        public static void Burbuja(int [] A )
        {
            for (int j = 0; j < A.Length; j++)//Repite las Pasadas
            {
                for (int i = 0; i < A.Length - 1; i++) // Primera Pasada
                {
                    int Aux;
                    if (A[i] > A[i + 1]) //Hay intercambio de elementos

                    {
                        Aux = A[i];
                        A[i] = A[i + 1];
                        A[i + 1] = Aux;
                    }
                }
            }

        }



    }
}
