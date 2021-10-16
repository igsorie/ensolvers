using BusinessLogic;
using BusinessLogic.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsolversImplementationExercise
{
    [TestClass]
    public class ItemServiceUnitTest
    {
        private ItemService itemService;

        [TestInitialize]
        public void Init()
        {
            IItemRepository itemRepository = new ItemRepositoryInMemoryImpl();
            itemService = new ItemService(itemRepository);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InvalidItemNameTest()
        {
            Item item = new Item();
            item.Name = "";

            itemService.IsValidItemName(item);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InvalidItemLongNameTest()
        {
            Item item = new Item();
            item.Name = "this is very long folder name, its imposible to add this.";

            itemService.IsValidItemName(item);
        }
    }
}
