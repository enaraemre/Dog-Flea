using System;
using System.Numerics;
namespace Dog_Flea
{
    class Program
    {          
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int DogA = 20, DogB = 0 , n= 20 , count=0 ;
            BigInteger sum = 0;
            Console.WriteLine("Beginning; DogA(" + DogA + ") and DogB(" + DogB + ")");
            for (int i=0; i<n; i++)
            {
                DogA = 20;
                DogB = 0;
                count = 0;
                do
                {
                    int x = rnd.Next(1, 21);
                   
                        if (x <= DogA)
                        {
                            DogA--;
                            DogB++;
                        }
                        else
                        {
                            DogA++;
                            DogB--;
                        }                 
                    count++;
                    //To see movement of fleas you can activate the code below and remove do-while loop.
                    //Console.WriteLine("Beginning; DogA(" + DogA + ") and DogB(" + DogB + ")");
                }
                while (DogA != 20);
                sum = sum + count;
            }
            Console.WriteLine(sum / n);
        }
    }
}