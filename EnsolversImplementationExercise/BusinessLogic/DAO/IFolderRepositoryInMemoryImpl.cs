using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DAO
{
    public class IFolderRepositoryInMemoryImpl:IFolderRepository
    {
        public List<Folder> Folders { get; set; }

        public IFolderRepositoryInMemoryImpl()
        {
            Folders = new List<Folder>();
        }

        public void AddFolder(Folder folder)
        {
            Folders.Add(folder);
        }

        public void UpdateFolder(Folder folder) 
        {
            Folder folderToUpdate = Folders.FirstOrDefault(x => x.Name == folder.Name);
            folderToUpdate.Name = folder.Name;
        }

        public Folder GetFolder(int id)
        {
            return Folders.FirstOrDefault(x => x.Id == id);
        }

        public List<Folder> GetFolders()
        {
            return Folders;
        }

        public void RemoveFolder(int id)
        {
            Folders.Remove(Folders.FirstOrDefault(x => x.Id == id));
        }
    }
}
