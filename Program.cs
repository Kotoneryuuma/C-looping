using System;

namespace fund1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while(i <= 100){
                if(i % 3 == 0 && i % 5 == 0){
                    Console.WriteLine("FizzBuzz");
                }
                if(i % 3 == 0 ){
                    Console.WriteLine("FIzz");
                }
                if(i % 5 == 0 ){
                    Console.WriteLine("Buzz");
                }
                i = i+1;
            }
        }
    }
}

// 1  create loop from 1 to 225
//  int start = 1;
//             int end = 225;
//             for(int i = start; i <= end; i++){
//                 Console.WriteLine(i);
//             }


// 2  create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
// int start = 1;
//             int end = 100;
//             for(int i = start; i <= end; i++){
//                 if(i % 3 == 0 ||i % 5 == 0){
//                     Console.WriteLine(i);
//                 }
//             }



//3  Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
// {
//             int start = 1;
//             int end = 100;
//             for(int i = start; i <= end; i++){
//                 if(i % 3 == 0 && i % 5 == 0){
//                     Console.WriteLine("FizzBuzz");
//                 }
//                 if(i % 3 == 0 ){
//                     Console.WriteLine("FIzz");
//                 }
//                 if(i % 5 == 0 ){
//                     Console.WriteLine("Buzz");
//                 }
//             }
//         }


// (Optional) If you used "for" loops for your solution, try doing the same with "while" loops. Vice-versa if you used "while" loops!
// static void Main(string[] args)
//         {
//             int i = 1;
//             while(i <= 100){
//                 if(i % 3 == 0 && i % 5 == 0){
//                     Console.WriteLine("FizzBuzz");
//                 }
//                 if(i % 3 == 0 ){
//                     Console.WriteLine("FIzz");
//                 }
//                 if(i % 5 == 0 ){
//                     Console.WriteLine("Buzz");
//                 }
//                 i = i+1;
//             }
//         }