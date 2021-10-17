using BusinessLogic;
using BusinessLogic.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsolversDB.Repositories
{
    public class DataAccessFolder : RepositoryBase<Folder>, IFolderRepository
    {
        public DataAccessFolder(EnsolversDBContext repositoryContext) : base(repositoryContext)
        {
        }

        public void AddFolder(Folder folder)
        {
            RepositoryContext.Folders.Add(folder);
            RepositoryContext.SaveChanges();
        }

        public void UpdateFolder(Folder folder)
        {
            RepositoryContext.Folders.Update(folder);
            RepositoryContext.SaveChanges();
        }

        public Folder GetFolder(int id)
        {
            return RepositoryContext.Folders.FirstOrDefault(c => c.Id == id);
        }

        public List<Folder> GetFolders()
        {
            return RepositoryContext.Folders.ToList();
        }

        public void RemoveFolder(int id)
        {
            RepositoryContext.Folders.Remove(GetFolder(id));
            RepositoryContext.SaveChanges();

        }

        public List<Item> GetItemsFromFolder(int folderId)
        {
            return RepositoryContext.Items.Where(x => x.FolderId == folderId).ToList();
        }
    }
}
