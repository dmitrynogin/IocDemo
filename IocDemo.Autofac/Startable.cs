using IocDemo.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace IocDemo.Autofac
{
    [Service]
    class Startable : IStartable
    {
        public Startable(IStartup[] startups)
        {
            Startups = startups;
        }

        IEnumerable<IStartup> Startups { get; }

        public void Start()
        {
            foreach (var startup in Startups)
                startup.Start();
        }
    }
}
