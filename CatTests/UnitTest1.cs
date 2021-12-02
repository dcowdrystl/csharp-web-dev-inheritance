using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cats;

namespace CatTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InheritsBaseInFirstConstructor()
        {
            HouseCat bob = new HouseCat("Bob", 7);
            Assert.AreEqual(7, bob.Weight, .001);
        }
    }
}
