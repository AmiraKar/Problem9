using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9
{
    class Program
    {
        static void Main(string[] args)
        {

            int primeNumber = 100;
            ArrayList primeNum = new ArrayList();
            void getPrimeNumber()
            {
                bool[] isNumberPrime = new bool[primeNumber];
                for (int i = 0; i < primeNumber; i++)
                    isNumberPrime[i] = true;
                for (int a = 2; a * a < primeNumber; a++)
                {
                    if (isNumberPrime[a] == true)
                    {
                        for (int i = a * a; i < primeNumber; i = i + a)
                            isNumberPrime[i] = false;
                    }
                }
                for (int a = 2; a < primeNumber; a++)
                    if (isNumberPrime[a] == true)
                        primeNum.Add(a);
            }
            //we call the Function getPrimeNumber
            getPrimeNumber();
            Console.WriteLine("3th prime number is: " +
                                           primeNum[2]);
            Console.WriteLine("5th prime number is: " +
                                           primeNum[4]);
        }
    }
}