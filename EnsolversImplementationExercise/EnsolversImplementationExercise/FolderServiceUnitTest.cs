using BusinessLogic;
using BusinessLogic.DAO;
using BusinessLogic.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsolversImplementationExercise
{
    [TestClass]
    public class FolderServiceUnitTest
    {
        private FolderService folderService;

        [TestInitialize]
        public void Init()
        {
            IFolderRepository folderRepository = new IFolderRepositoryInMemoryImpl();
            IItemRepository itemRepository = new ItemRepositoryInMemoryImpl();
            folderService = new FolderService(folderRepository, itemRepository);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InvalidFolderNameTest()
        {
            Folder folder = new Folder();
            folder.Name = "";
            folder.Id = 1;
            folderService.AddFolder(folder);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InvalidFolderLongNameTest()
        {
            Folder folder = new Folder();
            folder.Name = "this is very long folder name, its imposible to add this.";

            folderService.IsValidFolderName(folder);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InvalidUpdateFolderTest()
        {
            Folder folder = new Folder();
            folder.Name = "Work";
            folder.Id = 1;
            folderService.AddFolder(folder);
            Folder folderToUpdate = new Folder();
            folderToUpdate.Name = "New folder";
            folderToUpdate.Id = 2;
            folderService.Update(folderToUpdate);
        }

        [TestMethod]
        public void UpdateFolderTestOk()
        {
            Folder folder = new Folder();
            folder.Name = "Work";
            folder.Id = 1;
            folderService.AddFolder(folder);
            folder.Name = "New folder";
            folderService.Update(folder);
        }

        [TestMethod]
        public void GetFoldersTestOk()
        {
            Folder folder = new Folder();
            folder.Name = "Work";
            folder.Id = 1;
            folderService.AddFolder(folder);
            List<Folder> folders = folderService.GetFolders();
            Assert.AreEqual(folders[0], folder);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InvalidRemoveFolderTest()
        {
            Folder folder = new Folder();
            folder.Name = "Work";
            folder.Id = 1;
            folderService.AddFolder(folder);
            Folder folderToRemove = new Folder();
            folderToRemove.Name = "Work";
            folderToRemove.Id = 2;
            folderService.Remove(folderToRemove.Id);
        }
    }
}
