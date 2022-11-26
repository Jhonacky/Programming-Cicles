using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
          int age, average = 0, counter = 0;

          for(int x = 0; x < 20; x++){
            Console.WriteLine("Enter an age");
            age = int.Parse(Console.ReadLine());
            
            if(age > 18){
              average += age;
              counter++;
            }
          }
          if(average != 0){
            average /= counter;
            Console.WriteLine("The promedy of older people is: " + average);
          }
          Console.WriteLine("End of the programm");
        }
    }
}
