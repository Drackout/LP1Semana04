using System;

namespace MyFirstMethod
{
    class Program
    {

        private static async void CountTo10(){
            for(int i = 1; i <= 10; i++){
                Console.WriteLine(i);
            }
        }

        private static async void CountToN(int n){
            for(int i = 1; i <= n; i++){
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            CountToN(5);
            CountToN(15);
        }
    }
}
