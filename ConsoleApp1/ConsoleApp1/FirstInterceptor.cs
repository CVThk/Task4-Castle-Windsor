using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class FirstInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("First!");
            invocation.Proceed();
            Console.WriteLine("First.");
        }
    }
}
