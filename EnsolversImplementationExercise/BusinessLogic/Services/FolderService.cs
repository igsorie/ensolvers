using BusinessLogic.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class FolderService
    {
        public IFolderRepository folderRepository;
        public FolderService(IFolderRepository folderRepository)
        {
            this.folderRepository = folderRepository;
        }

        public void AddFolder(Folder folder)
        {
            IsValidFolderName(folder);
            folderRepository.AddFolder(folder);
        }

        public void IsValidFolderName(Folder folder)
        {
            if (!folder.IsValidFolderName())
            {
                throw new InvalidOperationException("Error to add folder. The item name is not invalid.");
            }
        }
    }
}
