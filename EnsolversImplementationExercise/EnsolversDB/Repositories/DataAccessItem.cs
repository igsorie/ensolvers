using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsolversDB.Repositories
{
    public class DataAccessItem : RepositoryBase<Item>, IItemRepository
    {
        public DataAccessItem(EnsolversDBContext repositoryContext) : base(repositoryContext)
        {
        }

        public void AddItem(Item item)
        {
            RepositoryContext.Items.Add(item);
            RepositoryContext.SaveChanges();
        }

        public void UpdateItem(Item item)
        {
            Item itemToUpdate = GetItem(item.Id);
            itemToUpdate.Name = item.Name;
            itemToUpdate.Status = item.Status;
            RepositoryContext.SaveChanges();
        }

        public Item GetItem(int id)
        {
            return RepositoryContext.Items.FirstOrDefault(c => c.Id == id);
        }

        public List<Item> GetItems()
        {
            return RepositoryContext.Items.ToList();
        }

        public List<Item> GetItemsFromFolder(int folderId) 
        {
            return RepositoryContext.Items.Where(x => x.FolderId == folderId).ToList();
        }
    }
 }
