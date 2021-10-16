using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IItemRepository
    {
        public void AddItem(Item item);

        public void UpdateItem(Item item);

        public Item GetItem(int id);

        public List<Item> GetItems();
    }
}
