using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;
//using System.ComponentModel;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();
            container.Register(
                Component.For<FirstInterceptor>(),
                Component.For<SecondInterceptor>(),
                Component.For<ThirdInterceptor>(),
                Component.For<IService>()
                    .ImplementedBy<Service>()
                    .Interceptors<FirstInterceptor>()
                    .Interceptors<SecondInterceptor>()
                    .Interceptors<ThirdInterceptor>()
                );

            var service = container.Resolve<IService>();
            service.CreateOrder(new Order());
        }
    }
}
