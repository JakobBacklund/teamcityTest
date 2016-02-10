using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talang2015
{
    class Program
    {
        static void Main(string[] args)
        {
            object o = new object();
            int i = 1;
            i.ToString();
            string s = "a string";
            s.ToString();

            Console.WriteLine(TestRefType(new int[] { 1, 2, 3 }));

            var anInt = 1;
            var anArr = new int[] { 1, 2, 3 };
            TestValueType(ref anInt);
            TestRefType(anArr);
            Console.WriteLine(anInt);
            Console.WriteLine(anArr);
            Console.Wriine("Hi");
        }

        static int TestValueType(ref int i)
        {
            i++;
            return i;
        }
        static int[] TestRefType(int[] arr)
        {
            arr[0] = 4;
            return arr;
        }
    }
}
