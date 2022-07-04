using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoGitHub.InterfaceConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Allo !!!!!!");
        }
        private static void go() 
        {
            long i = 0;
            long j = 0;
            bool h = true;
            do
	        {
                if(i-j < 1) 
                {
                    if (h == true)
	                {
                        Console.WriteLine("Kelly !!!!!");
                       if(Console.ReadKey().Key == ConsoleKey.Escape)
                       { 
                            j++;
                       }
                       else
	                   {
                            i--;
	                   }

                        h = false;
	                }
                    if (h == false)
	                {
                        Console.WriteLine("Pietra !!!!!");
                        if(Console.ReadKey().Key == ConsoleKey.Escape)
                        { 
                            i++;
                        }
                        else
	                    {
                            j--;
	                    }
                        h = true;
	                }
                }
                j--;
                i--;
	        } while (j+i != 2);

        }
    }
}
