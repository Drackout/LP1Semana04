using System;

namespace Fibonacci
{
    class Program
    {

        private static int Fibonacci(int num){
            int fibo = 1;
 
            
            if(fibo == 1){
                fibo = 1;
            }
             else{
                 fibo = fibo + Fibonacci(num-1);
             }

            return 
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci!");
            int n = 8;

            
            
            Console.WriteLine("out->"+Convert.ToInt64(Fibonacci(n)));

        }
    }
}
