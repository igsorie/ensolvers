using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public interface IItemService
    {
        public void AddItem(Item item);

        public void Update(Item item);

        public Item GetItem(int id);

        public List<Item> GetItems();
    }
}
