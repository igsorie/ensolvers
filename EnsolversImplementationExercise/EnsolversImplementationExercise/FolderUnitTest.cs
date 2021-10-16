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
            bool isValid = folderName.IsValidItemName();

            Assert.IsTrue(isValid);
        }
    }
}
