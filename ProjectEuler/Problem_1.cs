﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    // Find the sum of all the multiples of 3 or 5 below 1000.
    class Problem_1
    {
        private int result { get; set; } = 0;

        public Problem_1 ()
        {
        }

        public void solveProblem_1 ()
        {
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
            }

            Console.WriteLine(result);
        }
    }

    // Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
    // 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
    // By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
    class Problem_2
    {
        public int result { get; set; } = 0;

        public Problem_2 ()
        {
        }

        public void solveProblem_2 ()
        {

        }
    }

    // UNSOLVED - Problem 3 - Largest prime factor
    // Largest prime factor
    class Problem_3
    {
        private long number { get; set; } = 0;

        private long result { get; set; }

        public Problem_3()
        {
            Console.Write("Number = ");
            number = Convert.ToInt64(Console.ReadLine());
            ResolveProblem(number);
        }

        public void ResolveProblem(long number)
        {
            for (long i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    // UNSOLVED - Problem 4 - Largest palindrome
    // A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    // Find the largest palindrome made from the product of two 3-digit numbers.
    class Problem_4
    {
    }

    // Problem 5 - Smallest multiple
    // 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    // What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    class Problem_5
    {

    }


    // Problem 7 - 10001st prime
    // By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    // What is the 10 001st prime number?
    class Problem_7
    {
        public long Prime(int n)
        {
            long res = 2;

            int count = 0;

            while (count < n)
            {

                if (IsPrime(res))
                {
                    count++;
                    res++;
                }
                else
                {
                    res++;
                }
            }

            return res - 1;

        }

        public bool IsPrime(long n)
        {
            for (long i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }

}
