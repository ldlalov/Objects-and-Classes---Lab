using System;
using System.Collections.Generic;

namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Random random = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int newPosition = random.Next(words.Length - 1);
                string temp = words[newPosition];
                words[newPosition] = words[i];
                words[i]=temp;

            }
            Console.WriteLine(String.Join(Environment.NewLine,words));

        }
    }
}
