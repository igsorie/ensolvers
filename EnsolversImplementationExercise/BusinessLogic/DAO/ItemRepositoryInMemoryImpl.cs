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

        public void AddItem(Item item) 
        {
            Items.Add(item);
        }

        public void UpdateItem(Item item) 
        {
            Item itemToUpdate = Items.FirstOrDefault(x => x.Name == item.Name);
            itemToUpdate.Name = item.Name;
        }

        public Item GetItem(int id) 
        {
            return Items.FirstOrDefault(x => x.Id == id);
        }

        public List<Item> GetItems()
        {
            return Items;
        }
    }
}
