using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EnsolversImplementationExercise
{
    [TestClass]
    public class ItemsUnitTest
    {
        [TestMethod]
        public void IsValidItemNameTest()
        {
            Item item = new Item();
            bool isValid = item.IsValidItemName();
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void IsInvalidItemNameTest()
        {
            Item item = new Item();
            item.Name = "";

            bool isValid = item.IsValidItemName();
            Assert.IsFalse(isValid);
        }
    }
}
