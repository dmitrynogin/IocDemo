using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace IocDemo.Autofac
{
    public class AssemblyRegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            foreach (var assembly in Solution.Assemblies)
                builder.RegisterAssembly(assembly);
        }
    }
}
