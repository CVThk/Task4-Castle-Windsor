using StudentManagerment.Utilities;
using System;
using System.Text;

namespace StudentManagerment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            new Execute().runMain();
        }
    }
}
