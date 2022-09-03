using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class ThirdInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("Third!");
            invocation.Proceed();
            Console.WriteLine("Third.");
        }
    }
}
