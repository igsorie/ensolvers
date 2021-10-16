using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class ItemService
    {
        public IItemRepository itemRepository;
        public ItemService(IItemRepository itemRepository) 
        {
            this.itemRepository = itemRepository;
        }

        public void IsValidItemName(Item item)
        {
            if (!item.IsValidItemName())
            {
                throw new InvalidOperationException("Error to add item. The item name its invalid");
            }
        }
    }
}
