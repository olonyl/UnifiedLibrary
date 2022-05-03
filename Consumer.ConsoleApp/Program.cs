using SingleLibrary;
using System;

namespace Consumer.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IStack<int> stack = Stack<int>.Empty;

            IStack<int> stack2 = stack.Push(10);
            IStack<int> stack3 = stack2.Push(20);
            IStack<int> stack4 = stack3.Push(30);

            foreach (var cur in stack4)
            {
                Console.WriteLine(cur);
            }

            Game.Start();

            Console.Read();
        }
    }
}
