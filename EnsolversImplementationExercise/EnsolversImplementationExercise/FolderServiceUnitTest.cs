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
            folderService = new FolderService(folderRepository);
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
    }
}
