using IocDemo.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IocDemo.Tests
{
    [Service]
    class TestConfiguration : IConfiguration
    {
        static readonly IEnumerable<(string Section, string Name, string Value)> Values = new[]
        {
            ("DB", "ConnectionString", "USER=John Doe;PASSWORD=qwerty")
        };

        public IEnumerable<(string Name, string Value)> Section(string section) =>
            from v in Values
            where v.Section == section
            select (v.Name, v.Value);
    }
}
