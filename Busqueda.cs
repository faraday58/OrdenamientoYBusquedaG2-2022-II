using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenamientoYBusquedaG2_2022_II
{
    internal static class Busqueda
    {
        public static int Directa(int [] A, int dato )
        {
            
            for ( int i=0; i < A.Length; i++)
            {
                if ( A[i] == dato )
                {
                    return i;
                }
            }

            return -1;

        }
    }
}
