using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Loading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Console.WriteLine("■□□□□□□");
           Thread.Sleep(1000);                                 // 1초
            Console.Clear();
            Console.WriteLine("■■□□□□□");
            Thread.Sleep(1000);                                 // 1초
            Console.Clear();
            Console.WriteLine("■■■□□□□");
            Thread.Sleep(1000);                                 // 1초
            Console.Clear();
            Console.WriteLine("■■■■□□□");
            Thread.Sleep(1000);                                 // 1초
            Console.Clear();
            Console.WriteLine("■■■■■□□");
            Thread.Sleep(1000);                                 // 1초
            Console.Clear();
            Console.WriteLine("■■■■■■□");
            Thread.Sleep(1000);                                 // 1초
            Console.Clear();
            Console.WriteLine("■■■■■■■");
            Console.Clear();
            Console.WriteLine(" Complete ");
        }
    }
}
