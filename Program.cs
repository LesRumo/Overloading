using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    internal class Program
    {

        static double multiply(double x, double y) 

        {
            
            double result = x*y;
            return result;
        }

        static int multiply(int w, int z) 
        {
            int result = w*z;  
            return result;
        }
        static void Main(string[] args)
        {

            double result1 = multiply(6.7, 9.6);
            int result2 = multiply(6, 9);
            
            Console.WriteLine("result1: " + result1);
            Console.WriteLine("result2: " + result2);

            Console.ReadLine(); 
        }
    }
}
