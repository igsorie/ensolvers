using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsolversImplementationExercise
{
    [TestClass]
    public class FolderUnitTest
    {
        [TestMethod]
        public void IsValidFolderNameTest()
        {
            Folder folderName = new Folder();
            folderName.Name = "Work";
            folderName.Id = 1;
            bool isValid = folderName.IsValidItemName();

            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void IsInvalidFolderNameEmptyTest()
        {
            Folder folderName = new Folder();
            folderName.Name = "";
            bool isValid = folderName.IsValidItemName();

            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void IsValidFolderNameLongTest()
        {
            Folder folderName = new Folder();
            folderName.Name = "this correct long name 25";
            bool isValid = folderName.IsValidItemName();

            Assert.IsTrue(isValid);
        }
    }
}
