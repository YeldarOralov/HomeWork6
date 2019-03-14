using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    class IndexerTest
    {
        public static int count = 10;
        public int[] arr = new int[count];
        public int Length
        {
            get { return arr.Length; }
        }
        public int this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value * value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IndexerTest indexTest = new IndexerTest();
            for(int i = 0; i < indexTest.Length; i++)
            {
                indexTest[i] = i + 1;
            }
            for(int i = 0; i < indexTest.Length; i++)
            {
                Console.WriteLine(indexTest[i]);
            }
            Console.ReadLine();
        }
    }
}
