using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR.Test
{
    [TestClass]
    public class CalculationTests
    {

        [TestMethod]
        public void Calculate()
        {
            var result = 40;
            // Assert
            Assert.AreEqual(40, result);
        }
    }
}
