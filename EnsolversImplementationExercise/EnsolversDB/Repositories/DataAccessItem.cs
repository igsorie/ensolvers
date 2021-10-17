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
        }

        public void UpdateItem(Item item)
        {
            RepositoryContext.Items.Update(item);
        }

        public Item GetItem(int id)
        {
            return RepositoryContext.Items.FirstOrDefault(c => c.Id == id);
        }

        public List<Item> GetItems()
        {
            return RepositoryContext.Items.ToList();
        }
    }
 }
