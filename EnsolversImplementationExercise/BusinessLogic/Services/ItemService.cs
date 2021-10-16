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

        public void AddItem(Item item)
        {
            IsValidItemName(item);
            itemRepository.AddItem(item);
        }

        public void Update(Item item)
        {
            IsValidItemName(item);
            Item itemFind = itemRepository.GetItem(item.Id);
            if (itemFind == null)
            {
                throw new InvalidOperationException("Error to update item. It doesn't exist in the system.");
            }
            itemRepository.UpdateItem(item);
        }

        public void IsValidItemName(Item item)
        {
            if (!item.IsValidItemName())
            {
                throw new InvalidOperationException("Error to add item. The item name is not invalid.");
            }
        }
    }
}
