using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public interface IFolderService
    {
        public void AddFolder(Folder folder);

        public void Update(Folder folder);

        public List<Folder> GetFolders();

        public void Remove(int id);

    }
}
