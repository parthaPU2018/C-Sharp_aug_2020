﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Programfirst
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine("enter items of array");
            for (int i = 0; i < 10; i++) {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            

            
            
                int n = 10;

                
                for (int i = 0; i < n - 1; i++)
                {
                    
                    int min = i;
                for (int j = i + 1; j < n; j++)
                 {
                    if (arr[j] < arr[min])
                        min = j;


                    int temp = arr[min];
                    arr[min] = arr[i];
                    arr[i] = temp;
                  }
                }
              foreach(int t in arr)
             {
                 Console.WriteLine(t);
             }

            Console.ReadLine();

            


        }
    }
}
