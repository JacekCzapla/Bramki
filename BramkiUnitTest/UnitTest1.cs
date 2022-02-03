using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BramkiUnitTest
{
    [TestClass]
    public class BramkaNotTests
    {
        [TestMethod]
        public void TestCalc()
        {
            var b = new BramkaNOT();
            b.Input.Value = true;
            var res = b.Calculate();
            Assert.IsFalse(res);

            b.Input.Value = false;
            res = b.Calculate();
            Assert.IsTrue(res);

        }

        [TestMethod]
        public void TestORCalc()
        {
            var b = new BramkaOR();
            Assert.AreEqual("OR", b.Name);

            b.Inputs[0].Value = true;
            b.Inputs[1].Value = false;
            var res = b.Calculate();
            Assert.IsTrue(res);

            b.Inputs[0].Value = false;
            b.Inputs[1].Value = false;
            res = b.Calculate();
            Assert.IsFalse(res);


        }
    }
}