using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IocDemo.Tests
{
    [TestClass]
    public class DemoService_Should
    {
        [TestMethod]
        public void Greet()
        {
            var sp = new ServiceProvider();
            var s = sp.GetService<IDemoService>();
            var greet = s.Greet("John Doe");
            Assert.AreEqual("Hello John Doe!", greet);
        }
    }
}
