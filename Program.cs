using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, sum;
            int mn, mx;
            Console.WriteLine("Please enter value for first number : ");
            mn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter value for Second number : ");
            mx = Convert.ToInt32(Console.ReadLine());
            for (n = mn; n <= mx; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.WriteLine("The perfect number is {0} ", n);
            }
       
            Console.ReadLine();


        }
    }
    } 

