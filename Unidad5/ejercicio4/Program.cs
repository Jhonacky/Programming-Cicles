using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
          int number, divider = 1, counter = 0;

          Console.WriteLine("Enter a number");
          number = int.Parse(Console.ReadLine());

          while(divider <= number){
            if(number % divider == 0){
              counter++;
            }
            divider++;
            }
        if(counter == 2)
          Console.WriteLine("The number " + number + " is prime");
        else
          Console.WriteLine("The number " + number + " is not prime");
        }
    }
}
