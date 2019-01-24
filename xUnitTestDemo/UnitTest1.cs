using System;
using Xunit;

namespace xUnitTestDemo
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int i = 0;
            Console.Write(i.ToString());
        }
    }
}
