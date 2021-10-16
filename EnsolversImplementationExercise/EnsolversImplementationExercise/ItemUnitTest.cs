using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EnsolversImplementationExercise
{
    [TestClass]
    public class ItemUnitTest
    {
        [TestMethod]
        public void IsValidItemNameTest()
        {
            Item item = new Item();
            bool isValid = item.IsValidItemName();
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void IsInvalidItemNameEmptyTest()
        {
            Item item = new Item();
            item.Name = "";

            bool isValid = item.IsValidItemName();
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void IsValidLongNameTest()
        {
            Item item = new Item();
            item.Name = "Prepare weekly report";

            bool isValid = item.IsValidItemName();
            Assert.IsTrue(isValid);
        }
    }
}
