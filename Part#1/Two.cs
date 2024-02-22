using System;

class Program
{
      static void Main () 
      {
           int[] array = new int[5];

           for (int I = 0; I < array.Length; i++)
           {
                Console.Write(“Enter a number:  ”);
                int number = Convert.ToInt32(Console.ReadLine());
                array[i] = number * number;
           }

           int max = array[0];
           for (int i = 1; I < array.Length; i++)
           {
                 if (array[i] > max)
                 {
                       max = array[i];
                 }
           }
      }
}
