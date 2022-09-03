using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class SecondInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("Second!");
            invocation.Proceed();
            Console.WriteLine("Second.");
        }
    }
}
