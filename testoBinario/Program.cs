using System;
using System.Text;

namespace testoBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine(" inserisci una parola:");
            s = Console.ReadLine();
            foreach (char c in s)
            {
                Console.WriteLine((int)c);
            }
            Console.ReadLine();
        }
    }
}
