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

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddItemInvalidItemTest()
        {
            Item item = new Item();
            item.Name = "this is very long folder name, its imposible to add this.";
            itemService.AddItem(item);
        }

        [TestMethod]
        public void AddUserTestOk()
        {
            Item item = new Item();
            item.Name = "correct name";
            itemService.AddItem(item);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InvalidUpdateItemTest()
        {
            Item item = new Item();
            item.Name = "Write to candidates";
            item.Id = 1;
            itemService.AddItem(item);
            Item itemToUpdate = new Item();
            itemToUpdate.Name = "New item";
            itemToUpdate.Id = 2;
            itemService.Update(itemToUpdate);
        }

        [TestMethod]
        public void UpdateUserTestOk()
        {
            Item item = new Item();
            item.Name = "Write to candidates";
            item.Id = 1;
            itemService.AddItem(item);
            item.Name = "New item";
            itemService.Update(item);

        }

    }
}
