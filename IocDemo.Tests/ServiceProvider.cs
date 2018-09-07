using Autofac;
using IocDemo.Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace IocDemo.Tests
{
    class ServiceProvider : IServiceProvider
    {
        public ServiceProvider()
        {
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyModules(
                typeof(AssemblyRegistrationModule).Assembly);

            Container = builder.Build();
        }

        IContainer Container { get; }

        public T GetService<T>() =>
            (T)GetService(typeof(T));

        public object GetService(Type serviceType) =>
            Container.Resolve(serviceType);
    }
}
