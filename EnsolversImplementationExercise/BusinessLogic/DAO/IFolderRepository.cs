using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DAO
{
    public interface IFolderRepository
    {
        public void AddFolder(Folder folder);

        public void UpdateFolder(Folder folder);

        public Folder GetFolder(int id);

        public List<Folder> GetFolders();

        public void RemoveFolder(int id);
    }
}
