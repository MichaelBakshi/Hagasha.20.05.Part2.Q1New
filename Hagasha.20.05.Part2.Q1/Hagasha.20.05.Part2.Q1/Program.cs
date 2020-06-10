using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hagasha._20._05.Part2.Q1
{
    class Program
    {

        

        static void Main(string[] args)
        {


             int[] firstArray = null;
             int[] secondArray = null;

            RandomArrays(out firstArray, out secondArray);

            Console.WriteLine("result: "+Measure(ref firstArray, ref secondArray));
            Console.ReadLine();
            

        }
        /*    static int rnd(int start1, int end1)
            {
                Random generator = new Random();
               return generator.Next(start1, end1 + 1);
            }
             static int[] fillArr(int[]arr,int start,int end)
            {
                Random generator = new Random();
                for (int i= 0; i < arr.Length; i++)
                {
                    arr[i] = generator.Next(start, end + 1);
                }

                return generator.Next(start, end + 1);
            }
    */

        static int  Measure(ref int[] a, ref int[] b)
        {
            int firstCounter = 0;
            int secondCounter = 0;
            int smallest = 0;
            if (a.Length > b.Length) { smallest = b.Length; }
            else { smallest = a.Length; }
            for (int i = 0; i < smallest; i++)
            {
                if (a[i]>b[i])
                {
                    firstCounter++;
                }
                if (a[i]<b[i])
                {
                    secondCounter++;
                }
            }
            if (firstCounter == secondCounter) return 0;
            if (firstCounter > secondCounter) return 1;
            else
            {
                return -1;
            }
            
          
        }

        //creating 2 arrays with random length and random numbers
        static void RandomArrays(out int[] firstArray, out int[] secondArray)
        {
 
            Random generator = new Random();

            firstArray = new int[generator.Next(1,11)];
            secondArray = new int[generator.Next(1,11)];

            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = generator.Next(generator.Next(1, 101));
            }

            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = generator.Next(generator.Next(1, 101));
            }
            Console.Write("a :");
            foreach (int i in firstArray)
            {
                
                Console.Write(i+",");
                
            }
            Console.WriteLine();
            foreach (int i in secondArray)
            {
                Console.WriteLine(i+"b");
               
            } 
        }
       
    }
}
