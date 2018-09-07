using IocDemo.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace IocDemo.DomainModel
{
    [Service]
    public class DemoService : IDemoService
    {
        public string Greet(string name) => $"Hello {name}!";
    }
}
