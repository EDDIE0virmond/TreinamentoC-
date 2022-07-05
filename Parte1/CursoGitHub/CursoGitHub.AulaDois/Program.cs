using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet;
using BenchmarkDotNet.Running;

namespace CursoGitHub.AulaDois
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Program>();
            var rand = new Random();
            long k = 100;
            long[] l = new long[k];
            for(long i = 0; i < l.Length; i++)
            {
                l[i] = i + 1;
            }
            for (long i = 0; i < l.Length; i++) 
            {
                long sorting = rand.Next() % l.Length;
                var aux = l[i];
                l[i] = l[sorting];
                l[sorting] = aux;
            }
            print(l);
            mergesort(l, k-1, 0);
            print(l);
        }
        static void print(long[] vec)
        {
            for (long i = 0; i < vec.Length; i++)
            {
                Console.WriteLine( $"{vec[i]}\n");  
            }
        }
        static void interteine(long[] vec, long first, long last, long middle) 
        {
            long[] aux = new long[last - first - 1];
            long i, j, k = 0;
            i = first;
            j = middle + 1;
            while (j <= last && i <= middle) 
            {
                if (vec[i] <= vec[j])
                {
                    long v = vec[i];
                    aux[k] = v;
                    i++;
                }
                else
                {
                    aux[k] = vec[j];
                    j++;
                }
                k++;
            }
            while(i <= middle) 
            {
                aux[k] = vec[i];
                i++;
                k++;
            }
            while (j <= last) 
            {
                aux[k] = vec[j];
                j++;
                k++;
            }
            for (i = 0; i < (last - first - 1); i++) 
            {
                vec[i + first] = aux[i];
            }
            return;
        }
        static void mergesort(long[] vec, long last, long first) 
        {
            if(last > first) 
            {
                var middle = (last + first) / 2;
                mergesort(vec, middle - 1, first);
                mergesort(vec, last, middle+1);
                interteine(vec, first, last, middle);
            }
        }
    }
}
