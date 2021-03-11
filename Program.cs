using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2DDISKRETKA
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, w = 0, e = 0, x = 4, N = 10;
            int[] A = new int[N];
            int[] B = new int[N];
            int[] C = new int[20];
            int y;
            B[0] = 0;
            B[1] = 1;
            bool eseky = true;
            for (i = 0; i < N; i++)
            {
                A[i] = x;
                x += 2;
            }
            for (i = 2; i < N; i++)
            {
                y = B[i - 1] + 2 * B[i - 2];
                B[i] = y;
            }
            foreach (int hz in A)
            {
                for (i = 0; i < B.Length; i++)
                    if (hz == B[i])
                    {
                        eseky = false;
                        i = 10;
                    }
                break;
            }
            while (eseky)
            {
                for (i = 0; i < A.Length; i++)
                {
                    C[e] = A[i];
                    e++;
                }
                e = 10;
                for (i = 0; i < B.Length; i++)
                {
                    C[e] = B[i];
                    e++;
                }
                eseky = false;
            }
                foreach (int hz in C)
                    Console.Write(hz + "; ");
            Console.ReadKey();
            
        }
    }
}
