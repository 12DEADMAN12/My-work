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
            int i, w = 0, g = 0, x = 4, N = 10;
            int[] A = new int[N];
            int[] B = new int[N];
            int[] C = new int[20];
            int[] D = new int[1];
            int[] E = new int[1];
            int[] F = new int[1];
            B[0] = 0;
            B[1] = 4;
            bool eseky = true, work = false;
            for (i = 0; i < N; i++) // Заповнення А массиву
            {
                A[i] = x;
                x += 2;
            }
            for (i = 2; i < N; i++) //Заповнення Б масиву
                B[i] = B[i - 1] + 2 * B[i - 2];
            foreach (int hz in A) //Перевірка чи є однакові числа в масивах
            {
                for (i = 0; i < B.Length; i++)
                    if (hz == B[i])
                    {
                        D[w] = hz;
                        w++;
                        Array.Resize(ref D, D.Length + 1);
                    }
            }
            while (eseky) // Заповнення массиву С
            {
                for (i = 0; i < A.Length; i++)
                {
                    C[g] = A[i];
                    g++;
                }
                g = 10;
                for (i = 0; i < B.Length; i++)
                {
                    C[g] = B[i];
                    g++;
                }
                eseky = false;
                work = true;
            }
            while (work)
            {
                for (i = 0; i < C.Length; i++)
                {
                    foreach (int c in D)
                        if (c == C[i])
                            C = C.Where(val => val != c).ToArray();
                }
                work = false;
            }
            for (i = 0; i < A.Length; i++)  // Заповнення массиву E
            { 
            Array.Resize(ref E, E.Length + 1);
            if (A[i] != D[0])
                E[i] = A[i];
            }
            for (i = 0; i < B.Length; i++) // Заповнення массиву F 
            {
                Array.Resize(ref F, F.Length + 1);
                if (B[i] != D[0])
                    F[i] = B[i];
            }
            Console.Write("Множина А: ");
            foreach (int a in A)
                Console.Write(a + ", ");
            Console.WriteLine();
            Console.Write("Множина B: ");
            foreach (int b in B)
                Console.Write(b + ", ");
            Console.WriteLine();
            Console.Write("Множина C: ");
            foreach (int c in C)
                Console.Write(c + ", ");
            Console.WriteLine();
            Console.Write("Множина D: ");
            foreach (int d in D)
                Console.Write(d + ", ");
            Console.WriteLine();
            Console.Write("Множина E: ");
            foreach (int e in E)
                Console.Write(e + ", ");
            Console.WriteLine();
            Console.Write("Множина F: ");
            foreach (int f in F)
                Console.Write(f + ", ");
            Console.ReadKey();
            
        }
    }
}
