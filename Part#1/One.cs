using System;
Class Program
{
     static void Main ()
    {
          Console.Write(“Enter the base of the triangle:  ”);
          double triangleBase = Convert.ToDouble(Console.ReadLine());

          Console.Write(“Enter the height of the triangle:  ”);
          double triangleHeight =Convert.ToDouble(Console.ReadLine());

          double area = 0.5 * triangleBase * triangleHeight;

          Console.WriteLine(“The are of the triangle is:  “ + area);
     }
}
