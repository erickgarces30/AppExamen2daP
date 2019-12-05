using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExamen2daP.Clases
{
    class Vector
    {

        public static int[] generar(int tamanio)
        {
            //inicializar el generador de números
            //con una semilla
            var seed = Environment.TickCount;
            var random = new Random(seed);

            int[] vector = new int[tamanio];
            for(int i=0;i<tamanio;i++)
            {
                vector[i] = random.Next(1, 100);
            }

            return vector;
        }
        public static void ordenar(int[] vector, int tamanio)
        {
            for(int i=0;i<=tamanio;i++)
                for(int j=i+1;j<tamanio;j++)
                {
                    int aux = vector[i];
                    vector[i] = vector[j];
                    vector[j] = aux;

                }
        }

    }
}
