using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10F_Schőn_Verem
{
    class Program
    {
        class Verem<T>
        {
            private class Elem<R>
            {
                public R ertek;
                public Elem<R> le;

                public Elem() { le = this; }

                public Elem(Elem<R> regi, R ertek)
                {
                    this.le = regi.le;
                    regi.le = this;
                    this.ertek = ertek;
                }
            }

            Elem<T> fejelem = new Elem<T>();

            public void Push(T ertek) => new Elem<T>(fejelem, ertek);
            public T Peek() => fejelem.le.ertek;
            public bool Empty() => fejelem.le == fejelem;
            public T Pop()
            {
                if (!Empty())
                {
                    T result = Peek();
                    fejelem.le = fejelem.le.le; // ezt lehetne Elem metódusnak is! "kifűzés";
                    return result;
                }
                else
                {
                    Console.WriteLine("Hát ez a verem bizony üres.");
                    throw new Exception();
                }
            }

            public override string ToString()
            {
                string sum = "";
                Elem<T> aktelem = fejelem.le;
                while (aktelem!=fejelem)
                {
                    sum += " -> " + aktelem.ertek;
                    aktelem = aktelem.le;
                }
                return sum;
            }



        }
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
