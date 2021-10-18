using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Folder
    {
        public int Id { get; set; }

        public string Name { get; set; }

        private const int NAME_MAX_LENGTH = 25;

        public List<Item> Items { get; set; }

        public Folder()
        {
            Items = new List<Item>();
        }

        public bool IsValidFolderName()
        {
            return this.Name != null && !this.Name.Equals("") && this.Name.Length <= NAME_MAX_LENGTH;
        }
    }
}
