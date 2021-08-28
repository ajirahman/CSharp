using System;
using System.Collections;
using System.Collections.Generic;

namespace DotnetCoreSOLID
{
    class Program
    {
        static void Main()
        {
          foreach(var x in WithoutyieldMethod(2,5))
            {
                Console.Write(x);
            }

            Console.Write("***************************");
            foreach (var x in WithyieldMethod(2, 5))
            {
               
                Console.Write(x);
            }
            Console.Read();
        }

        private static IEnumerable WithyieldMethod(int v1, int v2)
        {
            for (int i = 0; i < v2; i++)
            {
                yield return 2 + v1 * 1;
            } //// put a break point so will underastnd the flow of yield.This applies for searching and browsing a number of elements required that will be reduce the dependency on the location of the element to find.
        }

        private static IEnumerable WithoutyieldMethod(int x, int number)
        {
            ////int x = 1;        
            ArrayList s = new ArrayList();
            for (int i = 0; i <number ; i++)
            {
                s.Add(2 + 2 * i);
                
            }
            return s;
        }
    }
    }

