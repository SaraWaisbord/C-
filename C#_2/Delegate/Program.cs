using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{


    delegate int Calc(int x, int y);
    internal class Program
    {
        public static int Add(int x,int y ) { Console.WriteLine(x + y); return x+y; }
        public static int Sub(int x, int y) { Console.WriteLine(x - y); return x - y; }
        public static int Double(int x, int y) { Console.WriteLine(x * y); return x * y; }

        public static Func <string,string> Substring = s => s.Substring(0, s.Length - 1);
        public static Func<string, string> ToLoewrCase = s => s.ToLower();
        static void Main(string[] args)
        {
            Calc c;
            c  = new Calc(Add);
            c += new Calc(Sub);
            c += new Calc(Double);
            c(4, 6);
            Func<string, string> sPtr;
            sPtr = Substring;
            Console.WriteLine(sPtr("aaa"));
            sPtr = ToLoewrCase;
            Console.WriteLine(sPtr("ABCDE"));

        }
    }
}
