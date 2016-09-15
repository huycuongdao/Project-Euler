using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem_7 prob = new Problem_7();

            //for (int i = 2; i < 30; i++)
            //{
            //    Console.WriteLine(i + " " + prob.IsPrime(i));
            //}



            Console.WriteLine(prob.Prime(10001));

        }
    }
}
