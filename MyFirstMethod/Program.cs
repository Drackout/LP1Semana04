using System;

namespace MyFirstMethod
{
    class Program
    {
        /// <summary>
        /// Counts from 1 to 10
        /// </summary>
        /// <returns>None</returns>
        private static async void CountTo10(){
            for(int i = 1; i <= 10; i++){
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Gets a number and counts from 1 to it
        /// </summary>
        /// <param name="n">the number to reach</param>
        /// <returns>None</returns>
        private static async void CountToN(int n){
            for(int i = 1; i <= n; i++){
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Count between 2 numbers
        /// </summary>
        /// <param name="n1">beggining number</param>
        /// <param name="n2">ending number</param>
        /// <returns>None</returns>
        private static async void CountToN(int n1, int n2){
            for(int i=n1; i <= n2; i++){
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Main with summon of other methods
        /// </summary>
        /// <param name="args">Received Arguments</param>
        static void Main(string[] args)
        {
            CountToN(5);
            CountToN(14, 20);
        }

        
    }
}
