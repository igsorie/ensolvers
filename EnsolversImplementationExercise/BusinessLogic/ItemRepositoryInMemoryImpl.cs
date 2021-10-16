using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ItemRepositoryInMemoryImpl:IItemRepository
    {
        public List<Item> Items { get; set; }
        public ItemRepositoryInMemoryImpl()
        {
            Items = new List<Item>();
        }

        public void AddItem(Item item) { }

        public void UpdateItem(Item item) { }

        public Item GetItem(int id) { return new Item(); }

    }
}
