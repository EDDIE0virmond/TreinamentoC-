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
            l.
            print(l);
        }
        static void print(long[] vec)
        {
            for (long i = 0; i < vec.Length; i++)
            {
                Console.WriteLine( $"{vec[i]}\n");  
            }
        }
        
    }
}
