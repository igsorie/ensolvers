﻿using BusinessLogic.DAO;
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

        public void Update(Folder folder)
        {
            IsValidFolderName(folder);
            Folder folderFind = folderRepository.GetFolder(folder.Id);
            if (folderFind == null)
            {
                throw new InvalidOperationException("Error to update folder. It doesn't exist in the system.");
            }
            folderRepository.UpdateFolder(folder);
        }

        public List<Folder> GetFolders()
        {
            return folderRepository.GetFolders();
        }

        public void Remove(Folder folder)
        {
            IsValidFolderName(folder);
            Folder folderFind = folderRepository.GetFolder(folder.Id);
            if (folderFind == null)
            {
                throw new InvalidOperationException("Error to remove folder. It doesn't exist in the system.");
            }
            folderRepository.RemoveFolder(folder.Id);
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
