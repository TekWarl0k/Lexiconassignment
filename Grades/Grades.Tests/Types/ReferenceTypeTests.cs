using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    [TestClass]
    class ReferenceTypeTests
    {
        [TestMethod]
        public void VariablesHoldAReference()
        {
            Gradebook g1 = new Gradebook();
            Gradebook g2 = g1;

            g1.Name = "Gradebook test";
            Assert.AreEqual(g1.Name, g2.Name);
        }
    }
}
