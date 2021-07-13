using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {  int x = Convert.ToInt32(Console.ReadLine());
        var rand = new Random();
        int guess = rand.Next(0,x);
        while((Math.Pow(guess,2)!=x)){
            int y = x/guess;
            int k = (guess+y)/2;
            guess = k;
            Console.WriteLine(guess);


        }
        
        



        }
    }
}
