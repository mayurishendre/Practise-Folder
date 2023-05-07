using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int nol=1;nol<=5;nol++)
            {
                for(int space=1;space<=nol;space++)
                {
                    Console.WriteLine("  ");
                    for(int no=5;no>=nol;no--)
                    {
                        Console.Write(no+" ");
                    
                    }
                 
                }
                
            }
            Console.WriteLine();
            Console.ReadLine();
           
        }
    }
}
