using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;


namespace TestProject
{
    [TestClass]
    public class TestProject
    {
        private const string expected = "Hello World! From Rushikesh";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                ConsoleApp.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(expected, result);
            }
        }
    }
}