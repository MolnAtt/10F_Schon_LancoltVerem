using System;
namespace _10F_Schőn_Verem
{
    class Program
    {
        static void Main(string[] args)
        {
            Verem<int> szamverem = new Verem<int>();
            Console.WriteLine(szamverem);
            szamverem.Push(5);
            Console.WriteLine(szamverem);
            szamverem.Push(8);
            Console.WriteLine(szamverem);
            szamverem.Push(10);
            Console.WriteLine(szamverem);
            szamverem.Push(25);
            Console.WriteLine(szamverem);

            Console.WriteLine(szamverem.Peek());
            Console.WriteLine(szamverem);
            Console.WriteLine(szamverem.Pop());
            Console.WriteLine(szamverem);
            Console.WriteLine(szamverem.Pop());
            Console.WriteLine(szamverem);
            Console.WriteLine(szamverem.Pop());
            Console.WriteLine(szamverem);
            Console.WriteLine(szamverem.Pop());
            Console.WriteLine(szamverem);
            Console.WriteLine(szamverem.Pop());
            Console.WriteLine(szamverem);
            Console.WriteLine(szamverem.Pop());
            Console.WriteLine(szamverem);
            Console.WriteLine(szamverem.Pop());
            Console.WriteLine(szamverem);
            Console.WriteLine(szamverem.Pop());

//            Stack<int> gyáriverem = new Stack<int>();
        }
    }
}
