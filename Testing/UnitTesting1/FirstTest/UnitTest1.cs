using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;

namespace FirstTest
{
    [TestClass]
    public class UnitTest1
    {
        #region MyRegion

        //[TestMethod]
        //public void TestMethod1()
        //{
        //       var res = MyMath.divide(6f, 3f);
        //       Assert.AreEqual(2f, res, 0.00001, "Something went wrong...");
        //}

        //[TestMethod]
        //public void TestMethod2()
        //{
        //    var res = MyMath.divide(1f, 2f);
        //    Assert.AreEqual(0.5f, res, 0.00001, "Something went wrong...");
        //}

        #endregion

        [DataTestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(2, 4, 6)]
        [DataRow(5, 5, 10)]
        [DataRow(3, 3, 6)]
        public void AddTestMethod(int num1, int num2, int expected)
        {
            int res = MyMath.add(num1, num2);
            Assert.AreEqual(expected, res);
        }
    }
}