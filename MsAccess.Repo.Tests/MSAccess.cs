﻿

using MsAccess.Repo.DemoData;
using Xunit;

namespace Unittest
{

    public class MSAccess
    {
        [Fact]
        public void TestHundDemoDate()
        {
            var blu = new DemoHundeData();
            var huhu = blu.Hundeerstellen().Count;

            Assert.Equal(1, huhu);
        }
    }
}


