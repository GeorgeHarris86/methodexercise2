﻿using System.Security.Cryptography.X509Certificates;

namespace MethodExercise2
{
    internal class program
      {
          private static void Main(string[] args)
          {
            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: (sum)");

            Console.WriteLine("Give me a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply the first one");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The product is: (product)");
          }

          public static int Sum(int num1, int num2)
          {

            //return num1 + num2;

            //return Sum;

            return num1 + num2;
          }
    
          public static int Multiply(int x, int y)
          {
            return x * y;
          }
    
          
    
       
    

     
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
      }






























}
