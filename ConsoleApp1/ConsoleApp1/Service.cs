using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Service : IService
    {
        public void CreateOrder(Order orderToCreate)
        {
            Console.WriteLine("Creating order...");

            // ...
        }
    }
}
