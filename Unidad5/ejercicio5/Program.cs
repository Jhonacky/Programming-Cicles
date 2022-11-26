using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
          
          bool flagP = false;
          bool flagN = false;
          int number, MaxEvenNumber = 0, MinOddNumber = 0;

          for(int x = 0; x < 20; x++){
            Console.WriteLine("Enter a number");
            number = int.Parse(Console.ReadLine());
            if(number % 2 == 0){
              if(flagP == false){
                MaxEvenNumber = number;
                flagP = true;
                }
              else if(number > MaxEvenNumber)
                MaxEvenNumber = number;}
            else if(flagN == false){
                MinOddNumber = number;
                flagN = true;
                }
              else if(number < MinOddNumber)
                MinOddNumber = number;                             
                
              
          }
          Console.WriteLine("The highest even number is: " + MaxEvenNumber + " The lowest odd number is : " + MinOddNumber);        
          
          
        
      }
    }
}




