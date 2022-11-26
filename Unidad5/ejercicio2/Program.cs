using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
          int n, biggest;

          Console.WriteLine("Enter a number:");
          n = int.Parse(Console.ReadLine());
          biggest = n;

          for(int x = 0; x < 9; x++){
          Console.WriteLine("Enter a number:");
          n = int.Parse(Console.ReadLine());
            if(n > biggest){
                biggest = n;
            }
          }
          Console.WriteLine("The highest value is: " + biggest);
          Console.WriteLine("End of the programm");
        }
    }
}
