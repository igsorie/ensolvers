using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Item
    {
        public string Name { get; set; }

        private const int NAME_MAX_LENGTH = 36;

        public bool IsValidItemName()
        {
            return this.Name != null && this.Name.Length <= NAME_MAX_LENGTH;
        }
    }
}
